using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę naturalną większą od 5: ");
        if (int.TryParse(Console.ReadLine(), out int liczba) && liczba > 5)
        {
            int liczbaDzielnikow = ZliczDzielnikiPierwsze(liczba);
            Console.WriteLine("Liczba dzielników pierwszych liczby " + liczba + ": " + liczbaDzielnikow);
        }
        else
        {
            Console.WriteLine("Podano niepoprawną liczbę.");
        }
    }

    static int ZliczDzielnikiPierwsze(int n)
    {
        int liczbaDzielnikow = 0;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0 && CzyPierwsza(i))
            {
                liczbaDzielnikow++;
            }
        }

        return liczbaDzielnikow;
    }

    static bool CzyPierwsza(int liczba)
    {
        if (liczba < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
                return false;
        }

        return true;
    }
}
