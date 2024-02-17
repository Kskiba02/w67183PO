using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W67183PO
{
    public class Motocykl : Pojazd
    {
        public int PojemnoscSilnika { get; set; }

        public Motocykl(string marka, string model, int rokProdukcji, string numerRejestracyjny, string kolor, int pojemnoscSilnika)
            : base("Motocykl", marka, model, rokProdukcji, numerRejestracyjny, kolor)
        {
            PojemnoscSilnika = pojemnoscSilnika;
        }

        public override void WyswietlDane()
        {
            base.WyswietlDane();
            Console.WriteLine($"Pojemność silnika: {PojemnoscSilnika}cc");
        }
    }
}
