using System;

class BasicCalculator
{
    static void Main()
    {
        double num1, num2, result;
        char operation;
        string choice;

        do
        {
            Console.Clear();
            Console.WriteLine("=== Basic Calculator ===");
            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    break;

                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }

            Console.WriteLine($"Result: {result}");

            Console.Write("\nDo you want to perform another calculation? (yes/no): ");
            choice = Console.ReadLine().ToLower();

        } while (choice == "yes");

        Console.WriteLine("Thank you for using the calculator!");
    }
}
