namespace Ejercicio6Empleados;

public class EmpleadoPasante : Empleado
{
    public decimal Beca { get; set; }

    public EmpleadoPasante(string nombre, string legajo, decimal beca)
        : base(nombre, legajo, TipoEmpleado.Pasante)
    {
        if (beca <= 0)
            throw new ArgumentException("La beca debe ser mayor a cero.");
        Beca = beca;
    }

    public override decimal CalcularSueldo()
    {
        return Beca;
    }
}