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
