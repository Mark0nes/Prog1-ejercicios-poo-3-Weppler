namespace Ejercicio4ProductosServicios
{
    public class Producto : IDescribible
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }

        public Producto(string nombre, decimal precio, string categoria)
        {
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }

        public string ObtenerDescripcion()
        {
            return $"Producto: {Nombre} | Categoría: {Categoria} | Precio: ${Precio:F2}";
        }
    }
}