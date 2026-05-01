namespace Ejercicio5FlotaVehiculos;
public enum Estado
{
    Activo,
    EnMantenimiento
}
public class Vehiculo
{
    public string Patente { get; set; }
    public int AnioFabricacion { get; set; }
    public int Estado { get; set; }

    public Vehiculo(string patente, int anioFabricacion, int estado)
    {
        Patente = patente;
        AnioFabricacion = anioFabricacion;
        Estado = (Estado)estado;
    }
    public virtual string ObtenerInformacion()
    {
        return $"{Patente} ({AnioFabricacion}) - Estado: {Estado}";
    }
}
