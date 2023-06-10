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

        // Zamiana miejscami wartości z wykorzystaniem operacji arytmetycznych
        a = a + b + c;
        b = a - (b + c);
        c = a - (b + c);
        a = a - (b + c);

        // Wyświetlanie wyniku
        Console.WriteLine("Po zamianie miejscami: a = " + a + ", b = " + b + ", c = " + c);

        Console.ReadLine();
    }
}