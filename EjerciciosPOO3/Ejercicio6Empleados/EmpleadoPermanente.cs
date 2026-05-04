namespace Ejercicio6Empleados;

public class EmpleadoPermanente : Empleado
{
    public decimal SueldoBase { get; set; }
    public int AñosAntiguedad { get; set; }

    public EmpleadoPermanente(string nombre, string legajo, decimal sueldoBase, int añosAntiguedad)
        : base(nombre, legajo, TipoEmpleado.Permanente)
    {
        if (sueldoBase <= 0)
            throw new ArgumentException("El sueldo base debe ser mayor a cero.");
        if (añosAntiguedad < 0)
            throw new ArgumentException("Los años de antigüedad no pueden ser negativos.");
        SueldoBase = sueldoBase;
        AñosAntiguedad = añosAntiguedad;
    }

    public override decimal CalcularSueldo()
    {
        return SueldoBase + (SueldoBase * 0.05m * AñosAntiguedad);
    }
}