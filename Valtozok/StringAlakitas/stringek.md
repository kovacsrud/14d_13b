# String manipuláció

Ha karakterenként kell manipulálni egy 
String típusú adatot, akkor először karakter tömbbé kell azt
alakítani

**Az eredeti string**
```c#
var szoveg = "ValaMi SzÖVeg696";
```
**Karaktertömbbé alakítás**
```C#
Char[] szovegCh = szoveg.ToCharArray();
```
**Feldolgozás**

```C#
for (int i = 0; i < szovegCh.Length; i++)
            {
                if (Char.IsLower(szovegCh[i]))
                {
                    szovegCh[i] = Char.ToUpper(szovegCh[i]);
                } else
                {
                    szovegCh[i] = Char.ToLower(szovegCh[i]);
                }
            }
```
**Visszaalakítás stringgé**

```C#
szoveg = new string(szovegCh);
Console.WriteLine(szoveg);
```