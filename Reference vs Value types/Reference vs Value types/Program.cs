namespace HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2 };

            PrintNumbers(numbers); // Prints 1, 2

            ChangeToZero(numbers);
            PrintNumbers(numbers); // Prints 0, 0

            ChangeToOne(numbers);
            PrintNumbers(numbers); // Prints 1, 1

            int counter = 0;

            Increment(counter);

            Console.WriteLine(counter); // Prints 0

            Increment(ref counter); //ref also needs to be specified by the caller
            Console.WriteLine(counter); // Prints 1
            Console.ReadKey();
        }

        public static void Increment(int num)
        {
            num += 1;
        }

        public static void Increment(ref int num)
        {
            num += 1;
        }

        private static void ChangeToZero(int[] arr)
        {
            arr[0] = 0;
            arr[1] = 0;
        }

        private static void ChangeToOne(int[] arr)
        {
            arr[0] = 1;
            arr[1] = 1;
        }

        private static void PrintNumbers(int[] arr)
        {
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}