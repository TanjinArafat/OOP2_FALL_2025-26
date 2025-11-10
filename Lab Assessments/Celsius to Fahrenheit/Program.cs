using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = ConvertToFahrenheit(celsius);
        Console.WriteLine("{0}°C = {1}°F", celsius, fahrenheit);
    }

    static double ConvertToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }
}
