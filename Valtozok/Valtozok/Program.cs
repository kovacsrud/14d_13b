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

            Console.ReadKey();
        }
    }
}
