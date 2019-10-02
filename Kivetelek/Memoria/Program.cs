using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Memoria
{
    class Program
    {
        static void Main(string[] args)
        {
            while (!Console.KeyAvailable)
            {
                using (var bitmap = new Bitmap(1280, 1024))
                {
                    Console.WriteLine(GC.GetTotalMemory(false));
                }

                
                
            }



            Console.ReadKey();
        }
    }
}
