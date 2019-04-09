using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VPM.Models
{
    public class mJsonMapResult
    {
        public summary summary { get; set; }
        public List<results> results { get; set; }
    }

    public class geoBias
    {
        public string lat { get; set; }
        public string lon { get; set; }
    }
    public class summary
    {
        public string query { get; set; }
        public string queryType { get; set; }
        public string queryTime { get; set; }
        public string numResults { get; set; }
        public string offset { get; set; }
        public string totalResults { get; set; }
        public string fuzzyLevel { get; set; }
        public geoBias geobias { get; set; }
    }


    public class results
    {
        public string type { get; set; }
        public string id { get; set; }
        public string score { get; set; }
        public string dist { get; set; }
        public string entityType { get; set; }
        public address address { get; set; }
        public position position { get; set; }

    }
    public class address
    {
        public string municipalitySubdivision { get; set; }
        public string municipality { get; set; }
        public string countrySubdivision { get; set; }
        public string countryCode { get; set; }
        public string country { get; set; }
        public string countryCodeISO3 { get; set; }
        public string freeformAddress { get; set; }

    }
    public class position
    {
        public string lat { get; set; }
        public string lon { get; set; }
    }






}//namespace
