# Přetypování a konverze datových typů v C#

V C# se konverze datových typů a přetypování (casting) používají k převodu hodnot mezi různými typy. 

## Explicitní přetypování (casting)

Explicitní přetypování je vyžadováno, když převod mezi typy není bezpečný a může dojít ke ztrátě dat nebo přesnosti. Používá se operátor přetypování `(nový_datový_typ)`.

### Příklad explicitního přetypování:
``` csharp
double x = 123.45;
int y = (int)x; // Explicitní přetypování z double na int
Console.WriteLine(y); // Výstup: 123
```

V tomto případě je hodnota typu `double` převedena na typ `int`. Desetinná část je ztracena, takže hodnota `123.45` se změní na `123`.

## `as` a `is` operátory

V C# jsou také speciální operátory `as` a `is`, které se používají pro přetypování referenčních typů.

- **`as` operátor**: Pokusí se přetypovat objekt na daný typ. Pokud se přetypování nezdaří, vrátí `null` místo vyvolání výjimky.
- **`is` operátor**: Zkontroluje, zda je objekt daného typu, a vrátí `true` nebo `false`.

### Příklad:
``` csharp
object obj = "Hello, world!";
string str = obj as string; // Přetypování pomocí 'as'. Pokud obj není string, vrátí null.

if (obj is string)
{
    Console.WriteLine("Objekt je typu string.");
}
```

## Úloha: Převod mezi datovými typy

Nyní si vytvoříme jednoduchou úlohu, která demonstruje různé typy přetypování.

### Napište program, který:
1. Vytvoří proměnnou typu `double` a přiřadí jí hodnotu `5.75`.
2. Převede tuto hodnotu na typ `int` pomocí explicitního přetypování.
3. Použije implicitní přetypování k převodu `int` na `float`.
4. Využije operátory `is` a `as` k přetypování objektů.

### Inspirace:
``` csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Implicitní a explicitní přetypování
        double originalValue = 5.75;
        int intValue = (int)originalValue; // Explicitní přetypování z double na int
        Console.WriteLine($"Hodnota jako int: {intValue}"); // Výstup: 5

        float floatValue = intValue; // Implicitní přetypování z int na float
        Console.WriteLine($"Hodnota jako float: {floatValue}"); // Výstup: 5

        // Použití 'as' a 'is' operátorů
        object someObject = "Hello, C#";
        string stringValue = someObject as string; // Přetypování pomocí 'as'

        if (someObject is string)
        {
            Console.WriteLine("someObject je typu string.");
        }
        else
        {
            Console.WriteLine("someObject není typu string.");
        }
    }
}
```
