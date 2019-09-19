using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Kutya:Allat
    {
        

        public int LabakSzama { get; set; }
        public string Fajta { get; set; }

        //Az ős osztály paraméteres konstruktorának hívása
        public Kutya(int labakszama, string fajta,int suly) : base(suly)
        {
            LabakSzama = labakszama;
            Fajta = fajta;
        }

        public void Ugat()
        {
            Console.WriteLine("A kutya ugat");
        }

        public void Kapar()
        {
            Console.WriteLine("Kapar a kutya");
        }

        public override void Eszik()
        {
            Console.WriteLine("A kutya eszik");
        }

        public override void Iszik()
        {
            Console.WriteLine("A kutya iszik");
        }

        public override string ToString()
        {
            return $"Fajta:{Fajta},Súlya:{Suly},{LabakSzama} lába van.";
        }

    }
}
