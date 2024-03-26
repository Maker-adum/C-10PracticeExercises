using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "output.txt";

        // Create the file and write the text
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Hello, World!");
        }

        // Verify the text was written by reading the file contents
        string fileContents = File.ReadAllText(filePath);
        Console.WriteLine(fileContents);
    }
}