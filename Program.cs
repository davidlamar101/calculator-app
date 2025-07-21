using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple .NET Calculator");
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero!");
                    return;
                }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operator.");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
}
