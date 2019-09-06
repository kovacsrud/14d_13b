using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a mondatot:");
            var mondat = Console.ReadLine();
            Console.WriteLine("Adjon meg egy karaktert:");
            var karakter = Console.ReadKey().KeyChar;
            var szamlalo = 0;
            Console.WriteLine();

            for (int i = 0; i < mondat.Length; i++)
            {
                if (mondat[i]==karakter)
                {
                    szamlalo++;
                }
            }

            Console.WriteLine($"{karakter} karakterből {szamlalo} db van.");
            Console.ReadKey();
        }
    }
}
