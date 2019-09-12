using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    class Ember
    {
        private int kor;
        private int magassag;
        private string nev;
        private string neme;

        public void setNev(string nev)
        {
            this.nev = nev;
        }

        public string getNev()
        {
            return this.nev;
        }
    }
}
