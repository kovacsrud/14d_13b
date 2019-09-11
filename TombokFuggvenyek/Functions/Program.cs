using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        public static void Kiir(string szoveg)
        {
            Console.WriteLine(szoveg);
        }
        public static void Kiir()
        {
            Console.WriteLine("_default");
        }

        public static int Osszeg(int a,int b)
        {
           return a + b;
        }

        //érték szerinti paraméter átadás
        public static void Ertek(int a)
        {
            a = a * a;
        }
        //cím szerinti paraméter átadás
        public static void Cim(ref int a)
        {
            a = a * a;
        }
        //Függvény, amely visszatér egy egész szám 
        //valamely egész hatványával   

        public static double Hatvany(double szam,double kitevo)
        {

            return Math.Pow(szam, kitevo);
            
        }

        static void Main(string[] args)
        {
            Kiir("Átadott szöveg");
            Kiir("Minta szöveg");
            Kiir();
            var a = Osszeg(3, 12);
            Console.WriteLine(a);
            Console.WriteLine(Osszeg(25,129));
            a = 3;
            Ertek(a);
            Console.WriteLine(a);
            Cim(ref a);
            Console.WriteLine(Hatvany(2,3));

            Console.ReadKey();
        }
    }
}
