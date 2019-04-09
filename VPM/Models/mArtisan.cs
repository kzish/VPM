using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VPM.Models
{
    public class mArtisan
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public string image { get; set; } = "image";
        public string name { get; set; } = "";
        public string surname { get; set; } = "";
        public string password { get; set; } = "";
        public string mobile { get; set; } = "";
        public string email { get; set; } = "";
        public double hourlyRate { get; set; } = 0.0;
        public string streetAddress { get; set; } = "";
        public EmploymentType employmentType { get; set; } = EmploymentType.partTime;
        public string country { get; set; } = "";
        public string stateOrPorvince { get; set; } = "";
        public string cityOrTown { get; set; } = "";
        public List<string> skills_list { get; set; } = new List<string>();
        public List<Referee> referees { get; set; } = new List<Referee>();
        public List<artisanRating> artisanRating { get; set; } = new List<artisanRating>();
        public int numJobs { get; set; }//the number of jobs that i have done
        public int myrating { get; set; }
        public bool registered { get; set; }
        public int getRating()//get my rating
        {
            try
            {
                var fiveRatings = artisanRating.Where(x => x.numStars == 5).Count();
                var fourRatings = artisanRating.Where(x => x.numStars == 4).Count();
                var threeRatings = artisanRating.Where(x => x.numStars == 3).Count();
                var twoRatings = artisanRating.Where(x => x.numStars == 2).Count();
                var oneRatings = artisanRating.Where(x => x.numStars == 1).Count();

                var rating = (
                               5 * fiveRatings +
                               4 * fourRatings +
                               3 * threeRatings +
                               2 * twoRatings +
                               1 * oneRatings
                              ) /
                              (
                              fiveRatings + fourRatings + threeRatings + twoRatings + oneRatings
                              );
                myrating = (int)rating;
                return (int)rating;
            }
            catch(Exception ex)
            {
                return 0;
            }
            
        }
        public void hashPassword()
        {
            this.password = globals.getmd5(password);
        }
    }

    public enum EmploymentType
    {
        fullTime,
        partTime
    }

    public class Referee
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public string refname { get; set; }
        public string refemail { get; set; }
        public string refmobile { get; set; }

        //contructor
        public Referee()
        {
            refname = "";
            refmobile = "";
            refemail = "";
        }

    }


    public class artisanRating
    {
        public string _id { get; set; } = Guid.NewGuid().ToString();
        public string clientID { get; set; }//the client who did the rating
        public int numStars { get; set; }//the number of stars given;
        public DateTime date { get; set; } = DateTime.Now;//date this was done
        public string assignmentID { get; set; }//the id of the assingment this rating was given
    }


}
