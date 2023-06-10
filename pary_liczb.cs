using System;

public class Program
{
    public static void FindNumberPairs(int n)
    {
        Console.WriteLine("Pary liczb naturalnych, których suma jest równa " + n + ":");

        for (int i = 1; i <= n / 2; i++)
        {
            int j = n - i;

            Console.WriteLine("(" + i + ", " + j + ")");
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę n:");
        int n = Convert.ToInt32(Console.ReadLine());

        FindNumberPairs(n);
    }
}
