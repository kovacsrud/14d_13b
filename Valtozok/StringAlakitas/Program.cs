using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlakitas
{
    class Program
    {
        static void Main(string[] args)
        {

            var szoveg = "ValaMi SzÖVeg696";

            Char[] szovegCh = szoveg.ToCharArray();

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

            var szamlalo = 0;

            for (int i = 0; i < szovegCh.Length; i++)
            {
                if (Char.IsDigit(szovegCh[i]))
                {
                    szamlalo++;
                    
                }
                
            }

            Console.WriteLine($"A szövegben {szamlalo} db szám van!");

            szoveg = new string(szovegCh);

            Console.WriteLine(szoveg);

            //értékadás apróságai
            //nem mindegy, hogy mikor történik az értékadás
            //++a először növelés, aztán értékadás
            //a++ először értékadás, majd növelés

            var a = 1;
            var b = ++a;

            Console.WriteLine($"B:{b},A:{a}");

            Console.ReadKey();
        }
    }
}
