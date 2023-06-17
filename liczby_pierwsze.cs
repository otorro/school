using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Pierwsze {n} liczb:");

        int liczba = 2;
        int liczbaLiczbPierwszych = 0;

        while (liczbaLiczbPierwszych < n)
        {
            if (CzyLiczbaPierwsza(liczba))
            {
                Console.WriteLine(liczba);
                liczbaLiczbPierwszych++;
            }

            liczba++;
        }

        Console.ReadLine();
    }

    static bool CzyLiczbaPierwsza(int liczba)
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
