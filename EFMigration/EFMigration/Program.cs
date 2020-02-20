using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoContext = new AutoContext();
            Auto auto = new Auto {
                Gyartmany ="Kia",
                Tipus="Ceed",
                GyartasiEv=2011

            };
            Tulaj tulaj = new Tulaj
            {
                Vezeteknev="Egeresi",
                Keresztnev="Huba",
                SzuletesiEv=2001,
                auto=auto
            };
            autoContext.autok.Add(auto);
            autoContext.tulajok.Add(tulaj);
            autoContext.SaveChanges();


            Console.ReadKey();
        }
    }
}
