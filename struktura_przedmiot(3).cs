using System;

enum KlasaRzadkosci
{
    Powszechny,
    Rzadki,
    Unikalny,
    Epicki
}

enum TypPrzedmiotu
{
    Bron,
    Zbroja,
    Amulet,
    Pierscien,
    Helm,
    Tarcza,
    Buty
}

struct Przedmiot
{
    public double waga;
    public int wartosc;
    public KlasaRzadkosci rzadkosc;
    public TypPrzedmiotu typ;
    public string nazwa;

    public void WypelnijPrzedmiot(double waga, int wartosc, KlasaRzadkosci rzadkosc, TypPrzedmiotu typ, string nazwa)
    {
        this.waga = waga;
        this.wartosc = wartosc;
        this.rzadkosc = rzadkosc;
        this.typ = typ;
        this.nazwa = nazwa;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Nazwa: {nazwa}");
        Console.WriteLine($"Typ: {typ}");
        Console.WriteLine($"Rzadkosc: {rzadkosc}");
        Console.WriteLine($"Waga: {waga}");
        Console.WriteLine($"Wartosc: {wartosc} szt. złota");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Przedmiot[] tablicaPrzedmiotow = new Przedmiot[5];

        WypelnijPrzedmioty(tablicaPrzedmiotow);
        WyswietlPrzedmioty(tablicaPrzedmiotow);

        Przedmiot losowyPrzedmiot = LosujPrzedmiot(tablicaPrzedmiotow);
        Console.WriteLine("Wylosowany przedmiot:");
        losowyPrzedmiot.WyswietlInformacje();

        Console.ReadLine();
    }

    static void WypelnijPrzedmioty(Przedmiot[] tablicaPrzedmiotow)
    {
        tablicaPrzedmiotow[0].WypelnijPrzedmiot(2.5, 10, KlasaRzadkosci.Powszechny, TypPrzedmiotu.Bron, "Miecz");
        tablicaPrzedmiotow[1].WypelnijPrzedmiot(3.0, 15, KlasaRzadkosci.Rzadki, TypPrzedmiotu.Zbroja, "Zbroja płytowa");
        tablicaPrzedmiotow[2].WypelnijPrzedmiot(0.8, 5, KlasaRzadkosci.Powszechny, TypPrzedmiotu.Amulet, "Amulet mocy");
        tablicaPrzedmiotow[3].WypelnijPrzedmiot(0.5, 20, KlasaRzadkosci.Unikalny, TypPrzedmiotu.Pierscien, "Pierścień mądrości");
        tablicaPrzedmiotow[4].WypelnijPrzedmiot(1.2, 30, KlasaRzadkosci.Epicki, TypPrzedmiotu.Helm, "Helm nieśmiertelności");
    }

    static void WyswietlPrzedmioty(Przedmiot[] tablicaPrzedmiotow)
    {
        Console.WriteLine("Przedmioty:");
        foreach (var przedmiot in tablicaPrzedmiotow)
        {
            przedmiot.WyswietlInformacje();
        }
    }

    static Przedmiot LosujPrzedmiot(Przedmiot[] tablicaPrzedmiotow)
    {
        Random random = new Random();
        int index = random.Next(0, tablicaPrzedmiotow.Length);
        return tablicaPrzedmiotow[index];
    }
}
