using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "input.txt";

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string fileContents = reader.ReadToEnd();
                Console.WriteLine("Hello I love Programming:");
                Console.WriteLine(fileContents);
            }
        }
        else
        {
            Console.WriteLine("File not found: input.txt");
        }
    }
}
