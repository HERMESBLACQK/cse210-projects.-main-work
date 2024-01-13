using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input;
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        if (numbers.Count > 0)
        {
            // Core Requirement 1: Compute the sum
            int sum = numbers.Sum();

            // Core Requirement 2: Compute the average
            double average = numbers.Average();

            // Core Requirement 3: Find the maximum number
            int maxNumber = numbers.Max();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {maxNumber}");

            // Stretch Challenge 1: Find the smallest positive number
            int smallestPositive = numbers.Where(n => n > 0).Min();
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            // Stretch Challenge 2: Sort the list
            List<int> sortedNumbers = numbers.OrderBy(n => n).ToList();
            Console.WriteLine("The sorted list is:");
            foreach (var num in sortedNumbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers entered.");
        }
    }
}
