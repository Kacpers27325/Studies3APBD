namespace DefaultNamespace;

public class Kontener
{
    public int Masa_ladunku { get;set; }
    public int Wysokosc { get;set; }
    public int Waga_wlasna { get;set; }
    public int Glebokosc { get;set; }
    public string Numer_seryjny { get;set; }
    public int max_ladownosc { get;set; }

    
    public Kontener(int masa_ladunku, int wysokosc, int waga_wlasna, int glebokosc, string nume_seryjny, int max_ladownosc)
    {
        masa_ladunku = masa_ladunku;
        wysokosc = wysokosc;
        waga_wlasna = waga_wlasna;
        glebokosc = glebokosc;
        nume_seryjny = nume_seryjny;
        max_ladownosc = max_ladownosc;
    }

    public void oproznij
    {
        masa=0;
    }

    public void zaladuj(int ile)
    {
        if (masa + ile <= max_ladownosc)
        {
            masa = masa + ile;
        }
        else
        {
            throw new Exception()
            {
                Console.WriteLine("OverFillException");
            }
        }
    }
}