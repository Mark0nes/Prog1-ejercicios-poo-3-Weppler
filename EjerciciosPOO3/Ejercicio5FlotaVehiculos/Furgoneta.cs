namespace Ejercicio5FlotaVehiculos;

public class Furgoneta : Vehiculo
{
    public double VolumenCarga { get; set; }

    public Furgoneta(string patente, int anioFabricacion, int estado, double volumenCarga)
        : base(patente, anioFabricacion, estado)
    {
        VolumenCarga = volumenCarga;
    }

    public override string ObtenerInformacion()
    {
        return $"{base.ObtenerInformacion()} - Volumen de Carga: {VolumenCarga} m³";
    }
}