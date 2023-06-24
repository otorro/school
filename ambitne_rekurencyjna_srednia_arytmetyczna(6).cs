using System;

class Program
{
    static void Main()
    {
        double[] liczby = { 2.5, 3.7, 1.9, 4.2, 2.1 };
        int rozmiar = liczby.Length;

        double srednia = ObliczSredniaRekurencyjnie(liczby, rozmiar);
        Console.WriteLine("Średnia: " + srednia);
    }

    static double ObliczSredniaRekurencyjnie(double[] tablica, int rozmiar)
    {
        // Warunek zakończenia rekurencji - gdy rozmiar tablicy wynosi 0
        if (rozmiar == 0)
            return 0;

        // Obliczenie sumy elementów tablicy
        double suma = tablica[rozmiar - 1] + ObliczSredniaRekurencyjnie(tablica, rozmiar - 1);

        // Obliczenie średniej arytmetycznej
        double srednia = suma / rozmiar;

        return srednia;
    }
}
