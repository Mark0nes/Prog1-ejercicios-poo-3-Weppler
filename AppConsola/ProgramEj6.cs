using Ejercicio6Empleados;

EjercicioEmpleados();
static void EjercicioEmpleados()
{
    RecursosHumanos recursosHumanos = new RecursosHumanos();

    recursosHumanos.AgregarEmpleado(new Empleado("Juan", 1, TipoEmpleado.Permanente, 200000, 5));
    recursosHumanos.AgregarEmpleado(new Empleado("María", 2, TipoEmpleado.Contratado, 100000, 4));
    recursosHumanos.AgregarEmpleado(new Empleado("Pedro", 3, TipoEmpleado.Pasante, 150000));
    recursosHumanos.AgregarEmpleado(new Empleado("Ana", 4, TipoEmpleado.Pasante, 150000));

    Console.WriteLine($"Nomina total: {recursosHumanos.CalcularNomina()}");
    Console.WriteLine($"Mejor pago: {recursosHumanos.ObtenerMejorPago().CalcularPago()} ({recursosHumanos.ObtenerMejorPago().Nombre})");
    List<EmpleadoPasante> pasantes = recursosHumanos.ListarPorTipo(TipoEmpleado.Pasante);
    foreach (var pasante in pasantes)
    {
        Console.WriteLine($"Pasante: {pasante.Nombre} ({pasante.Legajo}), Beca: {pasante.Beca}");
    }
}