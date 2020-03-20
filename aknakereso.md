# Aknakereső játék

A kialakult helyzet miatt jobb ha elölről kezdjük az aknakereső kivitelezését. Igyekszem lépésről-lépésre követhetően leírni a programot, magyarázatokkal. Érdemes lesz egy teljesen új projektet készíteni, mondjuk **Aknakereso** néven. A program FontAwesome elemeket fog használni ezért a megfelelő Nuget-et fel kell telepíteni.

Számos osztályból fog a program összeállni.

Először is készítsünk egy osztályt amiben a grafikus elemeket, és az azokkal kapcsolatos műveleteket kezeljük. Az osztály neve legyen **GameItem**. Ezekből a GameItem-ekből áll majd össze a játéktér. Minden GameItem-ben lesz két "réteg", ami **Label**-ekkel lesz megvalósítva. Induláskor a felső réteg látszódik majd a játéktérben. Ha bal gombbal kattintanak, akkor a felső réteg helyére az alsó kerül. Jobb gombbal való kattintáskor a felső réteg elemét zászlóra módosítjuk, ismételt kattintás esetén a zászlót eltüntetjük. A GameItem-ek egy 2 dimenziós tömböt alkotnak. Ezeknek a megfelelő rétegét egy **Grid**-be tesszük, amelynek dimenziója megegyezik a tömbével.


Hozzuk létre a **GameItem** osztályt:
```C#
public class GameItem
{
    
}
```
Az osztály mezői:
Az osztály mezőinek hozzáadása következik, amelyek a következők:
 - elemek tömb, ebben tároljuk a grafikus elemeket
 ```C#
 public FontAwesome.WPF.FontAwesome[] elemek;
 
 ```
 - A két réteg
 
 ```C#
 public Label UpLayer;
 public Label DownLayer;
 ```
 
 Egy logikai változó annak jelzésére, hogy az elem "fedett-e" azaz a felső rétege van-e megjelenítve, vagy már az alsó
 ```C#
 public bool Covered;
 ```
 Egy másik logikai változó, amely jelzi, ha zászlóval van megjelölve az elem.
 ```C#
 public bool Flagged;
 ```
 
 
