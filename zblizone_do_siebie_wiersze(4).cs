using System;

class Program
{
    static void Main()
    {
        int[,] tablica = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

        int[] najbardziejZbiorczeWiersze = ZnajdzNajbardziejZbiorczeWiersze(tablica);

        Console.WriteLine("Najbardziej zbliżone wiersze: " + najbardziejZbiorczeWiersze[0] + ", " + najbardziejZbiorczeWiersze[1]);
    }

    static int[] ZnajdzNajbardziejZbiorczeWiersze(int[,] tablica)
    {
        int liczbaWierszy = tablica.GetLength(0);
        int[] najbardziejZbiorczeWiersze = new int[2];
        int minRoznica = int.MaxValue;

        for (int i = 0; i < liczbaWierszy - 1; i++)
        {
            for (int j = i + 1; j < liczbaWierszy; j++)
            {
                int roznica = ObliczRoznicaWierszy(tablica, i, j);

                if (roznica < minRoznica)
                {
                    minRoznica = roznica;
                    najbardziejZbiorczeWiersze[0] = i;
                    najbardziejZbiorczeWiersze[1] = j;
                }
            }
        }

        return najbardziejZbiorczeWiersze;
    }

    static int ObliczRoznicaWierszy(int[,] tablica, int i, int j)
    {
        int liczbaKolumn = tablica.GetLength(1);
        int roznica = 0;

        for (int k = 0; k < liczbaKolumn; k++)
        {
            int aik = tablica[i, k];
            int ajk = tablica[j, k];

            roznica += (aik - ajk) * (aik - ajk);
        }

        return roznica;
    }
}
