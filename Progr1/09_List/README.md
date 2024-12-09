
# List v C#

V C# je **list** (seznam) datová struktura, která umožňuje uchovávat kolekci hodnot, podobně jako pole. Na rozdíl od polí je však **list dynamický**, což znamená, že jeho velikost se může měnit za běhu programu. Listy patří do **namespace System.Collections.Generic** a využívají generiku, což znamená, že při vytváření listu musíte určit typ prvků, které bude obsahovat.

## Vlastnosti listu:
- **Dynamická velikost**: Můžete přidávat a odebírat prvky, aniž byste museli předem určit velikost listu.
- **Indexování**: Hodnoty jsou uloženy v určitém pořadí a přístupné podle indexu (začíná od 0).
- **Typová bezpečnost**: Díky generice můžete pracovat s konkrétním typem dat (např. `List<int>`).
- **Metody**: List obsahuje mnoho užitečných metod, jako jsou `Add`, `Remove`, `Sort`, `Insert` nebo `Contains`.

## Syntaxe:
Příklad vytvoření a práce s listem:

``` cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Vytvoření listu celých čísel
        List<int> cisla = new List<int>();

        // Přidání prvků do listu
        cisla.Add(10);
        cisla.Add(20);
        cisla.Add(30);

        // Přístup k prvkům pomocí indexu
        Console.WriteLine(cisla[0]); // Výstup: 10

        // Iterace přes list
        foreach (int cislo in cisla)
        {
            Console.WriteLine(cislo);
        }

        // Odebrání prvku
        cisla.Remove(20);

        // Zjištění počtu prvků
        Console.WriteLine("Počet prvků: " + cisla.Count); // Výstup: 2
    }
}
```

---

## Úlohy:

### 1. Vytvořte list a přidejte hodnoty
Vytvořte program, který:
- Vytvoří list `List<string>`.
- Přidá do něj jména tří zvířat.
- Vypíše tato jména na obrazovku.

**Očekávaný výstup:**
``` cs
Pes
Kočka
Králík
```

---

### 2.  Vyhledávání v listu
Vytvořte program, který:
- Vytvoří list `List<int>` a přidá do něj čísla od 1 do 10.
- Požádá uživatele o zadání čísla.
- Zkontroluje, zda číslo v listu existuje, a vypíše zprávu o tom, zda bylo nalezeno.

**Příklad výstupu:**
``` cs
Zadejte číslo: 5
Číslo 5 bylo nalezeno v listu.
```

---

### 3. Řazení a práce s metodami
Napište program, který:
- Vytvoří list náhodných čísel (například 5 čísel mezi 1 a 100).
- Seřadí čísla vzestupně.
- Najde maximální a minimální hodnotu v listu.
- Vypíše původní i seřazený list, minimální a maximální hodnotu.

**Příklad výstupu:**
``` cs
Původní list: 42, 7, 89, 15, 23
Seřazený list: 7, 15, 23, 42, 89
Minimální hodnota: 7
Maximální hodnota: 89
```
