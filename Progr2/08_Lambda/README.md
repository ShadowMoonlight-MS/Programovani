# Lambda výrazy v C#

Lambda výrazy v C# jsou syntaktickým zkratem pro definování anonymních metod, tedy metod, které nemají jméno. Lambda výraz je v podstatě funkce, která může být přiřazena k delegátu nebo použita tam, kde očekáváme delegát.

## Syntaxe lambda výrazu v C#

``` cs
(parameters) => expression
```

- **parameters**: parametry, které přijímá lambda (mohou být volitelné, pokud není potřeba žádný parametr, lze použít prázdné závorky).
- **=>**: operátor lambda.
- **expression**: tělo lambda výrazu, což je buď jediný výraz, nebo blok kódu.

## Příklad

``` cs
Func<int, int, int> soucet = (a, b) => a + b;
Console.WriteLine(soucet(3, 4));  // Výstup: 7
```

Tento příklad ukazuje, jak lze definovat lambda výraz, který sečte dvě čísla.

# Úloha 1: Filtrace seznamu

**Popis úlohy**: Máte seznam čísel a chcete filtrovat pouze čísla větší než 10. Použijte lambda výraz v kombinaci s metodou `Where` z LINQ.




























``` cs
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> cisla = new List<int> { 5, 15, 8, 22, 1, 11 };

        // Filtrujeme čísla větší než 10
        

         // Výstup: 15, 22, 11
        
    }
}
```
**Nápověda**: K tomu budete potřebovat `List<int>` a metodu `Where` z knihovny `System.Linq`.


# Úloha 2: Seřazení seznamu podle délky řetězce

**Popis úlohy**: Máte seznam řetězců a chcete je seřadit podle délky řetězce. Použijte lambda výraz v kombinaci s metodou `OrderBy`.
















``` cs
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> slova = new List<string> { "jablko", "banán", "kiwi", "pomeranč", "hruška" };

        // Seřadíme seznam podle délky řetězce

        // Výstup: kiwi, hruška, banán, jablko, pomeranč
        
    }
}
```

**Nápověda**: Použijte `OrderBy` z LINQ, kde bude jako klíč pro seřazení délka řetězce (`s.Length`).

# Úloha 3: Komplexní transformace a filtrování

**Popis úlohy**: Máte seznam objektů, kterými jsou knihy. Každá kniha má název, autora a rok vydání. Chcete:

- Vybrat knihy, které byly vydány po roce 2000.
- Seřadit je podle autora.
- Transformovat je na seznam názvů knih.

Použijte LINQ a lambda výrazy pro tuto složitější transformaci.


















``` cs
using System;
using System.Collections.Generic;
using System.Linq;

class Kniha
{
    public string Nazev { get; set; }
    public string Autor { get; set; }
    public int RokVydani { get; set; }
}

class Program
{
    static void Main()
    {
        List<Kniha> knihy = new List<Kniha>
        {
            new Kniha { Nazev = "Kniha A", Autor = "Autor X", RokVydani = 1995 },
            new Kniha { Nazev = "Kniha B", Autor = "Autor Y", RokVydani = 2005 },
            new Kniha { Nazev = "Kniha C", Autor = "Autor X", RokVydani = 2010 },
            new Kniha { Nazev = "Kniha D", Autor = "Autor Z", RokVydani = 2018 }
        };

        // Filtrování knih po roce 2000, seřazení podle autora, transformace na názvy knih
         
            // Filtrování knih       
            // Seřazení podle autora
            // Transformace na názvy knih

        //výstup
    }
}
```

**nápověda**:

- `Where(k => k.RokVydani > 2000)` filtruje knihy, které byly vydány po roce 2000.
- `OrderBy(k => k.Autor)` je používáno k seřazení knih podle jména autora.
- `Select(k => k.Nazev)` transformuje seznam knih na seznam jejich názvů.


