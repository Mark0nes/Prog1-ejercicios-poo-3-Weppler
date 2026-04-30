using EjerciciosPOO3.Ejercicio1Vehiculos;

Ejerciciovehiculos();
static void Ejerciciovehiculos()
{
    List<Vehiculo> vehiculos  = new List<Vehiculo>();

    Auto auto1 = new Auto("Chevrolet", "Celta", 2014, 4);
    Auto auto2 = new Auto("Baic", "BJ30", 2026, 2);
    Moto moto1 = new Moto("Gilera", "Smash", 2026, false);
    Moto moto2 = new Moto("Yamaha", "Tornado", 1990, true);
    Vehiculo vehiculo1 = new Vehiculo("Nissan", "Gt", 2070);
    vehiculos.Add(auto1);
    vehiculos.Add(auto2);
    vehiculos.Add(moto1);
    vehiculos.Add(moto2);
    vehiculos.Add(vehiculo1);
    foreach (var vehiculo in vehiculos)
    {
        Console.WriteLine(vehiculo.Describir());
    }
}

try
{
    Vehiculo vehiculoPrueba = new Vehiculo("Prueba", "", 1820);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (AnioExeption ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}