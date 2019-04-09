using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace VPM.Models
{
    public class mPayments
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public DateTime date { get; set; } = DateTime.Now;
        public string reference { get; set; }
        public string clientID { get; set; }//client who made the payment
        public string propertyID { get; set; }//the id of the property payed to, provided that this is a rental payment
        public string artisanID { get; set; }//provided this is a payemnt made to an artisan
        public double amount { get; set; }//the amount that was payed
        public string flwRef { get; set; }//the reference from rave payment
        public PaymentType paymentType { get; set; }
        public string txref { get; set; }
        public string getpaymentType()
        {
            if (paymentType == PaymentType.artisanService) return "Artisan Service";
            if (paymentType == PaymentType.rentalPayment) return "Rental Payment";
            else return "";
        }
        public mProperty getProperty()
        {
            var pcol = globals.getDB().GetCollection<mProperty>("mProperty");
            var p = pcol.Find(x => x._id == propertyID).FirstOrDefault();
            return p;
        }
    }
    public enum PaymentType {
        artisanService,
        rentalPayment
    }
}
