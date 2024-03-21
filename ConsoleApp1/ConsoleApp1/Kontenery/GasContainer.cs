using ConsoleApp1;

namespace DefaultNamespace;

public class GasContainer : Kontener, IHazardnotifier
{
    public GasContainer(int masa_ladunku, int wysokosc, int waga_wlasna, int glebokosc, string nume_seryjny, double max_ladownosc) : base(masa_ladunku, wysokosc, waga_wlasna, glebokosc, nume_seryjny, max_ladownosc)
    {
    }

    public override void zaladuj(int ile)
    {
        if (Masa_ladunku + Waga_wlasna + ile <= max_ladownosc)
        {
            Masa_ladunku = Masa_ladunku + ile;
        }
        else
        {
            notify();
        }
    }

    public override void oproznij()
    {
        double mass = Masa_ladunku;
        base.oproznij();
        base.zaladuj((int)(mass*0.05));
    }

    public void notify()
    {
        throw new OverfillException("Zbyt pelny kontener: "+Numer_seryjny);
    }
}