using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;

namespace VPM.Models
{
    public class mProperty
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public string propertyName { get; set; } = "";
        public string propertyCountry { get; set; } = "";
        public string stateOrPorvince { get; set; } = "";
        public string cityOrTown { get; set; } = "";
        public string suburb { get; set; } = "";
        public string streetAddress { get; set; } = "";
        public PropertyType propertyType{ get; set; }//office, appartment, cottage etc
        public int numBeds { get; set; }//number of bedrooms
        public BathRoomType bathType{get;set;}//ensuite or shared
        public List<PropertyImages> PImages { get; set; } = new List<PropertyImages>();
        public List<TitleDeedFiles> TdFiles { get; set; } = new List<TitleDeedFiles>();
        public string userid { get; set; }//owner of the property
        public DateTime dateCreated { get; set; } = DateTime.Now;
        public string PropertyStatus { get; set; } = "Available";
        public bool saved { get; set; } 
        public string description { get; set; } = "";
        public double price { get; set; } 
        public string billingRate { get; set; } = "Monthly";
        public string eligibilityFormLink { get; set; }
        public List<WaitingList> waitingList { get; set; } = new List<WaitingList>();
        public bool adminApproved { get; set; }//approved to be ligit
        public DateTime? nextAvailableDate { get; set; }
        public string rejectionReason { get; set; }//reason for rejecting if reejected
        public string numberOfOccupants { get; set; } = "Un Specified";//number of occupants in this house
        public int qtyOfThisProperty { get; set; } = 1;//number of instances of this property
        public int qtyOfThisPropertyUsed { get; set; } = 0;//number of instances of this property used
        public List<Notifications> notifications { get; set; } = new List<Notifications>();
        public List<TimeLine> timeLine { get; set; } = new List<TimeLine>();
        public List<MaintananceList> maintananceList { get; set; } = new List<MaintananceList>();
        public List<RevenueAndTarget> revenueAndTarget { get; set; } = new List<RevenueAndTarget>();
        public PropertyPurpose propertyPurpose { get; set; }
        public string lat { get; set; }//latitude
        public string lon { get; set; }//longitude

        public int getNumOccupants()
        {
            return waitingList.Where(x => x.isAssigned).Count();
        }

        public string TrimDescription(int length)
        {
            if(this.description.Length>length)
            {
                return description.Substring(0, length) + "...";
            }
            else
            {
                return description;
            }
        }
        
        //get the number of instances of this item that are free
        public int getFreeSpaces()
        {
            return (qtyOfThisProperty - qtyOfThisPropertyUsed);
        }


        public double getYTDRevenue(DateTime from,DateTime to)
        {
            var sum = this.revenueAndTarget.Where(x=>x.date>=from && x.date<=to).Sum(x=>x.revenue);
            return sum;
        }

        public double[] getMonthlyRevenue(int year)
        {
            double[] arr = new double[12];
            for (int i = 1; i < 13; i++)
            {
                try
                {
                    var r = (double?)revenueAndTarget.Where(x => x.year == year && x.month == i).FirstOrDefault().revenue ?? 0.0;
                    arr[i - 1] = r;
                }catch(Exception ex)
                {
                    arr[i - 1] = 0;
                }
            }
            return arr;
        }

        public double[] getMonthlyTarget(int year)
        {
            double[] arr = new double[12];
            for (int i = 1; i < 13; i++)
            {
                try
                {
                    var r = (double?)revenueAndTarget.Where(x => x.year == year && x.month == i).FirstOrDefault().target ?? 0.0;
                arr[i - 1] = r;
                }
                catch (Exception ex)
                {
                    arr[i - 1] = 0;
                }
            }
            return arr;
        }
        public mUser getOwner()
        {
            var ucol = globals.getDB().GetCollection<mUser>("mUser");
            var user = ucol.Find(x=>x._id==userid).FirstOrDefault();
            return user;
        }



    }

    public enum PropertyPurpose
    {
        forRent,//this house is for Rent
        forSale//this house if going for sale
    }

    public enum BathRoomType {
        ensuite,shared
    }

    public enum PropertyType
    {
        house,office,cottage,boarding_house,apartment
    }

    public class TimeLine
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public DateTime date { get; set; } = DateTime.Now;
        public string message { get; set; }
    }


    public enum PropertyStatus
    {
        Available, Occupied
    }

   public class PropertyImages
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public string path { get; set; }
        public string caption { get; set; }
    }

    public class TitleDeedFiles
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public string path { get; set; }
        public string caption { get; set; }
        public string mime { get; set; }
    }

    public class WaitingList
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public DateTime date { get; set; } = DateTime.Now;
        public string name { get; set; } = "";
        public string surname { get; set; } = "";
        public string mobile { get; set; } = "";
        public string email { get; set; } = "";
        public string address { get; set; } = "";
        public bool isAssigned { get; set; } = false;//this is assigned will determin if this person is assinged or not and also in the event that a property may have more than one tenant the number of assigned will be counted
        public DateTime DateDeAssigned { get; set; }
        public DateTime fromDate { get; set; }//date requested from
        public DateTime toDate { get; set; }//date requested to
        public DateTime dateAssigned { get; set; }//the date this client was assigned this property
        public waitingListStage stage { get; set; }=waitingListStage.pending;//stage of the porcess
        public double getStage()
        {
            return (((double)stage - 1.0) / 5) * 100;
        }
        public string reasonForRejection { get; set; } = "";
        
    }

    public enum waitingListStage
    {
        rejected,
        pending,
        adminReview,
        landLordReview,
        eligible,
        accepted,
    }


    public class Notifications
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public DateTime date { get; set; } = DateTime.Now;
        public string from { get; set; }//from email name mobile
        public string message { get; set; }
        public bool read { get; set; } = false;//bool true false is read message
    }


    public class MaintananceList
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public DateTime date { get; set; } = DateTime.Now;
        public string description { get; set; }
        public double cost { get; set; }
        public DateTime dateCompleted { get; set; }
        public MaintananceStage stage { get; set; } = MaintananceStage.pendingPayment;//stage of the repair
        public double getStage()
        {
            return (((double)stage) / 4) * 100;
        }
    }

    public enum MaintananceStage
    {
        pendingPayment,
        pendingDispatch,//dispatch the artisan to do the work
        repairInProgress,//repairs are underway
        complete,
    }

    public class RevenueAndTarget
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public int month { get; set; } = 1;//month 1, 2, 3 etc
        public double revenue { get; set; } = 0;
        public double target { get; set; } = 0;
        public int year { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
    }


}
