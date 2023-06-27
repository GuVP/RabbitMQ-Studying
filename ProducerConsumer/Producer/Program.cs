using RabbitMQ.Client;

namespace Producer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sender sender = new Sender();
            string message = string.Empty;
            do
            {
                Console.WriteLine("Write a message and press [enter] to send it");
                message = Console.ReadLine();
                sender.SendMessage(message);
            } while (message != string.Empty);

            Console.WriteLine("Press [enter] to exit the Producer App...");
            Console.ReadLine();
        }
    }
}
