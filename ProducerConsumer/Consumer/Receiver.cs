using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer
{
    internal class Receiver
    {
        private readonly ConnectionFactory connectionFactory;
        private IConnection connection;
        private IModel channel;
        public Receiver()
        {
            this.connectionFactory = new ConnectionFactory
            {
                HostName = "localhost"
            };
        }

        public void StartConsumer()
        {
            connection = this.connectionFactory.CreateConnection();
            channel = connection.CreateModel();
            
            channel.QueueDeclare("BasicTest", false, false, false, null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body.ToArray());
                Console.WriteLine(message);
            };

            channel.BasicConsume("BasicTest", true, consumer);
        }

        public void StopConsumer()
        {
            channel.Dispose();
            connection.Dispose();
        }
    }
}
