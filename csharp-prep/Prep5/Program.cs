using System;

class Program
{
    static void Main()
    {
        // Call the DisplayWelcome function
        DisplayWelcome();

        // Call the PromptUserName function and save the return value
        string userName = PromptUserName();

        // Call the PromptUserNumber function and save the return value
        int userNumber = PromptUserNumber();

        // Call the SquareNumber function with the user's number and save the squared result
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}
