using Ejercicio4ProductosServicios;
using System.Linq;

EjercicioProductosServivios();

static void EjercicioProductosServivios()
{
    List<IDescribible> items = new List<IDescribible>
    {
        new Producto("Laptop", 1500, "Electrónica"),
        new Producto("Zapatos", 80, "Calzado"),
        new Servicio("Reparación de PC", 50, 2),
        new Servicio("Lustrado de zapatos", 30, 1),
        new Servicio("Compañia de gaming", 100, 8)
    };

    foreach (var item in items)
    {
        Console.WriteLine(item.ObtenerDescripcion());
    }

    List<IDescribible> itemsFiltrados = items.Where(i => (i.ByType == typeof(Producto) && i.Precio > 500) || (i.ByType == typeof(Servicio) && i.PrecioHora*i.DuracionHora > 500)).ToList();

    foreach (var item in itemsFiltrados)
    {
        Console.WriteLine(item.ObtenerDescripcion());
    }
    
}