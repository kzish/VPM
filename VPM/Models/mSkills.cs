using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VPM.Models
{
    public class mSkills
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public string skill { get; set; }
    }
}
