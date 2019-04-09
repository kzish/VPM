using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VPM.Models
{
    public class mToken
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public DateTime date { get; set; } = DateTime.Now;
        public string userid { get; set; }
    }
}
