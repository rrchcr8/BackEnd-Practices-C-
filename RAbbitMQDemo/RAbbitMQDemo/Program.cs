using System;
using RabbitMQ;
using RabbitMQ.Client;

namespace RAbbitMQDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory
            {
                Uri = new Uri("amqp://guest:guest@localhot:5672")

            };
        }
    }
     
}
