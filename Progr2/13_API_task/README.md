## Úkol
udělejte jednoduchou aplikaci co vypisuje celý json z API `https://api.exchangerate-api.com/v4/latest/EUR`, aby jste věděli co se v API nachází, můžete zkusit dát url link do prohlížeče.


```csharp
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using var httpClient = new HttpClient();

        while (true)
        {
            
            var response = await httpClient.GetAsync("https://api.exchangerate-api.com/v4/latest/EUR");
            var jsonData = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Získaná data: {jsonData}\n");
            await Task.Delay(5000); // čekání 5 sekund
        }
    }
}

```

## Stažení dat z API

```csharp
var response = await httpClient.GetAsync("https://api.exchangerate-api.com/v4/latest/EUR");
```
`GetAsync()` – asynchronně provádí HTTP GET požadavek na API, které vrací směnné kurzy pro EUR.

```csharp
var jsonData = await response.Content.ReadAsStringAsync();
```
`ReadAsStringAsync()` – přečte odpověď API jako řetězec JSON.




## Úkol:

Uprav předchozí aplikaci tak, aby splňovala následující požadavky:

- Data z API získáš v podobě JSON a deserializuješ je do vhodného C# objektu pomocí knihovny `System.Text.Json`.
- Získej kurz EUR vůči CZK a USD z těchto dat a vypiš je do konzole v přehledném formátu.
- Pokud dojde k výpadku API, vypiš chybovou hlášku a pokračuj v načítání každých 5 sekund.
- Volitelně umožni uživateli zastavit aplikaci stiskem klávesy `Esc`.

### Příklad výstupu:

```cs
Kurz EUR vůči CZK: 24.76, USD: 1.09
Kurz EUR vůči CZK: 24.76, USD: 1.09
Kurz EUR vůči CZK: 24.76, USD: 1.09
Kurz EUR vůči CZK: 24.76, USD: 1.09
...
```

### Doporučení:

- Použij knihovnu `System.Text.Json` nebo `Newtonsoft.Json` pro parsování JSONu.
- Zkus si práci s asynchronními operacemi, výjimkami a opakovaným načítáním.
