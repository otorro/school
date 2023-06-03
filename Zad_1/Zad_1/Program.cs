using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wpisz trzy liczby:");

        // Wczytaj trzy liczby od użytkownika
        double liczba1 = Convert.ToDouble(Console.ReadLine());
        double liczba2 = Convert.ToDouble(Console.ReadLine());
        double liczba3 = Convert.ToDouble(Console.ReadLine());

        // Oblicz średnią arytmetyczną
        double srednia = (liczba1 + liczba2 + liczba3) / 3;

        // Wyświetl wynik
        Console.WriteLine("Średnia arytmetyczna: " + srednia);

        // Zatrzymaj program, aby użytkownik mógł zobaczyć wynik
        Console.ReadLine();
    }
}
