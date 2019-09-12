using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Az Ember osztály egy példányának létrehozása
            Ember ubul = new Ember();
            Ember zeno = new Ember();

            ubul.setNev("Zénó, hehe");
            zeno.setNev("Zénó");

            Console.WriteLine($"Ubul:{ubul.getNev()}");


            Console.ReadKey();
        }
    }
}
