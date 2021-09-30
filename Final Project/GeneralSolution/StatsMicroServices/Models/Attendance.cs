using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsMicroServices.Models
{
    public class Attendance
    {      
       
        public string StartHour { get; set; }        
        public string EndhHour { get; set; }        
        public DateTime Date { get; set; }        
        public string Notes { get; set; }
        public int UserId { get; set; }
    }
}
