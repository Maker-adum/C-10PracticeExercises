using System;

class Program
{
    static void Main()
    {
        int[] myArray = { 1, 2, 3, 4, 5 };

        foreach (int element in myArray)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine(myArray.Length);
    }
}