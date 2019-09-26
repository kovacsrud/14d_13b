using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    class Kor:Isikidom
    {
        

        public double sugar { get; set; }

        public Kor(double sugar)
        {
            this.sugar = sugar;
        }

        public double Kerulet()
        {
            return 2*sugar*Math.PI;
        }

        public double Terulet()
        {
            return sugar * sugar * Math.PI;
        }
    }
}
