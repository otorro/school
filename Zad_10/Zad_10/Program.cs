using System;

class Program
{
    static void Main()
    {
        // Wczytywanie liczby od użytkownika
        Console.Write("Podaj liczbę naturalną: ");
        int liczba = Convert.ToInt32(Console.ReadLine());

        // Wyznaczanie ostatniej cyfry za pomocą dzielenia całkowitego i operacji modulo
        int ostatniaCyfra = liczba % 10;

        // Wyświetlanie wyniku
        Console.WriteLine("Ostatnia cyfra liczby {0} to {1}.", liczba, ostatniaCyfra);

        Console.ReadLine();
    }
}