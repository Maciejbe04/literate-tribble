using ConsoleApp1;

//object creation
var kontener1 = new GasContainer(30, 2, 2, 2, 202, 300, "Hel");

var kontener2 = new LiquidContainer(10, 2, 2, 2, 922, "Niebezpieczny", "paliwo");

var kontener3 = new GasContainer(30, 2, 2, 2, 202, 300, "tlen");

var kontener4 = new GasContainer(10, 2, 2, 2, 922, 350, "azot");


var kontener5 = new CoolingContainer(10, 2, 2, 2, 922, 350, "banan",30);



var list = new List<Kontener> { kontener1, kontener2, kontener3, kontener4 };

var list2 = new List<Kontener> { kontener1, kontener2, kontener3, kontener4, kontener5 };


var ship = new Ship(list2, 20, 5, 40);
var ship2 = new Ship(list, 25,5,40);


//czesc podstawowa

//container functionality
kontener2.Notify("zagrozenie o powodzi");
kontener3.FillContainer();
Console.WriteLine(kontener3);
Console.WriteLine();
kontener3.EmptyLoad();
Console.WriteLine(kontener3);




//ship functionality
ship.ShowShipContent();
ship.RemoveContainer(0);
Console.WriteLine();
ship.ShowShipContent();
Console.WriteLine();
var kontener6 = new GasContainer(2, 2, 2, 2, 2, 2, "butan");
ship.ReplaceContainer(2, kontener6);
ship.ShowShipContent();
Console.WriteLine(ship);  //ship details
ship.MoveContainer(ship2, 4);


Console.WriteLine("ship1\n");
ship.ShowShipContent();
Console.WriteLine("ship2\n");
ship2.ShowShipContent();







//częsc dla chetnych


//var kontenerowce = new List<Ship>();
//var kontenery = new List<Kontener>();


//while (true)
//{
//    var lista = new List<Kontener>();
//    Console.Clear();
//    Console.WriteLine("Lista kontenerowcow");
//    foreach(Ship s in kontenerowce)
//    {
//        Console.WriteLine(s);
//    }
//    Console.WriteLine("Lista Kontenerow");
//    foreach(Kontener k in kontenery)
//    {
//        Console.WriteLine(k);
//    }

//    if (kontenery.Count == 0)
//    {
//        Console.WriteLine(""""
//        Mozliwe akcje: 
//        1.Dodaj Kontenerowiec
//        2.Usun Kontenerowiec
//        3.Dodaj Kontener
//        """");
//    }
//    else if (kontenery.Count != 0)
//    {
//        Console.WriteLine(""""
//        Mozliwe akcje: 
//        1.Dodaj Kontenerowiec
//        2.Usun Kontenerowiec
//        3.Dodaj Kontener
//        4.Usun Kontener
//        5.Umiesc Kontener na statku
//        """");
//    }
//        var choice = Convert.ToInt32(Console.ReadLine());
//    if (choice.Equals(1))
//    {
//        Console.WriteLine("select speed");
//        var speed = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("select load");
//        var maxLoad = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Select max Weight of containers");
//        var maxWeight = Convert.ToInt32(Console.ReadLine());
//        var ship1 = new Ship(lista,speed,maxLoad,maxWeight);
//        kontenerowce.Add(ship1);
//    }
//    else if (choice.Equals(2))
//    {
//        var whichOne = Convert.ToInt32(Console.ReadLine());

//        for (int i = 0; i < kontenerowce.Count; i++)
//            {
//                if (kontenerowce[i].SerialNumber == whichOne)
//                {
//                    kontenerowce.Remove(kontenerowce[i]);
//                }
//            }
        
//    }
//    else if (choice.Equals(3))
//    {
//        Console.WriteLine("select cargo Weight");
//        var cargo = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("select height of container");
//        var height = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Select weight of container");
//        var ownWeight = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Select max depth of container");
//        var depth = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Select max weight of container");
//        var weight = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Select type of cargo");
//        var prod = Console.ReadLine();
//        Console.WriteLine("Select container type (single letter)");
//        var containerType = Console.ReadLine();
//        if (containerType.ToLower().Equals("g"))
//        {
//            Console.WriteLine("Select max pressure of container");
//            var maxPressure = Convert.ToInt32(Console.ReadLine());
//            var kontener = new GasContainer(cargo, height, ownWeight, depth, weight,maxPressure, prod);
//            kontenery.Add(kontener);

//        }
//        else if (containerType.ToLower().Equals("l")){
//            Console.WriteLine("Is it dangerous load or safe");
//            var isDangerous = Console.ReadLine();
//            var kontener = new LiquidContainer(cargo, height, ownWeight, depth, weight, isDangerous, prod);
//            kontenery.Add(kontener);
//        }
//        else if (containerType.ToLower().Equals("c"))
//        {
//            Console.WriteLine("Select max temperature in container");
//            var temp = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Select temp for product");
//            var tempProd = Convert.ToDouble(Console.ReadLine());
//            var kontener = new CoolingContainer(cargo, height, ownWeight, depth, weight, temp, prod,tempProd);
//            kontenery.Add(kontener);
//        }
        
        
//    }
//    else if (choice.Equals(4) && kontenery.Count != 0)
//    {
//        var whichOne = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < kontenery.Count; i++)
//        {
//            if (kontenery[i].NumerSeryjny == whichOne)
//            {
//                kontenery.Remove(kontenery[i]);
//            }
//        }

//    }
//    else if (choice.Equals(5) && kontenery.Count != 0)
//    {
//        Console.WriteLine("Which container whould u like to choose");
//        var container = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("On which ship would u like to place the container");
//        var shipSelect = Convert.ToInt32(Console.ReadLine());
//        foreach (Kontener k in kontenery)
//        {
//            if(k.NumerSeryjny == container)
//            {
//                lista.Add(k);
//            }
//        }



//    }
//    //tu dalej juz mi sie nie chcialo 


//}









