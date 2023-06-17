using System;

class Program
{
    static void Main()
    {
        int maksymalnaLiczbaProb = 3;
        int liczbaProb = 0;
        int rozmiar = 0;

        while (liczbaProb < maksymalnaLiczbaProb)
        {
            Console.Write("Podaj rozmiar rombu (większy lub równy 3, nieparzysty): ");
            rozmiar = Convert.ToInt32(Console.ReadLine());

            if (rozmiar >= 3 && rozmiar % 2 == 1)
            {
                RysujRomb(rozmiar);
                break;
            }
            else
            {
                Console.WriteLine("Nieprawidłowy rozmiar rombu.");
                liczbaProb++;
            }
        }

        if (liczbaProb == maksymalnaLiczbaProb)
        {
            Console.WriteLine("Przekroczono maksymalną liczbę prób. Program zostaje zakończony.");
        }

        Console.ReadLine();
    }

    static void RysujRomb(int rozmiar)
    {
        char[] obramowanieZnaki = { '#', '@', '|', '*' };
        char[] wnętrzeZnaki = { '.', ':', '-', '+' };

        Random rand = new Random();

        int indeksObramowania = rand.Next(0, obramowanieZnaki.Length);
        int indeksWnętrza = rand.Next(0, wnętrzeZnaki.Length);

        char znakObramowania = obramowanieZnaki[indeksObramowania];
        char znakWnętrza = wnętrzeZnaki[indeksWnętrza];

        for (int i = 0; i < rozmiar; i++)
        {
            int liczbaSpacji = Math.Abs(rozmiar / 2 - i);
            int liczbaZnakow = rozmiar - 2 * liczbaSpacji;

            for (int j = 0; j < liczbaSpacji; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < liczbaZnakow; j++)
            {
                if (j == 0 || j == liczbaZnakow - 1)
                    Console.Write(znakObramowania);
                else
                    Console.Write(znakWnętrza);
            }

            Console.WriteLine();
        }
    }
}
