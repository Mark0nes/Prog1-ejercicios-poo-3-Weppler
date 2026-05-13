using EjerciciosPOO3.Ejercicio1Vehiculos;

namespace TestEjerciciosPOO3;

[TestFixture]
public class TestsEjercicio1
{
    [Test]
    public void Test1()
    {
        Assert.Throws<ArgumentException>(()=>
        {
            Vehiculo vehiculo = new Vehiculo("","modelo",2009);
        });
    }

    [Test]
    public void Test2()
    {
        Assert.Throws<AnioException>(()=>
        {
            Vehiculo vehiculo = new Vehiculo("marca","modelo",1800);
        });
    }

    [Test]
    public void Test3()
    {
        Auto auto = new Auto("marca", "modelo", 2000, 4);
        string resultado = auto.Describir;

        Assert.That();
    }
}