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
        int dol = 0, gora = rozmiar - 1, lewo = 0, prawo = rozmiar - 1;

        while (liczba <= rozmiar * rozmiar)
        {
            for (int i = lewo; i <= prawo; i++)
            {
                tablica[gora, i] = liczba++;
            }
            gora--;

            for (int i = gora; i >= dol; i--)
            {
                tablica[i, prawo] = liczba++;
            }
            prawo--;

            for (int i = prawo; i >= lewo; i--)
            {
                tablica[dol, i] = liczba++;
            }
            dol++;

            for (int i = dol; i <= gora; i++)
            {
                tablica[i, lewo] = liczba++;
            }
            lewo++;
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
