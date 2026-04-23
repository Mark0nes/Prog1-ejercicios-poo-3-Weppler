namespace EjerciciosPOO3.Ejercicio1Vehiculos;

public class Auto : Vehiculo
{
    public int CantidadPuertas { get; set; }

    public Auto(string marca, string modelo, int anio, int cantidadPuertas)
        : base(marca, modelo, anio)
    {
        CantidadPuertas = cantidadPuertas;
    }

    public override string Describir()
    {
        return base.Describir() + $" - {CantidadPuertas} puertas";
    }
}