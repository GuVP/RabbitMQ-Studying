using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer
{
    internal class Sender
    {
        private readonly ConnectionFactory connectionFactory;
        public Sender()
        {
            this.connectionFactory = new ConnectionFactory
            {
                HostName = "localhost"
            };
        }

        public void SendMessage(string message)
        {
            using(var connection =  this.connectionFactory.CreateConnection())
            using(var channel = connection.CreateModel())
            {
                channel.QueueDeclare("BasicTest", false, false, false, null);

                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish("", "BasicTest", null, body);
                Console.WriteLine("Sent message {0}...", message);
            }
        }
    }
}
