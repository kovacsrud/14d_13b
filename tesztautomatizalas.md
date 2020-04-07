# Teszt automatizálás

A tesztelés fáradtságos tud lenni. Láthattuk, hogy a fejlesztés során a Unit tesztek készítése, karbantartása plusz munkát jelent (persze ez később megtérül).

Mi a helyzet, amikor különböző grafikus felületeket, weboldalakat kell tesztelni? Végig kell nyomogatni a menüpontokat 10x, 100x? Nem lehet ezt automatizálni? De lehet, azonban ez is szinte külön szakma a szoftverfejlesztésen belül. Ebbe fogunk betekinteni, amennyire lehet. 

Ezekre a feladatokra külön keretrendszerek léteznek, ezek közül a legismertebbek: Selenium, Appium, Katalon. A seleniummal kezdjük az ismerkedést. 

A célunk annak a megvalósítása, hogy legyen egy kis program, (még nem is lesz ez teszt), amely bemutatja, hogy hogyan is működik az automatizálás. A selenium képes arra, hogy a segítségével a mezőkbe való beírást, linkekre való kattintást, letöltést stb. automatizálni tudjuk.


Készítsünk egy új, konzolos projektet!

Nuget csomagok telepítésére lesz szükség. A **Solution**-ön jobb klikk, majd **Manage Nuget Packages for Solution**.

A **Browse** ra váltani, majd beírni ***selenium***.

Kiválasztani és telepíteni a következőket:
  - **Selenium.WebDriver**
  - **Selenium.FireFox.WebDriver** 
  
A következőt valósítjuk meg: belépés a Tanlaktanyára, majd belépés a 14d13b kurzusába, és annak az ott található feltöltések megszámlálása, illetve a feltöltések kiíratása.

Létrehozunk egy ún. drivert, ami a böngésző vezérlését fogja végezni. 
```C#
IWebDriver driver = new FirefoxDriver();
```
A piros aláhúzásoknál CTRL+.-al töltsük be a szükséges névtereket.

Elvégezzük a szükséges beállításokat:
```C#
driver.Url = "https://tanlaktanya.taszi.hu";
driver.Manage().Window.Maximize();
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
```
Az ImplicitWait-re azért van szükség, mert a weboldal letöltése több-kevesebb időbe telik, így ha ezt nem várnánk meg, akkor a későbbi műveletek kivételre futnának, hiszen nem lehet rákattintani egy linkre, ami még nincs is ott.

Először is a programnak meg kell találnia a **Belépés** szövegű linket

```C#
