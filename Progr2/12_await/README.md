
# Proč asynchronní programování?

**Nechcete blokovat uživatele:** Když aplikace provádí dlouhotrvající operaci (třeba stahování dat z internetu), synchronní kód by zablokoval uživatelské rozhraní.

**Využití vícejádrových procesorů:** Moderní hardware má více jader. Asynchronní a paralelní kód umožní tato jádra využít k urychlení zpracování.

**Odlišujte asynchronii od paralelizace:** Asynchronní kód často řeší to, že nechceme „čekat“ (blokovat vlákno), zatímco paralelizace znamená, že se reálně provádí více úloh současně na víc jádrech. V praxi to často kombinujeme.

### Ale proč je to tak, že nechceme blokovat?
Když program na něco čeká (třeba na data z disku nebo z webu), CPU reálně nic užitečného nedělá, jen sedí a čeká na odpověď. Asynchronní kód říká: „Dej mi vědět, až to bude, do té doby si budu dělat něco jiného (nebo nic, ale nezablokuji hlavní vlákno UI).“


# Základní stavební kameny

### Task a Task<TResult>
Task představuje asynchronní operaci, která se může dokončit v budoucnu.
Můžete si to představit jako „slib“, že výpočet jednou skončí – a my s výsledkem můžeme pracovat, až je hotový.

### async a await
- **async**: Označí metodu, že uvnitř může používat klíčové slovo await.
- **await**: Řekne programu „Počkej, až se tato asynchronní operace dokončí, a pak pokračuj dál.“

Když v asynchronní metodě narazíte na `await`, metoda se rozdělí: to, co je před `await`, se vykoná hned, a to, co je po `await`, se vykoná až po dokončení dané operace.
Díky tomu se neblokuje celé vlákno – vlákno mezitím může dělat jiné věci.


# Jednoduchý příklad

```cs
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Ahoj, začínám asynchronní metodu...");

        // Volání asynchronní metody
        await UkazkovaMetodaAsync();

        Console.WriteLine("Pokračuji, až když je UkazkovaMetodaAsync hotová.");
    }

    static async Task UkazkovaMetodaAsync()
    {
        Console.WriteLine("Pracuji v asynchronní metodě...");
        // Napodobíme zpoždění třeba 3 sekundy
        await Task.Delay(3000);
        Console.WriteLine("Hotovo, vracím se zpět.");
    }
}
```

### Co se tu děje?
- `Main` je označena jako `async Task Main`, což od C# 7.1 a výše umožňuje asynchronní vstupní bod.
- Spustí se `UkazkovaMetodaAsync()`, která běží asynchronně.
- Když dojde na `await Task.Delay(3000)`, tak se metoda „přeruší“ a vlákno se může věnovat něčemu jinému (např. UI).
- Po 3 sekundách se pokračuje dál.

```
# 4. Asynchronní stahování dat (ukázka s HttpClient)

Trochu realističtější příklad je stahování dat z webu, což je v praxi typická asynchronní operace.

```csharp
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://www.example.com";

        Console.WriteLine($"Stahuji data z: {url}");
        string obsah = await StahniStrankuAsync(url);

        Console.WriteLine("Délka staženého obsahu: " + obsah.Length);
    }

    static async Task<string> StahniStrankuAsync(string url)
    {
        using HttpClient client = new HttpClient();
        // GetStringAsync je asynchronní metoda
        string data = await client.GetStringAsync(url);
        return data;
    }
}
```

### Proč je to důležité?
Bez asynchronního přístupu by se vlákno zablokovalo a uživatel by čekal, než se data stáhnou.
Takhle necháme operaci běžet „na pozadí“ a UI vlákno (nebo hlavní vlákno) může žít dál.


# Úkoly k procvičení

### Úloha 1: Asynchronní časovač
Napište metodu `AsynchronniOdpočet(int sekundy)`, která:
- Každou sekundu vypíše „Zbývá X sekund“.
- Po uplynutí všech sekund vypíše „Konec odpočtu!“.  
V `Main` zavolejte tuto metodu a ukažte, že mezitím program může vypisovat další věci, aniž by čekal.

#### Nápověda:
Můžete použít `await Task.Delay(1000)` v cyklu.
Zkuste vypsat třeba „Dělám něco jiného…“ a uvidíte, jak se to proloží s výpisem odpočtu.

### Úloha 2: Více asynchronních volání najednou
Vytvořte metodu `StahniDataAsync(string url)`, která stáhne obsah stránky a vrátí `string`.
V `Main` si připravte pole URL adres, např. `{ "https://www.example.com", "https://www.google.com", ... }`.
Stáhněte obsah všech stránek paralelně.
K tomu můžete použít `Task.WhenAll(...)`, abyste spustili všechny stahovací metody najednou a pak čekali, až se všechny dokončí.
Po stažení všech stránek vypište, kolik znaků má každá stránka.

#### Nápověda:
```cs
Task<string>[] ukoly = urls.Select(url => StahniDataAsync(url)).ToArray();
string[] vysledky = await Task.WhenAll(ukoly);
```
Pak můžete třeba projít `vysledky` a vypsat délky.


# Důležité drobnosti
- **Výjimky v asynchronním kódu:** Pokud se v asynchronním kódu stane chyba, zabalí se do `Task`, a když pak použijete `await`, vyhodí se reálně v místě, kde `await` proběhne. Můžete tak chytat výjimky standardním `try-catch` blokem okolo `await`.
- **Zásady thread-safety:** Dávejte si pozor na přístup ke sdíleným zdrojům v paralelním kódu.
- **`async void`:** Používejte jen pro event handlery v UI, jinak preferujte `Task` nebo `Task<T>`.



