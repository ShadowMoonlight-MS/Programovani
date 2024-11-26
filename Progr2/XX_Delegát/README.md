# Save the content with custom code block delimiter "aaa" to a Markdown (.md) file
custom_content = """
# Delegáty v C#

Delegát je v C# typ, který odkazuje na metodu. Delegáty umožňují předávat metody jako parametry jiným metodám. Jsou základním kamenem pro pochopení pokročilých konceptů jako lambdy a LINQ. Pojďme to probrat a ukázat na čtyřech příkladech od jednodušších po složitější.

## 1. Co je delegát a jak ho definovat

Delegát je šablona pro metodu. Říká, jaký typ parametru a návratové hodnoty metoda musí mít.

### Příklad 1: Vlastní delegát
``` cs
// Definice delegáta
delegate int MathOperation(int x, int y);

class Program
{
    static void Main()
    {
        // Přiřazení metody Add k delegátu
        MathOperation operation = Add;
        Console.WriteLine(operation(3, 4)); // Výstup: 7
    }

    static int Add(int x, int y)
    {
        return x + y;
    }
}
```

**Vysvětlení:**

- Delegát `MathOperation` definuje metodu, která přijímá dva `int` parametry a vrací `int`.
- `Add` je metoda, která odpovídá této šabloně, takže ji můžeme přiřadit k delegátu.

---

## 2. Vestavěný delegát: Action

`Action` je předdefinovaný delegát, který nepředává žádnou návratovou hodnotu (`void`). Můžete jej použít místo psaní vlastního delegáta.

### Příklad 2: Použití Action
 
``` cs
using System;

class Program
{
    static void Main()
    {
        // Použití Action
        Action<string> printMessage = Print;
        printMessage("Hello, World!"); // Výstup: Hello, World!
    }

    static void Print(string message)
    {
        Console.WriteLine(message);
    }
}
```

**Vysvětlení:**

- `Action<string>` znamená, že delegát přijímá jeden parametr typu `string` a vrací `void`.
- Metoda `Print` odpovídá této šabloně.

---

## 3. Vestavěný delegát: Func

`Func` je delegát, který vrací hodnotu. Poslední typový parametr určuje návratový typ, předchozí typy jsou parametry.

### Příklad 3: Použití Func

``` cs
using System;

class Program
{
    static void Main()
    {
        // Použití Func
        Func<int, int, int> multiply = Multiply;
        Console.WriteLine(multiply(3, 4)); // Výstup: 12
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }
}
```

**Vysvětlení:**

- `Func<int, int, int>` znamená, že delegát přijímá dva `int` parametry a vrací `int`.
- Metoda `Multiply` odpovídá této šabloně.

---

## 4. Vestavěný delegát: Predicate

`Predicate` je delegát, který vždy vrací `bool` a přijímá jeden parametr. Používá se často pro testování podmínek.

### Příklad 4: Použití Predicate

``` cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Seznam čísel
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        // Použití Predicate
        Predicate<int> isEven = IsEven;

        // Filtrujeme sudá čísla
        List<int> evenNumbers = numbers.FindAll(isEven);
        Console.WriteLine(string.Join(", ", evenNumbers)); // Výstup: 2, 4, 6
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
```

**Vysvětlení:**

- `Predicate<int>` je delegát, který přijímá `int` a vrací `bool`.
- Metoda `IsEven` odpovídá této šabloně, protože testuje, zda číslo je sudé.
- `List.FindAll` používá `Predicate` k filtrování seznamu.

---

## Shrnutí delegátů a jejich použití

- **Vlastní delegáty:** Vhodné pro specifické scénáře, kdy chcete mít kontrolu nad šablonou metody.
- **Action:** Použijte, když nepotřebujete návratovou hodnotu (metody vracející `void`).
- **Func:** Použijte, když chcete návratovou hodnotu (např. matematické operace).
- **Predicate:** Použijte, když potřebujete podmínky vracející `bool`.
"""
