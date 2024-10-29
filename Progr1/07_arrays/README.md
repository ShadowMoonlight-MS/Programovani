# Pole v C#

Pole v C# je datová struktura, která uchovává pevný počet prvků stejného datového typu. Pole umožňuje rychlý přístup k prvkům pomocí indexů, kde první prvek má vždy index `0`. Vytvoření pole v C# vyžaduje zadání typu prvků a velikosti nebo přímo inicializaci s hodnotami.

### Struktura pole:

``` csharp
typ[] názevPole = new typ[velikost];
```

Níže jsou 4 příklady práce s poli od základních po složitější.

---

## Příklad 1: Jednoduché jednorozměrné pole

Vytvoříme pole čísel, které naplníme hodnotami a následně je vypíšeme pomocí `for` cyklu.


## Příklad 2: Výpis hodnot z pole

**Zadání:** Vytvoř pole celých čísel s hodnotami `{10, 20, 30, 40, 50}` a vypiš každé číslo v poli na nový řádek pomocí `foreach` cyklu.

``` csharp
int[] numbers = { 10, 20, 30, 40, 50 };

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

---

## Příklad 3: Součet hodnot v poli

**Zadání:** Vytvoř pole `scores`, které bude obsahovat hodnoty `{5, 10, 15, 20, 25}`. Poté spočítej a vypiš součet všech hodnot v poli.



## Příklad 4: Největší číslo v poli

**Zadání:** Vytvoř pole `numbers`, které bude obsahovat hodnoty `{23, 45, 12, 56, 34, 78}`. Najdi a vypiš největší číslo v poli.

