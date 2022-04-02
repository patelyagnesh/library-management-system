using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Movie : Media
    {
        public int RunTime { get; private set; }

        public Movie(string title, int runTime) : base(title, MediaType.Movie)
        {
            RunTime = runTime;
        }
        public override string MediaInfo()
        {
            string mediaInfo = Title + " is a " + MediaType + "\n" + "Serial No : " + SerialNo + "\n" + "Current Borrower : " + Borrower + "\n" + "Times Lent : " + NoOfTimesLent + "\n" + "Availability Status : " + IsAvailable + "\n" + "Run Time : " + RunTime + " Minutes";
            return mediaInfo;
        }
    }
}
