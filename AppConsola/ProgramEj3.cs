using Ejercicio3Libreria;
using System.Diagnostics.Contracts;
using System.Linq;

Ejercicio3Libreria();
static void EjercicioLibreria()
{
    List<Publicacion> publicaciones = new List<Publicacion>();

    Libro libro1 = new Libro("El Quijote", 19.99, 1605, "Miguel de Cervantes");
    Libro libro2 = new Libro("Cell", 9.99, 2011, "Stephen King");
    Revista revista1 = new Revista("National Geographic", 15.99, 2023, 120, Periodicidad.Mensual);
    Revista revista2 = new Revista("Videogames X", 12.99, 2025, 80, Periodicidad.Semanal);
    Publicacion publicacion1 = new Publicacion("Publicación Genérica", 10.99, 2020);
    publicaciones.Add(libro1);
    publicaciones.Add(libro2);
    publicaciones.Add(revista1);
    publicaciones.Add(revista2);
    publicaciones.Add(publicacion1);
    publicaciones.OrderByDescending(l => l.Precio).ToList();
    List<Libro> libros = publicaciones.OfType<Libro>().ToList();
    foreach (var publicacion in publicaciones)
    {
        Console.WriteLine(publicacion.ObtenerInformacion());
    }
    foreach (var libro in libros)
    {
        Console.WriteLine(libro.ObtenerInformacion());
    }
}

try
{
    Publicacion publicacionPrueba = new Publicacion("publicacion", -5.99, 2020);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error al crear la publicación: {ex.Message}");
}