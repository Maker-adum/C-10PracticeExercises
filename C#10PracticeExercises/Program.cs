namespace RandomNumberGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many random numbers do you want to generate? (default is 10)");

            int numCount;
            bool isValidInput = int.TryParse(Console.ReadLine(), out numCount);
            if (!isValidInput || numCount <= 0)
            {
                numCount = 10;
            }

            int[] randomNumbers = GenerateRandomNumbers(numCount);

            Console.WriteLine($"Generated {numCount} random numbers:");
            foreach (int number in randomNumbers)
            {
                Console.Write($"{number} ");
            }
        }

        static int[] GenerateRandomNumbers(int count = 10)
        {
            Random rand = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = rand.Next(1, 101);
            }

            return numbers;
        }
    }
}

