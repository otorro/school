using System;

class Program
{
    static void Main()
    {
        int rozmiar;
        bool poprawnyRozmiar = false;

        do
        {
            Console.Write("Podaj rozmiar tablicy: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out rozmiar) && rozmiar > 0)
            {
                poprawnyRozmiar = true;
            }
            else
            {
                Console.WriteLine("Niepoprawny rozmiar tablicy. Podaj liczbę całkowitą większą od zera.");
            }
        }
        while (!poprawnyRozmiar);

        int[,] tablica = new int[rozmiar, rozmiar];
        int liczba = 1;

        for (int i = 0; i < tablica.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    tablica[i, j] = liczba++;
                }
            }
            else
            {
                for (int j = tablica.GetLength(1) - 1; j >= 0; j--)
                {
                    tablica[i, j] = liczba++;
                }
            }
        }

        Console.WriteLine("Tablica wynikowa:");

        for (int i = 0; i < tablica.GetLength(0); i++)
        {
            for (int j = 0; j < tablica.GetLength(1); j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
