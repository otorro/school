using System;

class Program
{
    static void Main()
    {
        int n = 10;
        int[,] tablica = new int[n, n];
        int liczba = 1;
        int dol = 0, gora = n - 1, lewo = 0, prawo = n - 1;

        while (liczba <= n * n)
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
