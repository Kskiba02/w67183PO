using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W67183PO
{
    public class MotocyklElektryczny : Motocykl
    {
        public int PojemnoscBaterii { get; set; }

        public MotocyklElektryczny(string marka, string model, int rokProdukcji, string numerRejestracyjny, string kolor, int pojemnoscSilnika, int pojemnoscBaterii)
            : base(marka, model, rokProdukcji, numerRejestracyjny, kolor, pojemnoscSilnika)
        {
            this.PojemnoscBaterii = pojemnoscBaterii;
        }
        public override void WyswietlDane()
        {
            Console.WriteLine("Typ: Elektryczny");
            base.WyswietlDane();
            Console.WriteLine($"Pojemność baterii: {PojemnoscBaterii}kWh");
        }
    }

}
