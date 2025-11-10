using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number (a): ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Before swap: a = {0}, b = {1}", a, b);

        // Swap using XOR bitwise operator
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;

        Console.WriteLine("After swap: a = {0}, b = {1}", a, b);
    }
}
