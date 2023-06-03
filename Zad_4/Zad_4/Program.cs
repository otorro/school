using System;

class Program
{
    static void Main()
    {
        // Wczytywanie danych od użytkownika
        Console.Write("Podaj wartość a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj wartość b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj wartość c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj wartość d: ");
        int d = Convert.ToInt32(Console.ReadLine());

        // Sprawdzanie warunku braku rozwiązania
        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            // Obliczanie licznika i mianownika
            int x = a * d + b * c;
            int y = b * d;

            // Wyświetlanie wyniku
            Console.WriteLine("Licznik (x): " + x);
            Console.WriteLine("Mianownik (y): " + y);
        }

        Console.ReadLine();
    }
}
