using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Ember
    {
        public string Nev { get; set; }
        public int Kor { get; set; }
        public int Magassag { get; set; }
        public int Suly { get; set; }

        public abstract void Eszik();

        public abstract void Iszik();

        public abstract void Fut();

        public int GetSzuletesiEv()
        {
            return 2019 - Kor;
        }
        
    }
}
