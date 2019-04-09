using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB;
using Microsoft.AspNetCore.Hosting.Internal;
using VPM.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using PagedList.Core;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft;

namespace VPM.Controllers
{
    [Route("Artisan")]
    [AuthFilterArtisan]
    public class ArtisanController : Controller, IActionFilter
    {

        HostingEnvironment host = null;
        public ArtisanController(HostingEnvironment e)
        {
            host = e;
        }

        public void checkRegistration(mUser u)
        {
            if(!u.registered)
            {
                RedirectToAction("Dashboard", "artisan", new { msg="Your account is not registered",type="red"});
            }
        }

        public void checkRegistration()
        {
            var u = getuser();
            if (!u.registered)
            {
                RedirectToAction("Dashboard","Artisan", new { msg = "Your account is not registered", type = "red" });
            }
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            var sess = HttpContext.Session.GetString("email");
            if (sess == null)
            {
                RedirectToAction("Login", "Home");
            }
        }

        public mArtisan getuser()
        {
            var sess = HttpContext.Session.GetString("email");
            var acol = globals.getDB().GetCollection<mArtisan>("mArtisan");
            var a = acol.Find(x => x.email == sess || x.mobile==sess).FirstOrDefault();
            return a;
        }

        [Route("PaymentHistory")]
        public IActionResult PaymentHistory(DateTime from, DateTime to, int page = 1)
        {
            checkRegistration();
            from = from.AddDays(1);
            to = to.AddDays(1);
            var user = getuser();
            ViewBag.user = user;
            var pcol = globals.getDB().GetCollection<mPayments>("mPayments");
            var payments = pcol.Find(x => x.artisanID == user._id).ToList();
            if (from != null)
            {
                payments = payments.Where(x => x.date >= from).ToList();
            }
            if (to <= from)
            {
                to = DateTime.Now;
            }
            if (to != null)
            {
                payments = payments.Where(x => x.date <= to).ToList();
            }
            payments = payments.OrderByDescending(x => x.date).ToList();
            var pymts = (from d in payments select d).AsQueryable();
            ViewBag.payments = pymts.ToPagedList(page, 12);
            ViewBag.title = "Payment History";
            ViewBag.from = from.ToString("yyyy-MM-dd");
            ViewBag.to = to.ToString("yyyy-MM-dd");
            return View();
        }

        [Route("UpdateAssignmentStatus")]
        public IActionResult UpdateAssignmentStatus(string status, string aid, string msg, string type)
        {
            checkRegistration();
            var user = getuser();
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var ass = acol.Find(x => x._id == aid).FirstOrDefault();
            var ccol = globals.getDB().GetCollection<mClient>("mClient");
            var client = ccol.Find(x => x._id == ass.clientID).FirstOrDefault();

            AssignmentStatus astatus = AssignmentStatus.pending;
            if (status == "started") astatus = AssignmentStatus.started;
            if (status == "completed") astatus = AssignmentStatus.completed;
            var update = Builders<mAssignments>.Update.Set(x => x.assignmentStatus, astatus);
            acol.UpdateOne(x => x._id == aid, update);
            //send email to the client for any change
            var email = new globals.emailMessage();
            email.to = client.email;
            email.subject = "Assignemt status change";
            email.message = System.IO.File.ReadAllText(host.WebRootPath + "/emialViews/email_notification.html");
            email.message = email.message.Replace("{{message}}", "Your assignment status has changed log in to view progress");
            Task.Run(() =>
            {
                globals.sendEmail(email);
            });
            ViewBag.msg = msg;
            ViewBag.type = type;
            return RedirectToAction("AssignmentDetails", "Artisan", new { aid = aid, msg = "saved", type = "green" });
        }

        //fetch the other bids of this assigment
        //limit this to first 8 bids
        [Route("fetchOtherBids")]
        public string fetchOtherBids(string aid)
        {
            checkRegistration();
            var user = getuser();
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var ass = acol.Find(x => x._id == aid).FirstOrDefault();
            //ass.bids = ass.bids.Where(x => x.artisan_id != user._id).ToList();//remove myself from other bidders
            foreach (var b in ass.bids)
            {
                b.getArtisan();//populated the artisans
            }
            ass.bids = ass.bids.Take(8).ToList();//take first 8 bds only
            return JsonConvert.SerializeObject(ass.bids);
        }

        [HttpPost("OfferBidding")]
        public IActionResult OfferBidding(bid b, string aid, string msg, string type)
        {
            checkRegistration();
            var user = getuser();
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var ass = acol.Find(x => x._id == aid).FirstOrDefault();
            b.artisan_id = user._id;
            ass.bids.Add(b);//add to bids
            acol.ReplaceOne(x => x._id == aid, ass);//replace it
            //send email to the owner that ther is a bid

            var client = globals.getDB().GetCollection<mClient>("mClient").Find(x => x._id == ass.clientID).FirstOrDefault();
            var email = new globals.emailMessage();
            email.to = client.email;
            email.subject = "Assignment has a new bid";
            email.message = System.IO.File.ReadAllText(host.WebRootPath + "/emialViews/email_notification.html");
            email.message = email.message.Replace("{{message}}", "Your assignment '" + ass.description + "' has a new bid. Log in to review the bid");
            Task.Run(() =>
            {
                globals.sendEmail(email);//run this async
            });



            return RedirectToAction("Bidding", "Artisan", new { msg = "saved", type = "green" });

        }


        [HttpGet("RevokeBid")]
        public IActionResult RevokeBid(string aid, string msg, string type)
        {
            checkRegistration();
            var user = getuser();
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var ass = acol.Find(x => x._id == aid).First();
            ass._artisan_id = "";//remove my id from the assignment also
            var bid_ = ass.bids.Where(x => x.artisan_id == user._id).First();
            ass.bids.Remove(bid_);//remove the bid
            acol.ReplaceOne(x => x._id == aid, ass);//replace the assignment
            ViewBag.type = type;
            ViewBag.msg = msg;
            return RedirectToAction("Bidding", "Artisan", new { msg = "revoked", type = "green" });
        }

        [HttpGet("ChangePassword")]
        public IActionResult ChangePassword()
        {
            ViewBag.title = "Change Password";
            ViewBag.user = getuser();
            return View();
        }

        [Route("getAssignmentImages")]
        public string getAssignmentImages(string aid)
        {
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var ass = acol.Find(x => x._id == aid).FirstOrDefault();
            List<img_> imgs = new List<img_>();
            int index = 1;
            foreach (var i in ass.images)
            {
                var im = new img_();
                im.href = i;
                im.title = index + "/" + ass.images.Count;
                index++;
                imgs.Add(im);
            }
            return JsonConvert.SerializeObject(imgs);
        }
        //this is the class of the images
        public class img_
        {
            public string href { get; set; }
            public string title { get; set; }
        }

        [HttpPost("ChangePassword")]
        public IActionResult ChangePassword(string password)
        {
            try
            {
                ViewBag.title = "Change Password";
                var user = getuser();
                ViewBag.user = user;
                var acol = globals.getDB().GetCollection<mArtisan>("mArtisan");
                user.password = password;
                user.hashPassword();
                acol.ReplaceOneAsync(x => x._id == user._id, user);
                ViewBag.msg = "Saved";
                ViewBag.type = "green";
                HttpContext.Session.Clear();//clear the session
                return RedirectToAction("Profile", "Artisan", new { msg = "Saved",type="green" });//go to login page
            }
            catch (Exception ex)
            {
                ViewBag.msg = "Error";
                ViewBag.type = "red";
                return View();
            }


        }

        [Route("Dashboard")]
        [Route("")]
        public IActionResult Dashboard(string dateRange)
        {
            var user = getuser();
            ViewBag.user = user;
            ViewBag.title = "Dashboard";
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var asses = acol.Find(x => x._artisan_id == user._id && x.assignmentStatus == AssignmentStatus.signedOff).ToList();
            if (dateRange != null && dateRange != "")
            {
                var from = dateRange.Substring(0, 12);
                var to = dateRange.Replace(from, "").Replace(" – ", "");
                var datefrom = DateTime.Parse(from);
                var dateto = DateTime.Parse(to);
                asses = asses.Where(x => x.date >= datefrom && x.date <= dateto).ToList();
            }

            var ytd = 0.0;
            foreach (var a in asses)
            {
                ytd += a.amountPayed;
            }
            ViewBag.ytd = globals.getLocalCurrencyNG(ytd);
            return View();
        }

        [Route("Bidding")]
        public IActionResult Bidding(int page = 1, string param = "", string msg = "", string type = "")
        {
            checkRegistration();


            var user = getuser();
            ViewBag.user = user;
            ViewBag.title = "Bidding";
            ViewBag.type = type;
            ViewBag.msg = msg;

            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var scol = globals.getDB().GetCollection<mCountry>("mCountry");
            var countrys = scol.Find(e => e._id != null).ToList();
            var asses = acol.Find(x => x._id != null
                                    && x.assignmentStatus == AssignmentStatus.pending
                                    ).ToList();
            if (param != null && param != "")
            {
                param = param.ToLower();
                ViewBag.param = param;
                asses = asses.Where(x =>
                                    x.state.ToLower().Contains(param) ||
                                    x.city.ToLower().Contains(param) ||
                                    x.streetaddress.ToLower().Contains(param) ||
                                    x.description.ToLower().Contains(param)
                    ).ToList();
            }

            asses = asses.OrderByDescending(x => x.date).ToList();
            var ass = (from d in asses select d).AsQueryable();
            ViewBag.ass = ass.ToPagedList(page, 12);

            ViewBag.countrys = countrys;
            ViewBag.user = user;


            return View();
        }

        [Route("Pipeline")]
        public IActionResult Pipeline(int page = 1)
        {
            checkRegistration();

            var user = getuser();
            ViewBag.user = user;
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var assingments = acol.Find(x => x._artisan_id == user._id).ToList().OrderByDescending(x => x.date).ToList();//all the assignments assigned to me
            var a = (from d in assingments select d).AsQueryable();
            ViewBag.ass = a.ToPagedList(page, 12);
            ViewBag.title = "Pipeline";
            return View();
        }

        [Route("AssignmentDetails")]
        public IActionResult AssignmentDetails(string aid, string msg, string type)
        {
            checkRegistration();

            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var a = acol.Find(x => x._id == aid).FirstOrDefault();
            ViewBag.ass = a;
            var user = getuser();
            ViewBag.user = user;
            ViewBag.msg = msg;
            ViewBag.type = type;
            return View();
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("IndexRent", "Home");
        }

        [Route("Profile")]
        public IActionResult Profile(string msg = "",string type="")
        {
            ViewBag.user = getuser();
            ViewBag.title = "Profile";
            ViewBag.msg = msg;
            var scol = globals.getDB().GetCollection<mSkills>("mSkills");
            var skills = scol.Find(x => x._id != null).ToList();
            ViewBag.skills = skills;
            var ccol = globals.getDB().GetCollection<mCountry>("mCountry");
            var countrys = ccol.Find(e => e._id != null).ToList();
            ViewBag.countrys = countrys;
            ViewBag.type = type;
            return View();
        }

        //post updated skills from profile then return to the profile page
        [HttpPost("UpdateSkills")]
        public IActionResult UpdateSkills(mArtisan a,List<string> myskills)
        {
            var acol = globals.getDB().GetCollection<mArtisan>("mArtisan");
            var oa = getuser();
            a.password = oa.password;//maintain the password
            a._id = oa._id;//maintain the id also
            a.image = oa.image;
            a.skills_list = myskills;
            a.registered = true;
            acol.ReplaceOne(x => x._id == oa._id, a);
            return RedirectToAction("Profile", "Artisan", new { msg = "Saved",type="green" });
        }

        [Route("uploadProfilePicture")]
        public JsonResult uploadProfilePicture(IFormCollection fimg)
        {
            var Ucol = globals.getDB().GetCollection<mArtisan>("mArtisan");
            var user = getuser();

            try
            {

                //delete previose picture from disk
                if (user.image != null && user.image != "")
                {
                    FileInfo file = new FileInfo(host.WebRootPath + "/" + user.image);
                    if (file.Exists) file.Delete();
                }

                var filename = Path.Combine(host.WebRootPath, "uploads/" + globals.getId() + Path.GetExtension(fimg.Files[0].FileName));
                using (var stream = new FileStream(filename, FileMode.Create))
                {
                    fimg.Files[0].CopyTo(stream);
                    stream.Close();
                    stream.Dispose();
                }
                user.image = "/uploads/" + Path.GetFileName(filename);
                Ucol.ReplaceOne(x => x._id == user._id, user);
                return Json(new { res = "ok", msg = user.image });
            }
            catch (Exception ex)
            {
                return Json(new { res = "err", msg = ex.Message });
            }
        }





    }
}
