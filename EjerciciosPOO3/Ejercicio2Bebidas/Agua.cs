namespace Ejercicio2Bebidas;

public class Agua : Bebida
{
    public bool ConGas { get; set; }

    public Agua(string marca, double precio, bool conGas) : base(marca, precio)
    {
        ConGas = conGas;
    }

    public override string Preparar()
    {
        if (ConGas)
        {
            return $"Sirviendo agua con gas.";
        }
        else
        {
            return $"Sirviendo agua sin gas.";
        }
    }
}