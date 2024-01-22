using System;

public class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? ISBN { get; set; }
    public bool IsAvailable { get; set; }


    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        IsAvailable = true;
    }

    public void CheckAvailability()
    {
        if (IsAvailable)
        {
            Console.WriteLine("The book is available to be borrowed. ");
        }

        else
        {
            Console.WriteLine("The book is currently not available for borrowing. ");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string title = "The Great Gatsby";
        string author = "F. Scott Fitzgerald";
        string isbn = "9780743273565";

        Book book = new Book(title, author, isbn);

        book.CheckAvailability();

        // Simulating borrowing the book
        book.IsAvailable = false;

        book.CheckAvailability();
    }
}