using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringGyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a mondatot:");
            //A Console.ReadLine mindig String-be olvas be
            var mondat = Console.ReadLine();

            Console.WriteLine("Adja meg a szót:");
            var szo = Console.ReadLine();

            if (mondat.Contains(szo))
            {
                Console.WriteLine("Tartalmazza");
            } else
            {
                Console.WriteLine("Nem tartalmazza");
            }

            Console.ReadKey();
        }
    }
}
