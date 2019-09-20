using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butorok
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Szekreny> szekrenyek = new List<Szekreny>();

            
            Szekreny szekreny1 = new Szekreny(45, "dió", 125, true, true);
            Szekreny szekreny2 = new Szekreny(110, "fém", 125, true, true);
            Szekreny szekreny3 = new Szekreny(150, "fém", 140, false, true);
            szekrenyek.Add(szekreny1);
            szekrenyek.Add(szekreny2);
            szekrenyek.Add(szekreny3);

            var uveges = szekrenyek.FindAll(x => x.Uveges == true && x.JellemzoAnyag=="fém");

            //uveges-t listázni
            Console.WriteLine(uveges.Count);



            Console.ReadKey();
        }
    }
}
