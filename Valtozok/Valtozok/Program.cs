using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtozok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Érték típusok
            //szám típusú változók
            //egész típusok
            int a = Int32.MaxValue;
            byte b = Byte.MaxValue;
            short c = short.MaxValue;
            long d = 1231;

            //Szöveg 

            String str = "Valami szöveg";

            //karakter

            Char ch = 'z';

            //lebegőpontos számok
            float e = 1.126f; //32 bites
            double f = 23.577; //64 bites
            decimal g = 456.2353455m; //128 bites

            //logikai

            bool igaze = true;

            Console.WriteLine("A:{0}, B:{1}, C:{2}",a,b,c);
            Console.WriteLine($"A:{a},B:{b},C:{c}");

            //referencia típusú változók

            // tömb kezdőértékekkel
            String[] szovegek = {"egy","kettő","három" };

            //kezdőértékek nélkül
            String[] szovegek2 = new String[3];

            a = 0;
            b = 15;
            a = b;
            b = 20;

            String[] szovegek3 = szovegek;

            szovegek3[0] = "száz";

            Console.WriteLine($"A:{a},B:{b}");
            Console.WriteLine($"Sz:{szovegek[0]},Sz3:{szovegek3[0]}");


            Console.ReadKey();
        }
    }
}
