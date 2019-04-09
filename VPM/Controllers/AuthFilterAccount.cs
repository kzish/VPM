using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//this is the landlord/property owner authfilter
namespace VPM.Controllers
{
    public class AuthFilterAccount: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                var sess = filterContext.HttpContext.Session.GetString("email");
                var role = filterContext.HttpContext.Session.GetString("role");
                if (sess == null || sess == "")
                {
                    filterContext.Result = new RedirectResult("/Home/Join?msg=Log%20in%20or%20join%20to%20continue");
                }
                if (role != "owner")
                {
                    filterContext.Result = new RedirectResult("/Home/Join?msg=Log%20in%20or%20join%20to%20continue");
                }
            }
            catch (Exception e)
            {
                //RedirectToAction("Index", "Home");
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // do something after the action executes
        }
    }

}
