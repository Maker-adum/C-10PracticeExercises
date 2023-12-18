namespace SportsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of hours of exercise per week: ");
            int hoursOfExercise = int.Parse(Console.ReadLine());

            string feedback = GetFitnessLevel(hoursOfExercise);

            Console.WriteLine(feedback);
        }

        static string GetFitnessLevel(int hours)
        {
            string feedback = "";

            if (hours < 0)
            {
                feedback = "Invalid input: Number of hours cannot be negative";
            }
            else if (hours >= 0 && hours < 3)
            {
                feedback = "You should consider increasing the amount of exercise for better fitness.";
            }
            else if (hours >= 3 && hours < 7)
            {
                feedback = "You are maintaining a moderate level of fitness.";
            }
            else if (hours >= 7 && hours <= 10)
            {
                feedback = "You are in good shape. Keep it up!";
            }
            else
            {
                feedback = "Wow! You are very dedicated to fitness. Keep up the great work!";
                feedback += " You have earned an extra bonus for exercising more than 10 hours per week!";
            }

            return feedback;
        }
    }
}
