using DefaultNamespace;

namespace ConsoleApp1;

public class Ship
{
    public int max_number { get; set; }
    public double max_speed { get; set; }
    public double max_weight { get; set; }
    public List<Kontener> lista_kontenerow;
    private double zaladowana_masa;

    public Ship(int maxNumber, double maxSpeed,double maxWeight)
    {
        max_number = maxNumber;
        max_speed = maxSpeed;
        max_weight = maxWeight;
    }

    public void zaladuj(Kontener k)
    {
        if (zaladowana_masa + k.Masa_ladunku < max_weight)
        {
            lista_kontenerow.Add(k);
            zaladowana_masa = zaladowana_masa + k.Masa_ladunku;

        }
    }
    public void Zaladuj(List<Kontener> listaKontenerow)
    {
        foreach (Kontener k in listaKontenerow)
        {
            if (zaladowana_masa + k.Masa_ladunku < max_weight)
            {
                listaKontenerow.Add(k);
                zaladowana_masa += k.Masa_ladunku;
            }
            else
            {
                Console.WriteLine("Przekroczono maksymalną wagę. Nie można załadować więcej kontenerów.");
                break; // Przerwij pętlę jeśli przekroczono maksymalną wagę
            }
        }
    }

    public void UsunKontenerZeStatku(Kontener k)
    {
        lista_kontenerow.Remove(k);
    }

    public void Zastap(Kontener s, Kontener n)
    {
        lista_kontenerow.Remove(s);
        lista_kontenerow.Add(n);
    }

    public void Przenies(Kontener n, Ship s)
    {
        s.zaladuj(n);
        UsunKontenerZeStatku(n);
    }









}