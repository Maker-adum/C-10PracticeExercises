using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);

        bool guessedCorrectly = false;
        while (!guessedCorrectly)
        {
            Console.WriteLine("Guess the number between 1 and 100:");
            try
            {
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the number correctly.");
                    guessedCorrectly = true;
                }
                else if (userGuess < randomNumber)
                {
                    Console.WriteLine("Try again. The number is higher.");
                }
                else
                {
                    Console.WriteLine("Try again. The number is lower.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Input is not a valid integer.");
            }
        }
    }
}
