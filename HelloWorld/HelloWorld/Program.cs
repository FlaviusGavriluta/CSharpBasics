using System;

namespace HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] messages = { "Hello World!", "Codecool is best." };
            PrintMessage(messages);

            PrintMessages("Hello Codecool");

            void PrintMessages(string message)
            {
                Console.WriteLine(message);
            }
        }

        private static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void PrintMessage(string[] messages)
        {
            foreach (var message in messages)
            {
                Print(message);
            }

            void Print(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}