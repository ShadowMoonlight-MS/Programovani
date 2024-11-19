
# LINQ to Objects in C#

V C# umožňuje LINQ (Language-Integrated Query) jednoduché a efektivní dotazování na kolekce objektů (například pole, seznamy nebo jiné kolekce). LINQ to Objects je specifická část LINQ, která se používá přímo s objekty v paměti, což znamená, že se provádí na instancích kolekcí, jako je `List<T>`, `Array`, nebo `Dictionary`.

LINQ to Objects umožňuje provádět operace jako filtrování, třídění, agregace apod. bez nutnosti psát cykly.

Zde jsou dva příklady s ukázkami kódu a vysvětlením řešení.

## Příklad 1: Filtrace a řazení seznamu čísel
Máme seznam čísel a chceme získat všechna sudá čísla větší než 10 a seřadit je sestupně.

### Kód:
```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 12, 7, 18, 25, 30, 3, 16 };

        var evenNumbersGreaterThanTen = numbers
            .Where(n => n > 10 && n % 2 == 0)
            .OrderByDescending(n => n);

        Console.WriteLine("Sudá čísla větší než 10, seřazená sestupně:");
        foreach (var number in evenNumbersGreaterThanTen)
        {
            Console.WriteLine(number);
        }
    }
}
```


### Výstup:
```
Sudá čísla větší než 10, seřazená sestupně:
30
18
16
12
```

---

## Příklad 2: Práce s kolekcí objektů (filtrování a výběr vlastností)
Máme seznam zaměstnanců s jejich jmény a věkem a chceme najít jména zaměstnanců starších než 30 let.

### Kód:
``` csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Alice", Age = 28 },
            new Employee { Name = "Bob", Age = 35 },
            new Employee { Name = "Charlie", Age = 42 },
            new Employee { Name = "David", Age = 24 }
        };

        var employeesOverThirty = employees
            .Where(e => e.Age > 30)
            .Select(e => e.Name);

        Console.WriteLine("Zaměstnanci starší než 30:");
        foreach (var name in employeesOverThirty)
        {
            Console.WriteLine(name);
        }
    }
}
```

### Vysvětlení:
- `.Where(e => e.Age > 30)` filtruje zaměstnance starší než 30 let.
- `.Select(e => e.Name)` vrací jen jména vybraných zaměstnanců.
- Výsledkem je seznam jmen zaměstnanců, kteří splňují podmínku.

### Výstup:
```
Zaměstnanci starší než 30:
Bob
Charlie
```

---
# Zadání:
## Příklad 1: Výběr zaměstnanců podle délky jména
Máme seznam zaměstnanců a chceme najít zaměstnance, jejichž jméno má více než 4 znaky, a seřadit je podle délky jména vzestupně.

### Výstup:
```
Zaměstnanci s jménem delším než 4 znaky, seřazení podle délky jména:
Alice
David
Charlie
```

## Příklad 2: Získání průměrného věku
Máme seznam zaměstnanců a chceme zjistit průměrný věk zaměstnanců starších než 25 let.


### Výstup:
```
Průměrný věk zaměstnanců starších než 25 let: 33.75
```












### Kód:
``` csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Alice", Age = 28 },
            new Employee { Name = "Bob", Age = 35 },
            new Employee { Name = "Charlie", Age = 42 },
            new Employee { Name = "David", Age = 24 },
            new Employee { Name = "Eve", Age = 30 }
        };

        var longNameEmployees = employees
            .Where(e => e.Name.Length > 4)
            .OrderBy(e => e.Name.Length)
            .Select(e => e.Name);

        Console.WriteLine("Zaměstnanci s jménem delším než 4 znaky, seřazení podle délky jména:");
        foreach (var name in longNameEmployees)
        {
            Console.WriteLine(name);
        }
    }
}
```



---



### Kód:
``` csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Alice", Age = 28 },
            new Employee { Name = "Bob", Age = 35 },
            new Employee { Name = "Charlie", Age = 42 },
            new Employee { Name = "David", Age = 24 },
            new Employee { Name = "Eve", Age = 30 }
        };

        var averageAge = employees
            .Where(e => e.Age > 25)
            .Average(e => e.Age);

        Console.WriteLine("Průměrný věk zaměstnanců starších než 25 let: " + averageAge);
    }
}
```

### Vysvětlení:
- `.Where(e => e.Name.Length > 4)` vybírá zaměstnance, jejichž jméno má více než 4 znaky.
- `.OrderBy(e => e.Name.Length)` řadí zaměstnance podle délky jména vzestupně.
- `.Select(e => e.Name)` vybere pouze jména, nikoliv celé objekty zaměstnanců.


### Vysvětlení:
- `.Where(e => e.Age > 25)` vybírá zaměstnance starší než 25 let.
- `.Average(e => e.Age)` spočítá průměrný věk ze zvolených zaměstnanců.

