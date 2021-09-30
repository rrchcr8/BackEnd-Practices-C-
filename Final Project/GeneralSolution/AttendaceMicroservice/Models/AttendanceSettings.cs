using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendaceMicroservice.Models
{
    public interface IAttendanceSettings
    {
        string Server { get; set; }
        string Database { get; set; }
        string Collection { get; set; }

    }
    public class AttendanceSettings: IAttendanceSettings
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Collection { get; set; }
        
    }
}
