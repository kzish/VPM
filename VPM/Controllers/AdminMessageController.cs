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
using Microsoft.AspNetCore.Mvc.Filters;

namespace VPM.Controllers
{
    [Route("AdminMessage")]
    public class AdminMessageController : Controller, IActionFilter
    {


        HostingEnvironment host;

        public AdminMessageController(HostingEnvironment e)
        {
            host = e;
        }

        public IActionResult OnActionExecuting(string search, string msgId, string to)
        {
            var sess = HttpContext.Session.GetString("email");
            if (sess == null || sess == "")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "AdminMessage", new { to = to, search = search, msgId = msgId });
            }
        }

        private mUser getuser()
        {
            var sess = HttpContext.Session.GetString("email");
            var ucol = globals.getDB().GetCollection<mUser>("mUser");
            var user = ucol.Find(e => e.email == sess).FirstOrDefault();
            if(user==null)
            {
                RedirectToAction("Index","Home");
                return null;
            }
            return user;
        }


        [Route("Index")]
        public IActionResult Index(string search = "", string to = "", string msgId = "")
        {
            //msgId is the id of the current selected msg
            if (search == null) search = "";
            if (to == null) to = "";
            if (msgId == null) msgId = "";
            var user = getuser();
            if(user==null)
            {
                RedirectToAction("Index","Home");
            }
            ViewBag.user = user;
            ViewBag.title = "Messages";
            ViewBag.to = to;
            ViewBag.search = search;
            ViewBag.msgId = msgId;

            var mcol = globals.getDB().GetCollection<mMessages>("mMessages");
            if (search == "")
            {
                var msgs = mcol.Find(e => e.userEmail == user.email).ToList().ToList();
                ViewBag.msgs = msgs;
            }
            else if (search != "")
            {
                var msgs = mcol.Find(e => (  e.userEmail.Contains(search) && e.otherPerson== globals.supportEmail) ).ToList<mMessages>().ToList();
                ViewBag.msgs = msgs;
            }

            //not sure what this next if condition does
            if(user.email==globals.supportEmail)
            {
                if (search == "")
                {
                    var msgs = mcol.Find(e => e.otherPerson == user.email).ToList().Take(20).ToList();
                    ViewBag.msgs = msgs;
                }
                else if (search != "")
                {
                    var msgs = mcol.Find(e => (e.otherPerson == user.email && e.otherPerson.Contains(search))).ToList<mMessages>().Take(20).ToList();
                    ViewBag.msgs = msgs;
                }
            }
            List<chat> chats = new List<chat>();
            var cmsg = mcol.Find(e => e._id == msgId).FirstOrDefault();//selected message
            if (cmsg != null)
            {
                chats = cmsg.chats;
            }
            ViewBag.chats = chats;
            return View();
        }


        [Route("postMessage")]
        public IActionResult postMessage(string from, string to, string msgId, string message)
        {
            var mcol = globals.getDB().GetCollection<mMessages>("mMessages");
            var m = mcol.Find(e => e._id == msgId).FirstOrDefault();
            var chat = new chat();
            chat.to = to;
            chat.from = from;
            chat.message = message;
            if (m != null)
            {
                var update = Builders<mMessages>.Update.AddToSet(e => e.chats, chat);
                mcol.UpdateOne(e => e._id == msgId, update);//add the chat


                //also notify the recipient in there email and sms for now email
                var email = new globals.emailMessage();
                email.to = to;
                email.subject = "New Messgae Notification";
                var emsg = System.IO.File.ReadAllText(host.WebRootPath+ "/emialViews/email_notification.html");
                emsg = emsg.Replace("{{message}}", "Good day, You have a new message from " + from + ": " + message);
                email.message = emsg;
                globals.sendEmail(email);
            }

            var user = getuser();
            return RedirectToAction("Index", "AdminMessage", new { user = user, to = to, from = from, msgId = msgId });
        }



    }
}
