namespace Ejercicio6Empleados;

public class RecursosHumanos
{
    private List<Empleado> empleados = new List<Empleado>();

    public void AgregarEmpleado(Empleado empleado)
    {
        foreach (var emp in empleados)
        {
            if (emp.Legajo == empleado.Legajo)
                throw new ArgumentException("El legajo ingresado ya existe.");
        }
        empleados.Add(empleado);
    }

    public decimal CalcularNomina()
    {
        if (empleados.Count == 0)
            throw new InvalidOperationException("No hay empleados registrados.");
        return empleados.Sum(e => e.CalcularSueldo());
    }

    public Empleado ObtenerMejorPago()
    {
        if (empleados.Count == 0)
            throw new InvalidOperationException("No hay empleados registrados.");

        return empleados.OrderByDescending(e => e.CalcularSueldo()).First();
    }

    public List<Empleado> ListarPorTipo(TipoEmpleado tipo)
    {
        if (empleados.Count == 0)
            throw new InvalidOperationException("No hay empleados registrados.");
        return empleados.Where(e => e.Tipo == tipo).ToList();
    }
}