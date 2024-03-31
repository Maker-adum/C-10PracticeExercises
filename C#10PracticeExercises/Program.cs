using System;
using System.IO;

class Program
{
    static void Main()
    {
        string sourceFilePath = "source.txt";
        string destinationFilePath = "destination.txt";
        string newnameFilePath = "newname.txt";


        using (StreamWriter writer = new StreamWriter(sourceFilePath))
        {
            writer.WriteLine("Hello again world!");
        }

        File.Copy(sourceFilePath, destinationFilePath);

        File.Move(destinationFilePath, newnameFilePath);

        Console.WriteLine("Existence of files:");
        Console.WriteLine($"source.txt exists: {File.Exists(sourceFilePath)}");
        Console.WriteLine($"destinarion.txt exists: {File.Exists(destinationFilePath)}");
        Console.WriteLine($"newname.txt exists: {File.Exists(newnameFilePath)}");
    }
}