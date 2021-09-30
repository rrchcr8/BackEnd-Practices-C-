using System;

namespace MessagesLibrary
{
    public class AttendanceMessage
    {
        public string StartHour { get; set; }
        public string EndhHour { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public int UserId { get; set; }
    }
}
