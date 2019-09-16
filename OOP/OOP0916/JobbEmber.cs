using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP0916
{
    class JobbEmber
    {
       

        //property
        public String Nev { get; set; }
        public int Kor { get; set; }

        private String neme;
        public String Neme {
            get { return neme; }

            set {
                if (value == "férfi" || value == "nő")
                {
                    neme = value;
                }
                else
                {
                    //pl. lehet kivételt dobni
                    //throw new ArgumentException();
                    neme = "_default";
                }
            }
        }

        public int Suly { get; set; }

        public JobbEmber()
        {

        }

        public JobbEmber(string nev, int kor, string neme, int suly)
        {
            Nev = nev;
            Kor = kor;
            Neme = neme;
            Suly = suly;
        }


    }
}
