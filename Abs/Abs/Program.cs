using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportolo sportolo = new Sportolo();
            sportolo.Iszik();
            sportolo.Eszik();
            sportolo.Mozog();

            Console.ReadKey();
        }
    }
}
