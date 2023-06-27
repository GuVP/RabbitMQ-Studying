namespace Consumer
{
    class Program
    {
        public static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            receiver.StartConsumer();

            Console.WriteLine("Press [enter] to exit the Consumer...");
            Console.ReadLine();
            receiver.StopConsumer(); //Real case needs dispose to avoid memomy leak
        }
    }
}