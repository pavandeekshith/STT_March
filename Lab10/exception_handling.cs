using System;

class ExceptionHandlingDemo
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double difference = num1 - num2;
            double product = num1 * num2;
            double quotient;

            // Handle division separately to catch divide-by-zero
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            else
            {
                quotient = num1 / num2;
            }

            Console.WriteLine($"\nSum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");

            if ((int)sum % 2 == 0)
                Console.WriteLine("The sum is even.");
            else
                Console.WriteLine("The sum is odd.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric input.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nProgram execution completed.");
        }
    }
}
