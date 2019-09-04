# Változók, változó típusok
---
## Számokat tároló változók


### egész típusok
```c#
            int a = 12;
            byte b = 125;
            short c = -12;
            long d = 1231;
```

### Szöveg 
```c#
            String str = "Valami szöveg";
```

### karakter
```c#
            Char ch = 'z';
```
### lebegőpontos számok

```c#
            float e = 1.126f; //32 bites
            double f = 23.577; //64 bites
            decimal g = 456.2353455m; //128 bites
```

### logikai

```c#
            bool igaze = true;
```
Ezek a változók ún. érték típusú változók

## Referencia típusú változók
### Tömb, objektumok

            tömb kezdőértékekkel
			```c#
            String[] szovegek = {"egy","kettő","három" };
			```

            kezdőértékek nélkül
			```c#
            String[] szovegek2 = new String[3];
			```
			Nem a tömb, hanem csak a referenciája másolódik le!

			```c#
			String[] szovegek3 = szovegek;
			
            szovegek3[0] = "száz";

            Console.WriteLine($"A:{a},B:{b}");
            Console.WriteLine($"Sz:{szovegek[0]},Sz3:{szovegek3[0]}");
			```

