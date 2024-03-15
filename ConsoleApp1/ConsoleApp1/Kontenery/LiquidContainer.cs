using ConsoleApp1;

namespace DefaultNamespace;

public class LiquidContainer : Kontener, IHazardnotifier
{
    public LiquidContainer(int masa_ladunku, int wysokosc, int waga_wlasna, int glebokosc, string nume_seryjny, double max_ladownosc, bool niebezpieczny) : base(masa_ladunku, wysokosc, waga_wlasna, glebokosc, nume_seryjny, max_ladownosc, niebezpieczny)
    {
    }

    public override void zaladuj(int ile)
    {
        if (niebezpieczny == true)
        {
            max_ladownosc = max_ladownosc / 2;
        }
        else
        {
            max_ladownosc = max_ladownosc*0.9;
        }
        
        if (Masa_ladunku + ile <= max_ladownosc)
        {
            Masa_ladunku = Masa_ladunku + ile;
        }
        else
        {
            notify();
            throw new Exception("OverfillException");
        }
    }

    public override void oproznij()
    {
        Masa_ladunku=0;
    }
    
    public void notify()
    {
        throw new NotImplementedException();
    }
}