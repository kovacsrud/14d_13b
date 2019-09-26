using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    class Teglalap:Isikidom
    {
        

        public double OldalA { get; set; }
        public double OldalB { get; set; }

        public Teglalap(double oldalA, double oldalB)
        {
            OldalA = oldalA;
            OldalB = oldalB;
        }

        public double Kerulet()
        {
            return (OldalA+OldalB)*2;
        }

        public double Terulet()
        {
            return OldalA*OldalB;
        }
    }
}
