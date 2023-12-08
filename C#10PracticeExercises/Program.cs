
        Random random = new Random();

        // Generate a random number between 1 and 100
        int targetNumber = random.Next(1, 101);

        int userGuess;

        do
        {
            Console.Write("Enter your guess (between 1 and 100): ");

            // Read the user input as a string
            string userInput = Console.ReadLine();

            // Parse the string to an integer
            if (int.TryParse(userInput, out userGuess))
            {
                if (userGuess < 1 || userGuess > 100)
                {
                    Console.WriteLine("Please enter a number between 1 and 100.");
                }
                else if (userGuess < targetNumber)
                {
                    Console.WriteLine("Too low. Try again.");
                }
                else if (userGuess > targetNumber)
                {
                    Console.WriteLine("Too high. Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number {targetNumber}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (userGuess != targetNumber);


