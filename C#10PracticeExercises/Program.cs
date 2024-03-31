using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "output.bin";

        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write(1);
            writer.Write(2);
            writer.Write(3);
            writer.Write(4);
        }

        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            Console.WriteLine("Integers read from the binary file:");
            Console.WriteLine(reader.ReadInt32());
            Console.WriteLine(reader.ReadInt32());
            Console.WriteLine(reader.ReadInt32());
            Console.WriteLine(reader.ReadInt32());
        }
    }
}
