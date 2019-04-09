using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting.Internal;
using VPM.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using PagedList.Core;
using PagedList;

namespace VPM.Controllers
{
    [Route("Admin")]
    [AuthFilterAdmin]
    public class AdminController : Controller
    {


        HostingEnvironment host;

        public AdminController(HostingEnvironment e)
        {
            host = e;
        }

        private mUser getuser()
        {
            var sess = HttpContext.Session.GetString("email");
            var ucol = globals.getDB().GetCollection<mUser>("mUser");
            var user = ucol.Find(e => e.email == sess && e.role == UserRole.admin).FirstOrDefault();
            return user;
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            ViewBag.title = "Admin Login";
            return View();
        }

        [Route("Maintenance")]
        public IActionResult Maintenance(string AssignmentStatus, string pid = "", string msg = "", int page = 1)
        {
            var user = getuser();//getadmin

            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var props = pcol.Find(c => c._id != null).ToList();//all properties

            ViewBag.props = props;
            ViewBag.user = user;
            ViewBag.title = "Maintenance";

            //now get assignments
            var acol = globals.getDB().GetCollection<mAssignments>("mAssignments");
            if (pid != "" && pid != null)
            {
                var ass = (from d in acol.Find(c => c._id == pid).ToList() select d).AsQueryable();
                ViewBag.ass = ass.ToPagedList(page, 12);
            }
            else
            {
                var ass = (from d in acol.Find(c => c._id != null).ToList() select d).AsQueryable();
                ViewBag.ass = ass.ToPagedList(page, 12);
            }
            ViewBag.pid = pid;
            return View();
        }

        [HttpPost("Login")]//posting to do a login
        public IActionResult Login(mUser u)
        {
            ViewBag.title = "Admin Login";
            try
            {
                var ucol = globals.getDB().GetCollection<mUser>("mUser");
                var exist = ucol.Find(
                        _ => _.email == u.email
                        && _.password == globals.getmd5(u.password)
                        && _.role == UserRole.admin
                    ).FirstOrDefault();
                if (exist == null)
                {
                    ViewBag.res = "ok";
                    ViewBag.msg = "Invalid Login Details";
                    ViewBag.type = "red";
                }
                else
                {
                    HttpContext.Session.SetString("email", u.email);
                    HttpContext.Session.SetString("role", "admin");
                    return RedirectToAction("Dashboard", "Admin");
                }

            }
            catch (Exception ex)
            {
                ViewBag.res = "ok";
                ViewBag.msg = ex.Message;
                ViewBag.type = "red";
            }

            return View();
        }

        [Route("Dashboard")]
        [Route("")]
        public IActionResult Dashboard(int page = 1)
        {

            var user = getuser();
            ViewBag.user = user;
            ViewBag.title = "Dashboard";

            var ecol = globals.getDB().GetCollection<mEnquiry>("mEnquiry");
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var enqs = (from d in ecol.Find(x => x._id != null).ToList().OrderByDescending(x => x.date) select d).AsQueryable();
            var props = (from d in pcol.Find(x => x._id != null).ToList().OrderByDescending(x => x.dateCreated) select d).AsQueryable();
            ViewBag.enqs = enqs.ToPagedList(page, 8);//paged top 8 enquiries 
            ViewBag.props = props.ToPagedList(page, 8);//paged top 8 props 




            //count enquiries
            ViewBag.e_open = (int)ecol.Find(x => x.enquiryState == EnquiryState.open).Count();
            ViewBag.e_closed = (int)ecol.Find(x => x.enquiryState == EnquiryState.closed).Count();
            ViewBag.e_rejected = (int)ecol.Find(x => x.enquiryState == EnquiryState.rejected).Count();
            ViewBag.e_accepted = (int)ecol.Find(x => x.enquiryState == EnquiryState.accepted).Count();
            ViewBag.e_underAdminReview = (int)ecol.Find(x => x.enquiryState == EnquiryState.underAdminReview).Count();
            ViewBag.e_underLandLordReview = (int)ecol.Find(x => x.enquiryState == EnquiryState.underLandLordReview).Count();

            ViewBag.p_available = (int)pcol.Find(x => x.PropertyStatus == "Available" && x.adminApproved).Count();
            ViewBag.p_notavailable = (int)pcol.Find(x => x.PropertyStatus != "Available" && x.adminApproved).Count();


            return View();
        }


        [Route("WaitingLists")]
        public IActionResult WaitingLists(string type = "", string msg = "", int page = 1, string param = null)//param is the search param
        {
            ViewBag.title = "Waiting Lists";
            var user = getuser();
            ViewBag.user = user;
            ViewBag.msg = msg;
            ViewBag.type = type;

            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var propertys = pcol.Find(x => x._id != null).ToList().AsEnumerable();
            if (param != null)
            {
                param = param.ToLower();
                propertys = propertys.Where(
                    x => x._id != null &&
                    x.waitingList.Where(i =>
                                                i.name.ToLower().Contains(param) ||
                                                i.surname.ToLower().Contains(param) ||
                                                i.mobile.ToLower().Contains(param) ||
                                                i.email.ToLower().Contains(param) ||
                                                i.address.ToLower().Contains(param)
                    ).Any()
                );


            }
            var props_ = (from d in propertys select d).AsQueryable();
            ViewBag.properties = props_.ToPagedList(page, 12);
            ViewBag.param = param;
            return View();
        }

        [Route("removeFromWaitingList2")]
        public IActionResult removeFromWaitingList2(string pid, string cid)
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var prop = pcol.Find(x => x._id == pid).FirstOrDefault();
            var w = prop.waitingList.Where(x => x._id == cid).FirstOrDefault();
            prop.waitingList.Remove(w);
            pcol.ReplaceOne(x => x._id == pid, prop);
            return RedirectToAction("WaitingLists", "Admin", new { msg = "Removed", type = "blue" });
        }

        [Route("assignClientToProperty")]
        public IActionResult assignClientToProperty(string pid, string cid)
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var prop = pcol.Find(x => x._id == pid).FirstOrDefault();
            var w = prop.waitingList.Where(x => x._id == cid).FirstOrDefault();
            prop.waitingList.Remove(w);//remove it
            w.isAssigned = true;
            w.dateAssigned = DateTime.Now;
            prop.waitingList.Add(w);//add it thus updating it
            pcol.ReplaceOne(x => x._id == pid, prop);
            return RedirectToAction("WaitingLists", "Admin", new { msg = "Assigned", type = "blue" });
        }

        [Route("deAssignClientToProperty")]
        public IActionResult deAssignClientToProperty(string pid, string cid)
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var prop = pcol.Find(x => x._id == pid).FirstOrDefault();
            var w = prop.waitingList.Where(x => x._id == cid).FirstOrDefault();
            prop.waitingList.Remove(w);//remove it
            w.isAssigned = false;
            w.DateDeAssigned = DateTime.Now;
            prop.waitingList.Add(w);//add it thus updating it
            pcol.ReplaceOne(x => x._id == pid, prop);
            return RedirectToAction("WaitingLists", "Admin", new { msg = "de-Assigned", type = "blue" });
        }



        [Route("Enquiries")]
        public IActionResult Enquiries(int page = 1, string status = null, string msg = "", string type = "")
        {

            var user = getuser();
            ViewBag.user = user;
            ViewBag.title = "Enquiries";

            var ecol = globals.getDB().GetCollection<mEnquiry>("mEnquiry");
            var enqs = ecol.Find(x => x._id != null).ToList().OrderByDescending(x => x.date).ToList();
            if (status != null)
            {
                if (status == "open")
                {
                    enqs = enqs.Where(x => x.enquiryState == EnquiryState.open).ToList();
                }
                if (status == "closed")
                {
                    enqs = enqs.Where(x => x.enquiryState == EnquiryState.closed).ToList();
                }

            }
            var enqs_ = (from d in enqs select d).AsQueryable();
            ViewBag.enqs = enqs_.ToPagedList(page, 10);
            ViewBag.status = status;
            ViewBag.type = type;
            ViewBag.msg = msg;
            return View();
        }

        //get
        [HttpGet("ViewProperty")]
        public IActionResult ViewProperty(string pid, string msg, string type)
        {
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
            ViewBag.msg = msg;
            ViewBag.type = type;
            //ViewBag.pid = p._id;//property id
            ViewBag.title = "ViewProperty";

            return View();
        }

        [Route("Properties")]
        public IActionResult Properties(string propertyType, string stateOrPorvince, string cityOrTown, string adminApproved, int page = 1)
        {
            var user = getuser();
            ViewBag.user = user;
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");

            var props_ = pcol.Find(x => x._id != null).ToList();



            if (adminApproved != null && adminApproved != "")
            {
                bool a = false;
                if (adminApproved == "approved") a = true;
                props_ = props_.Where(x => x.adminApproved == a).ToList();
            }


            if (cityOrTown != null && cityOrTown != "")
            {
                props_ = props_.Where(x => x.cityOrTown.ToLower().Contains(cityOrTown.ToLower())).ToList();
            }

            if (stateOrPorvince != null && stateOrPorvince != "")
            {
                props_ = props_.Where(x => x.stateOrPorvince.ToLower().Contains(stateOrPorvince.ToLower())).ToList();
            }

            if (propertyType != null && propertyType != "")
            {
                if (propertyType == "apartment")
                {
                    props_ = props_.Where(x => x.propertyType == PropertyType.apartment).ToList();
                }
                if (propertyType == "boarding_house")
                {
                    props_ = props_.Where(x => x.propertyType == PropertyType.boarding_house).ToList();
                }
                if (propertyType == "cottage")
                {
                    props_ = props_.Where(x => x.propertyType == PropertyType.cottage).ToList();
                }
                if (propertyType == "house")
                {
                    props_ = props_.Where(x => x.propertyType == PropertyType.house).ToList();
                }
                if (propertyType == "office")
                {
                    props_ = props_.Where(x => x.propertyType == PropertyType.office).ToList();
                }
            }

            props_ = props_.OrderByDescending(x => x.dateCreated).ToList();
            var props = (from d in props_ select d).AsQueryable().ToPagedList(page, 12);


            ViewBag.props = props;
            ViewBag.title = "Properties";




            var scol = globals.getDB().GetCollection<mCountry>("mCountry");
            var countrys = scol.Find(e => e._id != null).ToList();
            ViewBag.countrys = countrys;
            ViewBag.user = user;


            ViewBag.propertyType = propertyType;
            ViewBag.stateOrPorvince = stateOrPorvince;
            ViewBag.cityOrTown = cityOrTown;
            ViewBag.adminApproved = adminApproved;

            return View();
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

        [Route("DeleteEnquiry")]
        public IActionResult DeleteEnquiry(string eid, string msg)
        {
            var ecol = globals.getDB().GetCollection<mEnquiry>("mEnquiry");
            var user = getuser();
            var enq = ecol.DeleteOne(x => x._id == eid);
            ViewBag.user = user;
            ViewBag.enq = enq;
            ViewBag.msg = msg;
            return RedirectToAction("Enquiries", "Admin", new { msg = "Deleted", type = "blue" });
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
            return RedirectToAction("ViewEnquiry", "Admin", new { eid = eid, msg = "Saved" });
        }


        [Route("VirtualAssistants")]
        public IActionResult VirtualAssistants(string msg, int page = 1)
        {
            var user = getuser();
            ViewBag.user = user;
            var vcol = globals.getDB().GetCollection<mVirtualAssistant>("mVirtualAssistant");
            var vassistans = (from d in vcol.Find(x => x._id != null).ToList().OrderByDescending(x => x.created) select d).AsQueryable();
            ViewBag.vassistants = vassistans.ToPagedList(page, 15);
            ViewBag.title = "VirtualAssistants";
            ViewBag.msg = msg;
            return View();
        }


        [HttpPost("CreateVirtualAssistant")]
        public IActionResult CreateVirtualAssistant(mVirtualAssistant va)
        {
            var vcol = globals.getDB().GetCollection<mVirtualAssistant>("mVirtualAssistant");
            var exist = vcol.Find(x => x.email == va.email).FirstOrDefault();
            if (exist != null)
            {
                return RedirectToAction("VirtualAssistants", "Admin", new { msg = "User with this email exists" });
            }
            else
            {
                vcol.InsertOne(va);
                return RedirectToAction("VirtualAssistants", "Admin", new { msg = "Saved" });
            }
        }


        [HttpPost("deleteVAssistant")]
        public JsonResult deleteVAssistant(string vid)
        {
            var vcol = globals.getDB().GetCollection<mVirtualAssistant>("mVirtualAssistant");
            vcol.DeleteOne(x => x._id == vid);
            return Json(new { res = "ok" });
        }

        [Route("approvalProperty")]
        public IActionResult approvalProperty(string pid)
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var p = pcol.Find(x => x._id == pid).FirstOrDefault();
            p.adminApproved = true;
            pcol.ReplaceOneAsync(x => x._id == pid, p);
            return RedirectToAction("ViewProperty", "Admin", new { msg = "Approved", pid = pid });
        }


        [Route("rejectProperty")]
        public IActionResult rejectProperty(string pid, string reason)
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var p = pcol.Find(x => x._id == pid).FirstOrDefault();
            p.adminApproved = false;
            p.rejectionReason = reason;
            pcol.ReplaceOneAsync(x => x._id == pid, p);
            return RedirectToAction("ViewProperty", "Admin", new { msg = "Rejected", pid = pid });
        }

        //save the next available date
        [HttpPost("SaveNextDate")]
        public IActionResult SaveNextDate(string PropertyStatus, DateTime nextAvailableDate, string pid)
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var p = pcol.Find(x => x._id == pid).FirstOrDefault();
            if (nextAvailableDate < DateTime.Now)
            {
                p.nextAvailableDate = null;
            }
            else
            {
                p.nextAvailableDate = nextAvailableDate;
            }
            p.PropertyStatus = PropertyStatus;
            pcol.ReplaceOneAsync(x => x._id == pid, p);
            return RedirectToAction("ViewProperty", "Admin", new { pid = pid, msg = "saved", type = "green" });
        }


        [Route("WaitingList")]
        public IActionResult WaitingList(string pid, int page = 1)
        {
            var user = getuser();
            ViewBag.user = user;
            ViewBag.title = "Waiting List";
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var p = pcol.Find(x => x._id == pid).FirstOrDefault();
            ViewBag.wl = (from d in p.waitingList.OrderByDescending(x => x.date) select d).AsQueryable().ToPagedList(page, 13);
            ViewBag.pid = p._id;
            return View();
        }


        [Route("removeFromWaitingList")]
        public JsonResult removeFromWaitingList(string pid, string wid)
        {
            try
            {
                var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
                var p = pcol.Find(x => x._id == pid).FirstOrDefault();
                var wi = p.waitingList.Where(x => x._id == wid).FirstOrDefault();
                p.waitingList.Remove(wi);
                pcol.ReplaceOneAsync(x => x._id == pid, p);
                return Json(new { res = "ok", msg = "deleted" });
            }
            catch (Exception ex)
            {
                return Json(new { res = "err", msg = ex.Message });
            }
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
            ViewBag.user = getuser();
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
                return RedirectToAction("Index", "Admin");//go to login page
            }
            catch (Exception ex)
            {
                ViewBag.msg = "Error";
                ViewBag.type = "red";
                return View();
            }


        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("IndexRent", "Home");
        }


        [Route("Artisans")]
        public IActionResult Artisans(int page = 1, string registered = "notregistered", string name = "", string surname = "", string mobile = "", string city = "")
        {
            if(registered!=null)
            registered = registered.ToLower();
            if(name!=null)
            name = name.ToLower();
            if(surname!=null)
            surname = surname.ToLower();
            if(mobile!=null)
            mobile = mobile.ToLower();
            if(city!=null)
            city = city.ToLower();
            ViewBag.title = "Artisans";
            ViewBag.user = getuser();
            var acol = globals.getDB().GetCollection<mArtisan>("mArtisan");
            var artisans = acol.Find(x => x._id != null).ToList();
            if (registered == "registered")
            {
                artisans = artisans.Where(x => x.registered).ToList();
            }
            if (registered == "notregistered")
            {
                artisans = artisans.Where(x => !x.registered).ToList();
            }
            if (name != null && name != "") artisans = artisans.Where(x => x.name.ToLower().Contains(name)).ToList();
            if (surname != null && surname != "") artisans = artisans.Where(x => x.surname.ToLower().Contains(surname)).ToList();
            if (mobile != null && mobile != "") artisans = artisans.Where(x => x.mobile.ToLower().Contains(mobile)).ToList();
            if (city != null && city != "") artisans = artisans.Where(x => x.cityOrTown.ToLower().Contains(city)).ToList();

            var artisans_ = (from d in artisans select d).AsQueryable();
            ViewBag.registered = registered;
            ViewBag.name = name;
            ViewBag.surname = surname;
            ViewBag.mobile = mobile;
            ViewBag.city = city;
            ViewBag.artisans = artisans_.ToPagedList(page, 12);
            return View();
        }

        [Route("ViewArtisanFullProfile")]
        public IActionResult ViewArtisanFullProfile(string aid,string msg="",string type="")//artisan profile =aid
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
            ViewBag.msg = msg;
            ViewBag.type = type;
            return View();
        }

        [Route("enableAccount")]
        public IActionResult enableAccount(string aid)
        {
            var acol = globals.getDB().GetCollection<mArtisan>("mArtisan");
            var update = Builders<mArtisan>.Update.Set(x => x.registered, true);
            acol.UpdateOne(x=>x._id==aid,update);//update it
            var artisan = acol.Find(x => x._id == aid).FirstOrDefault();
            //send email
            var email = new globals.emailMessage();
            email.message = System.IO.File.ReadAllText(host.WebRootPath + "/emialViews/email_notification.html");
            email.message = email.message.Replace("{{message}}", "Your account is now active.");
            email.to = artisan.email;
            email.subject = "Porchlyt Account Notification";
            Task.Run(()=> {
                globals.sendEmail(email);//send email async
            });
            return RedirectToAction("ViewArtisanFullProfile", "Admin", new { msg = "Enabled", type = "green" ,aid=aid});
        }

        [Route("disableAccount")]
        public IActionResult disableAccount(string aid)
        {
            var acol = globals.getDB().GetCollection<mArtisan>("mArtisan");
            var update = Builders<mArtisan>.Update.Set(x => x.registered, false);
            acol.UpdateOne(x => x._id == aid, update);//update it
            var artisan = acol.Find(x => x._id == aid).FirstOrDefault();
            //send email
            var email = new globals.emailMessage();
            email.message = System.IO.File.ReadAllText(host.WebRootPath + "/emialViews/email_notification.html");
            email.message = email.message.Replace("{{message}}", "Your account has been deactivated.");
            email.to = artisan.email;
            email.subject = "Porchlyt Account Notification";
            Task.Run(() => {
                globals.sendEmail(email);//send email async
            });
            return RedirectToAction("ViewArtisanFullProfile", "Admin", new { msg = "Disabled", type = "orange",aid=aid });
        }



    }
}
