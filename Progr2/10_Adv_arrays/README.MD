# Jak pracovat s 2D maticemi v C#

## Deklarace a inicializace matice

### Deklarace:

```csharp
// Deklarace matice s 2 rozměry
int[,] matice;
```

### Inicializace na konkrétní velikost (např. 3 řádky × 4 sloupce):

```csharp
// Vytvoříme matici, která má 3 řádky a 4 sloupce
matice = new int[3, 4];
```

### Volitelně můžeme už při deklaraci i přiřadit počáteční hodnoty, např.:

```csharp
// 2 řádky, 3 sloupce a rovnou vyplněné hodnoty
int[,] matice2 = new int[,]
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};
```

## Zápis hodnoty do matice

Přístup do matice probíhá pomocí dvou indexů: `[řádek, sloupec]`.

### Zápis:

```csharp
matice[1, 2] = 42; 
```

Tím uložíte číslo `42` do řádku číslo 1 a sloupce číslo 2 (nezapomeňte, že v C# se indexuje od **0**).

## Čtení hodnoty z matice

### Čtení:

```csharp
int x = matice[1, 2];
Console.WriteLine(x);  // vypíše uloženou hodnotu
```

## Zjištění počtu řádků a sloupců

### Pro zjištění **počtu řádků** použijte:

```csharp
int pocetRadku = matice.GetLength(0);
```

### Pro zjištění **počtu sloupců**:

```csharp
int pocetSloupcu = matice.GetLength(1);
```

## Procházení matice

Nejčastěji se pro průchod 2D maticí používají **dva vnořené cykly `for`**:

```csharp
int radku = matice.GetLength(0);
int sloupcu = matice.GetLength(1);

for (int i = 0; i < radku; i++)
{
    for (int j = 0; j < sloupcu; j++)
    {
        // práce s matice[i, j]
        Console.Write(matice[i, j] + " ");
    }
    Console.WriteLine(); // nový řádek po každém řádku matice
}
```

---

# Ukázkové úlohy s maticemi

Níže najdete tři příklady, kde si práci s 2D poli (maticemi) můžete vyzkoušet.

---

## 1. ÚLOHA: Výpis zadané 2D matice a součet jejích prvků

### Popis úlohy
1. Vytvořte 2D pole (matici) o velikosti 2×3 (2 řádky, 3 sloupce).
2. Uživatel do konzole zadá (postupně) hodnoty pro **všechny** buňky matice.
3. Vypište obsah matice na konzoli.
4. Vypočítejte a vypište součet všech prvků této matice.

### Vstup
Uživatel zadá **6 čísel** (každé představuje jednu hodnotu v matici). Např. postupně:

```
1
2
3
4
5
6
```

### Výstup

- Vypsání matice v podobě (např.):

```
Obsah matice:
1   2   3
4   5   6
```

- A poté vypsání součtu:

```
Součet všech prvků je: 21
```

### Ukázkový kód

```csharp
using System;

class Program
{
    static void Main()
    {
        // 1) Vytvoření matice 2×3
        int[,] matice = new int[2, 3];

        // 2) Čtení hodnot z konzole
        Console.WriteLine("Zadejte 6 hodnot pro matici 2x3:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"matice[{i},{j}]: ");
                matice[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // 3) Výpis obsahu matice
        Console.WriteLine("\nObsah matice:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matice[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // 4) Součet všech prvků
        int soucet = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                soucet += matice[i, j];
            }
        }

        Console.WriteLine($"\nSoučet všech prvků je: {soucet}");
    }
}
```

---

## 2. ÚLOHA: Sečtení dvou matic stejné velikosti

### Popis úlohy
1. Vytvořte **dvě** 2D pole (matice) o stejné velikosti (např. 3×3).
2. Uživatel zadá hodnoty **pro obě** matice.
3. Spočítejte jejich **součet** – výsledkem je opět matice, kde každý prvek je součtem odpovídajících prvků z obou matic.
4. Výsledek (třetí matici) vypište na konzoli.

### Vstup
Uživatel zadává pro obě matice 3×3 vždy 9 hodnot, celkem tedy 18 vstupních hodnot. Např.:

```
První matice (9 hodnot):
1
2
3
4
5
6
7
8
9

Druhá matice (9 hodnot):
9
8
7
6
5
4
3
2
1
```

### Výstup

Nejprve můžete vypsat obě vstupní matice pro kontrolu. Poté vypsat výsledek, např.:

```
První matice:
1   2   3
4   5   6
7   8   9

Druhá matice:
9   8   7
6   5   4
3   2   1

Součet matic:
10  10  10
10  10  10
10  10  10
```

### Ukázkový kód

```csharp
using System;

class Program
{
    static void Main()
    {
        // Rozměr matice
        int radky = 3;
        int sloupce = 3;

        // 1) Vytvoření dvou matic
        int[,] matA = new int[radky, sloupce];
        int[,] matB = new int[radky, sloupce];

        // 2) Načtení hodnot od uživatele
        Console.WriteLine("Zadejte hodnoty pro první matici 3x3:");
        for (int i = 0; i < radky; i++)
        {
            for (int j = 0; j < sloupce; j++)
            {
                matA[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nZadejte hodnoty pro druhou matici 3x3:");
        for (int i = 0; i < radky; i++)
        {
            for (int j = 0; j < sloupce; j++)
            {
                matB[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // 3) Výpočet součtu matic
        int[,] matC = new int[radky, sloupce];

        for (int i = 0; i < radky; i++)
        {
            for (int j = 0; j < sloupce; j++)
            {
                matC[i, j] = matA[i, j] + matB[i, j];
            }
        }

        // Výpis – funkce pro vypsání matice
        void VypisMatici(int[,] mat, string popisek)
        {
            Console.WriteLine(popisek);
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 4) Výpis výsledků
        Console.WriteLine();
        VypisMatici(matA, "První matice:");
        VypisMatici(matB, "Druhá matice:");
        VypisMatici(matC, "Součet matic:");
    }
}
```

---

## 3. ÚLOHA: Násobení dvou matic

### Popis úlohy
1. Uživatel zadá rozměry matic:
   - První matice bude rozměru (např.) **m × n**  
   - Druhá matice bude rozměru **n × p**  
   (Je nutné, aby **počet sloupců** první matice byl **stejný** jako **počet řádků** druhé matice, jinak násobení nelze provést.)
2. Uživatel vyplní obě matice.
3. Vytvoříme třetí matici o rozměru **m × p**, do níž uložíme výsledek násobení.
4. Výsledek (třetí matici) vypište na konzoli.

### Vstup

- Rozměry m, n, p  
- Hodnoty pro matici A (m×n)  
- Hodnoty pro matici B (n×p)  

Např.:

```
Zadej počet řádků první matice (m): 2
Zadej počet sloupců první matice (n): 3

Zadej počet řádků druhé matice (n - kontrola): 3
Zadej počet sloupců druhé matice (p): 2

První matice (2x3) – zadej 6 hodnot:
1
2
3
4
5
6

Druhá matice (3x2) – zadej 6 hodnot:
7
8
9
10
11
12
```

### Výstup

Výsledná matice (2×2) bude:

```
První matice (A):
1   2   3
4   5   6

Druhá matice (B):
7   8
9   10
11  12

Výsledek násobení (C = A × B):
58  64
139 154
```

### Pro \( C[1,1] \):
\(
C[1,1] = (1 * 7) + (2 * 9) + (3 * 11) = 7 + 18 + 33 = 58
\)
\( C[1,1] = 58 \)

### Pro \( C[1,2] \):
\(
C[1,2] = (1 * 8) + (2 * 10) + (3 * 12) = 8 + 20 + 36 = 64
\)
\( C[1,2] = 64 \)

### Pro \( C[2,1] \):
\(
C[2,1] = (4 * 7) + (5 * 9) + (6 * 11) = 28 + 45 + 66 = 139
\)
\( C[2,1] = 139 \)

### Pro \( C[2,2] \):
\(
C[2,2] = (4 * 8) + (5 * 10) + (6 * 12) = 32 + 50 + 72 = 154
\)
\( C[2,2] = 154 \)


### Ukázkový kód

```csharp
using System;

class Program
{
    static void Main()
    {
        // 1) Čtení rozměrů od uživatele
        Console.Write("Zadej počet řádků první matice (m): ");
        int m = int.Parse(Console.ReadLine());
        
        Console.Write("Zadej počet sloupců první matice (n): ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("Zadej počet řádků druhé matice (n musí souhlasit): ");
        int n2 = int.Parse(Console.ReadLine());
        // Lze doplnit kontrolu, že n == n2
        
        Console.Write("Zadej počet sloupců druhé matice (p): ");
        int p = int.Parse(Console.ReadLine());

        // 2) Vytvoření dvou matic
        int[,] A = new int[m, n];
        int[,] B = new int[n2, p];

        // 2a) Naplnění A
        Console.WriteLine($"\nZadej {m*n} hodnot pro první matici ({m}x{n}):");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // 2b) Naplnění B
        Console.WriteLine($"\nZadej {n2*p} hodnot pro druhou matici ({n2}x{p}):");
        for (int i = 0; i < n2; i++)
        {
            for (int j = 0; j < p; j++)
            {
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // 3) Násobení matic => C o rozměru (m × p)
        int[,] C = new int[m, p];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                int soucet = 0;
                // Vzorec: C[i,j] = Σ (A[i,k] * B[k,j]) pro k = 0..(n-1)
                for (int k = 0; k < n; k++)
                {
                    soucet += A[i, k] * B[k, j];
                }
                C[i, j] = soucet;
            }
        }

        // Funkce pro vypsání matice
        void VypisMatici(int[,] mat, string popis)
        {
            Console.WriteLine(popis);
            int radku = mat.GetLength(0);
            int sloupcu = mat.GetLength(1);

            for (int rr = 0; rr < radku; rr++)
            {
                for (int ss = 0; ss < sloupcu; ss++)
                {
                    Console.Write(mat[rr, ss] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 4) Výpis
        Console.WriteLine();
        VypisMatici(A, "První matice (A):");
        VypisMatici(B, "Druhá matice (B):");
        VypisMatici(C, "Výsledek násobení (C = A × B):");
    }
}
```

---

## Závěrem

- 2D pole (matici) deklarujeme v C# pomocí `int[,] matice;`.
- Prvky zapisujeme / čteme přes `matice[řádek, sloupec]`.
- Pro **průchod** maticí se často používají **dva cykly for**.
- V příkladech jste viděli **zadávání hodnot**, **sčítání** matic a **násobení** matic.

Tímto jste získali základní přehled o práci s dvourozměrnými poli v C#.
