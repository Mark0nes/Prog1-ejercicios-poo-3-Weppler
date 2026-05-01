namespace Ejercicio5FlotaVehiculos;
using System.Linq;

public class SistemaFlota
{
    public List<Vehiculo> flota = new List<Vehiculo>();

    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        foreach (var v in flota)
        {
            if (v.Patente == vehiculo.Patente)
                throw new ArgumentException("Ya existe un vehículo con esa patente.");
        }
        flota.Add(vehiculo);
    }

    public void CambiarEstado(string patente, int nuevoEstado)
    {
        if (patente.IsNullOrWhitespace())
            throw new ArgumentException("La patente no puede estar vacía.");
        if (nuevoEstado < 0 || nuevoEstado > 1)
            throw new ArgumentException("El estado debe ser 0 (Activo) o 1 (En Mantenimiento).");
        foreach (var vehiculo in flota)
        {
            if (vehiculo.Patente == patente)
            {
                vehiculo.Estado = (Estado)nuevoEstado;
                break;
            }
        }
    }

    public List<Vehiculo> MostrarVehiculosActivos()
    {
        return flota.Where(v => v.Estado == (int)Estado.Activo).ToList();
    }

    public Camion ObtenerCamionConMayorCapacidad()
    {
        return flota.OfType<Camion>().OrderByDescending(c => c.CapacidadCarga).FirstOrDefault();
    }

}