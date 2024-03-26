using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "input.txt";

        // Read the contents of the file
        using (StreamReader reader = new StreamReader(filePath))
        {
            string fileContents = reader.ReadToEnd();

            // Print the contents to the console
            Console.WriteLine("File contents:");
            Console.WriteLine(fileContents);
        }

        // The program continues executing after the using block
        Console.WriteLine("File reading complete.");
    }
}