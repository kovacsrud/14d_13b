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

            //lebegőpontos számok
            float e = 15.12643543793475959755459f; //32 bites
            double f = 15.12643543793475959755459; //64 bites
            decimal g = 15.12643543793475959755459m; //128 bites

            Console.WriteLine($"E:{e},F:{f}, G:{g}");

            Console.ReadKey();
        }
    }
}
