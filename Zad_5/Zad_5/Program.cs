using System;

class Program
{
    static void Main()
    {
        // Wczytywanie danych od użytkownika
        Console.Write("Podaj pierwszą liczbę: ");
        int liczba1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        int liczba2 = Convert.ToInt32(Console.ReadLine());

        // Sprawdzanie, która liczba jest większa
        int wiekszaLiczba = liczba1;
        if (liczba2 > liczba1)
        {
            wiekszaLiczba = liczba2;
        }

        // Wyświetlanie wyniku
        Console.WriteLine("Większa liczba to: " + wiekszaLiczba);

        Console.ReadLine();
    }
}