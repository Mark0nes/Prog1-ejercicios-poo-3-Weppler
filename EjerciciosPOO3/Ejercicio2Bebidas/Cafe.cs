namespace Ejercicio2Bebidas;

class Cafe : Bebida
{
    public bool TieneLeche {get;set;}

    public Cafe(string nombre, decimal precio, bool tieneLeche) : base(nombre, precio)
    {
        TieneLeche = tieneLeche;
    }

    public override string Preparar()
    {
        if (TieneLeche)
        {
            return $"Preparando {Nombre} con leche.";
        }
        else
        {
            return $"Preparando {Nombre} sin leche.";
        }
    }
}