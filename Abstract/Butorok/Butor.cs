using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butorok
{
    public class Butor
    {
        

        public int Suly { get; set; }
        public String JellemzoAnyag { get; set; }
        public int MaxMagassag { get; set; }

        public Butor(int suly, string jellemzoAnyag, int maxMagassag)
        {
            Suly = suly;
            JellemzoAnyag = jellemzoAnyag;
            MaxMagassag = maxMagassag;
        }

        public Butor()
        {

        }


    }
}
