using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Hosting.Internal;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;
using VPM.Models;
using Microsoft.AspNetCore.Http;
using PagedList.Core;
using System.IO;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using System.Web;
using System.Net;

namespace VPM.Controllers
{
    [Route("Account")]
    [AuthFilterAccount]
    public class AccountController : Controller
    {


        HostingEnvironment host;

        public AccountController(HostingEnvironment e)
        {
            host = e;
        }


        private mUser getuser()
        {
            var sess = HttpContext.Session.GetString("email");
            var ucol = globals.getDB().GetCollection<mUser>("mUser");
            var user = ucol.Find(e => e.email == sess||e.mobile==sess).FirstOrDefault();
            if (String.IsNullOrEmpty(user.name)) user.name = "New User";//placeholder for the name
            return user;
        }


       



        [Route("Dashboard")]
        [Route("")]
        public IActionResult Dashboard(int page = 1)
        {

            var user = getuser();
            ViewBag.user = user;
            ViewBag.title = "Dashboard";

            var ecol = globals.getDB().GetCollection<mEnquiry>("mEnquiry");
            var enqs = (from d in ecol.Find(x => x.enquiryState == EnquiryState.underLandLordReview).ToList().OrderByDescending(x => x.date) select d).AsQueryable();
            ViewBag.enqs = enqs.ToPagedList(page, 10);


            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var p = pcol.Find(x => x.userid == user._id).ToList();
            ViewBag.propertys = p;


            var mcol = globals.getDB().GetCollection<mMessages>("mMessages");
            var m = mcol.Find(x => x.userEmail == user.email).ToList();
            ViewBag.msgs = m;


            return View();
        }


        [Route("Chats")]
        public IActionResult Chats()
        {
            var user = getuser();
            ViewBag.user = user;
            return View();
        }


        [Route("getcities")]
        public string getcities(string country, string state)
        {
            state = "Abuja FCT";
            country = "Nigeria";
            try
            {
                var ccol = globals.getDB().GetCollection<mCountry>("mCountry");
                var country_ = ccol.Find(x => x.name == country
                ).FirstOrDefault();
                var states = country_.stateOrPorvince.Where(x => x.name == state).FirstOrDefault();
                return JsonConvert.SerializeObject(states.city_suburb_town_location.ToList());

            }
            catch (Exception e)
            {
                return Json(new { res = "err", msg = e.Message }).ToString();
            }
        }


        [Route("Maintenance")]
        public IActionResult Maintenance(string pid, int page = 1)
        {
            ViewBag.title = "Maintenance";

            var user = getuser();
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var props = pcol.Find(x => x.userid == user._id).ToList().OrderByDescending(x => x.dateCreated).ToList();
            ViewBag.props = props;
            mProperty p = null;
            if (pid == "" || pid == null)
            {
                p = pcol.Find(x => x.userid == user._id).FirstOrDefault();
            }
            else
            {
                p = pcol.Find(x => x._id == pid).FirstOrDefault();
            }
            ViewBag.user = user;
            if (p == null) return View();
            ViewBag.pid = p._id;
            ViewBag.selectedProperty = p;
            ViewBag.maintananceList = (from d in p.maintananceList.Where(x => x._id != null).OrderByDescending(x => x.date).ToList() select d).AsQueryable().ToPagedList(page, 12);

            return View();
        }


        [Route("Revenue")]
        public IActionResult Revenue(string pid, string dateRange, int year, int page = 1)
        {

            var user = getuser();


            ViewBag.title = "Revenue";


            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var props = pcol.Find(x => x.userid == user._id).ToList().OrderByDescending(x => x.dateCreated).ToList();
            ViewBag.props = props;
            mProperty p = null;
            if (pid == "" || pid == null)
            {
                p = pcol.Find(x => x.userid == user._id).FirstOrDefault();
            }
            else
            {
                p = pcol.Find(x => x._id == pid).FirstOrDefault();
            }
            ViewBag.user = user;
            if (p == null)
            {
                ViewBag.ytd = globals.getLocalCurrencyNG(0.00);
                return View();
            }
            ViewBag.pid = p._id;
            ViewBag.selectedProperty = p;

            ViewBag.notifications = (from d in p.notifications.Where(x => x._id != null).OrderByDescending(x => x.date).ToList() select d).AsQueryable().ToPagedList(page, 3);



            ViewBag.rejected = (int?)p.waitingList.Where(x => x.stage == waitingListStage.rejected).Count() ?? 0;
            ViewBag.accepted = (int?)p.waitingList.Where(x => x.stage == waitingListStage.accepted).Count() ?? 0;
            ViewBag.adminReview = (int?)p.waitingList.Where(x => x.stage == waitingListStage.adminReview).Count() ?? 0;
            ViewBag.landLordReview = (int?)p.waitingList.Where(x => x.stage == waitingListStage.landLordReview).Count() ?? 0;
            ViewBag.eligible = (int?)p.waitingList.Where(x => x.stage == waitingListStage.eligible).Count() ?? 0;
            ViewBag.pending = (int?)p.waitingList.Where(x => x.stage == waitingListStage.pending).Count() ?? 0;


            ViewBag.monthlyRevenue = JsonConvert.SerializeObject(p.getMonthlyRevenue(year));
            ViewBag.monthlyTarget = JsonConvert.SerializeObject(p.getMonthlyTarget(year));
            ViewBag.year = year;
            ViewBag.dateRange = dateRange;
            //dateRange=Sep+28%2C+2018+–+Oct+28%2C+2018
           /* if (dateRange != null)
            {
                var dates = dateRange.Split("–");
                var dfrom = dates[0];
                var dto = dates[1];
                dfrom = dfrom.Replace("%2C", " ").Replace("+", " ");
                dto = dto.Replace("%2C", " ").Replace("+", " ");
                var d1 = DateTime.Parse(dfrom);
                var d2 = DateTime.Parse(dto);
                var _ytd = p.getYTDRevenue(d1, d2);
                ViewBag.ytd = globals.getLocalCurrencyNG(_ytd);

            }
            else
            {
                ViewBag.ytd = globals.getLocalCurrencyNG(0.00);
            }*/

            var paycol = globals.getDB().GetCollection<mPayments>("mPayments");
            var All_Payments = paycol.Find(x => x.paymentType == PaymentType.rentalPayment &&x.propertyID==pid).ToList();//list all my payments for this property
            if (dateRange == null || dateRange == "")
            {
                var ytd = All_Payments.Select(x => x.amount).Sum();
                ViewBag.ytd = globals.getLocalCurrencyNG(ytd);
            }
            else
            {//filter by the dates
                var dates = dateRange.Split("–");
                var dfrom = dates[0];
                var dto = dates[1];
                dfrom = dfrom.Replace("%2C", " ").Replace("+", " ");
                dto = dto.Replace("%2C", " ").Replace("+", " ");
                var d1 = DateTime.Parse(dfrom).AddDays(-1);
                var d2 = DateTime.Parse(dto).AddDays(1);
                var ytd = All_Payments.Where(x=>x.date>=d1&&x.date<=d2).ToList().Select(x => x.amount).Sum();
                ViewBag.ytd = globals.getLocalCurrencyNG(ytd);
            }

            return View();
        }


        [Route("Pipeline")]
        public IActionResult Pipeline(string pid, int page = 1)
        {
            var user = getuser();
            ViewBag.title = "Pipeline";

            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var props = pcol.Find(x => x.userid == user._id).ToList().OrderByDescending(x => x.dateCreated).ToList();
            ViewBag.props = props;
            mProperty p = null;
            if (pid == "" || pid == null)
            {
                p = pcol.Find(x => x.userid == user._id).FirstOrDefault();
            }
            else
            {
                p = pcol.Find(x => x._id == pid).FirstOrDefault();
            }
            ViewBag.user = user;
            if (p == null) return View();
            ViewBag.pid = p._id;
            ViewBag.selectedProperty = p;

            ViewBag.notifications = (from d in p.notifications.Where(x => x._id != null).OrderByDescending(x => x.date).ToList() select d).AsQueryable().ToPagedList(page, 3);



            ViewBag.rejected = (int?)p.waitingList.Where(x => x.stage == waitingListStage.rejected).Count() ?? 0;
            ViewBag.accepted = (int?)p.waitingList.Where(x => x.stage == waitingListStage.accepted).Count() ?? 0;
            ViewBag.adminReview = (int?)p.waitingList.Where(x => x.stage == waitingListStage.adminReview).Count() ?? 0;
            ViewBag.landLordReview = (int?)p.waitingList.Where(x => x.stage == waitingListStage.landLordReview).Count() ?? 0;
            ViewBag.eligible = (int?)p.waitingList.Where(x => x.stage == waitingListStage.eligible).Count() ?? 0;
            ViewBag.pending = (int?)p.waitingList.Where(x => x.stage == waitingListStage.pending).Count() ?? 0;
            return View();
        }

        //get
        [HttpGet("CreateProperty")]
        public IActionResult CreateProperty(string pid)
        {
            ViewBag.title = "CreateProperty";

            var user = getuser();
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var scol = globals.getDB().GetCollection<mCountry>("mCountry");
            var countrys = scol.Find(e => e._id != null).ToList();

            var p = new mProperty();


            if (pid != null && pid != "")
            {
                p = pcol.Find(e => e._id == pid).FirstOrDefault();
            }
            else
            {
                p.userid = user._id;
                pcol.InsertOne(p);
            }

            ViewBag.countrys = countrys;
            ViewBag.property = p;
            ViewBag.user = user;
            ViewBag.pid = p._id;//property id

            return View();
        }

        //post
        [HttpPost("CreateProperty")]
        public IActionResult CreateProperty(mProperty p, string pid)
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var prop = pcol.Find(e => e._id == pid).FirstOrDefault();
            prop.propertyName = p.propertyName;
            prop.propertyType = p.propertyType;
            prop.propertyCountry = p.propertyCountry;
            prop.stateOrPorvince = p.stateOrPorvince;
            prop.cityOrTown = p.cityOrTown;
            prop.suburb = p.suburb;
            prop.streetAddress = p.streetAddress;
            prop.userid = getuser()._id;
            prop.PropertyStatus = p.PropertyStatus;
            prop.saved = true;
            prop.description = p.description;
            prop.price = p.price;
            prop.billingRate = p.billingRate;
            prop.numberOfOccupants = p.numberOfOccupants;
            prop.qtyOfThisProperty = p.qtyOfThisProperty;
            prop.numBeds = p.numBeds;
            prop.bathType = p.bathType;
            prop.propertyPurpose = p.propertyPurpose;

            var t = new TimeLine()
            {
                message = "Created property " + prop.propertyName
            };
            var m = new MaintananceList()
            {
                description = "First Inspection",
                stage = MaintananceStage.pendingDispatch,
                cost = 0
            };
            var n = new Notifications()
            {
                message = "First Inspection is still pending, a representative will soon be dispatched",
                from = "support@VPM.com",
            };
            //only add the initial time line info if none exist already
            if (prop.timeLine.Count == 0)
            {
                prop.timeLine.Add(t);
                prop.maintananceList.Add(m);
                prop.notifications.Add(n);
            }


            //save this properties geo goordinates as well
            var query = HttpUtility.UrlEncode(prop.cityOrTown + " " + prop.stateOrPorvince + " " + prop.streetAddress);
            WebClient wc = new WebClient();
            var response = wc.DownloadString("https://api.tomtom.com/search/2/geocode/" + query + ".json?key=kDBGrc2tROkfTL2jlCBl26GLscDVhEZL&typeahead=false&lat=9.0820&lon=8.6753&countrySet=NG");
            mJsonMapResult re = JsonConvert.DeserializeObject<mJsonMapResult>(response);
            prop.lat = re.results[0].position.lat;
            prop.lon = re.results[0].position.lon;

            pcol.ReplaceOneAsync(e => e._id == pid, prop);






            return RedirectToAction("Properties", "Account");

        }


        [Route("UploadPropertyImages")]
        public JsonResult UploadPropertyImages(IFormCollection file, string pid)
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var property = pcol.Find(e => e._id == pid).FirstOrDefault();
            var user = getuser();
            try
            {
                var image = new PropertyImages();
                var filename = Path.Combine(host.WebRootPath, "uploads/" + image._id + Path.GetExtension(file.Files[0].FileName));
                using (var stream = new FileStream(filename, FileMode.Create))
                {
                    file.Files[0].CopyTo(stream);
                    stream.Close();
                    stream.Dispose();
                }
                image.path = "/uploads/" + Path.GetFileName(filename);
                var update = Builders<mProperty>.Update.AddToSet(p => p.PImages, image);
                pcol.UpdateOne(e => e._id == pid, update);
                return Json(new { res = "ok", msg = Path.GetFileName(filename), id = image._id });
            }
            catch (Exception ex)
            {
                return Json(new { res = "err", msg = ex.Message });
            }
        }


        [Route("UploadPropertyTitleDeeds")]
        public JsonResult UploadPropertyTitleDeeds(IFormCollection file, string pid)
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var property = pcol.Find(e => e._id == pid).FirstOrDefault();
            var user = getuser();
            try
            {
                var td = new TitleDeedFiles();
                var filename = Path.Combine(host.WebRootPath, "uploads/" + td._id + Path.GetExtension(file.Files[0].FileName));
                using (var stream = new FileStream(filename, FileMode.Create))
                {
                    file.Files[0].CopyTo(stream);
                    stream.Close();
                    stream.Dispose();
                }
                td.path = "/uploads/" + Path.GetFileName(filename);
                td.mime = file.Files[0].ContentType;
                var update = Builders<mProperty>.Update.AddToSet(p => p.TdFiles, td);
                pcol.UpdateOne(e => e._id == pid, update);
                return Json(new { res = "ok", msg = Path.GetFileName(filename), id = td._id });
            }
            catch (Exception ex)
            {
                return Json(new { res = "err", msg = ex.Message });
            }
        }


        [Route("removePropertyImage")]
        public JsonResult removePropertyImage(string pid, string id)
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var product = pcol.Find(e => e._id == pid).FirstOrDefault();
            var image = product.PImages.Where(e => e._id == id).FirstOrDefault();
            try
            {
                System.IO.File.Delete(host.WebRootPath + image.path);

            }
            catch (Exception ex)
            {
                return Json(new { res = "err", msg = "1: " + ex });
            }
            try
            {
                var update = Builders<mProperty>.Update.Pull(p => p.PImages, image);
                pcol.UpdateOne(e => e._id == pid, update);
            }
            catch (Exception ex)
            {
                return Json(new { res = "err", msg = "2: " + ex });
            }
            return Json(new { res = "ok", msg = "image deleted" });

        }


        [Route("removeTitleDeed")]
        public JsonResult removeTitleDeed(string pid, string id)
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var product = pcol.Find(e => e._id == pid).FirstOrDefault();
            var td = product.TdFiles.Where(e => e._id == id).FirstOrDefault();
            try
            {
                System.IO.File.Delete(host.WebRootPath + td.path);

            }
            catch (Exception ex)
            {
                return Json(new { res = "err", msg = "1: " + ex });
            }
            try
            {
                var update = Builders<mProperty>.Update.Pull(p => p.TdFiles, td);
                pcol.UpdateOne(e => e._id == pid, update);
            }
            catch (Exception ex)
            {
                return Json(new { res = "err", msg = "2: " + ex });
            }
            return Json(new { res = "ok", msg = "td deleted" });

        }


        [Route("Properties")]
        public IActionResult Properties(int page = 1)
        {
            var user = getuser();
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");

            //clean up by removing any items that are unsaved
            var props = pcol.Find(x => x.propertyName == null || x.propertyName == "").ToList();
            foreach (var i in props)
            {
                deleteProperty_(i._id);
            }

            var property = (from d in pcol.Find(p => p.userid == user._id).ToList() select d).AsQueryable();
            ViewBag.user = user;
            ViewBag.property = property.ToPagedList(page, 11);
            ViewBag.title = "Properties";
            return View();
        }


        [Route("deleteProperty")]
        public JsonResult deleteProperty(string pid)
        {
            return deleteProperty_(pid);
        }

        public JsonResult deleteProperty_(string pid)
        {
            try
            {
                var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
                var p = pcol.Find(e => e._id == pid).FirstOrDefault();
                foreach (var i in p.PImages)
                {
                    System.IO.File.Delete(host.WebRootPath + i.path);
                }
                foreach (var i in p.TdFiles)
                {
                    System.IO.File.Delete(host.WebRootPath + i.path);
                }
                pcol.DeleteOne(e => e._id == pid);
                return Json(new { res = "ok", msg = "deleted" });
            }
            catch (Exception ex)
            {
                return Json(new { res = "err", msg = ex.ToString() });
            }
        }

        [Route("SaveGoogleFormLink")]
        public JsonResult SaveGoogleFormLink(string _ref, string pid)
        {
            try
            {
                var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
                var p = pcol.Find(e => e._id == pid).FirstOrDefault();
                p.eligibilityFormLink = _ref;
                pcol.ReplaceOneAsync(e => e._id == pid, p);
                return Json(new { res = "ok", msg = "saved" });
            }
            catch (Exception ex)
            {
                return Json(new { res = "err", msg = ex.Message });
            }

        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("IndexRent", "Home");
        }



        [Route("ViewEnquiry")]
        public IActionResult ViewEnquiry(string eid, string msg)
        {
            var ecol = globals.getDB().GetCollection<mEnquiry>("mEnquiry");
            var user = getuser();
            var enq = ecol.Find(x => x._id == eid).FirstOrDefault();
            ViewBag.user = user;
            ViewBag.enq = enq;
            ViewBag.msg = msg;
            return View();
        }

        [Route("deleteEligibilityForm")]
        public JsonResult deleteEligibilityForm(string pid)
        {
            try
            {
                var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
                var update = Builders<mProperty>.Update.Set(x => x.eligibilityFormLink, "");
                pcol.UpdateOne(x => x._id == pid, update);
                return Json(new { res = "ok", msg = "deleted" });
            }
            catch (Exception ex)
            {
                return Json(new { res = "err", msg = ex.Message });
            }
        }


        [HttpPost("setEnquiryStatus")]
        public IActionResult setEnquiryStatus(string eid, string enqStatus)
        {
            var ecol = globals.getDB().GetCollection<mEnquiry>("mEnquiry");
            EnquiryState enq = EnquiryState.rejected;
            if (enqStatus == "open") enq = EnquiryState.open;
            else if (enqStatus == "closed") enq = EnquiryState.closed;
            else if (enqStatus == "rejected") enq = EnquiryState.rejected;
            else if (enqStatus == "accepted") enq = EnquiryState.accepted;
            else if (enqStatus == "Under Admin Review") enq = EnquiryState.underAdminReview;
            else if (enqStatus == "Under LandLord Review") enq = EnquiryState.underLandLordReview;
            var update = Builders<mEnquiry>.Update.Set(x => x.enquiryState, enq);
            ecol.UpdateOne(x => x._id == eid, update);
            return RedirectToAction("ViewEnquiry", "Account", new { eid = eid, msg = "Saved" });
        }

        [HttpGet("Settings")]
        public IActionResult Settings(string msg)
        {
            var user = getuser();
            ViewBag.user = user;
            ViewBag.title = "Settings";
            return View();
        }


        [HttpPost("Settings")]
        public IActionResult Settings(
            string emialNotifications,
            string smsNotifications,
            string notifyWhenNewEnquiry,
            string notifyWhenNewWaitingListApplicant,
            string notifyWhenNewMessageArrives
            )
        {
            string msg = "";
            try
            {
                var ucol = globals.getDB().GetCollection<mUser>("mUser");
                var u = getuser();//ucol.Find(x => x._id == uid).FirstOrDefault();
                var s = new mSettings();
                if (emialNotifications != null) s.emialNotifications = true; else s.emialNotifications = false;
                if (smsNotifications != null) s.smsNotifications = true; else s.smsNotifications = false;
                if (notifyWhenNewEnquiry != null) s.notifyWhenNewEnquiry = true; else s.notifyWhenNewEnquiry = false;
                if (notifyWhenNewWaitingListApplicant != null) s.notifyWhenNewWaitingListApplicant = true; else s.notifyWhenNewWaitingListApplicant = false;
                if (notifyWhenNewWaitingListApplicant != null) s.notifyWhenNewWaitingListApplicant = true; else s.notifyWhenNewWaitingListApplicant = false;
                if (notifyWhenNewMessageArrives != null) s.notifyWhenNewMessageArrives = true; else s.notifyWhenNewMessageArrives = false;
                u.settings = s;
                ucol.ReplaceOneAsync(x => x._id == u._id, u);
                ViewBag.user = u;
                ViewBag.title = "Settings";
                msg = "Saved";
                ViewBag.type = "green";
            }
            catch (Exception ex)
            {
                msg = "Error";
                ViewBag.type = "red";
            }
            ViewBag.msg = msg;
            return View();
        }


        [HttpGet("AccountSettings")]
        public IActionResult AccountSettings()
        {
            ViewBag.user = getuser();
            ViewBag.title = "AccountSettings";
            return View();
        }

        [HttpPost("AccountSettings")]
        public IActionResult AccountSettings(mUser u)
        {
            var user = getuser();
            try
            {
                user.name = u.name;
                user.surname = u.surname;
                user.email = u.email;
                user.mobile = u.mobile;
                var ucol = globals.getDB().GetCollection<mUser>("mUser");
                ucol.ReplaceOneAsync(x => x._id == user._id, user);
                ViewBag.msg = "Saved";
                ViewBag.type = "green";
            }
            catch (Exception ex)
            {
                ViewBag.msg = "Error";
                ViewBag.type = "red";
            }
            ViewBag.user = user;
            ViewBag.title = "AccountSettings";
            return View();
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
                var ucol = globals.getDB().GetCollection<mUser>("mUser");
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
