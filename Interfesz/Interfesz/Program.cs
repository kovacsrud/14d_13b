using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Isikidom> sikidomok = new List<Isikidom>();
            Kor kor1 = new Kor(12);
            Kor kor2 = new Kor(34);
            Teglalap tegla1 = new Teglalap(12, 5);
            Teglalap tegla2 = new Teglalap(39, 11);

            sikidomok.Add(kor1);
            sikidomok.Add(kor2);
            sikidomok.Add(tegla1);
            sikidomok.Add(tegla2);

            foreach (var s in sikidomok)
            {
                Console.WriteLine($"K:{s.Kerulet()},T:{s.Terulet()}");
            }
            var osszkerulet = sikidomok.Sum(x => x.Kerulet());
            var osszterulet = sikidomok.Sum(x=>x.Terulet());

            Console.WriteLine($"Össz. kerület:{osszkerulet},Össz. terület:{osszterulet}");

            Console.ReadKey();
        }
    }
}
