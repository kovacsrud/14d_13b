using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EgyebModszerek
{
    class Program
    {
        static void Main(string[] args)
        {
            var szoveg = File.ReadAllLines(@"d:/rud/9bdoga.txt",Encoding.Default);

            Console.WriteLine(szoveg[0]);

            var szoveg2 = File.ReadAllText(@"d:/rud/9bdoga.txt", Encoding.Default);

            //Console.WriteLine(szoveg2);

            var szoveg3 = File.ReadLines(@"d:/rud/9bdoga.txt", Encoding.Default);

            foreach (var s in szoveg3)
            {
                Console.WriteLine(s);
            }

            File.WriteAllLines(@"d:/rud/9bdoga_mentes.txt", szoveg);


            Console.ReadKey();
        }
    }
}
