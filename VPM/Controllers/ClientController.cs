using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using VPM.Models;
using Microsoft.AspNetCore.Hosting.Internal;
using PagedList.Core;
using System.IO;
using System.Web;
using System.Net;
using Newtonsoft.Json;

namespace VPM.Controllers
{
    [Route("Client")]
    [AuthFilterClient]
    public class ClientController : Controller
    {



        HostingEnvironment host;

        public ClientController(HostingEnvironment e)
        {
            host = e;
        }

        private mClient getuser()
        {
            var sess = HttpContext.Session.GetString("email");
            var ucol = globals.getDB().GetCollection<mClient>("mClient");
            var user = ucol.Find(e => e.email == sess ||e.mobile==sess).FirstOrDefault();//fetch either by email or by mobile number
            if (String.IsNullOrEmpty(user.name)) user.name = "New User";
            return user;
        }


        [Route("CloseDispute")]
        public IActionResult CloseDispute(string aid)
        {
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var ass = acol.Find(x => x._id == aid).FirstOrDefault();
            var artisan = ass.getArtisan();
            ass.assignmentStatus = AssignmentStatus.completed;
            ass.dispute_description = "";
            acol.ReplaceOne(x => x._id == aid, ass);//update it
            //email the artisan 
            var email = new globals.emailMessage();
            email.to = artisan.email;
            email.subject = "Closed dispute";
            email.message = System.IO.File.ReadAllText(host.WebRootPath + "/emialViews/email_notification.html");
            email.message = email.message.Replace("{{message}}", "The assignment : " + ass.description + "  with dispute : " + ass.dispute_description + " has been closed");
            Task.Run(() =>
            {
                globals.sendEmail(email);
                email.to = globals.supportEmail;//send the same email to support
                globals.sendEmail(email);
            });

            return RedirectToAction("Maintenance", "client", new { msg = "Dispute has been recorded we will get in touch with you to assist to resolve the dispute", type = "blue" });
        }

        [Route("OpenDispute")]
        public IActionResult OpenDispute(string aid, string description)
        {
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var ass = acol.Find(x => x._id == aid).FirstOrDefault();
            var artisan = ass.getArtisan();
            ass.assignmentStatus = AssignmentStatus.dispute;
            ass.dispute_description = description;
            acol.ReplaceOne(x => x._id == aid, ass);//update it
            //email the artisan 
            var email = new globals.emailMessage();
            email.to = artisan.email;
            email.subject = "Open dispute";
            email.message = System.IO.File.ReadAllText(host.WebRootPath + "/emialViews/email_notification.html");
            email.message = email.message.Replace("{{message}}", "The assignment : " + ass.description + "  has an open dispute : " + description);
            Task.Run(() =>
            {
                globals.sendEmail(email);
                email.to = globals.supportEmail;//send the same email to support
                globals.sendEmail(email);
            });

            return RedirectToAction("Maintenance", "client", new { msg = "Dispute has been recoreded we will get in touch with you to assist to resolve the dispute", type = "blue" });
        }

        [Route("AssignTaskToArtisan")]
        public IActionResult AssignTaskToArtisan(string artisan_id, string assignment_id)
        {
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var update = Builders<mAssignments>.Update.Set(x => x._artisan_id, artisan_id);
            acol.UpdateOne(x => x._id == assignment_id, update);
            var ass = acol.Find(x => x._id == assignment_id).FirstOrDefault();

            var aacol = globals.getDB().GetCollection<mArtisan>("mArtisan");
            var artisan = aacol.Find(x => x._id == artisan_id).FirstOrDefault();

            //send email to artisan
            var email = new globals.emailMessage();
            email.to = artisan.email;
            email.subject = "New Job Assignment";
            email.message = System.IO.File.ReadAllText(host.WebRootPath + "/emialViews/email_notification.html");
            email.message = email.message.Replace("{{message}}", "You have a new job match: " + ass.description);
            Task.Run(() =>
            {
                globals.sendEmail(email);
            });
            return RedirectToAction("Support", "Client", new { aid = assignment_id, msg = "Assigned", type = "green" });

        }

        [Route("deAssignTaskToArtisan")]
        public IActionResult deAssignTaskToArtisan(string artisan_id, string assignment_id)
        {
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var update = Builders<mAssignments>.Update.Set(x => x._artisan_id, "");//clear the artisan id to de assign
            acol.UpdateOne(x => x._id == assignment_id, update);
            return RedirectToAction("Support", "Client", new { aid = assignment_id, msg = "de-Assigned", type = "green" });
        }

        [Route("ViewArtisanFullProfile")]
        public IActionResult ViewArtisanFullProfile(string aid)//artisan profile =aid
        {
            ViewBag.user = getuser();
            var acol = globals.getDB().GetCollection<mArtisan>("mArtisan");
            var artisan = acol.Find(x => x._id == aid).FirstOrDefault();
            ViewBag.artisan = artisan;
            ViewBag.title = "View Artisan Full Profile";
            var scol = globals.getDB().GetCollection<mSkills>("mSkills");
            var skills = scol.Find(x => x._id != null).ToList();
            ViewBag.skills = skills;
            var ccol = globals.getDB().GetCollection<mCountry>("mCountry");
            var countrys = ccol.Find(e => e._id != null).ToList();
            ViewBag.countrys = countrys;
            return View();
        }

        [HttpGet("MakePayment")]
        [HttpGet("")]
        public IActionResult MakePayment()
        {
            ViewBag.title = "Make Payment";

            var user = getuser();
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var ass = acol.Find(x => x.clientID == user._id && x._artisan_id != "" && x._artisan_id != null

            && x.assignmentStatus != AssignmentStatus.signedOff

            ).ToList();//only the jobs which have been assigned but not signed off
            ViewBag.ass = ass;

            var ppcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var property = ppcol.Find(x => x.waitingList.Where(i => i.email == user.email).Any()).FirstOrDefault();
            ViewBag.property = property;
            ViewBag.user = user;
            return View();
        }

        [Route("PaymentHistory")]
        public IActionResult PaymentHistory(DateTime from, DateTime to, int page = 1)
        {
            from = from.AddDays(1);
            to = to.AddDays(1);
            var user = getuser();
            ViewBag.user = user;
            var pcol = globals.getDB().GetCollection<mPayments>("mPayments");
            var payments = pcol.Find(x => x.clientID == user._id).ToList();
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
        
        [Route("Dashboard")]
        public IActionResult Dashboard()
        {
            var user = getuser();
            ViewBag.user = user;
            ViewBag.title = "Dashboard";
            return RedirectToAction("Makepayment", "Client");
        }
        
        [HttpGet("forgotpasswordTenant")]
        public IActionResult forgotpasswordTenant()
        {
            var user = getuser();
            ViewBag.user = user;
            ViewBag.title = "forgotpasswordTenant";
            return View();
        }
        
        [HttpGet("ReportIssue")]
        public IActionResult reportIssue()
        {
            var ass = new mAssignments();
            ViewBag.ass = ass;
            var user = getuser();
            ViewBag.user = user;
            ViewBag.title = "ReportIssue";
            return View();
        }

        [HttpPost("ReportIssue")]
        public IActionResult p_reportIssue(mAssignments ass)
        {
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            acol.InsertOne(ass);
            ViewBag.ass = ass;
            var user = getuser();
            ViewBag.user = user;
            ViewBag.title = "ReportIssue";
            return View();
        }
        
        [HttpGet("Account")]
        public IActionResult Account(string msg, string type)
        {
            ViewBag.title = "Account";
            ViewBag.user = getuser();
            ViewBag.type = type;
            ViewBag.msg = msg;
            return View();
        }

        [Route("Maintenance")]
        public IActionResult Maintenance(int page = 1, string msg = "", string type = "")
        {
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var emptyRequests = acol.Find(x => x.description == null || x.description == "").ToList();

            foreach (var e in emptyRequests)
            {
                acol.DeleteOne(x => x._id == e._id);
                foreach (var i in e.images)
                {
                    try
                    {
                        System.IO.File.Delete(i);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            //acol.DeleteMany(x => x.description == null || x.description == "");//clears all the fake ones

            var user = getuser();
            ViewBag.user = user;
            ViewBag.msg = msg;
            ViewBag.type = type;

            var countOpenAssignments = acol.Find(x => x.clientID == user._id && x.assignmentStatus != AssignmentStatus.signedOff).Count();
            ViewBag.countOpenAssignments = countOpenAssignments;
            var ass = (from d in acol.Find(x => x.clientID == user._id).ToList().OrderByDescending(x => x.date).ToList() select d).AsQueryable();
            ViewBag.ass = ass.ToPagedList(page, 12);
            ViewBag.title = "Maintenance";
            return View();
        }

        [HttpGet("Support")]
        //mtype = maintanance type parameter passed from the index.fix page
        public IActionResult Support(string mtype = "", string aid = "", string msg = "", string type = "", int page = 1)
        {
            mtype = mtype.Replace("'", "");
            var user = getuser();
            ViewBag.user = user;
            ViewBag.msg = msg;
            ViewBag.type = type;
            ViewBag.title = "Support";
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var scol = globals.getDB().GetCollection<mSkills>("mSkills");
            var skills = scol.Find(x => x._id != null).ToList();
            ViewBag.skills = skills;

            if (aid == "" || aid == null)
            {
                var ass = new mAssignments();
                ass.clientID = user._id;
                if (mtype != null && mtype != "")//this will set the selected skill mtype passed as parameter
                {
                    var mtypeSkill = skills.Where(x => x.skill == mtype).FirstOrDefault();
                    if(mtypeSkill!=null)
                    ass.skillType = mtypeSkill._id;
                }
                acol.InsertOne(ass);
                ViewBag.ass = ass;
                ViewBag.bids = (from d in ass.bids select d).AsQueryable().ToPagedList(page, 7);
            }
            else
            {
                var ass = acol.Find(x => x._id == aid).FirstOrDefault();
                if (mtype != null && mtype != "")//this will set the selected skill mtype passed as parameter
                {
                    var mtypeSkill = skills.Where(x => x.skill == mtype).FirstOrDefault();
                    if (mtypeSkill != null)
                    ass.skillType = mtypeSkill._id;
                }
                ViewBag.ass = ass;
                ViewBag.bids = (from d in ass.bids select d).AsQueryable().ToPagedList(page, 7);
            }


            return View();
        }

        [Route("SignoffAssignment")]
        public IActionResult SignoffAssignment(string aid, int rating)
        {
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var assignment = acol.Find(x => x._id == aid).FirstOrDefault();
            assignment.assignmentStatus = AssignmentStatus.signedOff;
            assignment.completetionDate = DateTime.Now;//save the date this assignment was completed
            acol.ReplaceOne(x => x._id == aid, assignment);

            //add rating
            var rat = new artisanRating();
            rat.clientID = assignment.getArtisan()._id;
            rat.numStars = rating;
            rat.assignmentID = assignment._id;

            var artcol = globals.getDB().GetCollection<mArtisan>("mArtisan");
            var artisan = assignment.getArtisan();
            artisan.artisanRating.Add(rat);
            artisan.numJobs += 1;//add number of jobs too
            artcol.ReplaceOne(x => x._id == artisan._id, artisan);//replace to update



            //end of month admin will disperse the funds
            return RedirectToAction("Maintenance", "client", new { msg = "updated", type = "green" });
        }

        [HttpPost("SavePaymentDetails")]//pt is payment type
        public IActionResult SavePaymentDetails(string txref, string pt, string flwRef, double amount, string AssignmentID)
        {
            var user = getuser();
            var pcol = globals.getDB().GetCollection<mPayments>("mPayments");
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var ppcol = globals.getDB().GetCollection<mProperty>("mProperty");

            var property = ppcol.Find(x => x.waitingList.Where(i => i.email == user.email).Any()).FirstOrDefault();
            var assignment = acol.Find(x => x._id == AssignmentID).FirstOrDefault();

            var payment = new mPayments();
            payment.reference = txref;//payment going to the artisan for his service
            if (pt == "artisanService" || pt == "0")
            {
                payment.paymentType = PaymentType.artisanService;
                payment.artisanID = assignment._artisan_id;
                assignment.addPayment(amount);//add the payment to the assignment
                acol.ReplaceOne(x => x._id == AssignmentID, assignment);//replace the assignment
                //send artisan an email
                var email = new globals.emailMessage();
                email.to = assignment.getArtisan().email;
                email.subject = "Payment has been made";
                email.message = System.IO.File.ReadAllText(host.WebRootPath + "/emialViews/email_notification.html");
                email.message = email.message.Replace("{{message}}", "A payment has been made for one of your assignments log in to view");
                Task.Run(() =>
                {
                    globals.sendEmail(email);
                });
            }
            else
            {
                payment.paymentType = PaymentType.rentalPayment;//payment going to property owner
                payment.propertyID = property._id;
            }
            payment.clientID = user._id;
            payment.flwRef = flwRef;
            payment.amount = amount;
            payment.txref = txref;
            pcol.InsertOne(payment);
            return RedirectToAction("PaymentHistory", "Client");
        }

        [Route("DeleteAssignement")]
        public IActionResult DeleteAssignement(string aid)
        {
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var ass = acol.Find(x => x._id == aid).FirstOrDefault();
            foreach (var t in ass.images)
            {
                System.IO.File.Delete(host.WebRootPath + t);
            }
            acol.DeleteOne(x => x._id == aid);
            return RedirectToAction("Maintenance", "Client", new { msg = "Deleted", type = "blue" });
        }

        //basically updates the existing assignment
        [HttpPost("CreateAssignment")]
        public IActionResult CreateAssignment(string skillType, string description, string state, string city, string streetAddress, string aid)
        {

            var lat = "";
            var lon = "";
            description = description.Trim(' ');
            state = state.Trim().Replace(" ", "");
            city = city.Trim(' ');
            streetAddress = streetAddress.Trim(' ');
            aid = aid.Trim();
            try
            {
                //save this properties geo goordinates as well
                var query = HttpUtility.UrlEncode(state.ToLower() + " " + city.ToLower() + " " + streetAddress.ToLower());
                WebClient wc = new WebClient();
                var response = wc.DownloadString("https://api.tomtom.com/search/2/geocode/" + query + ".json?key=kDBGrc2tROkfTL2jlCBl26GLscDVhEZL&typeahead=false&lat=9.0820&lon=8.6753&countrySet=NG");
                mJsonMapResult re = JsonConvert.DeserializeObject<mJsonMapResult>(response);

                lat = re.results[0].position.lat;
                lon = re.results[0].position.lon;

            }
            catch (Exception ex)
            {

            }


            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var ass = acol.Find(x => x._id == aid).FirstOrDefault();
            var update = Builders<mAssignments>.Update
                .Set(x => x.description, description)
                .Set(x => x.state, state)
                .Set(x => x.city, city)
                .Set(x => x.lat, lat)//set the coordiantes
                .Set(x => x.lon, lon)//set the longitude
                .Set(x => x.lon, lon)//set the longitude
                .Set(x => x.skillType, skillType);
            acol.UpdateOne(x => x._id == aid, update);
            return RedirectToAction("Maintenance", "Client");
        }

        [Route("UploadPropertyImages")]
        public JsonResult UploadPropertyImages(IFormCollection file, string aid)
        {
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var ass = acol.Find(e => e._id == aid).FirstOrDefault();
            var user = getuser();

            try
            {
                var image = Guid.NewGuid().ToString();
                var filename = Path.Combine(host.WebRootPath, "uploads/" + image + Path.GetExtension(file.Files[0].FileName));
                var _file = "/uploads/" + image + Path.GetExtension(file.Files[0].FileName);
                using (var stream = new FileStream(filename, FileMode.Create))
                {
                    file.Files[0].CopyTo(stream);
                    stream.Close();
                    stream.Dispose();
                }
                var update = Builders<mAssignments>.Update.
                             AddToSet(p => p.images, _file);
                acol.UpdateOne(x => x._id == aid, update);
                return Json(new { res = "ok", msg = Path.GetFileName(filename), id = image });
            }
            catch (Exception ex)
            {
                return Json(new { res = "err", msg = ex.Message });
            }
        }


        [HttpPost("ClientUpdateDetails")]
        public IActionResult ClientUpdateDetails(mClient r)
        {
            try
            {
                var rcol = globals.getDB().GetCollection<mClient>("mClient");
                var update = Builders<mClient>.Update
                    .Set(x => x.name, r.name)
                    .Set(x => x.surname, r.surname)
                    .Set(x => x.mobile, r.mobile)
                    .Set(x => x.email, r.email)
                    .Set(x => x.nextOfKin, r.nextOfKin)
                    .Set(x => x.nextOfKinMobile, r.nextOfKinMobile)
                    .Set(x => x.occupation, r.occupation)
                    .Set(x => x.address, r.address);
                rcol.UpdateOne(x => x.email == r.email, update);

                return RedirectToAction("Account", "Client", new { msg = "Updated", type = "green" });
            }
            catch (Exception ex)
            {
                return RedirectToAction("Account", "Client", new { msg = "Error", type = "red" });
            }
        }


        [Route("removeAssignmentImage")]
        public JsonResult removeAssignmentImage(string aid, string id)
        {
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            var assignment = acol.Find(e => e._id == aid).FirstOrDefault();
            var image = assignment.images.Where(i => i.Contains(id)).FirstOrDefault();
            try
            {
                System.IO.File.Delete(host.WebRootPath + image);

            }
            catch (Exception ex)
            {
                return Json(new { res = "err", msg = "1: " + ex });
            }
            try
            {
                var update = Builders<mAssignments>.Update.Pull(p => p.images, image);
                acol.UpdateOne(e => e._id == aid, update);
            }
            catch (Exception ex)
            {
                return Json(new { res = "err", msg = "2: " + ex });
            }
            return Json(new { res = "ok", msg = "image deleted" });

        }

        [HttpGet("ChangePassword")]
        public IActionResult ChangePassword()
        {
            ViewBag.title = "Change Password";
            ViewBag.user = getuser();
            return View();
        }


        [HttpPost("ChangePassword")]
        public IActionResult ChangePassword(string password)
        {
            try
            {
                ViewBag.title = "Change Password";
                var user = getuser();
                ViewBag.user = user;
                var ucol = globals.getDB().GetCollection<mClient>("mClient");
                user.password = password;
                user.hashPassword();
                ucol.ReplaceOneAsync(x => x._id == user._id, user);
                ViewBag.msg = "Saved";
                ViewBag.type = "green";
                HttpContext.Session.Clear();//clear the session
                return RedirectToAction("Index", "Home");//go to login page
            }
            catch (Exception ex)
            {
                ViewBag.msg = "Error";
                ViewBag.type = "red";
                return View();
            }


        }




    }
}
