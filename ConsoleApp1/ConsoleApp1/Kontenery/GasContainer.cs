using ConsoleApp1;

namespace DefaultNamespace;

public class GasContainer : LiquidContainer, IHazardnotifier
{
    public GasContainer(int masa_ladunku, int wysokosc, int waga_wlasna, int glebokosc, string nume_seryjny, double max_ladownosc, bool niebezpieczny) : base(masa_ladunku, wysokosc, waga_wlasna, glebokosc, nume_seryjny, max_ladownosc, niebezpieczny)
    {
    }

    public override void zaladuj(int ile)
    {
        base.zaladuj(ile);
    }

    public override void oproznij()
    {
        double mass = Masa_ladunku;
        base.oproznij();
        base.zaladuj((int)(mass*0.05));
    }

    public void notify()
    {
        throw new NotImplementedException();
    }
}