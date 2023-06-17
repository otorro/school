using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 2, 8, 1, 9, 3 }; // Przykładowa tablica do posortowania

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowanieBabelkowe(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);

        Console.ReadLine();
    }

    static void SortowanieBabelkowe(int[] tablica)
    {
        int n = tablica.Length;
        bool zamiana;

        do
        {
            zamiana = false;

            for (int i = 0; i < n - 1; i++)
            {
                if (tablica[i] > tablica[i + 1])
                {
                    // Zamiana miejscami, gdy kolejność jest niepoprawna
                    int temp = tablica[i];
                    tablica[i] = tablica[i + 1];
                    tablica[i + 1] = temp;

                    zamiana = true;
                }
            }

            n--; // Redukcja rozmiaru sortowanej części tablicy
        }
        while (zamiana);
    }

    static void WypiszTablice(int[] tablica)
    {
        foreach (var element in tablica)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }
}
