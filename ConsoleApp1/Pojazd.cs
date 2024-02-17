using System;

public class Pojazd
{
    public string TypPojazdu { get; protected set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public int RokProdukcji { get; set; }
    public string NumerRejestracyjny { get; set; }
    public string Kolor { get; set; }

    public Pojazd(string typPojazdu, string marka, string model, int rokProdukcji, string numerRejestracyjny, string kolor)
    {
        WalidujMarka(marka);
        WalidujModel(model);
        WalidujRokProdukcji(rokProdukcji);
        WalidujNumerRejestracyjny(numerRejestracyjny);
        WalidujKolor(kolor);

        TypPojazdu = typPojazdu;
        Marka = marka;
        Model = model;
        RokProdukcji = rokProdukcji;
        NumerRejestracyjny = numerRejestracyjny;
        Kolor = kolor;
    }
    public virtual void WyswietlDane()
    {
         Console.WriteLine($"Typ pojazdu: {TypPojazdu}");
        Console.WriteLine($"Marka: {Marka}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Rok produkcji: {RokProdukcji}");
        Console.WriteLine($"Numer rejestracyjny: {NumerRejestracyjny}");
        Console.WriteLine($"Kolor: {Kolor}");
    }

    private void WalidujMarka(string marka)
    {
        if (string.IsNullOrWhiteSpace(marka))
        {
            throw new ArgumentException("Marka pojazdu nie może być pusta.");
        }
    }

    private void WalidujModel(string model)
    {
        if (string.IsNullOrWhiteSpace(model))
        {
            throw new ArgumentException("Model pojazdu nie może być pusty.");
        }
    }

    private void WalidujRokProdukcji(int rokProdukcji)
    {
        if (rokProdukcji < 1885 || rokProdukcji > DateTime.Now.Year)
        {
            throw new ArgumentException("Niepoprawny rok produkcji pojazdu.");
        }
    }

    private void WalidujNumerRejestracyjny(string numerRejestracyjny)
    {
        if (string.IsNullOrWhiteSpace(numerRejestracyjny))
        {
            throw new ArgumentException("Numer rejestracyjny pojazdu nie może być pusty.");
        }
        if (numerRejestracyjny.Length != 7)
        {
            throw new ArgumentException("Numer rejestracyjny pojazdu musi składać się z 7 znaków.");
        }
        // Sprawdzenie, czy numer rejestracyjny jest unikalny
        if (SprawdzCzyNumerRejestracyjnyIstnieje(numerRejestracyjny))
        {
            throw new ArgumentException("Numer rejestracyjny już istnieje w bazie danych.");
        }
    }
    private bool SprawdzCzyNumerRejestracyjnyIstnieje(string numerRejestracyjny)
    {
        // Przyjmujemy, że lista pojazdów jest dostępna w zakresie tej klasy
        List<Pojazd> listaPojazdow = new List<Pojazd>();
        // Tu trzeba dodać logikę sprawdzającą unikalność numeru rejestracyjnego
        return listaPojazdow.Any(p => p.NumerRejestracyjny == numerRejestracyjny);
    }

    private void WalidujKolor(string kolor)
    {
        if (string.IsNullOrWhiteSpace(kolor))
        {
            throw new ArgumentException("Kolor pojazdu nie może być pusty.");
        }
    }
}
