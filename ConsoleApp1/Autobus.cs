using System;

public class Autobus : Pojazd
{
    public int LiczbaMiejsc { get; set; }

    public Autobus(string marka, string model, int rokProdukcji, string numerRejestracyjny, string kolor, int liczbaMiejsc)
        : base("Autobus", marka, model, rokProdukcji, numerRejestracyjny, kolor)
    {
        LiczbaMiejsc = liczbaMiejsc;
    }

    public override void WyswietlDane()
    {
        base.WyswietlDane(); // Wywołujemy implementację z klasy bazowej
        Console.WriteLine($"Liczba miejsc: {LiczbaMiejsc}");
    }
}
