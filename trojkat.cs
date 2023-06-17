using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wysokość trójkąta: ");
        int wysokosc = Convert.ToInt32(Console.ReadLine());

        RysujTrojkat(wysokosc);

        Console.ReadLine();
    }

    static void RysujTrojkat(int wysokosc)
    {
        int szerokosc = wysokosc * 2 - 1;
        int srodek = szerokosc / 2;

        for (int i = 0; i < wysokosc; i++)
        {
            int iloscPlusow = i * 2 + 1;
            int iloscSpacji = srodek - i;

            string wiersz = new String(' ', iloscSpacji);
            wiersz += new String('+', iloscPlusow);
            Console.WriteLine(wiersz);
        }
    }
}
