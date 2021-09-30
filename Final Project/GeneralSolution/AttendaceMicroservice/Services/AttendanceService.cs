using AttendaceMicroservice.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendaceMicroservice.Services
{
    public class AttendanceService
    {
        private IMongoCollection<Attendance> _attendance;

        public AttendanceService(IAttendanceSettings settings) {

            var client = new MongoClient(settings.Server);
            var database = client.GetDatabase(settings.Database);
            _attendance = database.GetCollection<Attendance>(settings.Collection);

        }
        public List<Attendance> Get() {
            return _attendance.Find(d => true).ToList();
        }
        public Attendance Create(Attendance attendance) {
            _attendance.InsertOne(attendance);
            return attendance;
        }



    }
}
