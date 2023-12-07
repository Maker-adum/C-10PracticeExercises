Console.Write("Enter a letter: "); 
char letter = Console.ReadLine().ToLower()[0]; // .ToLower conversts a letter to lowercase and
                                               // [0] used to get the first character of the input string since Console.ReadLine returns a string

if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
{
    Console.WriteLine("Vowel");
}
else
{
    Console.WriteLine("Consonant");
}
