using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Wersja 2: Losowanie liczby parzystej od razu");
        Console.Write("Wylosowane liczby: ");

        Random rand = new Random();
        int liczbaLosowan = 0;
        int liczba = 0;

        for (int i = 0; i < n; i++)
        {
            liczba = rand.Next(-4, 5) * 2;
            liczbaLosowan++;

            Console.Write(liczba);

            if (i < n - 1)
                Console.Write(", ");
        }

        Console.WriteLine();
        Console.WriteLine($"Liczba faktycznych losowań: {liczbaLosowan}");

        Console.ReadLine();
    }
}
