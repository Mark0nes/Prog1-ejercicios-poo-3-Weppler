using Ejercicio5FlotaVehiculos;

Ejercicio5FlotaVehiculos();
static void Ejercicio5FlotaVehiculos()
{
    SistemaFlota sistema = new SistemaFlota();
    Console.WriteLine("Ingrese la operacion que desea realizar:");
    Console.WriteLine("1. Agregar vehículo");
    Console.WriteLine("2. Cambiar estado de un vehículo");
    Console.WriteLine("3. Mostrar vehículos activos");
    Console.WriteLine("4. Mostrar camión con mayor capacidad de carga");
    int input = Convert.ToInt32(Console.ReadLine());

    switch (input)
    {
        case 1:
            Console.WriteLine("Ingrese la patente del vehículo:");
            string patente = Console.ReadLine();
            Console.WriteLine("Ingrese el año de fabricación del vehículo:");
            int anioFabricacion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el estado del vehículo (0 para Activo, 1 para En Mantenimiento):");
            int estado = Convert.ToInt32(Console.ReadLine());
            Vehiculo nuevoVehiculo = new Vehiculo(patente, anioFabricacion, estado);
            sistema.AgregarVehiculo(nuevoVehiculo);
            break;
        case 2:
            Console.WriteLine("Ingrese la patente del vehículo cuyo estado desea cambiar:");
            string patenteCambio = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo estado del vehículo (0 para Activo, 1 para En Mantenimiento):");
            int nuevoEstado = Convert.ToInt32(Console.ReadLine());
            sistema.CambiarEstado(patenteCambio, nuevoEstado);
            break;
        case 3:
            foreach (var vehiculo in sistema.MostrarVehiculosActivos())
            {
                Console.WriteLine(vehiculo.ObtenerInformacion());
            }
            break;
        case 4:
            Camion camionMayorCapacidad = sistema.ObtenerCamionConMayorCapacidad();
            if (camionMayorCapacidad != null)
                Console.WriteLine($"{camionMayorCapacidad.ObtenerInformacion()}");
            else
                Console.WriteLine("No hay camiones en la flota.");
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}

try 
{
    SistemaFlota sistema = new SistemaFlota();
    sistema.AgregarVehiculo(new Vehiculo("ABC123", 2010, 0));
    sistema.AgregarVehiculo(new Vehiculo("ABC123", 2015, 1));
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}