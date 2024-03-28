using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "input.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                string fileContent = reader.ReadToEnd();
                Console.WriteLine("File contents:");
                Console.WriteLine(fileContent);
            }
        
        {
            Console.WriteLine("An error occurred while accessing the file: ");
        }
    }
}
