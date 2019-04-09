using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VPM.Models
{
    //message is the person i am toking to
    public class mMessages
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();//msg id
        public List<chat> chats { get; set; } = new List<chat>();
        public string userEmail { get; set; }//this is my userid
        public string otherPerson { get; set; }//this is the email of the other person i am chatting with
        public UserType userType { get; set; }

    }

    public enum UserType
    {
        client,
        artisan,
        propertyOwner
    }
    //these are the messages in the chat
    public class chat
    {
        public DateTime date { get; set; } = DateTime.Now;
        public string from { get; set; }//from email
        public string to { get; set; }//to email
        public string message { get; set; }
        public bool read { get; set; }//if read or not message
    }



}
