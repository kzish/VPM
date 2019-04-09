using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VPM.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace VPM.Controllers
{
    [Route("Home")]
    [Route("")]
    public class HomeController : Controller
    {

        IHostingEnvironment host;
        public HomeController(IHostingEnvironment e)
        {
            host = e;
        }


        [Route("Privacy")]
        public IActionResult Privacy()
        {
            ViewBag.title = "Privacy";
            return View();
        }

        [Route("Terms")]
        public IActionResult Terms()
        {
            ViewBag.title = "Terms";
            return View();
        }

        [Route("ArtisanPolicy")]
        public IActionResult ArtisanPolicy()
        {
            ViewBag.title = "ArtisanPolicy";
            return View();
        }

        [Route("Join")]
        public IActionResult Join(string msg)
        {
            ViewBag.title = "Join";
            ViewBag.msg = msg;
            return View();
        }


        [Route("IndexRent")]
        public IActionResult IndexRent()
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var props = pcol.Find(x => x._id != null).ToList().Take(10).ToList();//just take the top ten properties to display on th ehome page
            ViewBag.props = props;
            ViewBag.title = "Find a home to rent";
            return View();
        }


        [Route("IndexFix")]
        [Route("")]
        public IActionResult IndexFix()
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var props = pcol.Find(x => x._id != null).ToList().Take(10).ToList();//just take the top ten properties to display on th ehome page
            ViewBag.props = props;
            ViewBag.title = "Need somthing fixed?";
            return View();
        }

        [Route("IndexSell")]
        public IActionResult IndexSell()
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var props = pcol.Find(x => x._id != null).ToList().Take(10).ToList();//just take the top ten properties to display on th ehome page
            ViewBag.props = props;
            ViewBag.title = "Want to sell Property?";
            return View();
        }

        [Route("IndexBuy")]
        //[Route("")]
        public IActionResult IndexBuy()
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var props = pcol.Find(x => x._id != null).ToList().Take(10).ToList();//just take the top ten properties to display on th ehome page
            ViewBag.props = props;
            ViewBag.title = "Want to Buy Property?";
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            ViewBag.title = "About";
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }


        [Route("Services")]
        public IActionResult Services()
        {
            ViewBag.title = "Services";
            return View();
        }


        //land lord login via post
        [HttpPost("PropertyOwnerLogin")]//posting to do a login
        public string PropertyOwnerLogin(mUser u)
        {
            u.password = u.password.Replace(" ", "");
            u.email = u.email.Replace(" ", "");
            try
            {
                var ucol = globals.getDB().GetCollection<mUser>("mUser");
                var exist = ucol.Find(_ => (_.email == u.email || _.mobile == u.email) && _.password == globals.getmd5(u.password)).FirstOrDefault();
                if (exist == null)
                {
                    ViewBag.res = "ok";
                    ViewBag.msg = "Invalid Login Details";
                    ViewBag.type = "red";
                    return "no";
                }
                else
                {
                    HttpContext.Session.SetString("email", u.email);
                    HttpContext.Session.SetString("role", "owner");
                    return "ok";
                }

            }
            catch (Exception ex)
            {
                ViewBag.res = "ok";
                ViewBag.msg = ex.Message;
                return "no";
            }
        }


        //artisan login via post method
        [HttpPost("Artisanlogin")]//posting to do a login
        public string Artisanlogin(mArtisan u)
        {
            u.password = u.password.Replace(" ", "");
            u.email = u.email.Replace(" ", "");
            try
            {
                var acol = globals.getDB().GetCollection<mArtisan>("mArtisan");
                if (String.IsNullOrEmpty(u.email)) u.email = u.mobile;//make sure we are not checking against an empty string
                //login in with either email or mobile but remember mobile is sitll coming in as email
                var exist = acol.Find(_ => (_.email == u.email || _.mobile == u.email) && _.password == globals.getmd5(u.password)).FirstOrDefault();
                if (exist == null)
                {
                    ViewBag.res = "ok";
                    ViewBag.msg = "Invalid Login Details";
                    ViewBag.type = "red";
                    return "no";
                }
                else
                {
                    HttpContext.Session.SetString("email", u.email);
                    HttpContext.Session.SetString("role", "artisan");
                    return "ok";
                }

            }
            catch (Exception ex)
            {
                ViewBag.res = "ok";
                ViewBag.msg = ex.Message;
                ViewBag.type = "red";
                return "no";
            }
        }


        //register a landlord
        [HttpPost("RegisterProperty")]
        public IActionResult RegisterProperty(mUser u)
        {
            try
            {
                var ucol = globals.getDB().GetCollection<mUser>("mUser");
                var tcol = globals.getDB().GetCollection<mToken>("mToken");
                if (String.IsNullOrEmpty(u.email)) u.email = u.mobile;//make sure we are not checking against a null or white space
                var exists = ucol.Find(e => e.email == u.email || e.mobile == u.mobile).FirstOrDefault();
                //no email confirmation for now
                /* if (exists != null && !exists.registered)
                 {
                     string tken = "";
                     //if user exists
                     var token = tcol.Find(e => e.userid == exists._id).FirstOrDefault();
                     tken = token._id;
                     //chech for existing token
                     if (token == null)
                     {
                         //if token null then make a new one
                         var ntoken = new mToken();
                         ntoken.userid = exists._id;
                         tcol.InsertOne(ntoken);
                         tken = ntoken._id;
                     }

                     //update user details
                     exists.copyFrom(u);
                     ucol.ReplaceOneAsync(e => e.email == exists.email, exists);


                     var email = new globals.emailMessage();
                     email.to = u.email;
                     var link = "http://" + HttpContext.Request.Host + "/Home/ConfirmRegistration?uid=" + u._id + "&token=" + tken;

                     var msg = System.IO.File.ReadAllText(Path.Combine(host.WebRootPath, "emialViews/email_thank_you_for_registering.html"));


                     email.subject = "VPM User Login";
                     email.message = msg.Replace("{{reglink}}", link);
                     globals.sendEmail(email);

                     ViewBag.res = "ok";
                     ViewBag.msg = "An email was sent to " + u.email + ". Follow the link to complete your registration, if you do not recieve an email within 5 mins please try again.";
                     ViewBag.type = "green";



                 }
                 */
                if (exists != null)
                {
                    ViewBag.res = "ok";
                    ViewBag.msg = "User with this email or mobile exists already";
                    ViewBag.type = "red";
                }

                else if (exists == null)
                {
                    u.hashPassword();
                    var ntoken = new mToken();
                    ntoken.userid = u._id;
                    tcol.InsertOne(ntoken);
                    u.role = UserRole.landlord;
                    ucol.InsertOne(u); //insert the landlord 


                    //auto login here
                    //create the session
                    HttpContext.Session.SetString("role", "owner");
                    HttpContext.Session.SetString("email", u.mobile);
                    return RedirectToAction("Dashboard", "Account");


                    //no email confirmation needed 
                    /* var email = new globals.emailMessage();
                     email.to = u.email;
                     var link = "http://" + HttpContext.Request.Host + "/Home/ConfirmRegistration?uid=" + u._id + "&token=" + ntoken._id;

                     var msg = System.IO.File.ReadAllText(Path.Combine(host.WebRootPath, "emialViews/email_thank_you_for_registering.html"));


                     email.subject = "User Login";
                     email.message = msg.Replace("{{reglink}}", link);
                     globals.sendEmail(email);
                     */
                    ViewBag.res = "ok";
                    ViewBag.msg = "Your registration was successful you may now login.";
                    ViewBag.type = "green";

                    //send his a message so that admin chat  is always there
                    var mess = new mMessages();
                    mess.userEmail = u.email;
                    mess.otherPerson = globals.supportEmail;

                    var chat = new chat();
                    chat.from = globals.supportEmail;
                    chat.to = u.email;
                    chat.message = "Hello, anything I can help you with?";
                    chat.read = false;
                    mess.chats.Add(chat);

                    var mcol = globals.getDB().GetCollection<mMessages>("mMessages");
                    mcol.InsertOne(mess);

                    //send email to admin
                    var email_ = new globals.emailMessage();
                    email_.subject = "New Home Owner registration";
                    email_.message = System.IO.File.ReadAllText(host.WebRootPath + "/emialViews/email_notification.html");
                    email_.message = email_.message.Replace("{{message}}", "A new Home Owner has registered Log in to view");
                    Task.Run(() =>
                    {
                        globals.sendEmail(email_);
                    });
                }



                else
                {
                    ViewBag.res = "ok";
                    ViewBag.msg = "error check it";
                    ViewBag.type = "red";
                }

            }
            catch (Exception ex)
            {
                ViewBag.res = "err";
                ViewBag.msg = ex.Message;
                ViewBag.type = "red";
            }
            ViewBag.user = u;
            return View();//go back to the same view 
        }



        //artisan register his/her skills
        [HttpGet("RegisterSkills")]
        public IActionResult RegisterSkills(string msg = "")
        {
            var scol = globals.getDB().GetCollection<mSkills>("mSkills");
            var ccol = globals.getDB().GetCollection<mCountry>("mCountry");
            var countrys = ccol.Find(x => x._id != null).ToList();
            ViewBag.countrys = countrys;
            var skills = scol.Find(x => x._id != null).ToList();
            ViewBag.skills = skills;
            var a = new mArtisan();
            ViewBag.a = a;//artisan

            a.referees.Add(new Referee());//add these two refs to prevent null ref error
            a.referees.Add(new Referee());
            ViewBag.msg = msg;
            ViewBag.title = "RegisterSkills";
            return View();
        }

        [HttpGet("RegisterProperty")]
        public IActionResult RegisterProperty()
        {
            ViewBag.title = "RegisterProperty";
            var user = new mUser();
            ViewBag.user = user;//placeholder user
            return View();
        }


        //artisan register himselve and skills via post
        [HttpPost("RegisterSkills")]
        public IActionResult RegisterSkills(mArtisan a, List<string> myskills)
        {

            if (a == null) a = new mArtisan();
            a.skills_list = myskills;
            var scol = globals.getDB().GetCollection<mSkills>("mSkills");
            var ccol = globals.getDB().GetCollection<mCountry>("mCountry");
            var countrys = ccol.Find(x => x._id != null).ToList();
            ViewBag.countrys = countrys;
            var skills = scol.Find(x => x._id != null).ToList();
            ViewBag.skills = skills;//all skills
            ViewBag.a = a;
            ViewBag.title = "RegisterSkills";


            if (a.skills_list.Count == 0)
            {
                ViewBag.type = "red";
                ViewBag.msg = "Select some skills";
                return View();

            }
            var acol = globals.getDB().GetCollection<mArtisan>("mArtisan");
            if (String.IsNullOrEmpty(a.email)) a.email = a.mobile;//make sure we are not checking against an empty string
            var exist = acol.Find(x => x.email == a.email || x.mobile == a.mobile).FirstOrDefault();
            if (exist != null)
            {
                ViewBag.msg = "An account with this email or mobile already exists";
                ViewBag.type = "red";
            }
            else
            {
                a.hashPassword();
                acol.InsertOne(a);

                //auto log in here
                //create session
                HttpContext.Session.SetString("email", a.mobile);
                //use mobile for session because it will always be there
                HttpContext.Session.SetString("role", "artisan");
                return RedirectToAction("Dashboard", "Artisan");


                ViewBag.msg = "Your account have been created, you may now log in";
                ViewBag.type = "green";

                //send email to admin
                var email_ = new globals.emailMessage();
                email_.subject = "Artisan Registration";
                email_.message = System.IO.File.ReadAllText(host.WebRootPath + "/emialViews/email_notification.html");
                email_.message = email_.message.Replace("{{message}}", "A new Home Artisan has registered Log in to view");
                Task.Run(() =>
                {
                    globals.sendEmail(email_);
                });

                //send his a message so that admin chat  is always there
                /* var mess = new mMessages();
                 mess.userEmail = a.email;
                 mess.otherPerson = globals.supportEmail;

                 var chat = new chat();
                 chat.from = globals.supportEmail;
                 chat.to = a.email;
                 chat.message = "Hello, anything I can help you with?";
                 chat.read = false;
                 mess.chats.Add(chat);

                 var mcol = globals.getDB().GetCollection<mMessages>("mMessages");
                 mcol.InsertOne(mess);*/

            }

            return View();
        }

        [Route("ConfirmRegistration")]
        public IActionResult ConfirmRegistration(string uid, string token)
        {
            try
            {
                var tcol = globals.getDB().GetCollection<mToken>("mToken");
                var ucol = globals.getDB().GetCollection<mUser>("mUser");
                var tken = tcol.Find(e => e.userid == uid && e._id == token).FirstOrDefault();
                if (tken == null)
                {
                    ViewBag.res = "no";
                    ViewBag.msg = "This is an invalid token";
                    ViewBag.type = "red";
                }
                else
                {
                    var user = ucol.Find(e => e._id == uid).FirstOrDefault();
                    user.registered = true;
                    ucol.ReplaceOneAsync(e => e._id == uid, user);//update the user registered field
                    tcol.DeleteOneAsync(e => e._id == token);//delete the token
                    ViewBag.res = "ok";
                    ViewBag.msg = "You have completed your registration, you may now log in";
                    ViewBag.type = "green";
                }
            }
            catch (Exception ex)
            {
                ViewBag.res = "ok";
                ViewBag.msg = "Something went wrong try again";
                ViewBag.type = "orange";
            }
            return View();

        }


        //landlord forgot password
        [HttpPost("forgotpassword1")]
        public IActionResult forgotpassword1(string email)
        {
            email = email.Replace(" ", "");
            ViewBag.title = "Forgot Password";
            if (email != "")
            {
                var ucol = globals.getDB().GetCollection<mUser>("mUser");
                var tcol = globals.getDB().GetCollection<mToken>("mToken");
                var user = ucol.Find(e => e.email == email).FirstOrDefault();
                if (user == null)
                {
                    ViewBag.res = "no";
                    ViewBag.title = "This email does not exist";
                }
                else
                {
                    user.password = globals.RandomPassword(8);//todo genertae the password randomly
                    var emsg = new globals.emailMessage();
                    emsg.to = email;
                    emsg.subject = "Forgot Password";
                    var link = "http://" + HttpContext.Request.Host + "/Home/";
                    var msg = System.IO.File.ReadAllText(Path.Combine(host.WebRootPath, "emialViews/email_reset_password.html"));
                    emsg.message = msg.Replace("{{reglink}}", link).Replace("{{password}}", user.password);
                    globals.sendEmail(emsg);
                    //var update = Builders<mUser>.Update.Set(x => x.password, globals.getmd5(user.password));
                    user.hashPassword();
                    ucol.ReplaceOne(e => e._id == user._id, user);//replace the user so he now has a new password

                    ViewBag.type = "blue";
                    ViewBag.msg = "An email has been sent to " + email + ". Follow the instructions to login";
                    ViewBag.res = "ok";
                }
            }
            return View();
        }

        //Client forgot passowrd
        [HttpPost("forgotpassword2")]
        public IActionResult forgotpassword2(string email)
        {
            email = email.Replace(" ", "");
            ViewBag.title = "Forgot Password";
            if (email != "")
            {
                var ucol = globals.getDB().GetCollection<mClient>("mClient");
                var user = ucol.Find(e => e.email == email).FirstOrDefault();
                if (user == null)
                {
                    ViewBag.res = "no";
                    ViewBag.title = "This email does not exist";
                }
                else
                {
                    user.password = globals.RandomPassword(8);//todo genertae the password randomly
                    var emsg = new globals.emailMessage();
                    emsg.to = email;
                    emsg.subject = "Forgot Password";
                    var link = "http://" + HttpContext.Request.Host + "/Home/";
                    var msg = System.IO.File.ReadAllText(Path.Combine(host.WebRootPath, "emialViews/email_reset_password.html"));
                    emsg.message = msg.Replace("{{reglink}}", link).Replace("{{password}}", user.password);
                    globals.sendEmail(emsg);
                    //var update = Builders<mClient>.Update.Set(x => x.password, globals.getmd5(user.password));
                    user.hashPassword();
                    ucol.ReplaceOne(e => e._id == user._id, user);//replace the user so he now has a new password

                    ViewBag.type = "blue";
                    ViewBag.msg = "An email has been sent to " + email + ". Follow the instructions to login";
                    ViewBag.res = "ok";
                }
            }
            return View();
        }

        //artisan forgot passowrd
        [HttpPost("forgotpassword3")]
        public IActionResult forgotpassword3(string email)
        {
            email = email.Replace(" ", "");
            ViewBag.title = "Forgot Password";
            if (email != "")
            {
                var ucol = globals.getDB().GetCollection<mArtisan>("mArtisan");
                var tcol = globals.getDB().GetCollection<mToken>("mToken");
                var user = ucol.Find(e => e.email == email).FirstOrDefault();
                if (user == null)
                {
                    ViewBag.res = "no";
                    ViewBag.title = "This email does not exist";
                }
                else
                {
                    user.password = globals.RandomPassword(8);//todo genertae the password randomly
                    var emsg = new globals.emailMessage();
                    emsg.to = email;
                    emsg.subject = "Forgot Password";
                    var link = "http://" + HttpContext.Request.Host + "/Home/";
                    var msg = System.IO.File.ReadAllText(Path.Combine(host.WebRootPath, "emialViews/email_reset_password.html"));
                    emsg.message = msg.Replace("{{reglink}}", link).Replace("{{password}}", user.password);
                    globals.sendEmail(emsg);
                    //var update = Builders<mArtisan>.Update.Set(x => x.password, globals.getmd5(user.password));
                    user.hashPassword();
                    ucol.ReplaceOne(e => e._id == user._id, user);//replace the user so he now has a new password

                    ViewBag.type = "blue";
                    ViewBag.msg = "An email has been sent to " + email + ". Follow the instructions to login";
                    ViewBag.res = "ok";
                }
            }
            return View();
        }

        [HttpGet("forgotpassword1")]
        public IActionResult forgotPassword1()
        {
            ViewBag.title = "Forgot Password";
            return View();
        }

        [HttpGet("forgotpassword2")]
        public IActionResult forgotPassword2()
        {
            ViewBag.title = "Forgot Password";
            return View();
        }

        [HttpGet("forgotpassword3")]
        public IActionResult forgotPassword3()
        {
            ViewBag.title = "Forgot Password";
            return View();
        }

        //get
        [Route("ClientSignUp")]
        public IActionResult ClientSignUp(string msg)
        {
            ViewBag.title = "ClientSignUp";
            ViewBag.msg = msg;
            return View();
        }

        //post
        [HttpPost("ClientRegister")]
        public IActionResult ClientRegister(mClient r)
        {
            var rcol = globals.getDB().GetCollection<mClient>("mClient");
            //make sure we are not considering email in checking existance because email is optional
            if (String.IsNullOrEmpty(r.email)) r.email = r.mobile;
            var exist = rcol.Find(x => (x.email == r.email || x.mobile == r.mobile)).FirstOrDefault();
            if (exist != null)
            {
                return RedirectToAction("ClientSignUp", "Home", new { msg = "Client with these details exists already" });
            }
            /* register and confirm email ** disabled for now  but still register**/
            else
            {
                HttpContext.Session.SetString("email", r.mobile);//use the mobile since its always there
                HttpContext.Session.SetString("role", "Client");
                r.hashPassword();
                rcol.InsertOne(r);

                //send his a message so that admin chat  is always there
                var mess = new mMessages();
                mess.userEmail = r.email;
                mess.otherPerson = globals.supportEmail;

                var chat = new chat();
                chat.from = globals.supportEmail;
                chat.to = r.email;
                chat.message = "Hello, anything I can help you with?";
                chat.read = false;
                mess.chats.Add(chat);

                var mcol = globals.getDB().GetCollection<mMessages>("mMessages");
                mcol.InsertOne(mess);


                //send email to admin
                var email_ = new globals.emailMessage();
                email_.subject = "New Client registration";
                email_.message = System.IO.File.ReadAllText(host.WebRootPath + "/emialViews/email_notification.html");
                email_.message = email_.message.Replace("{{message}}", "A new Client has registered Log in to view");
                Task.Run(() =>
                {
                    globals.sendEmail(email_);
                });


                return RedirectToAction("Dashboard", "Client");
            }


        }

        //Client login via post
        [HttpPost("ClientLogin")]//posting to do a login
        public string ClientLogin(mClient u)
        {
            u.password = u.password.Replace(" ", "");
            u.email = u.email.Replace(" ", "");
            if (String.IsNullOrEmpty(u.email)) u.email = u.mobile;//so that email is not checked against a null or blank
            ViewBag.title = "ClientLogin";
            try
            {
                var ucol = globals.getDB().GetCollection<mClient>("mClient");
                var pass = globals.getmd5(u.password);
                //check either by email or by mobile
                var exist = ucol.Find(_ => (_.email == u.email || _.mobile == u.email) && _.password == pass).FirstOrDefault();
                if (exist == null)
                {
                    ViewBag.res = "ok";
                    ViewBag.msg = "Invalid Login Details";
                    ViewBag.type = "red";
                    return "no";
                }
                else
                {
                    if (u.email == null || u.email == "") u.email = u.mobile;//if no email use the mobile
                    HttpContext.Session.SetString("email", u.email);
                    HttpContext.Session.SetString("role", "client");
                    return "ok";
                }

            }
            catch (Exception ex)
            {
                ViewBag.res = "ok";
                ViewBag.msg = ex.Message;
                ViewBag.type = "red";
                return "no";
            }
        }

        [Route("UpdateBrowser")]
        public IActionResult UpdateBrowser()
        {
            return View();
        }

        [Route("error404")]
        public IActionResult error404()
        {
            return View();//View("~/Views/Home/error404.html");
        }


    }
}
