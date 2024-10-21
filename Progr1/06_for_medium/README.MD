# Úloha 1: Najděte součet všech sudých čísel mezi dvěma čísly

Napište program, který pro dvě zadaná čísla najde a vypíše součet všech sudých čísel mezi nimi včetně těchto čísel, pokud jsou sudá.

## Vstup
Zadejte dvě čísla (nižší a vyšší hranice intervalu).

## Výstup
Součet všech sudých čísel v intervalu.

### Příklad
```csharp
Zadejte nižší hranici: 4
Zadejte vyšší hranici: 10
```
### Výstup
```csharp
28 (4 + 6 + 8 + 10)
```
### nápověda
```csharp
if (i % 2 == 0) // Kontrola, zda je číslo sudé
```
# Úloha 2: Vytvořte trojúhelník z hvězdiček
### nápověda: do cyklu 'for' můžete dát další cyklus 'for'

Napište program, který pro zadané číslo n vypíše trojúhelník z hvězdiček. Počet hvězdiček v řádcích bude od jedné až po n.

### Vstup
Zadejte číslo n, které určuje počet řádků.

### Výstup
Trojúhelník z hvězdiček.

### Příklad
```csharp
Zadejte hodnotu n: 5
*
**
***
****
*****
```
### úloha 2.1 udělejte to obráceně
```csharp
n: 5
*****
****
***
**
*
```
### úloha 2.2 
```csharp
n: 5

**********
 ******** 
  ******
   ****
    **
```
### úloha 2.3
```csharp
n: 4

   *
  ***
 *****
*******
 *****
  ***
   *
```
```csharp
n: 5

    **
   ****
  ******
 ********
**********
 ******** 
  ******
   ****
    **
```

# Úloha Bonus: Vypište prvočísla v zadaném rozsahu

Napište program, který pro zadaný rozsah čísel vypíše všechna prvočísla.

## Vstup
Zadejte dvě čísla (dolní a horní hranice intervalu).

## Výstup
Seznam prvočísel mezi těmito dvěma čísly (včetně).

### Příklad
```csharp
Zadejte nižší hranici: 10
Zadejte vyšší hranici: 30
Výstup: 11, 13, 17, 19, 23, 29
```