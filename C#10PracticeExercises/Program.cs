using System;
using System.IO;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the file path: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }

            string fileContents = File.ReadAllText(filePath);
            Console.WriteLine("File contents");
            Console.WriteLine(fileContents);
        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found. ");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}