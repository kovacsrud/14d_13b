using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Allat allat = new Allat(12);
            Allat masikAllat = new Allat();

            Kutya kutya = new Kutya(4,"Kuvasz",15);
            

            allat.Eszik();
            masikAllat.Iszik();
            Console.WriteLine(kutya.ToString());

            kutya.Eszik();
            kutya.Iszik();
            kutya.Ugat();
            


            Console.ReadKey();
        }
    }
}
