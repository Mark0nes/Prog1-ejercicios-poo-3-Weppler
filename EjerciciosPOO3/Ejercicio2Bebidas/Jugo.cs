namespace Ejercicio2Bebidas;

class Jugo : Bebida
{
    public string Fruta {get;set;}

    public Jugo(string nombre, decimal precio, string fruta) : base(nombre, precio)
    {
        if (string.IsNullOrWhiteSpace(fruta))
            throw new ArgumentException("La fruta no puede estar vacía.");
        Fruta = fruta;
    }

    public override string Preparar()
    {
        return $"Preparando {Nombre} de {Fruta}.";
    }
}