using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Stadionn> stadionok = new List<Stadionn>();

            try
            {
                FileStream file = new FileStream(@"d:/rud/stadion/vb2018.txt",FileMode.Open);
                using (StreamReader sr=new StreamReader(file,Encoding.Default))
                {
                    var fejlec = sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        var e = sr.ReadLine().Split(';');
                        Stadionn stadion = new Stadionn(e[0],e[1],e[2],Convert.ToInt32(e[3]));
                        stadionok.Add(stadion);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            Console.WriteLine($"3.feladat Stadionok száma:{stadionok.Count} db.");

            var legkisebb = stadionok.Find(x=>x.ferohely==stadionok.Min(y=>y.ferohely));
            Console.WriteLine($"4.feladat legkisebb férőhely:{legkisebb.nev1},{legkisebb.nev2},{legkisebb.varos}");
            Console.WriteLine($"5. feladat Átlagos férőhelyszám:{stadionok.Average(x=>x.ferohely):0.0}");

            var alternativ = stadionok.FindAll(x=>x.nev2!="n.a.").Count;
            Console.WriteLine($"6.feladat Két néven is ismert stadionok száma:{alternativ}");

            Console.Write("7.feladat Adja meg egy város nevét:");
            var varosnev = Console.ReadLine();
            while (varosnev.Length<3)
            {
                Console.Write("7.feladat Rövid! Adja meg egy város nevét:");
                varosnev = Console.ReadLine();
            }


            if (stadionok.Any(x=>x.varos.ToLower()==varosnev.ToLower()))
            {
                Console.WriteLine("8.feladat: A város vb helyszín!");

            }else
            {
                Console.WriteLine("8.feladat: A város NEM vb helyszín!");
            }

            var hanykulonbozo = stadionok.ToLookup(x=>x.varos).Count;

            Console.WriteLine($"Ennyi különböző városban zajlott:{hanykulonbozo}");


            Console.ReadKey();
        }
    }
}
