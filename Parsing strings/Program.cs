namespace parsingStrings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string input = GetInput();

            int number = ParseInput(input);

            Console.WriteLine("The square of the number:");
            Console.WriteLine(SquareInput(number));

            Console.ReadKey();
        }

        private static string GetInput()
        {
            return Console.ReadLine() ?? "";
        }

        private static int ParseInput(string input)
        {
            return Int32.Parse(input);
        }

        private static int SquareInput(int input)
        {
            return input * input;
        }
    }
}