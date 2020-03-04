using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog
{
    public class DHaromszog
    {
        private double aOldal;
        private double bOldal;
        private double cOldal;

        public double a {

           get { return aOldal; } 
                
               
           set {
                    if (value>0)
                    {
                        aOldal = value;
                    } else
                    {
                    throw new HaromszogHiba("Az a oldal nem lehet 0!");
                    }

                }
            
         }


        public double b {
            get { return bOldal; }

            set {
                if (value>0)
                {
                    bOldal = value;
                } else
                {
                    throw new HaromszogHiba("A b oldal nem lehet 0!");
                }
            }
        }


        public double c {
            get { return cOldal; }

            set {
                if (value > 0)
                {
                    cOldal = value;
                }
                else
                    throw new HaromszogHiba("A c oldal nem lehet 0!");
                {

                }
            }

        }

        public bool EllDerekszogu
        {
            get
            {
                if (Math.Pow(cOldal,2)==Math.Pow(bOldal,2)+Math.Pow(aOldal,2))
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        public bool EllMegszerkesztheto
        {
            get
            {
                if (aOldal+bOldal>cOldal)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }
        public bool EllNovekvoSorrend
        {
            get
            {
                if (aOldal<=bOldal && bOldal<=cOldal)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        public double Kerulet
        {
            get
            {
                return aOldal + bOldal + cOldal;
            }
        }

        public double Terulet
        {
            get
            {
                return (aOldal * bOldal) / 2;
            }
        }

        public int Sorszam { get; set; }

        public DHaromszog(string sor,int sorSzama)
        {
            Sorszam = sorSzama;
            var e = sor.Split(';');
            a = Convert.ToDouble(e[0]);
            b = Convert.ToDouble(e[1]);
            c = Convert.ToDouble(e[2]);

            if (!EllDerekszogu)
            {
                throw new HaromszogHiba("Ez nem derékszögű!");
            }
            if (!EllMegszerkesztheto)
            {
                throw new HaromszogHiba("Ez nem szerkeszthető meg!");
            }
            if (!EllNovekvoSorrend)
            {
                throw new HaromszogHiba("Az oldalak sorrendje rossz!");
            }

        }
    }
}
