using ConsoleApp1;

namespace DefaultNamespace;

public class LiquidContainer : Kontener, IHazardnotifier
{
    public LiquidContainer(int masa_ladunku, int wysokosc, int waga_wlasna, int glebokosc, string nume_seryjny, int max_ladownosc, bool niebezpieczny) : base(masa_ladunku, wysokosc, waga_wlasna, glebokosc, nume_seryjny, max_ladownosc, niebezpieczny)
    {
    }

    public override void zaladuj(int a)
    {
        
        Console.WriteLine();
        base.zaladuj(a);
    }

    public void notify()
    {
        throw new NotImplementedException();
    }
}