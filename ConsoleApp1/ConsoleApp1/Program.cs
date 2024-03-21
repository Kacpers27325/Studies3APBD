
using System.Security.AccessControl;
using System.Security.Cryptography;
using DefaultNamespace;


LiquidContainer liquidone= new LiquidContainer(30,10,
    200, 2,"DDD1",3000,false );
liquidone.zaladuj(2470);

Console.WriteLine(liquidone.ToString());


GasContainer gasone = new GasContainer(100, 500, 1000, 900, "KON-1-G", 5000);

Console.WriteLine();
gasone.zaladuj(3900);
Console.WriteLine(gasone.ToString());
gasone.oproznij();
Console.WriteLine();
Console.WriteLine(gasone.ToString());


