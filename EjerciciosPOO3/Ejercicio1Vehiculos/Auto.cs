namespace EjerciciosPOO3.Ejercicio1Vehiculo;

public class Auto : Vehiculo
{
    public int CantidadPuertas{get; set;}

    public override string Describir()
    {
        return $" - {CantidadPuertas} puertas" ;
    }
}