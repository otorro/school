using System;

public class Program
{
    public static double CalculateExponential(double x, int n)
    {
        double result = 1.0; // Pierwszy wyraz szeregu Taylora

        for (int i = 1; i <= n; i++)
        {
            double term = Math.Pow(x, i) / Factorial(i);
            result += term;
        }

        return result;
    }

    public static int Factorial(int number)
    {
        int result = 1;

        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj wartość x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj liczbę wyrazów (n) do uwzględnienia w szeregu Taylora:");
        int n = Convert.ToInt32(Console.ReadLine());

        double result = CalculateExponential(x, n);

        Console.WriteLine("Szacowana wartość e^x: " + result);
    }
}
