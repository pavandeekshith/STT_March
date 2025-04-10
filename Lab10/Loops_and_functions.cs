using System;

class LoopAndFunctionDemo
{
    static void Main()
    {
        // For loop: print 1 to 10
        Console.WriteLine("Numbers from 1 to 10 using for loop:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        // While loop: repeat factorial calculation until user types "exit"
        while (true)
        {
            Console.Write("Enter a non-negative integer to calculate its factorial (or type 'exit' to quit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (int.TryParse(input, out int number) && number >= 0)
            {
                long fact = CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is: {fact}\n");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.\n");
            }
        }

        Console.WriteLine("Program ended.");
    }

    static long CalculateFactorial(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}