# Teszt automatizálás

A tesztelés fáradtságos tud lenni. Láthattuk, hogy a fejlesztés során a Unit tesztek készítése, karbantartása plusz munkát jelent (persze ez később megtérül).

Mi a helyzet, amikor különböző grafikus felületeket, weboldalakat kell tesztelni? Végig kell nyomogatni a menüpontokat 10x, 100x? Nem lehet ezt automatizálni? De lehet, azonban ez is szinte külön szakma a szoftverfejlesztésen belül. Ebbe fogunk betekinteni, amennyire lehet. 

Ezekre a feladatokra külön keretrendszerek léteznek, ezek közül a legismertebbek: Selenium, Appium, Katalon. A seleniummal kezdjük az ismerkedést. 

A célunk annak a megvalósítása, hogy legyen egy kis program, (még nem is lesz ez teszt), amely bemutatja, hogy hogyan is működik az automatizálás. A selenium képes arra, hogy a segítségével a mezőkbe való beírást, linkekre való kattintást, letöltést stb. automatizálni tudjuk.


Készítsünk egy új, konzolos projektet!

Nuget csomagok telepítésére lesz szükség. A **Solution**-ön jobb klikk, majd **Manage Nuget Packages for Solution**.

