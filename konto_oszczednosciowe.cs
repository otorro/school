using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj kwotę początkową na koncie:");
        decimal kwotaPoczatkowa = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Podaj oprocentowanie konta w skali roku:");
        decimal oprocentowanie = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Podaj liczbę miesięcy oszczędzania:");
        int liczbaMiesiecy = Convert.ToInt32(Console.ReadLine());

        decimal podatekBelki = 0.19m; // Stawka podatku Belki 19%

        decimal oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
        decimal kwotaKoncowa = kwotaPoczatkowa * (decimal)Math.Pow(1 + (double)oprocentowanieMiesieczne, liczbaMiesiecy);

        decimal podatek = (kwotaKoncowa - kwotaPoczatkowa) * podatekBelki;
        decimal kwotaKoncowaPoPodatku = kwotaKoncowa - podatek;

        Console.WriteLine("Kwota zarobiona (po uwzględnieniu podatku Belki): " + kwotaKoncowaPoPodatku);
    }
}
