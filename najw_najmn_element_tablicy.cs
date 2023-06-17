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

        // Wywołanie metody do znajdowania najmniejszego i największego elementu
        int najmniejszy = ZnajdzNajmniejszyElement(tablica);
        int najwiekszy = ZnajdzNajwiekszyElement(tablica);

        Console.WriteLine("Najmniejszy element: " + najmniejszy);
        Console.WriteLine("Największy element: " + najwiekszy);

        Console.ReadLine();
    }

    static int ZnajdzNajmniejszyElement(int[] tablica)
    {
        int najmniejszy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszy)
            {
                najmniejszy = tablica[i];
            }
        }

        return najmniejszy;
    }

    static int ZnajdzNajwiekszyElement(int[] tablica)
    {
        int najwiekszy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] > najwiekszy)
            {
                najwiekszy = tablica[i];
            }
        }

        return najwiekszy;
    }
}
