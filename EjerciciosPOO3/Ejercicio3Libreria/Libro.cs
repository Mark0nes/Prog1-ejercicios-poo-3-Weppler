namespace Ejercicio3Libreria;

public class Libro : Publicacion
{
    public string Autor { get; set; }
    public int NumeroPaginas { get; set; }

    public Libro(string titulo, double precio, int anioPublicacion, string autor, int numeroPaginas)
        : base(titulo, precio, anioPublicacion)
    {
        if (string.IsNullOrWhiteSpace(autor))
            throw new ArgumentException("El autor no puede estar vacío.");
        if (numeroPaginas <= 0)
            throw new ArgumentException("El número de páginas debe ser mayor que cero.");

        Autor = autor;
        NumeroPaginas = numeroPaginas;
    }

    public override string ObtenerInformacion()
    {
        return $"{base.ObtenerInformacion()} - Autor: {Autor}, Páginas: {NumeroPaginas}";
    }
}