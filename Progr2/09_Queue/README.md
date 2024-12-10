# Co je Queue<T>?

`Queue<T>` je FIFO (First In, First Out) datová struktura, což znamená, že první prvek, který do fronty vložíš, bude také první, který bude odstraněn. Představ si to jako frontu na nějakém místě (např. u pokladny), kde lidé přicházejí jako první a odcházejí také jako první.

## Vlastnosti Queue<T>:
- **FIFO princip**: Prvky jsou odstraněny v pořadí, v jakém byly přidány.
- **Dynamická velikost**: Fronta se automaticky zvětšuje a zmenšuje podle potřeby, když do ní přidáváš nebo z ní odebíráš prvky.
- **Typový parametr T**: Fronta je generická, takže může obsahovat libovolný typ dat (např. `Queue<int>`, `Queue<string>`, atd.).

## Základní operace s Queue<T>:
- **Enqueue(T item)** – Přidá prvek na konec fronty.
- **Dequeue()** – Odebere a vrátí první prvek z fronty.
- **Peek()** – Vrátí první prvek z fronty bez jeho odstranění.
- **Count** – Vrací počet prvků v frontě.
- **Clear()** – Odstraní všechny prvky z fronty.

## Příklad použití Queue<T>:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Vytvoření nové fronty typu string
        Queue<string> queue = new Queue<string>();

        // Přidání prvků do fronty
        queue.Enqueue("Alice");
        queue.Enqueue("Bob");
        queue.Enqueue("Charlie");

        // Zobrazení počtu prvků ve frontě
        Console.WriteLine("Počet prvků ve frontě: " + queue.Count); // Výstup: 3

        // Odebrání prvního prvku
        string firstPerson = queue.Dequeue();
        Console.WriteLine($"{firstPerson} odešel z fronty."); // Výstup: Alice odešel z fronty.

        // Zobrazení prvního prvku bez jeho odstranění
        string peekPerson = queue.Peek();
        Console.WriteLine($"První v řadě je: {peekPerson}"); // Výstup: Bob

        // Odebrání dalšího prvku
        firstPerson = queue.Dequeue();
        Console.WriteLine($"{firstPerson} odešel z fronty."); // Výstup: Bob odešel z fronty.

        // Zobrazení zbytku ve frontě
        Console.WriteLine("Zbytek ve frontě:");
        foreach (var person in queue)
        {
            Console.WriteLine(person); // Výstup: Charlie
        }

        // Vymazání všech prvků
        queue.Clear();
        Console.WriteLine("Počet prvků po vymazání: " + queue.Count); // Výstup: 0
    }
}
```
## Výstup:
```cs
Počet prvků ve frontě: 3
Alice odešel z fronty.
První v řadě je: Bob
Bob odešel z fronty.
Zbytek ve frontě:
Charlie
Počet prvků po vymazání: 0
```
# Využití Queue<T> v praxi

Queue<T> je ideální pro situace, kdy musíš zachovat pořadí, v jakém prvky přicházejí a zároveň zpracovávat je v tomto pořadí. Několik příkladů použití:

- **Zpracování úloh**: Pokud máš systém, který přijímá úkoly a zpracovává je v pořadí, v jakém byly přidány.
- **Simulace fronty**: Pro simulace front v reálném světě, např. fronta čekající zákazníky v obchodě.
- **Výpočetní algoritmy**: V některých algoritmech, jako jsou algoritmy pro hledání v grafech (např. Breadth-First Search, BFS), kde využíváš frontu k udržování pořadí zpracování uzlů.

## Kdy použít Queue<T>?
Použij Queue<T> v případech, kdy potřebuješ:
- Zpracovávat prvky v pořadí, v jakém přicházejí.
- Udržovat pořadí přidání.
- Uskladnit prvky do fronty pro pozdější zpracování.

---

# Úkoly

## Úkol 1: Ověření, zda je seznam palindrom

Máme seznam písmen (nebo slov) a musíme ověřit, zda tento seznam tvoří palindrom. Seznam je palindrom, pokud čte-li jej zepředu i zezadu, je stejný (např. "radar").

### Úkol:
1. Vytvoř frontu, která bude obsahovat písmena ze slova.
2. Zkontroluj, zda je fronta palindromem (tedy jestli jsou písmena stejná zepředu i zezadu).
3. Pokud ano, vypiš "Palindrom". Pokud ne, vypiš "Není palindrom".



### Vstup:
``` cs
Slovo (např. "radar").
```
### Výstup (pro slovo "radar"):
``` cs
Slovo "radar" je palindrom.
```

Pokud bys zadal slovo, které není palindrom, např. "hello", výstup by byl:

``` cs
Slovo "hello" není palindrom.
```

---

## Úkol 2: Zpracování úkolů ve frontě s prioritou

Představ si, že máš systém, který zpracovává úkoly. Každý úkol má určený prioritní status (například "vysoká", "střední" a "nízká"). Úkoly s vyšší prioritou musí být zpracovány dříve, bez ohledu na to, kdy byly přidány do fronty.

Pro tento úkol použijeme dvě fronty:
1. **Fronta pro úkoly s vysokou prioritou**.
2. **Fronta pro úkoly s nízkou prioritou** (střední prioritu budeme ignorovat).

### Postup:
1. Vytvoř dvě fronty pro vysokou a nízkou prioritu.
2. Přidej několik úkolů s různými prioritami do těchto front.
3. Úkoly budou zpracovávány tak, že úkoly s vysokou prioritou budou zpracovány dříve než úkoly s nízkou prioritou.
4. Když všechny úkoly z vysoké priority budou zpracovány, teprve pak se zpracují úkoly z nízké priority.
```cs
//vstup = Console.Readline ...
np zahrát si hru
vp dojít nakoupit
vp umít nádobí
np zavolat kamarádovy
np koukat na televizi
vp uklidit svůj pokoj
konec //pokud uživatel napíše 'konec', přejde se na výstup
//výstup
1.Dojít nakoupit
2.umít nádobí
3.uklidit svůj pokoj
4.zahrát si hru
5.zavolat kamarádovy
6.koukat na televizi


```