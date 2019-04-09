using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VPM.Models
{
    public class mEnquiry
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string enquiry { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        public string property_id { get; set; }
        public string reasonForRejection { get; set; }
        public EnquiryState enquiryState { get; set; } = EnquiryState.open;
        public string getStatus()
        {
            if (enquiryState == EnquiryState.open) return "open";
            else if (enquiryState == EnquiryState.closed) return "closed";
            else if (enquiryState == EnquiryState.rejected) return "rejected";
            else if (enquiryState == EnquiryState.accepted) return "accepted";
            else if (enquiryState == EnquiryState.underAdminReview) return "Under Admin Review";
            else if (enquiryState == EnquiryState.underLandLordReview) return "Under LandLord Review";
            else return "";
        }



    }

    public enum EnquiryState
    {
        open,
        underLandLordReview,
        underAdminReview,
        accepted,
        rejected,
        closed
    }
}
