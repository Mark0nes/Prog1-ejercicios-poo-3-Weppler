namespace Ejercicio4ProductosServicios
{
    public class Producto : IDescribible
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }

        public Producto(string nombre, decimal precio, string categoria)
        {
            if (nombre.IsNullOrWhiteSpace())
                throw new ArgumentException("El nombre del producto no puede estar vacío.");
            if (precio < 0)
                throw new ArgumentException("El precio del producto no puede ser negativo.");
            if (categoria.IsNullOrWhiteSpace())
                throw new ArgumentException("La categoría del producto no puede estar vacía.");

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