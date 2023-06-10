using System;

public class Program
{
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
        int n, k;

        do
        {
            Console.WriteLine("Podaj liczbę n (n >= 5):");
            n = Convert.ToInt32(Console.ReadLine());
        } while (n < 5);

        do
        {
            Console.WriteLine("Podaj liczbę k (k >= 5):");
            k = Convert.ToInt32(Console.ReadLine());
        } while (k < 5);

        int nFactorial = Factorial(n);
        int kFactorial = Factorial(k);

        int m = (nFactorial - kFactorial) / kFactorial;

        Console.WriteLine("Wynik: " + m);
    }
}
