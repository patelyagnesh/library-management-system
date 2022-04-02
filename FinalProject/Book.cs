using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Book : Media
    {
        public int PageCount { get; private set; }

        public Book(string title, MediaType mediaType, int pageCount) : base(title, mediaType)
        {
            PageCount = pageCount;
        }

        public override string MediaInfo()
        {
            string mediaInfo = Title + " is a " + MediaType + "\n" + "Serial No : " + SerialNo + "\n" + "Current Borrower : " + Borrower + "\n" + "Times Lent : " + NoOfTimesLent + "\n" + "Availability Status : " + IsAvailable + "\n" + "No. of Pages : " + PageCount;
            return mediaInfo;
        }
    }
}
