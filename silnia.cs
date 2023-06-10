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
        Console.WriteLine("Podaj liczbę x:");
        int x = Convert.ToInt32(Console.ReadLine());

        int n = 0;
        int factorial = 1;

        while (factorial <= x)
        {
            n++;

            factorial = Factorial(n);

            if (factorial == x)
            {
                Console.WriteLine("Liczba " + x + " jest silnią liczby " + n);
                return;
            }
        }

        Console.WriteLine("Liczba " + x + " nie jest silnią żadnej liczby.");
    }
}
