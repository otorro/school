using System;

class Program
{
    static void Main()
    {
        int x, n;
        double wynik, prawidlowyWynik;

        do
        {
            Console.Write("Podaj liczbę naturalną x: ");
        } while (!int.TryParse(Console.ReadLine(), out x) || x <= 0);

        do
        {
            Console.Write("Podaj liczbę całkowitą nieujemną n: ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

        wynik = ObliczPotegę(x, n);
        prawidlowyWynik = Math.Pow(x, n);

        Console.WriteLine("Wynik obliczony algorytmem iteracyjnym: " + wynik);
        Console.WriteLine("Wynik prawidłowy: " + prawidlowyWynik);

        if (wynik == prawidlowyWynik)
        {
            Console.WriteLine("Wyniki są zgodne.");
        }
        else
        {
            Console.WriteLine("Wyniki nie są zgodne.");
        }

        Console.ReadLine();
    }

    static double ObliczPotegę(int x, int n)
    {
        double wynik = x;
        int suma = x;

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j <= x; j++)
            {
                suma += x;
            }
            wynik += suma;
        }

        return wynik;
    }
}
