# OOP, öröklődés

Az öröklődés során egy osztálynál megadhatunk egy ős osztályt. Az ős osztály tulajdonságai és metódusai az utód osztályban is elérhetőek lesznek.

**Allat osztály**
```C#
class Allat
    {
        public int Suly { get; set; }

        public Allat(int suly)
        {
            Suly = suly;
        }
        public Allat()
        {
            Suly = 1;
        }

        public virtual void  Eszik()
        {
            Console.WriteLine("Az állat eszik");
        }

        public void  Iszik()
        {
            Console.WriteLine("Az állat iszik");
        }


    }
```

**Kutya osztály az Allat-ból leszármaztatva**
```C#
    class Kutya:Allat
    {
        

        public int LabakSzama { get; set; }
        public string Fajta { get; set; }

        

        public void Ugat()
        {
            Console.WriteLine("A kutya ugat");
        }

        public void Kapar()
        {
            Console.WriteLine("Kapar a kutya");
        }

        public override void Eszik()
        {
            Console.WriteLine("A kutya eszik");
        }
```
Az utód osztályban az ős osztály metódusait felül lehet írni, azonban ehhez az ős osztályban a felülírni kívánt metódusnál szerepelnie kell a **virtual** kulcsszónak.

Ha szükség van az ős osztály paraméteres konstruktorának hívására akkor az utódban kell létrehozni egy konstruktort, és a base() függvénnyel lehet hivatkozni az ős paraméteres konstruktorára.
```C
public Kutya(int labakszama, string fajta,int suly) : base(suly)
        {
            LabakSzama = labakszama;
            Fajta = fajta;
        }
```

Az előbbi példában a suly paraméter értékét a base(suly) hívással az ős osztály konstruktorának adtuk át.

Ha szeretenénk egyetlen függvényhívással valamilyen áttekintést adni az adott objektumról, akkor felül tudjuk írni a **ToString()** metódusát, és ebben a metódusban megadhatjuk a megfelelő információkat.
pl.
```C#
 public override string ToString()
        {
            return $"Fajta:{Fajta},Súlya:{Suly},{LabakSzama} lába van.";
        }
```