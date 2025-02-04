
# Funkce (Metody) v C#

V C# se „funkce“ nazývají metody. Umožňují nám rozdělit program na menší, přehledné bloky kódu, které se dají opakovaně používat. Díky tomu se zjednodušuje nejen psaní kódu, ale i jeho údržba a testování. Pojďme se podívat, jak se takové metody definují a používají.

## Základní struktura metody

Každá metoda v C# má několik základních částí:

- **Návratový typ:** Určuje, jaký typ hodnotu metoda vrací (např. `void` pokud nic nevrací, `int`, `string` atd.).
- **Název metody:** Jako např. `Ahoj`.
- **Parametry:** Hodnoty, které metoda přijímá (může být prázdná, pokud nejsou potřeba).

### Příklad metody bez parametrů a bez návratové hodnoty

``` csharp
public void Ahoj()
{
    Console.WriteLine("Ahoj světe!");
}
```

Tuto metodu voláme jednoduše jako `Ahoj();`.

## Metoda s parametrem

Pokud chceme, aby metoda pracovala s nějakou hodnotou, přidáme parametr:

``` csharp
public void Ahoj(string jmeno)
{
    Console.WriteLine("Ahoj " + jmeno + "!");
}
```

Zde metoda `Ahoj` očekává jeden parametr typu `string`. Při volání musíme předat hodnotu, např. `Ahoj("Marie");`.

## Proč metody?

- **Modularita:** Rozdělení programu na menší části umožňuje lepší organizaci kódu. Místo toho, abychom psali opakující se bloky kódu, definujeme metodu a voláme ji tam, kde ji potřebujeme.
- **Přehlednost:** Kód je snazší pochopit, pokud je rozdělený do logických celků. Místo dlouhých sekvencí příkazů vidíme jasně definované úkoly.
- **Opakované použití:** Jednou napsanou metodu můžeme volat z různých částí programu. To snižuje množství duplikovaného kódu a usnadňuje změny – stačí upravit kód v metodě a všechna volání budou automaticky aktualizována.
- **Abstrakce:** Metody nám umožňují skrýt detaily implementace. Když někdo volá metodu `Ahoj("Petr")`, nemusí vědět, jak přesně funguje, stačí vědět, co dělá a jaké parametry potřebuje.

## Rozšíření a vnitřní logika

Pojďme se podívat na příklad, který demonstruje použití metody s logikou uvnitř a návratovou hodnotou:

``` csharp
public int Secti(int a, int b)
{
    int soucet = a + b;
    return soucet;
}
```

Tuto metodu voláme takto:

``` csharp
int vysledek = Secti(3, 4);
Console.WriteLine("Výsledek: " + vysledek);
```

## Úlohy

### Úloha 1 – Metoda s parametrem

**Zadání:**  
Vytvořte metodu `Pozdrav(string jmeno)`, která přijme jako parametr jméno a vypíše pozdrav ve tvaru "Ahoj, [jméno]!".

**Input:**

``` cs
Pozdrav("Karel");
```

**Output:**
``` cs
Ahoj, Karel!
```
### Úloha 2 – Metoda s návratovou hodnotou a kontrolou vstupu

**Zadání:**  
Vytvořte metodu `Secti(int a, int b)`, která obdrží dvě čísla, sečte je a vrátí výsledek. Ověřte, že ani jedno z čísel není záporné. Pokud je číslo záporné, vypište varování a vraťte 0.

**Input:**

``` csharp
Secti(5, 3);
Secti(5, -3);
```

**Output:**
```cs
8  
Chyba: Zadaná čísla nesmí být záporná. (metoda vrací 0)
```
### Úloha 3 – Kontrola prvočíselnosti

**Zadání:**  
Vytvořte metodu `JePrvocislo(int n)`, která zjistí, zda je zadané číslo prvočíslo.

**Input:**

``` csharp
JePrvocislo(11);
JePrvocislo(12);
```

**Output:**
``` cs
true  
false
```