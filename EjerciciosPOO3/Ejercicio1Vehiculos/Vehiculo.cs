namespace EjerciciosPOO3.Ejercicio1Vehiculo;

public class Vehiculo
{
    public string Marca {get; set;}
    public string Modelo {get; set;}
    public int Anio {get; set;}

    public Vehiculo(string marca, string modelo, int anio)
    {
        Marca=marca;
        Modelo=modelo;

        if (anio < 1900)
            throw new AnioException(anio);
        
    }

    public string Describir()
    {
        return $"{Marca} {Modelo} ({Anio})";
    }
}