using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

         sentence = sentence.Trim();

        string[] words = Regex.Split(sentence, @"\s+");

        int wordCount = words.Length;

        Console.WriteLine($"Number of words in the sentence: {wordCount}");
    }
}










