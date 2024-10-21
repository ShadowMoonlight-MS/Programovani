# Boxing a Unboxing v C#

Boxing a Unboxing v C# jsou techniky používané k převodu mezi hodnotovými typy (například int, float, bool) a referenčními typy (object). Jedná se o mechanismus, který umožňuje hodnotovým typům chovat se jako objekty. Tento proces je velmi užitečný při práci s kolekcemi, které očekávají typ object, jako jsou například starší nestrukturované kolekce (ArrayList), které byly běžně používány před zavedením generických typů.

## Co je Boxing?

Boxing je proces převodu hodnotového typu na referenční typ tím, že se hodnota "zabalí" do objektu. Vytvoří se nová instance typu object, která obsahuje kopii původní hodnoty.

Při boxingu se provádějí následující kroky:

1. Vytvoří se nová instance typu object na heapu.
2. Hodnota je zkopírována z hodnotového typu do této nové instance.

### Příklad Boxing:
``` csharp
int number = 123;      // Hodnotový typ
object obj = number;   // Boxing: int je převeden na object
Console.WriteLine(obj); // Výstup: 123
```

V tomto případě je hodnota 123 zabalena do objektu typu object.

## Co je Unboxing?

Unboxing je opačný proces, při kterém se referenční typ převádí zpět na hodnotový typ. Musí být použito explicitní přetypování, aby se získala původní hodnota uložená v objektu.

Při unboxingu se provádějí následující kroky:

1. Zkontroluje se, zda objekt skutečně obsahuje hodnotu daného typu.
2. Hodnota se zkopíruje zpět z instance typu object na hodnotový typ.

### Příklad Unboxing:
``` csharp
object obj = 123;     // Boxing: int je zabaleno do object
int number = (int)obj; // Unboxing: object je převeden zpět na int
Console.WriteLine(number); // Výstup: 123
```

V tomto případě je hodnota vybalena z objektu typu object zpět do proměnné int.

## Důležité aspekty Boxingu a Unboxingu

- **Výkon**: Boxing a unboxing jsou operace náročné na výkon, protože při každém boxingu se alokuje paměť na heapu a při unboxingu se provádí kontrola typu. Proto je dobré se těmto operacím vyhýbat tam, kde je to možné.
- **Bezpečnost typů**: Unboxing vyžaduje explicitní přetypování, což znamená, že pokud typ objektu neodpovídá hodnotovému typu, vyvolá to chybu při běhu programu (InvalidCastException).

## Praktická úloha: Boxing a Unboxing

### Napište program, který:

1. Vytvoří proměnnou typu int s hodnotou 456.
2. Provádí boxing této hodnoty do objektu typu object.
3. Provede unboxing této hodnoty zpět na int.
4. Ověří, zda unboxing proběhl správně.

### Inspirace:
``` csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Vytvoření proměnné hodnotového typu
        int originalValue = 456;

        // 2. Boxing: Zabalíme hodnotu do objektu typu 'object'
        object boxedValue = originalValue;
        Console.WriteLine($"Hodnota po boxingu: {boxedValue}"); // Výstup: 456

        // 3. Unboxing: Převedeme objekt zpět na 'int'
        int unboxedValue = (int)boxedValue;
        Console.WriteLine($"Hodnota po unboxingu: {unboxedValue}"); // Výstup: 456

        // 4. Ověření, zda unboxing proběhl správně
        if (originalValue == unboxedValue)
        {
            Console.WriteLine("Unboxing proběhl úspěšně.");
        }
        else
        {
            Console.WriteLine("Nastala chyba při unboxingu.");
        }
    }
}
```
## Kdy používat Boxing a Unboxing

V moderním C# se boxing a unboxing používají méně často díky existenci generik (`List<T>`, `Dictionary<TKey, TValue>`, atd.), které umožňují pracovat s typy bezpečněji a efektivněji bez nutnosti převodu na object. Nicméně, koncept je stále důležitý, zvláště při práci s rozhraními nebo starším kódem, kde může být očekáván typ object.
