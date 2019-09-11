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

        static void Main(string[] args)
        {
            Kiir("Átadott szöveg");
            Kiir("Minta szöveg");
            Kiir();
            var a = Osszeg(3, 12);
            Console.WriteLine(a);
            Console.WriteLine(Osszeg(25,129));                       

            Console.ReadKey();
        }
    }
}
