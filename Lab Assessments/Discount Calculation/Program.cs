using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter item price: $");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        double discountAmount = (discountPercent / 100) * price;
        double finalPrice = price - discountAmount;

        Console.WriteLine("Price after {0}% discount = ${1:F2}", discountPercent, finalPrice);
    }
}
