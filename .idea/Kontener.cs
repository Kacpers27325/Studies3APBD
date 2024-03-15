namespace DefaultNamespace;

public class Kontener
{
    private int masa_ladunku;
    private int wysokosc;
    private int waga_wlasna;
    private int glebokosc;
    private string numer_seryjny;
    private int max_ladownosc;

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