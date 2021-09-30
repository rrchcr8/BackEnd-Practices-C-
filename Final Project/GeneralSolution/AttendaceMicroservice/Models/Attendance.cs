using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendaceMicroservice.Models
{
    public class Attendance
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("startHour")]
        public string StartHour { get; set; }
        [BsonElement("endHour")]
        public string EndhHour { get; set; }
        [BsonElement("date")]
        public DateTime Date { get; set; }
        [BsonElement("notes")]
        public string Notes { get; set; }
        public int UserId { get; set; }

    }
}
