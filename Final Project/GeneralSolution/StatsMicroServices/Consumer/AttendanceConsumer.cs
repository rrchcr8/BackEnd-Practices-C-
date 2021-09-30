using MassTransit;
using MessagesLibrary;
using StatsMicroServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsMicroServices.Consumer
{
    public class AttendanceConsumer : IConsumer<AttendanceMessage>
    {
        public async Task Consume(ConsumeContext<AttendanceMessage> context)
        {
            await Task.Run(() => { var obj = context.Message; Console.WriteLine(obj.UserId); });
        }
    }
}
