using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VPM.Models
{
    public class mClient
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public string surname { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string occupation { get; set; }
        public string password { get; set; }
        public string nextOfKin { get; set; }
        public string nextOfKinMobile { get; set; }
        public void hashPassword()
        {
            this.password = globals.getmd5(this.password);
        }

    }
}
