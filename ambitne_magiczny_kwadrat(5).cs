using System;

class Program
{
    static void Main()
    {
        int[,] kwadrat1 = new int[,]
        {
            { 8, 1, 6 },
            { 3, 5, 7 },
            { 4, 9, 2 }
        };

        int[,] kwadrat2 = new int[,]
        {
            { 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 }
        };

        int[,] kwadrat3 = new int[,]
        {
            { 8, 1, 6 },
            { 3, 5, 7 },
            { 4, 9, 3 }
        };

        Console.WriteLine("Który kwadrat chcesz sprawdzić?");
        Console.WriteLine("1 - Kwadrat spełniający wszystkie warunki");
        Console.WriteLine("2 - Kwadrat niespełniający warunku unikatowości");
        Console.WriteLine("3 - Kwadrat niespełniający przynajmniej jednego z warunków sum");

        int wybor;
        bool poprawnyWybor = false;

        do
        {
            Console.Write("Twój wybór: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out wybor) && (wybor == 1 || wybor == 2 || wybor == 3))
            {
                poprawnyWybor = true;
            }
            else
            {
                Console.WriteLine("Niepoprawny wybór. Wybierz 1, 2 lub 3.");
            }
        }
        while (!poprawnyWybor);

        int[,] kwadrat;

        switch (wybor)
        {
            case 1:
                kwadrat = kwadrat1;
                break;
            case 2:
                kwadrat = kwadrat2;
                break;
            case 3:
                kwadrat = kwadrat3;
                break;
            default:
                kwadrat = null;
                break;
        }

        if (kwadrat != null)
        {
            bool unikatowe = SprawdzUnikatowosc(kwadrat);
            bool suma = SprawdzSume(kwadrat);

            if (unikatowe && suma)
            {
                Console.WriteLine("Podany kwadrat jest kwadratem magicznym!");
            }
            else
            {
                Console.WriteLine("Podany kwadrat nie jest kwadratem magicznym.");
            }
        }
    }

    static bool SprawdzUnikatowosc(int[,] kwadrat)
    {
        int n = kwadrat.GetLength(0);
        int[] liczby = new int[n * n + 1];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int liczba = kwadrat[i, j];

                if (liczby[liczba] == 0)
                {
                    liczby[liczba] = 1;
                }
                else
                {
                    return false; // Liczba już wystąpiła
                }
            }
        }

        return true; // Wszystkie liczby są unikatowe
    }

    static bool SprawdzSume(int[,] kwadrat)
    {
        int n = kwadrat.GetLength(0);
        int suma = 0;

        for (int i = 0; i < n; i++)
        {
            suma += kwadrat[i, 0]; // Suma w pierwszej kolumnie (suma wiersza)

            for (int j = 0; j < n; j++)
            {
                if (kwadrat[i, j] != kwadrat[j, i])
                {
                    return false; // Niespełniony warunek sumy w kolumnach
                }
            }
        }

        // Sprawdzenie sum na przekątnych
        int sumaPrzekatna1 = 0;
        int sumaPrzekatna2 = 0;

        for (int i = 0; i < n; i++)
        {
            sumaPrzekatna1 += kwadrat[i, i];
            sumaPrzekatna2 += kwadrat[i, n - 1 - i];
        }

        return suma == sumaPrzekatna1 && suma == sumaPrzekatna2;
    }
}
