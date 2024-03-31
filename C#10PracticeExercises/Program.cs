using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the file path: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            using (FileStream fileStream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[fileStream.Length];

                int bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                string fileContents = System.Text.Encoding.UTF8.GetString(buffer);
                Console.WriteLine("File Contents");
                Console.WriteLine(fileContents);
            }
        }

        else
        {
            Console.WriteLine("File not found");
        }
    }
}