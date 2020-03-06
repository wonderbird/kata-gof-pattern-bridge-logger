using System;

namespace gof_pattern_bridge_logger
{
    public class Program
    {
        public static ILogger Logger { get; set; } = new Logger();

        public static void Main(string[] args)
        {
            Logger.Log("Hello World!");
            Logger.Log("Hello, Stefan");

            var messages = Logger.GetAllMessages();
            foreach (var message in messages)
                Console.WriteLine(message);
        }
    }
}