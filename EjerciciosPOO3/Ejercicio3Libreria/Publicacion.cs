namespace Ejercicio3Libreria;

public abstract class Publicacion
{
    public string Titulo { get; set; }
    public double Precio { get; set; }
    public int AnioPublicacion { get; set; }

    public Publicacion(string titulo, double precio, int anioPublicacion)
    {
        if (string.IsNullOrWhiteSpace(titulo))
            throw new ArgumentException("El título no puede estar vacío.");
        if (precio < 0)
            throw new ArgumentException("El precio no puede ser negativo.");
        if (anioPublicacion < 0)
            throw new ArgumentException("El año de publicación no puede ser negativo.");

        Titulo = titulo;
        Precio = precio;
        AnioPublicacion = anioPublicacion;
    }

    public abstract string ObtenerInformacion()
    {
        return $"{Titulo} ({AnioPublicacion}) - {Precio:F2}$";
    }
}