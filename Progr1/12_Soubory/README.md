# Základní způsoby pro práci s textovými soubory

## 1. Třída `File`

Třída `File` nabízí **statické metody**, které velmi zjednodušují manipulaci se soubory:

- `File.WriteAllText(path, text)` – zapíše celý text do zadaného souboru (pokud soubor existuje, přepíše jej).
- `File.AppendAllText(path, text)` – přidá text na konec souboru (pokud soubor neexistuje, vytvoří jej).
- `File.ReadAllText(path)` – načte celý obsah souboru do jednoho řetězce.
- `File.ReadAllLines(path)` – načte soubor po řádcích do pole řetězců.

### Jednoduché příklady:

``` cs
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string cesta = "text.txt";
        string text = "Ahoj, tohle je nový řádek!";

        // 1. Zápis do souboru (přepíše, pokud soubor existuje)
        File.WriteAllText(cesta, text);

        // 2. Čtení ze souboru
        string obsah = File.ReadAllText(cesta);
        Console.WriteLine("Obsah souboru: " + obsah);

        // 3. Přidání dalšího řádku
        File.AppendAllText(cesta, "\nDalší řádek...");
        
        // 4. Opětovné přečtení a vypsání obsahu
        obsah = File.ReadAllText(cesta);
        Console.WriteLine("Aktualizovaný obsah: \n" + obsah);
    }
}
```

---

## 2. Práce s `StreamWriter` a `StreamReader`

Toto je **flexibilnější** (i když o něco zdlouhavější) způsob, který vám umožňuje pracovat se soubory **krok po kroku**.

- **`StreamWriter`** – pro zápis do souboru.
- **`StreamReader`** – pro čtení ze souboru.

Díky nim můžete číst a psát řádek po řádku (nebo i jednotlivé znaky).

### Zápis pomocí `StreamWriter`

``` cs
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string cesta = "vystup.txt";

        // Pomocí using zajistíme, že se writer po skončení bloku korektně uzavře.
        using (StreamWriter writer = new StreamWriter(cesta))
        {
            writer.WriteLine("První řádek");
            writer.WriteLine("Druhý řádek");
        } // Zde dojde k uzavření writeru.
    }
}
```

### Čtení pomocí `StreamReader`

``` cs
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string cesta = "vystup.txt";

        using (StreamReader reader = new StreamReader(cesta))
        {
            // Bude číst řádek po řádku, dokud nenarazí na konec souboru.
            string? radek;
            while ((radek = reader.ReadLine()) != null)
            {
                Console.WriteLine(radek);
            }
        }
    }
}
```

---

## Ukázková úloha: Textový zápis a čtení

### Zadání

1. Vytvořte jednoduchý program, který **vždy** zapíše (nebo vytvoří) **textový soubor na ploše**.  
2. Uživatel do konzole zadá řetězec, který do souboru uložíte.  
3. Nakonec obsah téhož souboru načtěte a vypište do konzole.

### Řešení

``` cs
:)
```
