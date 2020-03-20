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
Az osztály metódusai:

 - SetUpLayer a felső réteg beállítása. Jelen esetben nem a réteg **Text** tulajdonságába írunk, ugyanis a FontAwesome elemek ott nem használhatóak, hanem egy StackPanelt csinálunk, abba írunk, és ezt a StackPanelt adjuk hozzá a Label-hez. A szín megadás bedrótozása nem szép megoldás, később majd refaktorálni kell, de első verziónak elmegy. A bemenő paraméterben az elemek tömb elemének sorszámát adjuk meg, azaz hogy melyik elemet akarjuk használni.
 
 ```C#
  public void SetUpLayer(int elem)
  {
    StackPanel pn = new StackPanel();
            
    pn.Children.Add(elemek[elem]);
    UpLayer.MinHeight = 40;
    UpLayer.Margin = new Thickness(1);
    UpLayer.VerticalAlignment = VerticalAlignment.Center;
    UpLayer.HorizontalAlignment = HorizontalAlignment.Center;
    UpLayer.Background = Brushes.AliceBlue;
    UpLayer.Content = pn;
           
}
 ```
  - SetDownLayer az alsó réteg beállítása.
  
```C#
public void SetDownLayer(int elem)
{
            
    StackPanel pn = new StackPanel();
            
    pn.Children.Add(elemek[elem]);
    DownLayer.MinHeight = 40;
    DownLayer.Margin = new Thickness(1);
    DownLayer.VerticalAlignment = VerticalAlignment.Center;
    DownLayer.HorizontalAlignment = HorizontalAlignment.Center;
    DownLayer.Background = Brushes.AliceBlue;
    DownLayer.Content = pn;
           
}
```
 - A felső réteg lekérdezése
```C#
public Label GetUpLayer()
{
    return UpLayer;
}
```
- Az alsó réteg lekérdezése

```C#
public Label GetDownLayer()
{
    return DownLayer;
}
```


