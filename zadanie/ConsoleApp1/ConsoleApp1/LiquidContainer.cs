using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LiquidContainer(double masaLadunku, int wysokosc, double wagaWlasna, int glebokosc, int maksymalnaLadownosc, string typLadunku, string product) : Kontener(masaLadunku, wysokosc, wagaWlasna, glebokosc, maksymalnaLadownosc, product),IHazardNotifier
    {
        public string TypLadunku { get; set; } = typLadunku;

        public void Notify(string message)
        {
            Console.WriteLine(message + " " + NumerSeryjny);
        }

        public override void FillContainer()
        {
            
           
            if (TypLadunku.ToUpper() == "NIEBEZPIECZNY")
            {
                if (MasaLadunku + WagaWlasna > MaksymalnaLadownosc * 0.5)
                {
                    Console.WriteLine("Masa ladunku przekracza dozwolana pojemnosc");
                }
                else
                {
                    WagaWlasna += MasaLadunku;
                 
                    Console.WriteLine($"Loaded {MasaLadunku}");
                }
             
            }
            else if (TypLadunku.ToUpper() == "ZWYKLY")
            {
                if(MasaLadunku + WagaWlasna > MaksymalnaLadownosc * 0.9)
                {
                    Console.WriteLine("Masa ladunku przekracza dozwolana pojemnosc");
                }
                else
                {
                    WagaWlasna += MasaLadunku;
                    
                    Console.WriteLine($"Loaded {MasaLadunku}");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidlowe zadeklarowanie typu ladunku");
            }
           
        }
        public override string ToString()
        {
            return $"numer seryjny: Kon-L-{NumerSeryjny}\n" + base.ToString() + $"Typ ladunku: {TypLadunku}\n";
        }
    }
}
