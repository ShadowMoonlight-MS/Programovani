
# Zásobník (`Stack<T>`) v C#

✅ **Co je `Stack<T>`?**  
`Stack<T>` je datová struktura, která pracuje na principu **LIFO** (*Last In, First Out*), což znamená, že poslední prvek, který do zásobníku přidáte, bude první, který odeberete.

### 📦 **Příklad z reálného života:**  
Představte si zásobník talířů v restauraci. Nový talíř položíte navrch, a když chcete nějaký vzít, vezmete ten úplně nahoře.

---

## ⚙️ **Základní operace:**
- **`Push(T item)`** – přidá prvek na vrchol zásobníku.
- **`Pop()`** – odebere a vrátí prvek z vrcholu zásobníku.
- **`Peek()`** – vrátí prvek z vrcholu zásobníku bez odebrání.
- **`Count`** – vrací počet prvků v zásobníku.
- **`Clear()`** – vyprázdní zásobník.

---

## 📌 **Příklad:**

``` csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> zasobnik = new Stack<string>();

        // Přidání prvků
        zasobnik.Push("První");
        zasobnik.Push("Druhý");
        zasobnik.Push("Třetí");

        // Zobrazení vrchního prvku bez odebrání
        Console.WriteLine("Vrchol zásobníku: " + zasobnik.Peek());

        // Odebrání prvků (LIFO)
        Console.WriteLine("Odebráno: " + zasobnik.Pop());
        Console.WriteLine("Odebráno: " + zasobnik.Pop());
    }
}
```

### 💡 **Výsledek:**

```cs
Vrchol zásobníku: Třetí
Odebráno: Třetí
Odebráno: Druhý
```

---

# 📝 **Úloha 1 (Lehčí) – Reverze textu pomocí zásobníku**

### **Zadání:**
Napište program, který:
- Načte řetězec od uživatele.
- Pomocí `Stack<char>` obrátí pořadí znaků v řetězci.
- Vypíše obrácený řetězec.

### **Nápověda:**
- Pro každý znak v řetězci použijte `Push()`.
- Pak použijte `Pop()` k postupnému vyjmutí znaků a vytvoření obráceného textu.



### **Output:**

```cs
Zadejte text:
ahoj
Obrácený text:
joha
```

---

# 📝 **Úloha 2 (Těžší) – Kontrola správnosti závorek**

### **Zadání:**
Napište program, který zkontroluje, zda jsou všechny závorky v řetězci správně uzavřeny a zanořeny.  
Podporované závorky: `()`, `{}`, `[]`

### **Příklady vstupu/výstupu:**
- ✅ `"({[]})"` → **Správně**  
- ❌ `"(]"` → **Chyba**  
- ❌ `"((())"` → **Chyba**

### **Nápověda:**
- Použijte `Stack<char>` k uchovávání otevíracích závorek.
- Když najdete zavírací závorku, zkontrolujte, jestli odpovídá té na vrcholu zásobníku (`Peek()` + `Pop()`).
- Pokud zásobník na konci není prázdný, znamená to chybu v párování.

### **Output:**

``` csharp
Zadejte výraz:
({[]})

Správně uzavřené závorky.
```

### **Output:**

``` csharp

Zadejte výraz:
(]
Špatně uzavřené závorky.
```
