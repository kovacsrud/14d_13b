# Beágyazott tömbök

Olyan tömbök, ahol a tömb elemei tömböket tartalmaznak. A tömbök típusa egyezőkell hogy legyen, de az elemszámok különbözhetnek.

## Deklaráció
```C#
 int[][] betomb = new int[3][];
```
## Feltöltés adatokkal
```C#
betomb[0] = new int[] {1,2,3,7,8 };
betomb[1] = new int[] {4,5,6 };
betomb[2] = new int[] { 11, 26, 85, 44 };
```

## Kiíratás

```c#
for (int i = 0; i < betomb.Length; i++)
        {
          for (int j = 0; j < betomb[i].Length; j++)
            {
                 Console.Write(betomb[i][j]+" ");
            }
          Console.WriteLine();
        }
```