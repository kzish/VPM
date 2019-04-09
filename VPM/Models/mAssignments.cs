using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;

namespace VPM.Models
{
    public class mAssignments
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public string _artisan_id { get; set; }//as long as this id is empty its free for anyone to take it
        public DateTime date { get; set; } = DateTime.Now;
        public string description { get; set; }
        public AssignmentStatus assignmentStatus { get; set; } = AssignmentStatus.pending;
        public DateTime completetionDate { get; set; }
        public List<string> images { get; set; } = new List<string>();
        public string clientID { get; set; }//the id of the client who reported the issue
        public string lat { get; set; } = "";//latitude of address
        public string lon { get; set; } = "";//longitude of address
        public string city { get; set; } = "";
        public string state { get; set; } = "";
        public string skillType { get; set; } = "";
        public string streetaddress { get; set; } = "";
        public List<bid> bids { get; set; } = new List<bid>();
        public double amountPayed { get; set; }//the amount payed for this 
        public string dispute_description{get;set;}
        public void addPayment(double payment)//method to add the payment to the amount payed
        {
            amountPayed += payment;
        }
        public string getSkillType()
        {
            var scol = globals.getDB().GetCollection<mSkills>("mSkills");
            var skill = scol.Find(x => x._id == this.skillType).FirstOrDefault();
            return skill.skill;
        }
        //check to see if this artisan is already in the bid
        public bool isArtisanInBid(string artisan_id)
        {
            var is_there = bids.Where(x => x.artisan_id == artisan_id).Any();
            return is_there;
        }

        public mArtisan getArtisan()
        {
            var acol = globals.getDB().GetCollection<mArtisan>("mArtisan");
            var artisan = acol.Find(x=>x._id==_artisan_id).FirstOrDefault();
            return artisan;
        }


        public int getNumBids()
        {
            return bids.Count();
        }
        public string getAssignmentStatus()
        {
            if (assignmentStatus == AssignmentStatus.completed) return "completed";
            if (assignmentStatus == AssignmentStatus.started) return "started";
            if (assignmentStatus == AssignmentStatus.pending) return "pending";
            if (assignmentStatus == AssignmentStatus.signedOff) return "signed off";
            if (assignmentStatus == AssignmentStatus.dispute) return "dispute";
            else return "Unknown";
        }
    }


    //thesea re bids that have been placed by the artisans
    public class bid
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public DateTime date { get; set; } = DateTime.Now;
        public DateTime proposed_start_date { get; set; }
        public string artisan_id { get; set; }
        public double bidding_price { get; set; }
        public string bidding_rate { get; set; }//monthly weekly hourly etc
        public string bidding_description { get; set; }
        public int estimatedDays { get; set; }//estimade number of days
        public mArtisan getArtisan()
        {
            var acol = globals.getDB().GetCollection<mArtisan>("mArtisan");
            var a = acol.Find(x => x._id == artisan_id).FirstOrDefault();
            try
            {
                a.getRating();//ensure he comes with his rating at run time
            }catch(Exception ex)
            {

            }
            this.artisan = a;
            return a;
        }
        public mArtisan artisan { get; set; }
    }



    public enum AssignmentStatus
    {
        pending,
        started,
        completed,
        signedOff,
        dispute
    }

}
