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



### `virtual` a `override`
V C# jsou klíčová slova `virtual` a `override` důležitá pro to, aby bylo možné přepsat metodu **bázové třídy** v **odvozené třídě**. Teď ti vysvětlím, proč je tam musíš mít a co přesně dělají.

### `virtual`
Klíčové slovo `virtual` se používá v **bázové třídě** (např. `Animal`), aby řeklo: "Tahle metoda může být přepsána v odvozených třídách." Pokud necháš metodu bez `virtual`, odvozené třídy nemohou tuto metodu změnit a budou muset používat její původní verzi.

**Příklad:**
V třídě `Animal` je metoda `Speak()` označena jako `virtual`, což znamená, že odvozené třídy jako `Dog` nebo `Cat` mají povolení tuto metodu přepsat vlastní verzí.

### `override`
Klíčové slovo `override` se používá v **odvozené třídě** (např. `Dog` a `Cat`), aby řeklo: "Tahle metoda nahrazuje (přepisuje) tu metodu, která byla označena jako `virtual` v bázové třídě." Když třída `Dog` přepíše metodu `Speak()`, nahradí tu verzi, která je v `Animal`, a použije svou vlastní implementaci.

**Příklad:**
V třídě `Dog` a `Cat` je metoda `Speak()` označena jako `override`, což znamená, že přepisuje původní verzi metody `Speak()` z třídy `Animal`. Takže když zavoláš `Speak()` u objektu typu `Dog`, použije se verze z `Dog`, nikoli z `Animal`.

### Proč to tam musí být?

Bez `virtual` v bázové třídě (`Animal`) nemůže odvozená třída (`Dog`, `Cat`) metodu přepsat. Pokud bys to zkusil bez `virtual`, dostal bys chybu.  
**Bez `override`** v odvozené třídě (`Dog`, `Cat`) bys vlastně nevytvářel novou verzi metody `Speak()`, ale psal bys novou metodu, což by vedlo k tomu, že by se volala původní verze metody z bázové třídy.

### Schrnutí:
- `virtual` v bázové třídě říká: "Tahle metoda může být přepsána."
- `override` v odvozené třídě říká: "Tahle metoda přepisuje metodu z bázové třídy."

Pokud bys neoznačil metodu v bázové třídě jako `virtual`, nemohl bys ji v odvozených třídách změnit (přepsat). A pokud bys v odvozené třídě nepoužil `override`, nemohl bys jasně říct, že má být původní metoda nahrazena.


```csharp
using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myAnimal.Speak();  // Výstup: Animal makes a sound.
        myDog.Speak();     // Výstup: Dog barks.
        myCat.Speak();     // Výstup: Cat meows.
    }
}
```
# Zadání:
Vytvoř program, který bude pracovat se základní třídou `Person` (osoba) a odvozenou třídou `Student` (student). Každá třída bude mít jednoduché vlastnosti a metody.

## Specifikace:

### Bázová třída: `Person`
- Obsahuje vlastnosti `Name` (jméno) a metodu `SayHello()`, která vypíše pozdrav.

### Odvozená třída: `Student`
- Dědí z `Person`.
- Přidává vlastnost `Grade` (ročník) a přepisuje metodu `SayHello()`, aby vypisovala jméno a ročník studenta.

# Inspirace
```csharp
using System;

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual void SayHello()
    {
        Console.WriteLine($"Hello, my name is {Name}.");
    }
}

class Student : Person
{
    public int Grade { get; set; }

    public Student(string name, int grade) : base(name)
    {
        Grade = grade;
    }

    public override void SayHello()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am in grade {Grade}.");
    }
}

class Program
{
    static void Main()
    {
     
        Person person = new Person("Alice");
        person.SayHello();

        Console.WriteLine(); 

        Student student = new Student("Bob", 10);
        student.SayHello();
    }
}

```

