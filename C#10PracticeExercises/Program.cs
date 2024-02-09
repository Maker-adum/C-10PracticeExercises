using System;

class Program
{
    static void Main()
    {
        // two-dimensional array of integers
        int[,] myArray = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Printing all elements in the array
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                Console.WriteLine(myArray[i, j]);
            }
        }
    }
}