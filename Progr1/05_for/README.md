# `for` cyklus v C#

`for` cyklus v C# je řídící struktura, která umožňuje opakované provedení bloku kódu po určitou dobu, dokud je splněna daná podmínka. Jeho syntaxe je následující:

```csharp
for (inicializace; podmínka; inkrementace/dekrementace)
{
    // Kód, který se bude opakovaně provádět
}
```

**Inicializace**: Obvykle nastavuje počáteční hodnotu řídící proměnné.  
**Podmínka**: Testuje se před každou iterací. Pokud je podmínka splněna (`true`), cyklus se provede, pokud ne, cyklus skončí.  
**Inkrementace/dekrementace**: Po každé iteraci se provede změna hodnoty řídící proměnné.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Hodnota i: " + i);
}
```
V tomto příkladu:

- **Inicializace**: `int i = 0` – nastaví počáteční hodnotu `i` na 0.
- **Podmínka**: `i < 5` – cyklus se bude opakovat, dokud je `i` menší než 5.
- **Inkrementace**: `i++` – po každé iteraci se hodnota `i` zvýší o 1.

**Výstupem bude**:
```csharp
Hodnota i: 0
Hodnota i: 1
Hodnota i: 2
Hodnota i: 3
Hodnota i: 4
```
# Zadání
### Úloha 1: Součet čísel
Napiš program, který pomocí `for` cyklu vypočítá a vypíše součet všech celých čísel od 1 do 100.

**Nápověda**:  
Použij `for` cyklus a proměnnou, která bude uchovávat průběžný součet.

**Příklad výstupu**:
```cs
Součet čísel od 1 do 100 je: 5050
```


### Úloha 2: Vypsání sudých čísel
Napiš program, který pomocí `for` cyklu vypíše všechna sudá čísla v rozsahu od 1 do 50.

**Nápověda**:  
Podmínka pro sudé číslo je, že číslo modulo 2 je 0 (`i % 2 == 0`).

**Příklad výstupu**:
```cs
2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50
```


### Úloha 3: Faktorál čísla
Napiš program, který pomocí `for` cyklu vypočítá faktorál zadaného čísla `n`.

**Nápověda**:  
Faktorál čísla `n` je definován jako součin všech celých čísel od 1 do `n` (např. `5! = 5 * 4 * 3 * 2 * 1 = 120`).

**Příklad výstupu** (pro `n = 5`):
```cs
Faktorál čísla 5 je: 120
```


