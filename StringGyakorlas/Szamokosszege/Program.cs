using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamokosszege
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a mondatot:");
            var mondat = Console.ReadLine();
            double sum = 0;

            for (int i = 0; i < mondat.Length; i++)
            {
                //Ha számjegy a karakter
                if (Char.IsDigit(mondat[i]))
                {
                    //a karakter numerikus értéke kell, amit még
                    //konvertálni is kell
                    sum=sum+(Char.GetNumericValue(mondat[i]));
                }
            }

            Console.WriteLine(sum);

            Console.ReadKey();

        }
    }
}
