
# WPF alkalmazás tesztelésének automatizálása

Egy komplexebb alkalmazás az egyes osztályokon kívül számos grafikus felületet (UI-user interface) foglalhat magába. Nem csak a háttérben dolgozó egységek tesztelése szükséges, hanem a UI működését is szükséges tesztelni. Ennek az elvégzése fáradtságos munkával járhat, ezért szükség lehet a tesztelés automatizálására.

A windowsos grafikus felületű alkalmazások automatizált tesztelése hasonlít a böngészőben végzett tesztekhez. A felület elemeibe adatokat küldhetünk, gombra kattintást programozhatunk stb. Az egyes tesztesetekre tesztekek készíthetünk, és utána annyiszor futtathatóak, amennyiszer szükséges. A tesztek eredményéről riportot lehet készíteni stb.

A cél: Egy nagyon egyszerű, Celsius-Fahrenheit hőmérséklet átszámító program készítése, majd tesztelése automatizált teszttel, és a végén riport készítése a tesztek futásáról.

Egy új Wpf alkalmazás a kiindulópont a projekt neve legyen **WpfHomersekletAtvalto**.

A projekt létrehozása után adjunk hozzá egy új osztályt az osztály neve legyen **HomersekletAtvalto**. Erre az osztályra bízzuk a megfelelő hőmérsékletértékek kiszámítását. Két metódusa lesz, az egyik Celsius fokot vált Fahrenheit-re, a másik Fahrenheit fokot Celsiusra. Statikus osztály lesz, így nem lesz szükség külön példányosításra.

Az osztály kódja,metódusai:
```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHomersekletAtvalto
{
    public static class HomersekletAtvalto
    {
       

        public static double CelsiusToFahrenheit(double celsius)
        {

            return (celsius * 1.8) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {

            return (fahrenheit - 32) / 1.8;
          
        }
    }
}
```

### Az alkalmazás felülete így fog kinézni:

!(honkonvertalo.png A felület)

