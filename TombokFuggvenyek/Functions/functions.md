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
# Érték és cím szerinti paraméter átadás

Az alábbi két függvény közül az első érték szerinti átadással kap paramétert. Ebben az esetben az átadott változó lemásolódik, a globális változó értéke nem fog változni.

**Érték szerinti paraméterátadás**
```c#
 public static void Ertek(int a)
        {
            a = a * a;
        }
```
A hívás módja:
```C#
int a=3
Ertek(a);
```
A értéke a függvény hívása után is 3 lesz.
**Cím, vagy referencia szerinti paraméterátadás**
```c#
 public static void Cim(ref int a)
        {
            a = a * a;
        }
```
A hívás módja cím szerinti paraméter átadásnál:
```C#
int a=3
Cim(ref a);
```
Ebben az esetben az **a** változó címét adjuk át.
**a** változó értéke a Cim függvény hívása után 9 lesz.