using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public enum MediaType { Book, Magazine, Movie }
    public abstract class Media
    {
        static int nextSerialNo = 1;
        public string Title { get; set; }
        public MediaType MediaType { get; set; }
        public int SerialNo { get; private set; }
        public int NoOfTimesLent { get; set; } = 0;
        public bool IsAvailable { get; set; } = true;
        public string Borrower { get; set; } = "";

        public Media(string title, MediaType mediaType)
        {
            Title = title;
            MediaType = mediaType;
            SerialNo = nextSerialNo;

            nextSerialNo++;
        }
        public virtual string MediaInfo()
        {
            string mediaInfo = Title + " is a " + MediaType + "\n" + "Serial No : " + SerialNo + "\n" + "Current Borrower : " + Borrower + "\n" + "Times Lent : " + NoOfTimesLent + "\n" + "Availability Status : " + IsAvailable;
            return mediaInfo;
        }
    }
}
