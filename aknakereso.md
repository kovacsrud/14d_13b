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
 - A legfontosabb a konstruktor, beállítjuk a grafikus elemeket, a rétegeket, állapotváltozókat.
 
```C#
public GameItem(int up,int down)
{
    UpLayer = new Label();
    DownLayer = new Label();

    elemek =  new FontAwesome.WPF.FontAwesome[12];
    for (int i = 0; i < elemek.Length; i++)
    {
        elemek[i]= new FontAwesome.WPF.FontAwesome();
    }

    elemek[0].Icon = FontAwesomeIcon.Bomb;
    elemek[0].FontSize = 20;
    elemek[1].Text = "1";
    elemek[1].FontSize = 20;
    elemek[2].Text = "2";
    elemek[2].FontSize = 20;
    elemek[3].Text = "3";
    elemek[3].FontSize = 20;
    elemek[4].Text = "4";
    elemek[4].FontSize = 20;
    elemek[5].Text = "5";
    elemek[5].FontSize = 20;
    elemek[6].Text = "6";
    elemek[6].FontSize = 20;
    elemek[7].Text = "7";
    elemek[7].FontSize = 20;
    elemek[8].Text = "7";
    elemek[8].FontSize = 20;
    elemek[9].Icon = FontAwesomeIcon.Flag;
    elemek[9].FontSize = 20;
    elemek[10].Icon = FontAwesomeIcon.Square;
    elemek[10].FontSize = 20;
    elemek[10].Foreground = Brushes.Beige;
    elemek[11].Icon = FontAwesomeIcon.SquareOutline;
    elemek[11].FontSize = 20;

    SetUpLayer(up);
    SetDownLayer(down);
    Covered = true;
    Flagged = false;


}
```
- A felső réteg elemének módosítása, akkor kell, amikor zászlóval megjelöljük az elemet

```C#
public void ChangeUpIcon(int elem)
{
    StackPanel pn = (StackPanel)UpLayer.Content;
    FontAwesome.WPF.FontAwesome actIcon = (FontAwesome.WPF.FontAwesome)pn.Children[0];
    actIcon.Icon = elemek[elem].Icon;     
            
}
```
## Vegyük használatba a GameItem osztályt!

Az ablak XAML fájljában készítsünk egy Grid-et, a neve legyen alapGrid.
```xml
 <Grid x:Name="alapGrid">
        
 </Grid>
```


Egyenlőre az ablak mögöttes kódjába dolgozunk, később minden játékkal kapcsolatos tevéknységet külön osztályba helyezünk.

**A kiinduló állapot:**

```C#
 public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }
    }
```

**Hozzuk létre a szükséges mezőket**

```C#
public partial class MainWindow : Window
    {
        GameItem[,] gameItems;
        int sor;
        int oszlop;
        //BombPos bombaHelyek;
        bool IsBomb;

        public MainWindow()
        {
            InitializeComponent();
        }
    }
```
Az **IsBomb** logikai változó jelzi, ha aknára léptünk, ebben az esetben felfedjük a teljes játékteret, és játék vége.

A **MainWindow()** metódusban elvégezzük a létrehozó műveleteket (lesz egy pár)

```C#
sor = 20;
oszlop = 20;
gameItems = new GameItem[sor, oszlop];

for (int i = 0; i < gameItems.GetLength(0); i++)
{
    for (int j = 0; j < gameItems.GetLength(1); j++)
       {
           gameItems[i, j] = new GameItem(11,10);
       }
}
IsBomb = false;

//ide jön a többi művelet
```

Látszik, hogy BombPos osztály egyenlőre nincsen (ez volt a múltkori feladat), az egyenlőre ki van kommentelve.

**Jelenleg akkor így állunk:**

```C#
public partial class MainWindow : Window
    {
        int sor;
        int oszlop;
        GameItem[,] gameItems;
        //BombPos bombaHelyek;
        bool IsBomb;

        public MainWindow()
        {
            InitializeComponent();
            sor = 20;
            oszlop = 20;
            gameItems = new GameItem[sor, oszlop];

            for (int i = 0; i < gameItems.GetLength(0); i++)
            {
                for (int j = 0; j < gameItems.GetLength(1); j++)
                {
                    gameItems[i, j] = new GameItem(11, 10);
                }
            }
            IsBomb = false;
            CreateGrid(sor, oszlop);
        }
    }
```
**A következő lépés a Grid létrehozása. Ezt kódból kell csinálni, külön metódust készítünk erre a célra, nevezzük el CreateGrid-nek**.


```C#
public void CreateGrid(int sor, int oszlop)
{
    Grid mineGrid = new Grid();
            //sor ill. oszlop definíciókat kell hozzáadni
            //először
            for (int i = 0; i < sor; i++)
            {
                RowDefinition rowdef = new RowDefinition();
                mineGrid.RowDefinitions.Add(rowdef);
            }
            for (int i = 0; i < oszlop; i++)
            {
                ColumnDefinition coldef = new ColumnDefinition();
                mineGrid.ColumnDefinitions.Add(coldef);
            }

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {                                 
                            
                            mineGrid.Children.Add(gameItems[i,j].GetUpLayer());
                            Grid.SetRow(gameItems[i, j].GetUpLayer(), i);
                            Grid.SetColumn(gameItems[i, j].GetUpLayer(), j);
                            //itt majd hozzá kell adni egy eseménykezelő függvényt a bal gombos kattintáshoz
                            //itt majd hozzá kell adni egy eseménykezelő függvényt a jobb gombos kattintáshoz
                }

            }
            
    alapGrid.Children.Add(mineGrid);
}
```
Ezek után a kódnak futnia kell, és meg kell jelennie a 20x20-as gridnek. Mára ennyi.

2020.03.24

A mai feladat a múltkori feladat belegyúrása a projektbe. A múlkori feladat az volt, hogy mindenki készítsen egy osztályt, amely létrehozza a bombák pozícióit egy 2 dimenziós térben.

Létrehozunk egy új osztályt, **BombPos** néven

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAknakereso
{
    public class BombPos
    {

    }
}
```
Ebbe az osztályba készítünk egy beágyazott osztályt, ez fogja tárolni egy bomba pozícióját

```C#
public class Pos
        {

            public int sor { get; set; }
            public int oszlop { get; set; }

            public Pos(int sor, int oszlop)
            {
                this.sor = sor;
                this.oszlop = oszlop;
            }
                        
        }
```

Létrehozunk egy listát a pozíciók tárolására. A lista gyakorlatilag Property-ként fog működni. A bombapoziciók privát láthatóságú, ezt csak az osztály tudja változtatni. A bombak publikus, és csak olvasható.

```C#
private List<Pos> bombapoziciok=new List<Pos>();
public List<Pos> bombak {
     get { return bombapoziciok; }
           
}
```
Véletlenszámra szükség lesz:
```C#
 Random rand = new Random();
```

Jöjjön a konstruktor. Paraméterként jön a játéktér sorainak, oszlopainak száma, valamint hogy hány aknapozíció kell.

```C#
public BombPos(int sorSzam,int oszlopSzam,int darabszam)
        {
            for (int i = 0; i <darabszam ; i++)
            {
                var randSor = rand.Next(0, sorSzam + 1);
                var randOszlop = rand.Next(0, oszlopSzam + 1);

                while (bombapoziciok.Any(x => x.sor == randSor && x.oszlop == randOszlop))
                {
                    randSor = rand.Next(0, sorSzam + 1);
                    randOszlop = rand.Next(0, oszlopSzam + 1);
                }
                bombapoziciok.Add(new Pos(randSor, randOszlop));
            }
            
        }
```

Ezek után, a főprogramból már használható az osztály.

A főprogramban először hozzunk létre egy példányt a BombPos osztályból, ez az osztály fogja a pozíciókat szolgáltatni a bombák elhelyezéséhez. A **MainWindow()** metódusban kell létrehozni a példányt.

```C#
BombPos bombaHelyek;
```

## Aknarakó metódus írása

Már van egy gridünk, melyekben Label-ek vannak. A feladat most az, hogy a BombPos osztály példánya által megadott pozíciók esetében a Label-en megadott karatert bombára alakítsuk. Ezt végzi el az Aknarako metódus. Ez bemenő paraméterként megkapja a sorok és az oszlopok számát, valamint azt a gridet, amelyen a gyerek gridjén végig kell menni. Végigmegyünk a gameItems tömbön, és ha a pozíciója benne van a bombák pozíciói között, akkor az alsó réteget 0-ra állítjuk (ez a bomba pozíciója a gameitemek között).

```C#
 public void Aknarako(int sor, int oszlop,Grid alapGrid)
        {
            var aknaSzam = (sor * oszlop) / 10;

            bombaHelyek = new BombPos(20, 20, aknaSzam);


            foreach (Grid mineGrid in alapGrid.Children)
            {
                foreach (Label item in mineGrid.Children)
                {

                    var s = Grid.GetRow(item);
                    var o = Grid.GetColumn(item);

                    if (bombaHelyek.bombak.Any(x=>x.sor==s && x.oszlop==o))
                    {
                        gameItems[s, o].SetDownLayer(0);
                    }
                }

            }
                           
            
        }
```
