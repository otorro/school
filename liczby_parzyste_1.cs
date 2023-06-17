using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Wersja 1: Sprawdzanie poprawności po losowaniu");
        Console.Write("Wylosowane liczby: ");

        Random rand = new Random();
        int liczbaLosowan = 0;
        int liczba = 0;

        for (int i = 0; i < n; i++)
        {
            do
            {
                liczba = rand.Next(-8, 9);
                liczbaLosowan++;
            }
            while (liczba % 2 != 0);

            Console.Write(liczba);

            if (i < n - 1)
                Console.Write(", ");
        }

        Console.WriteLine();
        Console.WriteLine($"Liczba faktycznych losowań: {liczbaLosowan}");

        Console.ReadLine();
    }
}
