using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W67183PO
{
    class Ciezarowka : Pojazd
    {
        public double MaksymalneObciazenie { get; set; }

        public Ciezarowka(string marka, string model, int rokProdukcji, string numerRejestracyjny, string kolor, double maksymalneObciazenie)
            : base("Ciezarowka", marka, model, rokProdukcji, numerRejestracyjny, kolor)
        {
            MaksymalneObciazenie = maksymalneObciazenie;
        }

        public override void WyswietlDane()
        {
            base.WyswietlDane(); // Wywołujemy implementację z klasy bazowej
            Console.WriteLine($"MaksymalneObciazenie: {MaksymalneObciazenie} ton");
        }
    }
}
