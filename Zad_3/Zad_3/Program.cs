using System;

class Program
{
    static void Main()
    {
        // Pobieranie danych od użytkownika
        Console.Write("Podaj wagę [kg]: ");
        double waga = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wzrost [cm]: ");
        double wzrostCm = Convert.ToDouble(Console.ReadLine());

        // Przeliczenie wzrostu na metry
        double wzrostM = wzrostCm / 100;

        // Obliczanie BMI
        double bmi = ObliczBMI(waga, wzrostM);

        // Wyświetlanie wyniku
        Console.WriteLine("Twoje BMI wynosi: " + bmi);

        // Ocena wyniku BMI
        if (bmi < 18.5)
        {
            Console.WriteLine("Masz niedowagę.");
        }
        else if (bmi >= 18.5 && bmi < 25)
        {
            Console.WriteLine("Twoja waga jest prawidłowa.");
        }
        else if (bmi >= 25 && bmi < 30)
        {
            Console.WriteLine("Masz nadwagę.");
        }
        else
        {
            Console.WriteLine("Masz otyłość.");
        }

        Console.ReadLine();
    }

    static double ObliczBMI(double waga, double wzrost)
    {
        return waga / (wzrost * wzrost);
    }
}