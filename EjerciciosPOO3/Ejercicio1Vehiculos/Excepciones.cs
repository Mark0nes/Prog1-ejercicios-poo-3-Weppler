namespace EjerciciosPOO3.Ejercicio1Vehiculos;

public class AnioException : Exception
{
    public int Anio {get;}

    public AnioException(int anio) :base ($"El año del vehiculo {anio} no es valido, debe ser mayor a 1900")
    {
        Anio = anio;
    }
}