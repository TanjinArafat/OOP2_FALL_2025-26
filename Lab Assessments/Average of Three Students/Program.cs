using System;

class Program
{
    static void Main()
    {
        double[] scores = new double[3];
        double sum = 0;

        Console.WriteLine("Enter the scores of three students:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Score {0}: ", i + 1);
            scores[i] = Convert.ToDouble(Console.ReadLine());
            sum += scores[i];
        }

        double average = sum / 3;
        Console.WriteLine("Average score: " + Math.Round(average, 2));
    }
}