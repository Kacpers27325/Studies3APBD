using ConsoleApp1;

namespace DefaultNamespace;

public class CoolingContainer : Kontener, IHazardnotifier
{
    public double temp;
    public string kind;
    private int numer =  1;
    public CoolingContainer(double temp, string kind, int masa_ladunku, int wysokosc, int waga_wlasna, int glebokosc, string nume_seryjny, double max_ladownosc) : base(masa_ladunku, wysokosc, waga_wlasna, glebokosc, max_ladownosc)
    {
        this.temp = temp;
        this.kind = kind;
        this.Numer_seryjny = "KON-C-"+numer++;
    }

    public void zaladuj(int ile, int temperatura_produktu, string rodzaj_produktu)
    {
        if (temp >= temperatura_produktu)
        {
            if (rodzaj_produktu.Equals(kind))
            {
                base.zaladuj(ile);     
            }
            else
            {
                Console.WriteLine("Rozne rodzaje kontenerow");
            }
        }
        else
        {
            Console.WriteLine("Zbyt niska temperatura kontenera");
        }
    }

    public override void oproznij()
    {
        double mass = Masa_ladunku;
        base.oproznij();
    }

    public void notify()
    {
        throw new OverfillException("Kontener przeladowany: "+ Numer_seryjny);
    }
}