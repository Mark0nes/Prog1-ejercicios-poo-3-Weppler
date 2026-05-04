namespace Ejercicio6Empleados;

public abstract class Empleado : ICalculableSueldo
{
    public string Nombre { get; set; }
    public string Legajo { get; set; }
    public TipoEmpleado Tipo { get; }

    public Empleado(string nombre, string legajo, TipoEmpleado tipo)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre no puede estar vacío.");
        if (string.IsNullOrWhiteSpace(legajo))
            throw new ArgumentException("El legajo no puede estar vacío.");
        if (tipo == null || tipo < 0 || tipo > 2)
            throw new ArgumentException("El tipo de empleado no es valido.");
        Nombre = nombre;
        Legajo = legajo;
        Tipo = tipo;
    }

    public abstract decimal CalcularSueldo();
}