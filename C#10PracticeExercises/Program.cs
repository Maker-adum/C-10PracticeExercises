using System;
using MyMath;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1 = Addition.Add(5, 3);
            Console.WriteLine("Result of Addition: " + result1);

            int result2 = Subtraction.Subtract(10, 4);
            Console.WriteLine("Result of Subtraction: " + result2);
        }
    }
}

namespace MyMath
{
    public class Addition
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class Subtraction
    {
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}