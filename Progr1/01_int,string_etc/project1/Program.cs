using Microsoft.VisualBasic;
using System;
public class Auto
{
    public string vyrobce { get; set; }
    public int rokvyroby { get; set; }
    public Auto(string vyrobce, int rokvyroby)
    {
        this.vyrobce = vyrobce;
        this.rokvyroby = rokvyroby;
    }
    public void info()
    {
        Console.WriteLine("Auto " + vyrobce + "rok " + rokvyroby);
    }
    public void Zadej(string vyrobce)
    {
        this.vyrobce = vyrobce;
    }
    public string vyzvedni()
    {
        return vyrobce;
    }
}
class Program
{
    static void Main(string[] args)
    {
       Auto car = new Auto("škoda", 1999);
        Console.WriteLine(car.vyrobce);
        car.info();
        car.Zadej("Škoda");
        Console.WriteLine(car.vyzvedni());
    }
}
