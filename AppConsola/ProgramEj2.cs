using Ejercicio2Bebidas;

EjercicioBebidas();
static void EjercicioBebidas()
{
    List<Bebida> bebidas = new List<Bebida>();

    Agua agua1 = new Agua("Villavicencio", 50.0, true);
    Cafe cafe1 = new Cafe("Nescafé", 80.0, true);
    Jugo jugo1 = new Jugo("Cepita", 60.0, "Naranja");
    Bebida bebida1 = new Bebida("Bebida Genérica", 30.0);

    bebidas.Add(agua1);
    bebidas.Add(cafe1);
    bebidas.Add(jugo1);
    bebidas.Add(bebida1);

    foreach (var bebida in bebidas)
    {
        Console.WriteLine($"{bebida.MostrarPrecio()} - {bebida.Preparar()}");
    }
}