using System;

class Program
{
    static void Main()
    {
        // Creating a List of integers
        List<int> myList = new List<int>();

        // Adding 7 elements to the list
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(5);
        myList.Add(6);
        myList.Add(7);

        // Removing the 5th element
        myList.RemoveAt(4);

        // Inserting an element at the beginning of the list
        myList.Insert(0, 10);

        // Printing out all the elements using a foreach loop
        foreach (int element in myList)
        {
            Console.WriteLine(element);
        }
    }
}