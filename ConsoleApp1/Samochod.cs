using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W67183PO
{
    public class Samochod : Pojazd
    {
        public int LiczbaDrzwi { get; set; }

        public Samochod(string marka, string model, int rokProdukcji, string numerRejestracyjny, string kolor, int liczbaDrzwi)
            : base("Samochód", marka, model, rokProdukcji, numerRejestracyjny, kolor)
        {
            LiczbaDrzwi = liczbaDrzwi;

        }

        public override void WyswietlDane()
        {
            base.WyswietlDane();
            Console.WriteLine($"Liczba Drzwi: {LiczbaDrzwi}");
        }
    }
}
