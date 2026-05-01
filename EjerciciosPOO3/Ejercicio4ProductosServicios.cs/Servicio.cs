namespace Ejercicio4ProductosServicios
{
    public class Servicio : IDescribible
    {
        public string Nombre { get; set; }
        public decimal PrecioHora { get; set; }
        public int DuracionHora { get; set; }

        public Servicio(string nombre, decimal precioHora, int duracionHora)
        {
            if (nombre.IsNullOrWhiteSpace())
                throw new ArgumentException("El nombre del servicio no puede estar vacío.");
            if (precioHora < 0)
                throw new ArgumentException("El precio por hora del servicio no puede ser negativo.");
            if (duracionHora <= 0)
                throw new ArgumentException("La duración del servicio debe ser mayor a cero.");
            Nombre = nombre;
            PrecioHora = precioHora;
            DuracionHora = duracionHora;
        }

        public string ObtenerDescripcion()
        {
            return $"Servicio: {Nombre} | Duración: {DuracionHora}h | Total: ${PrecioHora * DuracionHora:F2}";
        }
    }
}