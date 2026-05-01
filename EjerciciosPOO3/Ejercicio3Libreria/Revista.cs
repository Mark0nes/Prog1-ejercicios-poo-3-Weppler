namespace Ejercicio3Libreria;

public enum Periodicidad
{
    Semanal = 7,
    Qincenal = 15,
    Mensual = 30
}
public class Revista : Publicacion
{
    public int NumeroEdicion { get; set; }
    public string Periodicidad { get; set; }

    public Revista(string titulo, double precio, int anioPublicacion, int numeroEdicion, Periodicidad periodicidad)
        : base(titulo, precio, anioPublicacion)
    {
        if (string.IsNullOrWhiteSpace(periodicidad.ToString()))
            throw new ArgumentException("La periodicidad no puede estar vacía.");
        if (numeroEdicion <= 0)
            throw new ArgumentException("El número de edición debe ser mayor que cero.");

        NumeroEdicion = numeroEdicion;
        Periodicidad = periodicidad.ToString();
    }

    public override string ObtenerInformacion()
    {
        return $"{base.ObtenerInformacion()} - Edición: {NumeroEdicion}, Periodicidad: {Periodicidad}";
    }
}