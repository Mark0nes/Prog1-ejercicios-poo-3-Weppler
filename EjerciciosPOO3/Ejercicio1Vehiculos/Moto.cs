namespace EjerciciosPOO3.Ejercicio1Vehiculo;

public class Moto : Vehiculo 
{
    public bool TieneSidecar;

    public Moto(bool tieneSidecar)
    {
        TieneSidecar = tieneSidecar;

    }

    public string Describir()
    {
        if (tieneSidecar)
        {
            return $" - con sidecar";
        } else
        {
            return $" - sin sidecar";
        }
    }
}