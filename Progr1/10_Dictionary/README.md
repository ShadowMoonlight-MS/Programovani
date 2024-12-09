### Dictionary in C#

`Dictionary<TKey, TValue>` je kolekce, která mapuje unikátní **klíče** (`TKey`) na odpovídající **hodnoty** (`TValue`). Každý klíč je v rámci `Dictionary` unikátní, a hodnoty k němu přiřazené mohou být libovolného typu.

### Jak funguje `Dictionary`:
- Můžete přidávat položky pomocí `Add()` nebo indexátoru.
- Přístup k hodnotám je rychlý díky internímu použití hashování.
- Při pokusu o přístup k neexistujícímu klíči dojde k výjimce `KeyNotFoundException`, nebo můžete použít metodu `TryGetValue()` pro bezpečný přístup.

#### Základní příklad:
``` cs
Dictionary<string, int> dict = new Dictionary<string, int>();
dict.Add("apple", 5);
dict["banana"] = 3;

Console.WriteLine(dict["apple"]);  // Vytiskne 5
Console.WriteLine(dict["banana"]); // Vytiskne 3
``` 

### Úloha 1: Seznam věcí na nákup
Vytvořte `Dictionary`, který bude uchovávat názvy produktů jako klíče a jejich množství jako hodnoty. Přidejte alespoň 5 položek a vypište je.

**nápověda**:
``` cs
    Console.WriteLine($"{item.Key}: {item.Value}");
``` 

### Úloha 2: Hledání zaměstnanců podle ID
Vytvořte `Dictionary`, kde klíčem je ID zaměstnance (řetězec) a hodnotou jeho jméno (řetězec). Přidejte několik zaměstnanců a implementujte funkci, která najde zaměstnance podle jeho ID.



### BONUS: Sčítání frekvence slov 
Vytvořte `Dictionary`, které bude uchovávat slova jako klíče a jejich výskyt v textu jako hodnoty. Na základě daného textu spočítejte, kolikrát se každé slovo vyskytuje.

**Řešení**:
```cs
//vstup: pes pes pes kočka
//výstup: pes 3 kočka 1
``` 

### Závěr:
- `Dictionary<TKey, TValue>` je ideální pro případy, kdy potřebujete rychlý přístup k hodnotám na základě unikátního klíče.
- Můžete jej využít pro mapování, hledání, sčítání a další operace, kde se vyžaduje efektivní ukládání a vyhledávání dat.
