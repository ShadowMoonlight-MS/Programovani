# Dědičnost

 Dědičnost je klíčovým principem objektově orientovaného programování (OOP), který umožňuje jedné třídě přebírat vlastnosti a metody jiné třídy. Tím vzniká hierarchie tříd, kde podřízená třída (nebo odvozená třída) dědí z nadřízené třídy (nebo bázové třídy). Díky tomu lze v odvozené třídě používat členy (proměnné, metody, vlastnosti) z bázové třídy, aniž bychom je museli znovu definovat. V C# se dědičnost implementuje pomocí dvojtečky `:`, kde specifikujeme, z jaké třídy chceme dědit.
 

```csharp
using System;

class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Speak();  // Zděděná metoda z Animal
        dog.Bark();   // Metoda specifická pro Dog
    }
}

```



``