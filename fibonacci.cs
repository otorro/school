using System;

public class Program
{
    public static void PrintFibonacciSequence(int n)
    {
        int first = 0;
        int second = 1;

        Console.WriteLine("Ciąg Fibonacciego:");

        if (n >= 1)
        {
            Console.WriteLine(first);
        }

        if (n >= 2)
        {
            Console.WriteLine(second);
        }

        for (int i = 3; i <= n; i++)
        {
            int next = first + second;
            Console.WriteLine(next);

            first = second;
            second = next;
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę wyrazów do wygenerowania w ciągu Fibonacciego:");
        int n = Convert.ToInt32(Console.ReadLine());

        PrintFibonacciSequence(n);
    }
}
