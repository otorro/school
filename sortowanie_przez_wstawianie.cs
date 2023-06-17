using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 2, 8, 1, 9, 3 }; // Przykładowa tablica do posortowania

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowaniePrzezWstawianie(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);

        Console.ReadLine();
    }

    static void SortowaniePrzezWstawianie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 1; i < n; i++)
        {
            int klucz = tablica[i];
            int j = i - 1;

            while (j >= 0 && tablica[j] > klucz)
            {
                tablica[j + 1] = tablica[j];
                j--;
            }

            tablica[j + 1] = klucz;
        }
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
