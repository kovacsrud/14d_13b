using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIdojaras
{
    public class IdoJarasAdat
    {
       

        public int Ev { get; set; }
        public int Honap { get; set; }
        public int Nap { get; set; }
        public int Ora { get; set; }
        public double Homerseklet { get; set; }
        public double Szelsebesseg { get; set; }
        public double Paratartalom { get; set; }

        public IdoJarasAdat(int ev, int honap, int nap, int ora, double homerseklet, double szelsebesseg, double paratartalom)
        {
            Ev = ev;
            Honap = honap;
            Nap = nap;
            Ora = ora;
            Homerseklet = homerseklet;
            Szelsebesseg = szelsebesseg;
            Paratartalom = paratartalom;
        }

    }
}
