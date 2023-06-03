using System;

class Program
{
    static void Main()
    {
        // Wczytywanie danych od użytkownika
        Console.Write("Podaj współrzędną x punktu P: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj współrzędną y punktu P: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj promień koła: ");
        double r = Convert.ToDouble(Console.ReadLine());

        // Obliczanie odległości punktu P od środka koła
        double odleglosc = Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2));

        // Sprawdzanie warunku należenia punktu do koła
        bool czyLezyWKole = odleglosc <= r;

        // Wyświetlanie wyniku
        if (czyLezyWKole)
        {
            Console.WriteLine("Punkt P({0}, {1}) leży w obrębie koła o środku O(0, 0) i promieniu {2}.", x, y, r);
        }
        else
        {
            Console.WriteLine("Punkt P({0}, {1}) nie leży w obrębie koła o środku O(0, 0) i promieniu {2}.", x, y, r);
        }

        Console.ReadLine();
    }
}