using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butorok
{
    public class Szekreny:Butor
    {
        

        public bool Uveges { get; set; }
        public bool KulcssalZarhato { get; set; }

        public Szekreny(int suly,string jellemzoAnyag,int maxMagassag, bool uveges, bool kulcssalZarhato):base(suly,jellemzoAnyag,maxMagassag)
        {
            Suly = suly;
            JellemzoAnyag = jellemzoAnyag;
            MaxMagassag = maxMagassag;
            Uveges = uveges;
            KulcssalZarhato = kulcssalZarhato;
        }
    }
}
