using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp1
{
    class Ship
    {
        private static int id = 1;
        public List<Kontener> Load {  get; set; } 
        public double MaxVelocity { get; set; } 
        public double MaxLoad { get; set; } 
        public double MaxWeight { get; set; } 
        public int SerialNumber { get; }


        public Ship(List<Kontener> load, double maxVelocity, double maxLoad, double maxWeight)
        {
            var checkWeight = 0.0;

            foreach (Kontener k in load)
            {
                checkWeight += k.WagaWlasna;
            }

            if (load.Count() > maxLoad || checkWeight > maxWeight)
            {
                throw new Exception("Max container load exceeded");
            }
            else
            {
                Load = load;
            }
            MaxVelocity = maxVelocity;
            MaxLoad = maxLoad;
            MaxWeight = maxWeight;
            SerialNumber = id++;
        }

        public void AddContainer(Kontener kontener)
        {
            var checkWeight = 0.0;

            foreach(Kontener k in Load){
                checkWeight += k.WagaWlasna;
            }


            if (Load.Count() < MaxLoad || checkWeight <= MaxWeight)
            {
                Load.Add(kontener);
            }
            else
            {
                Console.WriteLine("Max load exceeded");
            }
        }
        public void RemoveContainer(int serialNumber)
        {
            foreach (Kontener kontener in Load)
            {
                if(kontener.NumerSeryjny == serialNumber)
                {
                    Load.Remove(kontener);
                    break;
                }

            }



        }
        public void ReplaceContainer(int serialNum1, Kontener newContainer)
        {
            foreach (Kontener k in Load)
            {
                if (k.NumerSeryjny == serialNum1)
                {
                    var index = Load.IndexOf(k);
                    Load.Remove(k);
                    Load.Insert(index, newContainer);
                    break;
                }
                else
                {
                    
                }
            }
        }
        public void MoveContainer(Ship targetShip, int serialNumber)
        {
            Kontener kontener = null;

            foreach (Kontener k in Load)
            {
                if (k.NumerSeryjny == serialNumber)
                {
                    kontener = k;
                }
            }

            if (kontener == null)
            {
                throw new Exception("container is null");
            }
            
            
            this.RemoveContainer(serialNumber);

            
            targetShip.AddContainer(kontener);
        }
        public void ShowShipContent()
        {
            foreach(Kontener k in Load)
            {
                Console.WriteLine(k);
            }
        }
        public override string ToString()
        {
            return $"Ship {SerialNumber} details\nVmax: {MaxVelocity} wezlow\nMax load: {MaxLoad} kontenery\nMaksymalna waga wszystkich kontenerow: {MaxWeight}\n";
        }



    }
}
