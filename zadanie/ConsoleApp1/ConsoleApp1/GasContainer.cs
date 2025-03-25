using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GasContainer(double masaLadunku, int wysokosc, double wagaWlasna, int glebokosc, int maksymalnaLadownosc, int cisnienie, string product) : Kontener(masaLadunku, wysokosc, wagaWlasna, glebokosc, maksymalnaLadownosc, product),IHazardNotifier
    {
        private int Cisnienie { get; set; } = cisnienie;
        public override void EmptyLoad()
        {
            WagaWlasna -= MasaLadunku;
            WagaWlasna += 0.05 * MasaLadunku;
            
        }
        public void Notify(string message)
        {
            Console.WriteLine(message + " " + NumerSeryjny);
        }
        public override string ToString()
        {
            return $"Kontener Kon-G-{NumerSeryjny}\n" + base.ToString() + $"cisnienie: {Cisnienie}\n";
            
        }




    }
}
