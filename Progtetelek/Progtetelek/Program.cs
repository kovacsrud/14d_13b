using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progtetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[100];
            var osszeg = 0;

            //osztály példányosítása
            Random rand = new Random();

            Feltoltes(szamok, rand);

            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg = osszeg + szamok[i];
            }

            Console.WriteLine($"Az elemek összege:{osszeg}");

            var min = Int32.MaxValue;
            var max = Int32.MinValue;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]<min)
                {
                    min = szamok[i];
                }
                if (szamok[i]>max)
                {
                    max = szamok[i];
                }
            }

            Console.WriteLine($"A legkisebb elem:{min}");
            Console.WriteLine($"A legnagyobb elem:{max}");

            //Negatív számok darabszáma (megszámlálás)
            var negativNum = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]<0)
                {
                    negativNum++;
                }
            }

            Console.WriteLine($"Negatív elemek száma:{negativNum}");

            //Linq használatával
            Console.WriteLine(szamok.Max());
            Console.WriteLine(szamok.Min());
            Console.WriteLine(szamok.Sum());
            Console.WriteLine(szamok.Count(x=>x>0));


            Console.ReadKey();
        }

        private static void Feltoltes(int[] szamok, Random rand)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(-50, 626);
            }
        }
    }
}
