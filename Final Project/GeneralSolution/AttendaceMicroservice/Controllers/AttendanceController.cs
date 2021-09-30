using AttendaceMicroservice.Models;
using AttendaceMicroservice.Services;
using MassTransit;
using MessagesLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendaceMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        public AttendanceService _attendanceService;
        private readonly IBus _busService;

        public AttendanceController(AttendanceService attendanceService, IBus busService) {

            this._attendanceService = attendanceService;
            this._busService = busService;
        }
        [HttpGet]
        public ActionResult<List<Attendance>> Get() {

            return _attendanceService.Get();
                }

        [HttpPost]
        public async Task<string> Create (Attendance attendance)
        {
            if (attendance != null) 
            { 
            this._attendanceService.Create(attendance);
                AttendanceMessage attendanceMessage = new AttendanceMessage();
                attendanceMessage.EndhHour = attendance.EndhHour;
                attendanceMessage.StartHour = attendance.StartHour;
                attendanceMessage.Date = attendance.Date;
                attendanceMessage.Notes = attendance.Notes;
                attendanceMessage.UserId = attendance.UserId;

                Uri uri = new Uri("rabbitmq://localhost/attendanceQueue");
            var endPoint = await  _busService.GetSendEndpoint(uri);
            await endPoint.Send(attendanceMessage);
            return "true";
            }
            return "false";
           
        }

    }
}
