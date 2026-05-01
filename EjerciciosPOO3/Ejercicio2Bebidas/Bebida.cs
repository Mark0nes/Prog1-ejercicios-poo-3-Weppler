namespace Ejercicio2Bebidas;

abstract class Bebida
{
    public string Nombre {get;set;}
    public decimal Precio {get;set;}

    virtual Bebida(string nombre, decimal precio)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre no puede estar vacío.");
        if (precio < 0)
            throw new ArgumentException("El precio no puede ser negativo.");
        Nombre = nombre;
        Precio = precio;
    }
    abstract string Preparar();
    virtual string MostrarPrecio()
    {
        return "{Nombre}: ${Precio:F2}";
    }
}