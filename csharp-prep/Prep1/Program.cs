using System;

class Program
{
    static void Main(string[] args)
    {
        // This Prompt the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // This Prompt the user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        //This  Display the text back on one line
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}

