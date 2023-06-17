using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 2, 8, 1, 9, 3 }; // Przykładowa tablica do posortowania

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowaniePrzezWybieranie(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);

        Console.ReadLine();
    }

    static void SortowaniePrzezWybieranie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int indeksMinimum = i;

            for (int j = i + 1; j < n; j++)
            {
                if (tablica[j] < tablica[indeksMinimum])
                {
                    indeksMinimum = j;
                }
            }

            // Zamiana miejscami elementu najmniejszego z aktualnym elementem na pozycji i
            int temp = tablica[indeksMinimum];
            tablica[indeksMinimum] = tablica[i];
            tablica[i] = temp;
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
