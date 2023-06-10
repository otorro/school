using System;

class Program
{
    static void Main()
    {
        // Wczytywanie danych od użytkownika
        Console.Write("Podaj długość boku A: ");
        double bokA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj długość boku B: ");
        double bokB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj długość boku C: ");
        double bokC = Convert.ToDouble(Console.ReadLine());

        // Sprawdzanie warunku trójkąta równobocznego
        bool czyTrojkatRownoboczny = (bokA == bokB) && (bokB == bokC);

        // Wyświetlanie wyniku
        if (czyTrojkatRownoboczny)
        {
            Console.WriteLine("Podane boki tworzą trójkąt równoboczny.");
        }
        else
        {
            Console.WriteLine("Podane boki nie tworzą trójkąta równobocznego.");
        }

        Console.ReadLine();
    }
}