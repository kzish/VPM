using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VPM.Models
{
    public class mVirtualAssistant
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }//username email use the company email
        public string password { get; set; }
        public void hashPassword()
        {
            this.password = globals.getmd5(this.password);
        }
        public bool activated { get; set; }//set to true or false to enable or disable
        public DateTime created { get; set; } = DateTime.Now;

    }
}
