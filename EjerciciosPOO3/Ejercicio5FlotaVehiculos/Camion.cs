namespace Ejercicio5FlotaVehiculos;

public class Camion : Vehiculo
{
    public double CapacidadCarga { get; set; }

    public Camion(string patente, int anioFabricacion, int estado, double capacidadCarga)
        : base(patente, anioFabricacion, estado)
    {
        CapacidadCarga = capacidadCarga;
    }

    public override string ObtenerInformacion()
    {
        return $"{base.ObtenerInformacion()} - Capacidad de Carga: {CapacidadCarga} tons";
    }
}