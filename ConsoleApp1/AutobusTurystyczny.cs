using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W67183PO
{
    public class AutobusTurystyczny : Autobus
    {
        public string DostepnoscToalety { get; set; }

        public AutobusTurystyczny(string marka, string model, int rokProdukcji, string numerRejestracyjny, string kolor, int liczbaMiejsc, string dostepnoscToalety)
            : base(marka, model, rokProdukcji, numerRejestracyjny, kolor, liczbaMiejsc)
        {
            this.DostepnoscToalety = dostepnoscToalety;
        }
        public override void WyswietlDane()
        {
            Console.WriteLine("Typ: Turystyczny");
            base.WyswietlDane();
            Console.WriteLine($"Dostępność toalety: {DostepnoscToalety}");
        }
    }
}
