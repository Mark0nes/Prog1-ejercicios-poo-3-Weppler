namespace EjerciciosPOO3.Ejercicio1Vehiculos;

public class Moto : Vehiculo 
{
    public bool TieneSidecar;

    public Moto(string marca, string modelo, int anio, bool tieneSidecar)
        : base(marca, modelo, anio)
    {
        TieneSidecar = tieneSidecar;
    }

    public override string Describir()
    {
        return base.Describir() + (TieneSidecar ? " - con sidecar" : " - sin sidecar");
    }
}