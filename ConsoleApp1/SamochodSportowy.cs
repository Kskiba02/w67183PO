using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W67183PO
{
    public class SamochodSportowy : Samochod
    {
        public bool CzyMaSpoiler { get; set; }

        public SamochodSportowy(string marka, string model, int rokProdukcji, string numerRejestracyjny, string kolor, int liczbaDrzwi, bool czyMaSpoiler)
            : base(marka, model, rokProdukcji, numerRejestracyjny, kolor, liczbaDrzwi)
        {
            CzyMaSpoiler = czyMaSpoiler;
        }

        public override void WyswietlDane()
        {
            
            base.WyswietlDane();
            Console.WriteLine("Typ: Sportowy");
            Console.WriteLine($"Czy ma spoiler: {(CzyMaSpoiler ? "Tak" : "Nie")}");
        }
    }

}
