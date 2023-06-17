using System;

class Program
{
    static void Main()
    {
        // Tworzenie tablicy i wypełnianie jej losowymi wartościami
        int[] tablica = new int[10];
        Random random = new Random();

        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = random.Next(1, 100); // Losowa wartość od 1 do 100
        }

        // Wywołanie metody do wypisywania tablicy od tyłu
        WypiszTabliceOdTylu(tablica);

        Console.ReadLine();
    }

    static void WypiszTabliceOdTylu(int[] tablica)
    {
        // Iterowanie po tablicy od końca do początku
        for (int i = tablica.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(tablica[i]);
        }
    }
}
