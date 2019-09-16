using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista, mint adatszerkezet (dinamikus tömb)
            List<int> szamok = new List<int>();
            Random rand = new Random();

            var elemSzam = rand.Next(120, 211);

            for (int i = 0; i < elemSzam; i++)
            {
                szamok.Add(rand.Next(-100, 101));
            }

            for (int i = 0; i < szamok.Count; i++)
            {
                Console.Write(szamok[i]+" ");
            }

            //szamok.Add(12);
            //szamok.Add(48);

            //Console.WriteLine(szamok.Count);
            //Console.WriteLine(szamok[0]);
            //Console.WriteLine(szamok.Sum());
            //lista kiürítése
            //szamok.Clear();

            Console.ReadKey();
        }
    }
}
