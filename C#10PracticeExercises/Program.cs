using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the file path: ");
        string filePath = Console.ReadLine();

        Console.WriteLine("Enter the string to write to the file: ");
        string content = Console.ReadLine();

        Console.WriteLine("Enter the number of times to write the string: ");
        int count = int.Parse(Console.ReadLine());


        using (FileStream fileStream = File.Create(filePath))
        {
            for (int i = 0; i < count; i++)
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(content);
                fileStream.Write(bytes, 0, bytes.Length);
            }
        }

        Console.WriteLine($"File '{filePath}' created successfully with '{content}' written {count} times.");
    }
}