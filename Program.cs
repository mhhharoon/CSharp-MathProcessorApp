using System;

// Declare a namespace (a container for your classes)
namespace MyConsoleApp
{
    // Create a class named MathOperations
    class MathOperations
    {
        // This is a void method (it returns nothing)
        // It takes two integers as input parameters
        public void Operate(int number1, int number2)
        {
            // Perform a math operation on the first number
            int result = number1 + 10;

            // Display the result of the operation
            Console.WriteLine("The result of number1 + 10 is: " + result);

            // Display the second number
            Console.WriteLine("The second number is: " + number2);
        }
    }

    // The Program class contains the entry point of the application
    class Program
    {
        // The Main method is the starting point of the app
        static void Main(string[] args)
        {
            // Create an instance (object) of the MathOperations class
            MathOperations math = new MathOperations();

            // Call the method with two integers
            math.Operate(5, 20);

            // Call the method again, using named arguments
            math.Operate(number1: 12, number2: 8);

            // Pause the console to view results
            Console.ReadLine();
        }
    }
}
