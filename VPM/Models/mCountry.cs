using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VPM.Models
{
    public class mCountry
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public List<mStateOrProvince> stateOrPorvince { get; set; } = new List<mStateOrProvince>();
    }

    public class mStateOrProvince
    {
        public string name { get; set; }
        public List<string> city_suburb_town_location { get; set; } = new List<string>();
    }


}
