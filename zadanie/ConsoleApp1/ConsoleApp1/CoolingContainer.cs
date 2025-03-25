using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CoolingContainer : Kontener
    {
        public double TempWKont { get; set; }
        public double TempProduktu { get; set; }


        public CoolingContainer(double masaLadunku, int wysokosc, double wagaWlasna, int glebokosc, int maksymalnaLadownosc, double tempWKont, string product, double tempProduktu)
        : base(masaLadunku, wysokosc, wagaWlasna, glebokosc, maksymalnaLadownosc, product)
        {
            
            if (tempWKont < tempProduktu)
            {
                throw new Exception("Temp of container cant be lower than temp of the product");
            }
            

            TempWKont = tempWKont;
            TempProduktu = tempProduktu;
        }


        public override string ToString()
        {
            return $"numer seryjny: Kon-C-{NumerSeryjny}\n" + base.ToString() + $"Temp w kontenerze: {TempWKont}\n Temp produktu: {TempProduktu}\n";
        }



    }
}
