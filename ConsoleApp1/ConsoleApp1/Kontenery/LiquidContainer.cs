using ConsoleApp1;

namespace DefaultNamespace;

public class LiquidContainer : Kontener, IHazardnotifier
{
    public bool niebezpieczny;
    private int numer = 1;
    public LiquidContainer(int masa_ladunku, int wysokosc, int waga_wlasna, int glebokosc, string nume_seryjny, double max_ladownosc, bool niebezpieczny) : base(masa_ladunku, wysokosc, waga_wlasna, glebokosc, max_ladownosc)
    {
        this.niebezpieczny = niebezpieczny;
        this.Numer_seryjny = "KON-L-"+numer++;
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
        
        if (Masa_ladunku + ile + Waga_wlasna <= max_ladownosc)
        {
            Masa_ladunku = Masa_ladunku + ile;
        }
        else
        {
            notify();
            throw new OverfillException("Nie mozna zaladować");
        }
    }
    
    

    public override void oproznij()
    {
        Masa_ladunku=0;
    }
    
    public void notify()
    {
        throw new OverfillException("Niebezpieczna sytuacja w kontenerze "+Numer_seryjny);
    }
    public override string ToString()
    {
        return "Kontener numer: "+Numer_seryjny + "\nMasa ladunku " + Masa_ladunku
               +"\nNiebezpieczny: "+niebezpieczny + "\nGlebokosc "+Glebokosc
               +"\nWaga wlasna: "+Waga_wlasna+"\nMax ladownosc: "+max_ladownosc
               +"\nWysokosc: "+Wysokosc;
    }
}