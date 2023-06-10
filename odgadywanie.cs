using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Wybierz liczbę z przedziału 1-20 i zapamiętaj ją.");

        int dolnaGranica = 1;
        int gornaGranica = 20;
        int propozycja;
        bool odgadniete = false;

        while (!odgadniete)
        {
            propozycja = (dolnaGranica + gornaGranica) / 2;

            Console.WriteLine("Czy Twoja liczba to " + propozycja + "?");
            Console.WriteLine("Odpowiedz liczbowo: -1, jeśli jest mniejsza, 1, jeśli jest większa, 0 jeśli zgadłem.");

            int odpowiedz = Convert.ToInt32(Console.ReadLine());

            if (odpowiedz == -1)
            {
                gornaGranica = propozycja - 1;
            }
            else if (odpowiedz == 1)
            {
                dolnaGranica = propozycja + 1;
            }
            else if (odpowiedz == 0)
            {
                Console.WriteLine("Odgadłem! Twoja liczba to " + propozycja + ".");
                odgadniete = true;
            }
            else
            {
                Console.WriteLine("Niepoprawna odpowiedź. Wprowadź -1, 1 lub 0.");
            }
        }
    }
}
