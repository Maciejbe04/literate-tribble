using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Kontener(double masaLadunku, int wysokosc, double wagaWlasna, int glebokosc, int maksymalnaLadownosc, string product)
    {
        private static int id; 
        public double MasaLadunku { get; set; } = masaLadunku;
        public int Wysokosc { get; set; } = wysokosc;
        public double WagaWlasna { get; set; } = wagaWlasna;
        public int Glebokosc { get; set; } = glebokosc;
        public int NumerSeryjny { get; } = id++;
        public int MaksymalnaLadownosc { get; set; } = maksymalnaLadownosc;
        public string Product { get; set; } = product;


        public virtual void EmptyLoad()
        {
            MasaLadunku = 0;
            
        }

        public virtual void FillContainer()
        {
            
            if (MasaLadunku > MaksymalnaLadownosc)
            {
                throw new OverfillException("too much load");
            }
            else
            {
                WagaWlasna += MasaLadunku;
               
                Console.WriteLine($"Loaded {MasaLadunku}");
            }

        }

        public override string ToString()
        {
            return  $"Ladunek: {Product.ToUpper()}\nmasa ladunku : {MasaLadunku}\nwysokosc: {Wysokosc}\nwaga wlasna: {WagaWlasna}" +
                $"\nglebokosc: {Glebokosc}\nmaksymalna ladownosc: {MaksymalnaLadownosc}\n";
        }

    }
}
