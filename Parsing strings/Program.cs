namespace parsingStrings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number;
            do
            {
                Console.WriteLine("Please enter a number:");
            } while (!ParseInput(GetInput(), out number));

            Console.WriteLine("The square of the number:");
            Console.WriteLine(SquareInput(number));

            Console.ReadKey();
        }

        private static string GetInput()
        {
            return Console.ReadLine();
        }

        private static bool ParseInput(string input, out int number)
        {
            return Int32.TryParse(input, out number);
        }

        private static int SquareInput(int input)
        {
            return input * input;
        }
    }
}