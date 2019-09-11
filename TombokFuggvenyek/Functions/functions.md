# Függvények (metódusok)

A függvény gyakorlatilag egy alprogram, amelyet létrehozás után annyiszor hívunk meg(hajtatunk végre), ahányszor szükség van rá. Minden olyan tevékenységet, amelynek végrehajtására többször is szükség van érdemes függvénybe tenni.

## Nagyon egyszerű függvény

```C#
 public static void Kiir()
        {
            Console.WriteLine("Igazán egyszerű függvény");
        }
```
**void** jelentése: A függvénynek nincs visszatérési értéke.

Ha általánosabban akarunk használni egy függvényt, akkor átadhatunk neki értékeket.
Ebben az esetben az átadott értékek lokális változóként jönnek létre és csak a függvény kódblokkjában lesznek elérhetőek.

```C#
public static void Kiir(string szoveg)
  {
     Console.WriteLine(szoveg);
  }
```
Egy függvénynek ugyanazzal a névvel több alakja is lehet (overloading), ebben az esetben a paraméterlistáknak különbözniük kell.

**Függvény visszatérési értékkel**

Ebben az esetben deklarációkor meg kell adni a visszatérési érték típusát, illetve a **return** utasítással visszaadni a visszatérési értéket.
```C#
public static int Osszeg(int a,int b)
   {
      return a + b;
   }
```