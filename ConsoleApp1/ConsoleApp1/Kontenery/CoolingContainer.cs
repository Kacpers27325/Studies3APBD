using ConsoleApp1;

namespace DefaultNamespace;

public class CoolingContainer : Kontener, IHazardnotifier
{
    public double temp;
    public string kind;
    public CoolingContainer(double temp, string kind, int masa_ladunku, int wysokosc, int waga_wlasna, int glebokosc, string nume_seryjny, double max_ladownosc, bool niebezpieczny) : base(masa_ladunku, wysokosc, waga_wlasna, glebokosc, nume_seryjny, max_ladownosc)
    {
        temp = temp;
        kind = kind;
    }

    public void zaladuj(int ile, int temperatura_produktu)
    {
        if (temp > temperatura_produktu)
        {
            base.zaladuj(ile);    
        }
        else
        {
            
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
        throw new NotImplementedException();
    }
}