namespace Ejercicio6Empleados;

public enum TipoEmpleado
{
    Permanente,
    Contratado,
    Pasante
}

public interface ICalculableSueldo
{
    decimal CalcularSueldo();
}
