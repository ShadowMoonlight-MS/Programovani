# Delegáty v C#

Delegáty v C# jsou speciální typy, které slouží jako reference na metody. Lze si je představit jako "ukazatele na funkce" – delegát uchovává odkaz na metodu a umožňuje volat tuto metodu nepřímo prostřednictvím delegáta.

Delegáty jsou klíčové pro koncepty jako **události** a **callbacky** a často se používají při práci s **asynchronním programováním** nebo při vytváření **plug-in struktur**.

---

### Deklarace delegáta

Delegáta deklarujeme pomocí klíčového slova `delegate`, které definuje signaturu metody, kterou může delegát odkazovat. Signatura určuje návratový typ a parametry metody.

``` csharp
delegate návratovýTyp NázevDelegáta(parametry);
```

---

## Příklad 1: Základní delegát

Vytvoříme jednoduchého delegáta, který bude odkazovat na metodu pro sčítání dvou čísel.

1. Definujeme delegáta `MathOperation`.
2. Vytvoříme metodu `Add`, která přijímá dva parametry typu `int` a vrací jejich součet.
3. Delegát použijeme k volání této metody.

``` csharp
using System;

delegate int MathOperation(int x, int y); // Deklarace delegáta

class Program
{
    static int Add(int x, int y)
    {
        return x + y;
    }

    static void Main()
    {
        MathOperation operation = Add; // Přiřazení metody k delegátu
        Console.WriteLine("Výsledek sčítání: " + operation(5, 3)); // Volání metody přes delegáta
    }
}
```

**Vysvětlení:** Delegát `MathOperation` uchovává odkaz na metodu `Add`, takže můžeme zavolat `Add` přes proměnnou `operation`. Tento kód by měl vypsat výsledek sčítání dvou čísel.

---

## Příklad 2: Delegát s více metodami (Multicast Delegát)

V tomto příkladu ukážeme, jak delegát může odkazovat na více metod najednou. Vytvoříme několik matematických operací a pomocí delegáta je všechny zavoláme.

1. Definujeme delegáta `MathOperation`, který pracuje s `int` parametry.
2. Vytvoříme tři metody `Add`, `Subtract`, a `Multiply`.
3. Přidáme všechny tři metody do delegáta a postupně je všechny zavoláme.


- **Multicast Delegát:** K proměnné `operation` postupně přidáme metody `Add`, `Subtract`, a `Multiply` pomocí `+=`. Delegát nyní uchovává odkazy na všechny tři metody.
- **Volání všech metod:** Pomocí `GetInvocationList()` získáme všechny metody v delegátu, které následně postupně zavoláme a vypíšeme výsledky každé operace.


``` csharp
using System;

delegate int MathOperation(int x, int y);

class Program
{
    static int Add(int x, int y)
    {
        return x + y;
    }

    static int Subtract(int x, int y)
    {
        return x - y;
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }

    static void Main()
    {
        MathOperation operation = Add;      // Přidáme sčítání
        operation += Subtract;               // Přidáme odčítání
        operation += Multiply;               // Přidáme násobení

        Console.WriteLine("Výsledky operací:");
        foreach (MathOperation op in operation.GetInvocationList())
        {
            Console.WriteLine(op(6, 3));     // Zavoláme všechny metody postupně
        }
    }
}
//Výsledky operací:
//9
//3
//18
```
# Příklad 3: Delegát pro zpracování textu (TextProcessing Delegate)

V tomto příkladu vytvoříme delegáta pro zpracování textových řetězců. Definujeme několik metod, které provádějí různé operace na vstupním textu, a přidáme je všechny do jednoho delegáta.

1. Definujeme delegáta `TextOperation`, který pracuje s `string` parametry.
2. Vytvoříme tři metody `ToUpperCase`, `ToLowerCase`, a `AddExclamation`.
3. Přidáme všechny tři metody do delegáta a postupně je všechny zavoláme.








### Inspirace:

``` csharp
using System;

delegate string TextOperation(string text);

class Program
{
    static string ToUpperCase(string text)
    {
        return text.ToUpper();
    }

    static string ToLowerCase(string text)
    {
        return text.ToLower();
    }

    static string AddExclamation(string text)
    {
        return text + "!";
    }

    static void Main()
    {
        TextOperation textOperations = ToUpperCase;       // Přidáme konverzi na velká písmena
        textOperations += ToLowerCase;                    // Přidáme konverzi na malá písmena
        textOperations += AddExclamation;                 // Přidáme vykřičník na konec textu

        Console.WriteLine("Výsledky zpracování textu:");
        foreach (TextOperation op in textOperations.GetInvocationList())
        {
            Console.WriteLine(op("Hello World"));         // Zavoláme všechny metody postupně
        }
    }
}
```





