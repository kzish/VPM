using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VPM.Models
{
    //user is the property owner
    public class mUser
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string password { get; set; }
        public UserRole role { get; set; }
        public bool registered { get; set; }
        public mSettings settings { get; set; } = new mSettings();


        public void copyFrom(mUser u)
        {
            name = u.name;
            surname = u.surname;
            email = u.email;
            password = u.password;
        }

        public void hashPassword()
        {
            password = globals.getmd5(password);
        }
    }
    public enum UserRole
    {
        artisan,
        tenant,
        landlord,
        virtualAssistant,
        admin,
    }


    public class mSettings
    {
        public bool emialNotifications { get; set; } = false;//email notifications
        public bool smsNotifications { get; set; } = false;//sms data charges may applly
        public bool notifyWhenNewEnquiry { get; set; } = false;//new Enquiry
        public bool notifyWhenNewWaitingListApplicant { get; set; } = false;//new applicant
        public bool notifyWhenNewMessageArrives { get; set; }//when new message comes

    }


}
