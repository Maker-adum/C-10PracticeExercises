using System;

class Program
{
    static void Main()
    {
        // Creating an array of strings
        string[] movies = { "Bell Air", "The midnight Agent", "The Dark Desire", "Fight Club" };

        // Adding another favorite movie using Array.Add
        Array.Resize(ref movies, movies.Length + 1);
        movies[movies.Length - 1] = "13 Reasons Why";

        // Printing the second element using the indexer
        Console.WriteLine("Second element: " + movies[1]);

        // Sorting the array in alphabetical order
        Array.Sort(movies);

        // Printing the sorted array
        Console.WriteLine("Sorted movies:");
        foreach (string movie in movies)
        {
            Console.WriteLine(movie);
        }
    }
}