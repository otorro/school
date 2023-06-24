using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int dlugoscTablicy = random.Next(1, 101); // Losowa długość tablicy od 1 do 100
        int[] tablica = new int[dlugoscTablicy];

        for (int i = 0; i < dlugoscTablicy; i++)
        {
            tablica[i] = random.Next(1, 101); // Losowa liczba całkowita od 1 do 100
        }

        Console.WriteLine("Tablica wygenerowana losowo:");
        WyswietlTablice(tablica);

        int mediana = ObliczMediane(tablica);
        Console.WriteLine("Mediana: " + mediana);
    }

    static void WyswietlTablice(int[] tablica)
    {
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static int ObliczMediane(int[] tablica)
    {
        int[] kopiaTablicy = new int[tablica.Length];
        Array.Copy(tablica, kopiaTablicy, tablica.Length);

        Array.Sort(kopiaTablicy);

        int srodkowyIndex = kopiaTablicy.Length / 2;
        int mediana;

        if (kopiaTablicy.Length % 2 == 0)
        {
            int element1 = kopiaTablicy[srodkowyIndex - 1];
            int element2 = kopiaTablicy[srodkowyIndex];
            mediana = (element1 + element2) / 2;
        }
        else
        {
            mediana = kopiaTablicy[srodkowyIndex];
        }

        return mediana;
    }
}
