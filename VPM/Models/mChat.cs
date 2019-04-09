using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace VPM.Models
{
    public class mChat
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();

    }

    public class mComment
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string parent { get; set; }
        public DateTime created { get; set; } = DateTime.Now;
        public DateTime modified { get; set; } = DateTime.Now;
        public string content { get; set; }
        List<string> pings = new List<string>();
        public string creator { get; set; }//id of the person who created this comment
        public string fullname { get; set; }
        public string profile_picture_url { get; set; }
        public bool created_by_admin { get; set; }
        public bool created_by_current_user { get; set; }
        public bool user_has_upvoted { get; set; }
        public bool is_new { get; set; }

        public mUser getOwner()
        {
            var ucol = globals.getDB().GetCollection<mUser>("mUser");
            var user = ucol.Find(x => x._id == creator).FirstOrDefault();
            return user;
        }



    }
}
