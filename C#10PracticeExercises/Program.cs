
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfAges = 3; 

            int[] ages = new int[numberOfAges];
            int sum = 0;

            for (int i = 0; i < numberOfAges; i++)
            {
                Console.Write($"Enter age {i + 1}: ");
                ages[i] = int.Parse(Console.ReadLine());
                sum += ages[i];
            }

            double averageAge = (double)sum / numberOfAges;

            Console.WriteLine($"The average age is: {averageAge:F2}");  //F2 is a format specifier for floating point number. Specifies that the number should be formated to two decimal places
        }
    }

