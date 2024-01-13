using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        do
        {
            int magicNumber = random.Next(1, 101);
            int guessCount = 0;
            int userGuess;

            Console.WriteLine("Welcome to Guess My Number!");
            Console.WriteLine("I've picked a magic number between 1 and 100. Try to guess it.");

            do
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                guessCount++;

                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

            } while (userGuess != magicNumber);

            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Do you want to play again? (yes/no): ");
        } while (Console.ReadLine().ToLower() == "yes");

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
