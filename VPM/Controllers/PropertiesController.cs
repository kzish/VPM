using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;
using VPM.Models;
using Newtonsoft.Json;
using Newtonsoft;
using PagedList;
using PagedList.Core;
using Microsoft.AspNetCore.Hosting.Internal;
using System.Net;
using System.Web;
using Newtonsoft.Json.Linq;

namespace VPM.Controllers
{
    [Route("Properties")]
    public class PropertiesController : Controller
    {

        HostingEnvironment host;
        public PropertiesController(HostingEnvironment e)
        {
            host = e;
        }

        private mUser getuser()
        {
            var sess = HttpContext.Session.GetString("email");
            var ucol = globals.getDB().GetCollection<mUser>("mUser");
            var user = ucol.Find(e => e.email == sess).FirstOrDefault();
            return user;
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



        [Route("getSuburbs")]
        public string getSuburbs(string country, string term, string state)
        {
            try
            {

                var ccol = globals.getDB().GetCollection<mCountry>("mCountry");
                var subs = ccol.Find(x => x._id != null).ToList();
                var list = new List<string>();
                foreach (var p in subs)
                {
                    // list.Add(p.);
                }
                return JsonConvert.SerializeObject(subs);
            }
            catch (Exception x)
            {
                return Json(new { res = "err", msg = x.Message }).ToString();
            }
        }


        [Route("ViewProperty")]
        public IActionResult ViewProperty(string pid, string msg)
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var property = pcol.Find(p => p._id == pid).FirstOrDefault();
            ViewBag.property = property;
            ViewBag.msg = msg;
            ViewBag.title = "View Property";

            //grab the other properties near this one
            //by clustering ie looking at the similarities

            var props = pcol.Find(x => x._id != null).ToList();
            //filter address only
            //filter location
            props = props.Where(
                  x =>
                  x.cityOrTown.ToLower().Contains(property.cityOrTown.ToLower()) ||
                  x.stateOrPorvince.ToLower().Contains(property.stateOrPorvince.ToLower()) ||
                  x.streetAddress.ToLower().Contains(property.streetAddress.ToLower())
              ).ToList().Take(5).ToList();

            //remove this property from other properties
            props = props.Where(x => x._id != property._id).ToList();
            ViewBag.otherProps = props;

            return View();
        }

        [Route("makeEnquiry")]
        public IActionResult makeEnquiry(mEnquiry eq)
        {
            var ecol = globals.getDB().GetCollection<mEnquiry>("mEnquiry");
            ecol.InsertOne(eq);
            //make a notification to the admin and also the property owner (todo)
            var to = globals.supportEmail;
            var from = eq.email;
            var message = "You have a new enquiry: " + eq.enquiry;
            globals.emailNotifcation(to, from, message, host);

            //confirm to the client
            to = eq.email;
            from = "";
            message = "We have recieved your enquiry we will get in touch with you soon";
            globals.emailNotifcation(to, from, message, host);
            return RedirectToAction("ViewProperty", "Properties", new { pid = eq.property_id, msg = "Thank you for you enquiry we will contact you as soon as possible" });
        }


        [Route("JoinWaitingList")]
        public IActionResult JoinWaitingList(WaitingList w, string pid)
        {

            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var p = pcol.Find(x => x._id == pid).FirstOrDefault();
            string msg = "";

            var exist = p.waitingList.Select(x => x.mobile == w.mobile).FirstOrDefault();
            if (!exist)
            {
                if (w.address == null) w.address = "";
                if (w.name == null) w.name = "";
                if (w.surname == null) w.surname = "";
                if (w.email == null) w.email = "";
                if (w.mobile == null) w.mobile = "";//prevent null values
                p.waitingList.Add(w);
                msg = "Your details have been added to the waiting list, we will be in touch will you as soon as your request is available";
                pcol.ReplaceOneAsync(x => x._id == pid, p);

                //confirm client
                var to = w.email;
                var from = "VPM";
                var message = "You have been added to the waiting list, We will contact you as soon as the property is avaialable";
                globals.emailNotifcation(to, from, message, host);


                //notify the admin
                to = globals.supportEmail;
                from = w.email;
                message = w.email + " has joined the waiting list";
                globals.emailNotifcation(to, from, message, host);

            }
            else
            {
                msg = "Your details are already on the waiting list, we will contact you as soon as your request is available";
            }

            return RedirectToAction("ViewProperty", "Properties", new { msg = msg, pid = pid });


        }

        //for the auto complete
        //[Route("SearchArtisans_Ajax")]
        public string SearchArtisans_Ajax(string query)
        {
            var pcol = globals.getDB().GetCollection<mSkills>("mSkills");
            query = query.ToLower().Replace(" ", "");
            var props = pcol.Find(
                   x =>
                   x.skill.ToLower().Contains(query)
               ).ToList();
            var numSuggestions = " (" + props.Count + ")";
            var spcList = new searchPropertyAjaxClass();
            foreach (var p in props)
            {
                var spc = new suggestions();
                spc.value = p.skill;
                spc.data = "/Properties/SearchArtisan?param=" + p.skill;
                spcList.suggestions.Add(spc);
            }
            return JsonConvert.SerializeObject(spcList);
        }


        //for the auto complete
        [Route("SearchProperties_Ajax")]
        public string SearchProperties_Ajax(string query,string t)//this t is for type either buy or rent
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            query = query.ToLower().Replace(" ", "");
            var props = pcol.Find(
                   x =>
                   x.cityOrTown.ToLower().Contains(query) ||
                   x.stateOrPorvince.ToLower().Contains(query) ||
                   x.streetAddress.ToLower().Contains(query)
               ).ToList();
            //check if this is for sale or rent
            if(t=="buy")
            {
                props = props.Where(x => x.propertyPurpose == PropertyPurpose.forSale).ToList();
            }
            if (t == "rent")
            {
                props = props.Where(x => x.propertyPurpose == PropertyPurpose.forRent).ToList();
            }
            var numSuggestions = " (" + props.Count + ")";
            var spcList = new searchPropertyAjaxClass();
            foreach (var p in props)
            {
                var spc = new suggestions();
                spc.value = p.stateOrPorvince + numSuggestions;//will navigate with the data
                spc.data = "/Properties/SearchProperties?p=r&location=" + query + "&type1=1&type2=1&type3=1&type4=1&type5=1";
                spcList.suggestions.Add(spc);
            }
            return JsonConvert.SerializeObject(spcList);
        }
        public class searchPropertyAjaxClass
        {
            public string query { get; set; } = "Unit";
            public List<suggestions> suggestions { get; set; } = new List<suggestions>();
        }
        public class suggestions
        {
            public string value { get; set; }
            public string data { get; set; }
        }

        //[Route("SearchArtisan")]
        public IActionResult SearchArtisan(string param, int page = 1)//param is skill
        {
            var scol = globals.getDB().GetCollection<mSkills>("mSkills");
            var skills = scol.Find(x => x._id != null).ToList();//all skills
            if (param != null && param != "")
            {
                param = param.ToLower();//.Replace("", "");
                skills = scol.Find(
                       x =>
                       x.skill.ToLower().Contains(param)
                   ).ToList();
            }
            //search the artisans who have this skills
            var acol = globals.getDB().GetCollection<mArtisan>("mArtisan");
            var artisans = acol.Find(x => x._id != null).ToList();//all artisans
            var fileredArtisans = new List<mArtisan>();
            if (param != null && param != "")
            {
                foreach (var s in skills)
                {
                    var with_the_skill = artisans.Where(x => x.skills_list.Contains(s.skill)).ToList();
                    foreach (var w in with_the_skill)
                    {
                        if (!fileredArtisans.Contains(w))
                        {
                            fileredArtisans.Add(w);
                        }
                    }
                }
                var artisans_ = (from d in fileredArtisans select d).AsQueryable();
                ViewBag.artisans = artisans_.ToPagedList(page, 12);
            }
            else
            {
                var artisans_ = (from d in artisans select d).AsQueryable();
                ViewBag.artisans = artisans_.ToPagedList(page, 12);
            }
            ViewBag.param = param;
            ViewBag.title = "Search Properties";
            return View();
        }



        [Route("SearchProperties")]
        [Route("")]
        public IActionResult SearchProperties(
            string type = "",//this first parameter is used to show that this is the first search so all parameters of type1 etc must be inittilized
            int type1 = 0,//property type eg apartments
            int type2 = 0,//property type eg apartments
            int type3 = 0,//property type eg apartments
            int type4 = 0,//property type eg apartments
            int type5 = 0,//property type eg apartments
            int page = 1,
            int bathType = -1,
            string p = "",//purpose = 'b' for buying 'r' for renting
            string price_max = "",//on if selected
            string price_range = "100000",
            string location = "",
            int beds = 1,//number of bedrooms
            string t="rent"
            )//this p is for purpose = b for buy and r for rent //type=apartments office buildings
        {
            var user = getuser();
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var scol = globals.getDB().GetCollection<mCountry>("mCountry");
            var countrys = scol.Find(e => e._id != null).ToList();

            var props = pcol.Find(x => x._id != null).ToList();
            //filter location
            if (location != "" && location != null)
            {
                location = location.ToLower().Replace(" ", "");
                props = props.Where(
                    x =>
                    x.cityOrTown.ToLower().Contains(location) ||
                    x.stateOrPorvince.ToLower().Contains(location) ||
                    x.streetAddress.ToLower().Contains(location)
                // x.suburb.ToLower().Contains(location)//suburb is null shiit
                ).ToList();
                if (props == null)
                {
                    props = new List<mProperty>().ToList();//incase its null return empty list
                    props.Append(new mProperty { });
                }
            }


            // house,office,cottage,boarding_house,apartment
            //filter property type
            if (type != "" && type != null)
            {
                type1 = 1;
                type2 = 1;
                type3 = 1;
                type4 = 1;
                type5 = 1;
            }
            if (type1 == 0) { props = props.Where(x => x.propertyType != (VPM.Models.PropertyType.house)).ToList(); }
            if (type2 == 0) { props = props.Where(x => x.propertyType != (VPM.Models.PropertyType.office)).ToList(); }
            if (type3 == 0) { props = props.Where(x => x.propertyType != (VPM.Models.PropertyType.cottage)).ToList(); }
            if (type4 == 0) { props = props.Where(x => x.propertyType != (VPM.Models.PropertyType.boarding_house)).ToList(); }
            if (type5 == 0) { props = props.Where(x => x.propertyType != (VPM.Models.PropertyType.apartment)).ToList(); }

            //filter price range
            if (price_max != "on")
            {
                double price = double.Parse(price_range);
                props = props.Where(x => x.price <= price).ToList();
                if (props == null)
                {
                    props = new List<mProperty>().ToList();//incase its null return empty list
                    props.Append(new mProperty { });
                }
            }

            //filter bathType
            if (bathType != -1)
            {
                if (bathType == 0)
                {
                    props = props.Where(x => x.bathType == BathRoomType.ensuite).ToList();
                }
                if (bathType == 1)
                {
                    props = props.Where(x => x.bathType == BathRoomType.shared).ToList();
                }
                if (props == null)
                {
                    props = new List<mProperty>().ToList();//incase its null return empty list
                    props.Append(new mProperty { });
                }
            }


            //filter the number of bedrooms
            props = props.Where(x => x.numBeds >= beds).ToList();
            if (props == null)
            {
                props = new List<mProperty>().ToList();//incase its null return empty list
                props.Append(new mProperty { });
            }

            //filter the property for sale or rent
            if(t=="rent")
            {
                props = props.Where(x => x.propertyPurpose == PropertyPurpose.forRent).ToList();
            }
            if (t == "buy")
            {
                props = props.Where(x => x.propertyPurpose == PropertyPurpose.forSale).ToList();
            }

            var props_ = (from d in props select d).AsQueryable();
            ViewBag.numProps = props_.Count();
            ViewBag.props = props_.ToPagedList(page, 12);
            ViewBag.countrys = countrys;
            ViewBag.user = user;
            ViewBag.p = p;
            ViewBag.type1 = type1;
            ViewBag.type2 = type2;
            ViewBag.type3 = type3;
            ViewBag.type4 = type4;
            ViewBag.type5 = type5;
            ViewBag.price_max = price_max;
            ViewBag.bathType = bathType;
            ViewBag.location = location;
            ViewBag.price_range = price_range;
            ViewBag.beds = beds;

            if (t == "rent")
            {
                ViewBag.title = "Search Rentals";
            }
            else if (t == "buy")
            {
                ViewBag.title = "Search Property";
            }

            ViewBag.t = t;



            //the first propery returned will be the basis of the map location
            //the rest of the houses will have there own locations 
            if (props.Count > 0)
            {
                var _property1 = props[0];
                var query = HttpUtility.UrlEncode(_property1.cityOrTown + " " + _property1.stateOrPorvince + " " + _property1.streetAddress);
                WebClient wc = new WebClient();
                var response = wc.DownloadString("https://api.tomtom.com/search/2/geocode/" + query + ".json?key=kDBGrc2tROkfTL2jlCBl26GLscDVhEZL&typeahead=false&lat=9.0820&lon=8.6753&countrySet=NG");
                mJsonMapResult re = JsonConvert.DeserializeObject<mJsonMapResult>(response);
                ViewBag.lat = re.results[0].position.lat;
                ViewBag.lon = re.results[0].position.lon;
            }

           
            return View();
        }



    }
}
