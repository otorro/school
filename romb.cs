using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj rozmiar rombu: ");
        int rozmiar = Convert.ToInt32(Console.ReadLine());

        RysujRomb(rozmiar);

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
            for (int j = 0; j < rozmiar - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * i + 1; j++)
            {
                if (j == 0 || j == 2 * i)
                    Console.Write(znakObramowania);
                else
                    Console.Write(znakWnętrza);
            }

            Console.WriteLine();
        }

        for (int i = rozmiar - 2; i >= 0; i--)
        {
            for (int j = 0; j < rozmiar - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * i + 1; j++)
            {
                if (j == 0 || j == 2 * i)
                    Console.Write(znakObramowania);
                else
                    Console.Write(znakWnętrza);
            }

            Console.WriteLine();
        }
    }
}
