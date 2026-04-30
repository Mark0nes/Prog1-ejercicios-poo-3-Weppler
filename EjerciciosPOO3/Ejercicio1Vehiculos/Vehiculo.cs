namespace EjerciciosPOO3.Ejercicio1Vehiculos;

public class Vehiculo
{
    public string Marca {get; set;}
    public string Modelo {get; set;}
    public int Anio {get; set;}

    public Vehiculo(string marca, string modelo, int anio)
    {
        if (marca.IsNullOrWhiteSpace || modelo.IsNullOrWhiteSpace)
            throw new ArgumentException("Ninguno de los datos ingresados pueden estar vacios");

        Marca=marca;
        Modelo=modelo;

        if (anio < 1900)
            throw new AnioException(anio);
        Anio = anio;
    }

    public virtual string Describir()
    {
        return $"{Marca} {Modelo} ({Anio})";
    }
}