using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VPM.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB;


namespace VPM.Controllers
{
    public class AuthFilterAdmin : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var d = filterContext.RouteData.Values;
            adminExists();
            if (
               (string)d.Values.ToArray()[0] == "Login" ||
               (string)d.Values.ToArray()[1] == "Login" ||
               (string)d.Values.ToArray()[0] == "pLogin" ||
               (string)d.Values.ToArray()[1] == "pLogin"
               )
            {
                return;//skip this for the login and post login
            }
            try
            {
                var sess = filterContext.HttpContext.Session.GetString("email");
                var role = filterContext.HttpContext.Session.GetString("role");
                if (sess == null || sess == "")
                {
                    filterContext.Result = new RedirectResult("/Home/Join?msg=Log%20in%20or%20join%20to%20continue");
                }
                if (role != "admin")
                {
                    filterContext.Result = new RedirectResult("/Home/Join?msg=Log%20in%20or%20join%20to%20continue");
                }
            }
            catch (Exception e)
            {
                filterContext.Result = new RedirectResult("/Home/Join?msg=Log%20in%20or%20join%20to%20continue");
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // do something after the action executes
        }



        public void adminExists()
        {
            var ucol = globals.getDB().GetCollection<mUser>("mUser");
            var user = ucol.Find(e => e.role == UserRole.admin).FirstOrDefault();
            if (user == null)
            {
                var u = new mUser();
                u.name = "admin";
                u.surname = "user";
                u.password = "12345";
                u.hashPassword();
                u.email = globals.supportEmail;
                u.role = UserRole.admin;
                ucol.InsertOne(u);
            }
        }

        //make sure that the user is an admin
        private mUser getuser(ActionExecutingContext filterContext)
        {
            var sess = filterContext.HttpContext.Session.GetString("email");
            var ucol = globals.getDB().GetCollection<mUser>("mUser");
            var user = ucol.Find(e => e.email == sess && e.role == UserRole.admin).FirstOrDefault();
            if (user == null)
            {
                filterContext.Result = new RedirectResult("/Home/Join?msg=Log%20in%20or%20join%20to%20continue");
            }
            return user;
        }


    }




}
