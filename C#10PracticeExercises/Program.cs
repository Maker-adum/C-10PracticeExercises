using System;

class Program
{
    static void Main()
    {
        // Creating an array of doubles
        double[] myArray = { 1.5, 2.3, 4.7, 3.2, 5.1 };

        // Calculating the average of the elements in the array
        double sum = 0;
        for (int i = 0; i < myArray.Length; i++)
        {
            sum += myArray[i];
        }

        double average = sum / myArray.Length;

        // Printing the average
        Console.WriteLine("Average: " + average);
    }
}