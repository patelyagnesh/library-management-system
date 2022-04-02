using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Magazine : Book
    {
        public int IssueNo { get; private set; }

        public Magazine(string title, int pageCount, int issueNo) : base(title, MediaType.Magazine, pageCount)
        {
            IssueNo = issueNo;
        }
        public override string MediaInfo()
        {
            string mediaInfo = Title + " is a " + MediaType + "\n" + "Serial No : " + SerialNo + "\n" + "Current Borrower : " + Borrower + "\n" + "Times Lent : " + NoOfTimesLent + "\n" + "Availability Status : " + IsAvailable + "\n" + "No. of Pages : " + PageCount + "\n" + "Issue no : " + IssueNo;
            return mediaInfo;
        }
    }
}
