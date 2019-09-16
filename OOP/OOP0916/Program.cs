using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP0916
{
    class Program
    {
        static void Main(string[] args)
        {
            //az UjEmber osztály példányosítása
            UjEmber zeno = new UjEmber();
            zeno.setNev("Zabos Zénó");

            Console.WriteLine(zeno.getNev());


            Console.ReadKey();
        }
    }
}
