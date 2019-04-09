using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

//this route is for special routes 
namespace VPM.Controllers
{
    [Route("SpecialRoute")]
    public class SpecialRouteController : Controller
    {

        /// <summary>
        /// ClientSearchItemToBeFixed will redirect to client sign up page if no session exists
        /// </summary>
        /// this method is used in IndexFox.cshtml
        /// when user clicks to search for a service
        /// <returns></returns>
        [Route("ClientSearchItemToBeFixed")]
        public IActionResult ClientSearchItemToBeFixed(string mtype)
        {
            var sess = HttpContext.Session.GetString("email");
            if(sess==null)
            {
                return RedirectToAction("ClientSignUp", "Home");
            }
            else
            {
                return RedirectToAction("Support","Client", new { mtype = mtype });
            }
        }
    }
}
