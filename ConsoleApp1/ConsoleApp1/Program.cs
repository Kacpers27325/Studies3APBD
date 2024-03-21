
using System.Security.AccessControl;
using System.Security.Cryptography;
using ConsoleApp1;
using DefaultNamespace;


LiquidContainer liquidone= new LiquidContainer(30,10,
    200, 2,"DDD1",3000,false );
liquidone.zaladuj(2470);

Console.WriteLine(liquidone.ToString());


GasContainer gasone = new GasContainer(100, 500, 1000, 900, 5000);
GasContainer gasonee = new GasContainer(100, 500, 1000, 900, 5000);


Console.WriteLine("AAAAA");
Console.WriteLine(gasonee.ToString());
Console.WriteLine();
gasone.zaladuj(3900);
Console.WriteLine(gasone.ToString());
gasone.oproznij();
Console.WriteLine();
Console.WriteLine(gasone.ToString());
Console.WriteLine();


CoolingContainer coolingContainer = new CoolingContainer(5, "Frytki", 1000, 1000,
    500, 500, "KON-1-C", 4000);

Console.WriteLine(coolingContainer);
Console.WriteLine();
coolingContainer.zaladuj(2500,4,"Frytki");


Ship ship = new Ship(5, 10, 10000);

ship.zaladuj(gasone);
ship.zaladuj(liquidone);
ship.zaladuj(gasone);

ship.wypiszKontenery();

Console.WriteLine();
ship.UsunKontenerZeStatku(gasone);
ship.wypiszKontenery();