using W67183PO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pojazdy
{
    class Program
    {
        static List<Pojazd> listaPojazdow = new List<Pojazd>();

static void Main(string[] args)
{
    try
    {
        WczytajBazeDanych();

        while (true)
        {
            // Menu główne programu
            Console.WriteLine("1. Dodaj pojazd");
            Console.WriteLine("2. Usuń pojazd");
            Console.WriteLine("3. Wyświetl pojazdy");
            Console.WriteLine("4. Zapisz bazę danych");
            Console.WriteLine("5. Wyjście");

            Console.Write("Wybierz opcję: ");
            int opcja;
            if (int.TryParse(Console.ReadLine(), out opcja))
            {
                switch (opcja)
                {
                    case 1:
                        DodajPojazd();
                        break;
                    case 2:
                        UsunPojazd();
                        break;
                    case 3:
                        WyswietlPojazdy();
                        break;
                    case 4:
                        ZapiszBazeDanych();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Wystąpił błąd: " + ex.Message);
    }
}
        static void DodajPojazd()
        {
            try
            {
                Console.WriteLine("Dodawanie nowego pojazdu:");

                Console.WriteLine("Wybierz typ pojazdu:");
                Console.WriteLine("1. Samochód");
                Console.WriteLine("2. Autobus");
                Console.WriteLine("3. Motocykl");
                Console.WriteLine("4. Ciężarówka");
                Console.Write("Wybierz opcję: ");

                int opcja;
                if (int.TryParse(Console.ReadLine(), out opcja))
                {
                    switch (opcja)
                    {
                        case 1:
                            DodajSamochod();
                            break;
                        case 2:
                            DodajAutobus();
                            break;
                        case 3:
                            DodajMotocykl();
                            break;
                        case 4:
                            DodajCiezarowke();
                            break;
                        default:
                            Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas dodawania pojazdu: " + ex.Message);
            }
        }

        static void DodajSamochod()
        {
            Console.WriteLine("Wybierz typ samochodu:");
            Console.WriteLine("1. Samochód standardowy");
            Console.WriteLine("2. Samochód sportowy");

            Console.Write("Wybierz opcję: ");
            int wyborTypu;
            if (int.TryParse(Console.ReadLine(), out wyborTypu))
            {
                switch (wyborTypu)
                {
                    case 1:
                        DodajSamochodStandardowy();
                        break;
                    case 2:
                        DodajSamochodSportowy();
                        break;
                    default:
                        Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
            }
        }
        static void DodajSamochodStandardowy()
        {
            Console.WriteLine("Dodawanie nowego samochodu standardowego:");

            Console.Write("Marka: ");
            string marka = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Rok produkcji: ");
            int rokProdukcji;
            while (!int.TryParse(Console.ReadLine(), out rokProdukcji))
            {
                Console.WriteLine("Niepoprawny format roku produkcji. Wprowadź ponownie.");
            }

            Console.Write("Numer rejestracyjny: ");
            string numerRejestracyjny = Console.ReadLine();

            Console.Write("Kolor: ");
            string kolor = Console.ReadLine();

            Console.Write("Liczba drzwi: ");
            int liczbaDrzwi;
            while (!int.TryParse(Console.ReadLine(), out liczbaDrzwi))
            {
                Console.WriteLine("Niepoprawny format liczby drzwi. Wprowadź ponownie.");
            }

            Samochod nowySamochod = new Samochod(marka, model, rokProdukcji, numerRejestracyjny, kolor, liczbaDrzwi);
            listaPojazdow.Add(nowySamochod);

            Console.WriteLine("Samochód dodany pomyślnie.");
        }
        static void DodajSamochodSportowy()
        {
            Console.WriteLine("Dodawanie nowego samochodu sportowego:");

            Console.Write("Marka: ");
            string marka = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Rok produkcji: ");
            int rokProdukcji;
            while (!int.TryParse(Console.ReadLine(), out rokProdukcji))
            {
                Console.WriteLine("Niepoprawny format roku produkcji. Wprowadź ponownie.");
            }

            Console.Write("Numer rejestracyjny: ");
            string numerRejestracyjny = Console.ReadLine();

            Console.Write("Kolor: ");
            string kolor = Console.ReadLine();

            Console.Write("Liczba drzwi: ");
            int liczbaDrzwi;
            while (!int.TryParse(Console.ReadLine(), out liczbaDrzwi))
            {
                Console.WriteLine("Niepoprawny format liczby drzwi. Wprowadź ponownie.");
            }

            Console.Write("Czy ma spoiler? (T/N): ");
            bool czyMaSpoiler = (Console.ReadLine().ToUpper() == "T");

            SamochodSportowy nowySamochodSportowy = new SamochodSportowy(marka, model, rokProdukcji, numerRejestracyjny, kolor, liczbaDrzwi, czyMaSpoiler);
            listaPojazdow.Add(nowySamochodSportowy);

            Console.WriteLine("Samochód sportowy dodany pomyślnie.");
        }

        static void DodajAutobus()
        {
            Console.WriteLine("Wybierz typ autobusu:");
            Console.WriteLine("1. Zwykły autobus");
            Console.WriteLine("2. Autobus turystyczny");
            Console.Write("Wybierz opcję: ");

            int opcja;
            if (int.TryParse(Console.ReadLine(), out opcja))
            {
                switch (opcja)
                {
                    case 1:
                        DodajZwyklyAutobus();
                        break;
                    case 2:
                        DodajAutobusTurystyczny();
                        break;
                    default:
                        Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
            }
        }
        static void DodajZwyklyAutobus()
        {
            Console.WriteLine("Dodawanie nowego autobusu:");

            Console.Write("Marka: ");
            string marka = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Rok produkcji: ");
            int rokProdukcji;
            while (!int.TryParse(Console.ReadLine(), out rokProdukcji))
            {
                Console.WriteLine("Niepoprawny format roku produkcji. Wprowadź ponownie.");
            }

            Console.Write("Numer rejestracyjny: ");
            string numerRejestracyjny = Console.ReadLine();

            Console.Write("Kolor: ");
            string kolor = Console.ReadLine();

            Console.Write("Ilość miejsc: ");
            int iloscMiejsc;
            while (!int.TryParse(Console.ReadLine(), out iloscMiejsc))
            {
                Console.WriteLine("Niepoprawny format ilości miejsc. Wprowadź ponownie.");
            }

            Autobus nowyAutobus = new Autobus(marka, model, rokProdukcji, numerRejestracyjny, kolor, iloscMiejsc);
            listaPojazdow.Add(nowyAutobus);

            Console.WriteLine("Autobus dodany pomyślnie.");
        }
        static void DodajAutobusTurystyczny()
        {
            Console.WriteLine("Dodawanie nowego autobusu turystycznego:");

            Console.Write("Marka: ");
            string marka = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Rok produkcji: ");
            int rokProdukcji;
            while (!int.TryParse(Console.ReadLine(), out rokProdukcji))
            {
                Console.WriteLine("Niepoprawny format roku produkcji. Wprowadź ponownie.");
            }

            Console.Write("Numer rejestracyjny: ");
            string numerRejestracyjny = Console.ReadLine();

            Console.Write("Kolor: ");
            string kolor = Console.ReadLine();

            Console.Write("Ilość miejsc: ");
            int iloscMiejsc;
            while (!int.TryParse(Console.ReadLine(), out iloscMiejsc))
            {
                Console.WriteLine("Niepoprawny format ilości miejsc. Wprowadź ponownie.");
            }

            Console.Write("Dostępność toalety (Tak/Nie): ");
            string dostepnoscToalety = Console.ReadLine();

            

            AutobusTurystyczny nowyAutobusTurystyczny = new AutobusTurystyczny(marka, model, rokProdukcji, numerRejestracyjny, kolor, iloscMiejsc, dostepnoscToalety);
            listaPojazdow.Add(nowyAutobusTurystyczny);

            Console.WriteLine("Autobus turystyczny dodany pomyślnie.");
        }
        static void DodajMotocykl()
        {
            Console.WriteLine("Dodawanie nowego motocykla:");

            Console.WriteLine("Wybierz typ motocykla:");
            Console.WriteLine("1. Motocykl standardowy");
            Console.WriteLine("2. Motocykl elektryczny");
            Console.Write("Wybierz opcję: ");

            int opcja;
            if (int.TryParse(Console.ReadLine(), out opcja))
            {
                switch (opcja)
                {
                    case 1:
                        DodajMotocyklStandardowy();
                        break;
                    case 2:
                        DodajMotocyklElektryczny();
                        break;
                    default:
                        Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
            }
        }

        static void DodajMotocyklStandardowy()
        {
            Console.WriteLine("Dodawanie nowego motocykla:");

            Console.Write("Marka: ");
            string marka = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Rok produkcji: ");
            int rokProdukcji;
            while (!int.TryParse(Console.ReadLine(), out rokProdukcji))
            {
                Console.WriteLine("Niepoprawny format roku produkcji. Wprowadź ponownie.");
            }

            Console.Write("Numer rejestracyjny: ");
            string numerRejestracyjny = Console.ReadLine();

            Console.Write("Kolor: ");
            string kolor = Console.ReadLine();

            Console.Write("Pojemność silnika (ccm): ");
            int pojemnoscSilnika;
            while (!int.TryParse(Console.ReadLine(), out pojemnoscSilnika))
            {
                Console.WriteLine("Niepoprawny format pojemności silnika. Wprowadź ponownie.");
            }

            Motocykl nowyMotocykl = new Motocykl(marka, model, rokProdukcji, numerRejestracyjny, kolor, pojemnoscSilnika);
            listaPojazdow.Add(nowyMotocykl);

            Console.WriteLine("Motocykl dodany pomyślnie.");
        }
        static void DodajMotocyklElektryczny()
        {
            Console.WriteLine("Dodawanie nowego motocykla elektrycznego:");

            Console.Write("Marka: ");
            string marka = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Rok produkcji: ");
            int rokProdukcji;
            while (!int.TryParse(Console.ReadLine(), out rokProdukcji))
            {
                Console.WriteLine("Niepoprawny format roku produkcji. Wprowadź ponownie.");
            }

            Console.Write("Numer rejestracyjny: ");
            string numerRejestracyjny = Console.ReadLine();

            Console.Write("Kolor: ");
            string kolor = Console.ReadLine();

            Console.Write("Pojemność silnika (ccm): ");
            int pojemnoscSilnika;
            while (!int.TryParse(Console.ReadLine(), out pojemnoscSilnika))
            {
                Console.WriteLine("Niepoprawny format pojemności silnika. Wprowadź ponownie.");
            }

            Console.Write("Pojemność baterii (kWh): ");
            int pojemnoscBaterii;
            while (!int.TryParse(Console.ReadLine(), out pojemnoscBaterii))
            {
                Console.WriteLine("Niepoprawny format pojemności baterii. Wprowadź ponownie.");
            }

            MotocyklElektryczny nowyMotocyklElektryczny = new MotocyklElektryczny(marka, model, rokProdukcji, numerRejestracyjny, kolor, pojemnoscSilnika, pojemnoscBaterii);
            listaPojazdow.Add(nowyMotocyklElektryczny);

            Console.WriteLine("Motocykl elektryczny dodany pomyślnie.");
        }
        static void DodajCiezarowke()
        {
            Console.WriteLine("Dodawanie nowej ciężarówki:");

            Console.Write("Marka: ");
            string marka = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Rok produkcji: ");
            int rokProdukcji;
            while (!int.TryParse(Console.ReadLine(), out rokProdukcji))
            {
                Console.WriteLine("Niepoprawny format roku produkcji. Wprowadź ponownie.");
            }

            Console.Write("Numer rejestracyjny: ");
            string numerRejestracyjny = Console.ReadLine();

            Console.Write("Kolor: ");
            string kolor = Console.ReadLine();

            Console.Write("Maksymalne obciążenie (kg): ");
            int maksymalneObciazenie;
            while (!int.TryParse(Console.ReadLine(), out maksymalneObciazenie))
            {
                Console.WriteLine("Niepoprawny format maksymalnego obciążenia. Wprowadź ponownie.");
            }

            Ciezarowka nowaCiezarowka = new Ciezarowka(marka, model, rokProdukcji, numerRejestracyjny, kolor, maksymalneObciazenie);
            listaPojazdow.Add(nowaCiezarowka);

            Console.WriteLine("Ciężarówka dodana pomyślnie.");
        }
        static void UsunPojazd()
        {
            Console.WriteLine("Usuwanie pojazdu:");

            Console.Write("Podaj numer rejestracyjny pojazdu do usunięcia: ");
            string numerRejestracyjny = Console.ReadLine();

            Pojazd pojazdDoUsuniecia = listaPojazdow.FirstOrDefault(p => p.NumerRejestracyjny == numerRejestracyjny);
            if (pojazdDoUsuniecia != null)
            {
                listaPojazdow.Remove(pojazdDoUsuniecia);
                Console.WriteLine("Pojazd usunięty pomyślnie.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono pojazdu o podanym numerze rejestracyjnym.");
            }
        }

        static void WyswietlPojazdy()
        {
            Console.WriteLine("Lista pojazdów:");

            if (listaPojazdow.Count == 0)
            {
                Console.WriteLine("Baza danych jest pusta. Brak pojazdów do wyświetlenia.");
            }
            else
            {
                foreach (var pojazd in listaPojazdow)
                {
                    Console.WriteLine("----------------------------------------");
                    pojazd.WyswietlDane();
                    Console.WriteLine("----------------------------------------");
                }
            }
        }
        static void ZapiszBazeDanych()
        {
            string sciezkaDoPliku = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "baza_danych.txt");

            try
            {
                Console.WriteLine("Liczba pojazdów do zapisania: " + listaPojazdow.Count);

                using (StreamWriter sw = new StreamWriter(sciezkaDoPliku))
                {
                    foreach (var pojazd in listaPojazdow)
                    {
                        string typPojazdu = "";

                        if (pojazd is Samochod)
                        {
                            typPojazdu = "Samochod";
                        }
                        else if (pojazd is Autobus)
                        {
                            typPojazdu = "Autobus";
                        }
                        else if (pojazd is Motocykl)
                        {
                            typPojazdu = "Motocykl";
                        }
                        else if (pojazd is Ciezarowka)
                        {
                            typPojazdu = "Ciezarowka";
                        }
                        else
                        {
                            typPojazdu = "Nieznany";
                        }

                        Console.WriteLine($"Zapisywanie pojazdu typu: {typPojazdu}");

                        string pojazdData = $"{typPojazdu},{pojazd.Marka},{pojazd.Model},{pojazd.RokProdukcji},{pojazd.NumerRejestracyjny},{pojazd.Kolor}";

                        // Dodaj dodatkowe dane dla konkretnych typów pojazdów
                        if (pojazd is Samochod samochod)
                        {
                            pojazdData += $",{samochod.LiczbaDrzwi}";
                        }
                        else if (pojazd is SamochodSportowy sportowy)
                        {
                            string czyMaSpoiler = sportowy.CzyMaSpoiler ? "1" : "0";
                            pojazdData += $",{czyMaSpoiler}";
                        }
                        else if (pojazd is Autobus autobus)
                        {
                            pojazdData += $",{autobus.LiczbaMiejsc}";
                        }
                        else if (pojazd is AutobusTurystyczny turystyczny)
                        {
                            pojazdData += $",{turystyczny.LiczbaMiejsc}";
                        }
                        else if (pojazd is Motocykl motocykl)
                        {
                            pojazdData += $",{motocykl.PojemnoscSilnika}";
                        }
                        else if (pojazd is MotocyklElektryczny elektryczny)
                        {
                            pojazdData += $",{elektryczny.PojemnoscBaterii}";
                        }
                        else if (pojazd is Ciezarowka ciezarowka)
                        {
                            pojazdData += $",{ciezarowka.MaksymalneObciazenie}";
                        }

                        sw.WriteLine(pojazdData);
                    }
                }

                Console.WriteLine("Baza danych została zapisana do pliku: " + sciezkaDoPliku);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas zapisywania bazy danych: " + ex.Message);
            }
        }


        static void WczytajBazeDanych()
        {
            string sciezkaDoPliku = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "baza_danych.txt");

            if (File.Exists(sciezkaDoPliku))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(sciezkaDoPliku))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length >= 6) // Sprawdź, czy wiersz zawiera co najmniej 6 części
                            {
                                string typPojazdu = parts[0]; // Pierwsza część to typ pojazdu
                                string marka = parts[1];
                                string model = parts[2];
                                int rokProdukcji = int.Parse(parts[3]);
                                string numerRejestracyjny = parts[4];
                                string kolor = parts[5];

                                // Tworzymy pojazd na podstawie typu
                                switch (typPojazdu.ToLower())
                                {
                                    case "samochod":
                                        if (parts.Length >= 7)
                                        {
                                            int liczbaDrzwi = int.Parse(parts[6]);
                                            Samochod samochod = new Samochod(marka, model, rokProdukcji, numerRejestracyjny, kolor, liczbaDrzwi);
                                            listaPojazdow.Add(samochod);
                                        }
                                        break;
                                    case "autobus":
                                        if (parts.Length >= 7)
                                        {
                                            int iloscMiejsc = int.Parse(parts[6]);
                                            Autobus autobus = new Autobus(marka, model, rokProdukcji, numerRejestracyjny, kolor, iloscMiejsc);
                                            listaPojazdow.Add(autobus);
                                        }
                                        break;
                                    case "motocykl":
                                        if (parts.Length >= 7)
                                        {
                                            int pojemnoscSilnika = int.Parse(parts[6]);
                                            Motocykl motocykl = new Motocykl(marka, model, rokProdukcji, numerRejestracyjny, kolor, pojemnoscSilnika);
                                            listaPojazdow.Add(motocykl);
                                        }
                                        break;
                                    case "ciezarowka":
                                        if (parts.Length >= 7)
                                        {
                                            int maksymalneObciazenie = int.Parse(parts[6]);
                                            Ciezarowka ciezarowka = new Ciezarowka(marka, model, rokProdukcji, numerRejestracyjny, kolor, maksymalneObciazenie);
                                            listaPojazdow.Add(ciezarowka);
                                        }
                                        break;
                                    default:
                                        Console.WriteLine($"Nieznany typ pojazdu: {typPojazdu}");
                                        break;
                                }
                            }
                        }
                    }

                    Console.WriteLine("Baza danych została wczytana z pliku: " + sciezkaDoPliku);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wystąpił błąd podczas wczytywania bazy danych: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Plik bazy danych nie istnieje.");
            }
        }
    }
}
