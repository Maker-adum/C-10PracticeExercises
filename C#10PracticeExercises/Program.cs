// Read user input
Console.Write("Enter your first name: ");
string firstName = Console.ReadLine();

Console.Write("Enter your last name: ");
string lastName = Console.ReadLine();

// Normalize the names by converting them to lowercase
string normalizedFirstName = firstName.ToLower();
string normalizedLastName = lastName.ToLower();

// Define the recognized name
string recognizedFirstName = "mike";
string recognizedLastName = "london";

// Check if the user's name matches the recognized name
 if (normalizedFirstName.Contains(recognizedFirstName) && normalizedLastName.Contains(recognizedLastName))
 {
    Console.WriteLine("Hello, Mike London! Welcome!");
 }
   else
   
    Console.WriteLine("Hello! Welcome!");
 
     