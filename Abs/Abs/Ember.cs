using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs
{
    public abstract class Ember
    {
        public string Nev { get; set; }
        public int SzuletesiEv { get; set; }
        public int Suly { get; set; }

        public abstract void Eszik();

        public abstract void Iszik();

        public virtual void Mozog()
        {
            Console.WriteLine("Az ember mozog");
        }
    }
}
