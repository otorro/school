using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wpisz pole koła:");

        // Wczytaj pole koła od użytkownika
        double poleKola = Convert.ToDouble(Console.ReadLine());

        // Oblicz promień koła
        double promien = Math.Sqrt(poleKola / Math.PI);

        // Oblicz obwód koła
        double obwod = 2 * Math.PI * promien;

        // Wyświetl wynik
        Console.WriteLine("Obwód koła: " + obwod);

        // Zatrzymaj program, aby użytkownik mógł zobaczyć wynik
        Console.ReadLine();
    }
}