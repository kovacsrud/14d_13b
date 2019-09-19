using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Allat
    {
       

        public int Suly { get; set; }

        public Allat(int suly)
        {
            Suly = suly;
        }
        public Allat()
        {
            Suly = 1;
        }

        public virtual void  Eszik()
        {
            Console.WriteLine("Az állat eszik");
        }

        public virtual void  Iszik()
        {
            Console.WriteLine("Az állat iszik");
        }


    }
}
