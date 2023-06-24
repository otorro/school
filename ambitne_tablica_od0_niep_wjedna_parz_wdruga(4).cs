using System;

class Program
{
    static void Main()
    {
        int rozmiar;
        bool poprawnyRozmiar = false;
        int N = Console.WindowWidth / 6; // Maksymalny wymiar tablicy, tak aby cała zmieściła się na ekranie

        do
        {
            Console.Write("Podaj rozmiar tablicy (n x n, dodatnie i nieparzyste): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out rozmiar) && rozmiar > 0 && rozmiar % 2 != 0 && rozmiar <= N)
            {
                poprawnyRozmiar = true;
            }
            else
            {
                Console.WriteLine($"Niepoprawny rozmiar tablicy. Podaj liczbę całkowitą nieparzystą, dodatnią i nie większą niż {N}.");
            }
        }
        while (!poprawnyRozmiar);

        int[,] tablica = new int[N, N];

        // Wypełnianie tablicy zerami
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                tablica[i, j] = 0;
            }
        }

        int x = N / 2;
        int y = N / 2;
        int kierunek = 0; // 0 - góra, 1 - prawo, 2 - dół, 3 - lewo

        for (int liczba = 1; liczba <= rozmiar * rozmiar; liczba++)
        {
            tablica[x, y] = liczba;

            switch (kierunek)
            {
                case 0: // Góra
                    x--;
                    y++;
                    if (x < 0 || tablica[x, y] != 0) // Jeśli dotarto do krawędzi lub następne pole już jest wypełnione
                    {
                        x++;
                        y--;
                        kierunek = 1; // Zmiana kierunku na prawo
                    }
                    break;
                case 1: // Prawo
                    y++;
                    x++;
                    if (y >= N || tablica[x, y] != 0)
                    {
                        x--;
                        y--;
                        kierunek = 2; // Zmiana kierunku na dół
                    }
                    break;
                case 2: // Dół
                    x++;
                    y--;
                    if (x >= N || tablica[x, y] != 0)
                    {
                        x--;
                        y++;
                        kierunek = 3; // Zmiana kierunku na lewo
                    }
                    break;
                case 3: // Lewo
                    y--;
                    x--;
                    if (y < 0 || tablica[x, y] != 0)
                    {
                        x++;
                        y++;
                        kierunek = 0; // Zmiana kierunku na górę
                    }
                    break;
            }
        }

        Console.WriteLine("Tablica wynikowa:");

        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j].ToString().PadLeft(2) + "\t");
            }
            Console.WriteLine();
        }
    }
}
