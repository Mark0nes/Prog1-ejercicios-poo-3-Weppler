namespace Ejercicio4ProductosServicios
{
    public class Servicio : IDescribible
    {
        public string Nombre { get; set; }
        public decimal PrecioHora { get; set; }
        public int DuracionHora { get; set; }

        public Servicio(string nombre, decimal precioHora, int duracionHora)
        {
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