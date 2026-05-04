namespace Ejercicio6Empleados;

public class EmpleadoContratado : Empleado
{
    public decimal ValorHora { get; set; }
    public int HorasTrabajadas { get; set; }

    public EmpleadoContratado(string nombre, string legajo, decimal valorHora, int horasTrabajadas)
        : base(nombre, legajo, TipoEmpleado.Contratado)
    {
        if (valorHora <= 0)
            throw new ArgumentException("El valor por hora debe ser mayor a cero.");
        if (horasTrabajadas < 0)
            throw new ArgumentException("Las horas trabajadas no pueden ser negativas.");
        ValorHora = valorHora;
        HorasTrabajadas = horasTrabajadas;
    }

    public override decimal CalcularSueldo()
    {
        return ValorHora * HorasTrabajadas;
    }
}