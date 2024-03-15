namespace DefaultNamespace;

public class Kontener
{
    private int masa;
    private int wysokosc;
    private int waga_wlasna;
    private int glebokosc;
    private string numer_seryjny;
    private int max_ladownosc;

    public Kontener(int masa, int wysokosc, int waga_wlasna, int glebokosc, string nume_seryjny, int max_ladownosc)
    {
        masa = masa;
        wysokosc = wysokosc;
        waga_wlasna = waga_wlasna;
        glebokosc = glebokosc;
        nume_seryjny = nume_seryjny;
        max_ladownosc = max_ladownosc;
    }
    
}