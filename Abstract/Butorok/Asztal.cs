using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butorok
{
    class Asztal:Butor
    {
        

        public String AsztallapAlak { get; set; }
        public bool Fiokos { get; set; }

        public Asztal(int suly, string jellemzoAnyag, int maxMagassag,string alak,bool fiokos) : base(suly, jellemzoAnyag, maxMagassag)
        {
            this.AsztallapAlak = alak;
            this.Fiokos = fiokos;
        }
        public Asztal()
        { }
    }
}
