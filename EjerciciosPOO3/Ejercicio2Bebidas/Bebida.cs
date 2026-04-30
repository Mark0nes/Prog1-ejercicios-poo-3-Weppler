namespace Ejercicio2Bebidas;

abstract class Bebida
{
    public string Nombre {get;set;}
    public decimal Precio {get;set;}

    abstract string Preparar()
    {
        
    }
    string MostrarPrecio()
    {
        
    }
}