using System;

class Program
{
    static void Main()
    {
        // Wczytywanie danych od użytkownika
        Console.Write("Podaj pierwszą liczbę: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Wybierz działanie (1-dodawanie, 2-odejmowanie, 3-mnożenie, 4-dzielenie): ");
        int dzialanie = Convert.ToInt32(Console.ReadLine());

        // Wykonanie działania i wyświetlanie wyniku
        switch (dzialanie)
        {
            case 1: // Dodawanie
                double suma = liczba1 + liczba2;
                Console.WriteLine("Wynik dodawania: " + suma);
                break;
            case 2: // Odejmowanie
                double roznica = liczba1 - liczba2;
                Console.WriteLine("Wynik odejmowania: " + roznica);
                break;
            case 3: // Mnożenie
                double iloczyn = liczba1 * liczba2;
                Console.WriteLine("Wynik mnożenia: " + iloczyn);
                break;
            case 4: // Dzielenie
                if (liczba2 != 0)
                {
                    double iloraz = liczba1 / liczba2;
                    Console.WriteLine("Wynik dzielenia: " + iloraz);
                }
                else
                {
                    Console.WriteLine("Wynik dzielenia: " + liczba1 + "/0");
                }
                break;
            default:
                Console.WriteLine("Niepoprawny numer działania.");
                break;
        }

        Console.ReadLine();
    }
}