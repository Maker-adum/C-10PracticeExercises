using System;
using System.IO;

class Program
{
    static void Main()
    {
        string mainDirectory = "mydir";
        string subDirectory = "mysubdir";

        if (!Directory.Exists(mainDirectory))
        {
            Directory.CreateDirectory(mainDirectory);
            Console.WriteLine($"Created directory: {mainDirectory}");
        }

        string subDirectoryPath = Path.Combine(mainDirectory, subDirectory);
        Directory.CreateDirectory(subDirectoryPath);
        Console.WriteLine($"{subDirectory}");

        string[] filesInmainDirectory = Directory.GetFiles(mainDirectory);

        foreach (string file in filesInmainDirectory)
        {
            Console.WriteLine(Path.GetFileName(file));
        }
    }
}
