namespace DefaultNamespace;

public abstract class Kontener
{
    public int Masa_ladunku { get;set; }
    public int Wysokosc { get;set; }
    public int Waga_wlasna { get;set; }
    public int Glebokosc { get;set; }
    public string Numer_seryjny { get;set; }
    public double max_ladownosc { get;set; }
    public bool niebezpieczny { get; set; }

    
    public Kontener(int masa_ladunku, int wysokosc, int waga_wlasna, int glebokosc, string nume_seryjny, double max_ladownosc)
    {
        this.niebezpieczny = niebezpieczny;
        this.Masa_ladunku = masa_ladunku;
        this.Wysokosc = wysokosc;
        this.Waga_wlasna = waga_wlasna;
        this.Glebokosc = glebokosc;
        this.Numer_seryjny = nume_seryjny;
        this.max_ladownosc = max_ladownosc;
    }

    public virtual void oproznij()
    {
        Masa_ladunku=0;
    }

    public virtual void zaladuj(int ile)
    {
        if (Masa_ladunku + Waga_wlasna + ile <= max_ladownosc)
        {
            Masa_ladunku = Masa_ladunku + ile;
        }
        else
        {
            throw new Exception("OverfillException "+Numer_seryjny);
        }
    }
    public override string ToString()
    {
        return "Kontener numer: "+Numer_seryjny + "\nMasa ladunku " + Masa_ladunku
            +"\nNiebezpieczny: "+niebezpieczny + "\nGlebokosc "+Glebokosc
            +"\nWaga wlasna: "+Waga_wlasna+"\nMax ladownosc: "+max_ladownosc
            +"\nWysokosc: "+Wysokosc;
    }
    
}