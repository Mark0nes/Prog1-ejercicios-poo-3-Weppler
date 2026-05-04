using Ejercicio6Empleados;

EjercicioEmpleados();
static void EjercicioEmpleados()
{
    RecursosHumanos recursosHumanos = new RecursosHumanos();

    recursosHumanos.AgregarEmpleado(new EmpleadoPermanente("Juan", 1, 200000, 5));
    recursosHumanos.AgregarEmpleado(new EmpleadoContratado("María", 2, 100000, 4));
    recursosHumanos.AgregarEmpleado(new EmpleadoPasante("Pedro", 3, 150000));
    recursosHumanos.AgregarEmpleado(new EmpleadoPasante("Ana", 4, 150000));

    Console.WriteLine($"Nomina total: {recursosHumanos.CalcularNomina()}");
    Console.WriteLine($"Mejor pago: {recursosHumanos.ObtenerMejorPago().CalcularPago()} ({recursosHumanos.ObtenerMejorPago().Nombre})");
    List<EmpleadoPasante> pasantes = recursosHumanos.ListarPorTipo(TipoEmpleado.Pasante);
    foreach (var pasante in pasantes)
    {
        Console.WriteLine($"Pasante: {pasante.Nombre} ({pasante.Legajo}), Beca: {pasante.Beca}");
    }
}