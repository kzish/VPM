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
    [Route("ClientMessage")]
    [AuthFilterClient]
    public class ClientMessageController : Controller, IActionFilter
    {


        HostingEnvironment host;

        public ClientMessageController(HostingEnvironment e)
        {
            host = e;
        }

      

        private mClient getuser()
        {
            var sess = HttpContext.Session.GetString("email");
            var ucol = globals.getDB().GetCollection<mClient>("mClient");
            var user = ucol.Find(e => e.email == sess).FirstOrDefault();
            if(user==null)
            {
                RedirectToAction("Index","Home");
                return null;
            }
            return user;
        }


        [Route("Index")]
        [Route("")]
        public IActionResult Index()
        {
            var user = getuser();
            if(user==null)
            {
                RedirectToAction("Index","Home");
            }
            ViewBag.user = user;
            ViewBag.title = "Messages";
            ViewBag.to = globals.supportEmail;
            var mcol = globals.getDB().GetCollection<mMessages>("mMessages");
            var all_messages = mcol.Find(e => e.userEmail == user.email && e.userType == UserType.client).FirstOrDefault();
            ViewBag.chats = all_messages.chats;
            return View();
        }


        [Route("postMessage")]
        public IActionResult postMessage(string message)
        {
            var user = getuser();
            var mcol = globals.getDB().GetCollection<mMessages>("mMessages");
            var m = mcol.Find(e => e.userEmail==user.email&& e.userType==UserType.client).FirstOrDefault();
            var chat = new chat();
            chat.message = message;
            if (m != null)
            {
                var update = Builders<mMessages>.Update.AddToSet(e => e.chats, chat);
                mcol.UpdateOne(e => e.userEmail == user.email && e.userType == UserType.client, update);//add the chat
               
                //also notify the recipient in there email and sms for now email
                var email = new globals.emailMessage();
                email.to = globals.supportEmail;
                email.subject = "New Message Notification";
                var emsg = System.IO.File.ReadAllText(host.WebRootPath + "/emialViews/email_notification.html");
                emsg = emsg.Replace("{{message}}", "Good day, You have a new message from " + user.email + ": " + message);
                email.message = emsg;
                Task.Run(()=> {
                    globals.sendEmail(email);
                });
                
            }

            return RedirectToAction("Index", "ClientMessage");
        }



    }
}
