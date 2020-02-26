using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlapMuveletek
{
    public class Alapmuvelet
    {
        public double Osszead(double a,double b)
        {
            return a + b;
        }

        public double Kivon(double a,double b)
        {
            return a - b;
        }

        public double Szoroz(double a,double b)
        {
            return a * b;
        }

        public double Oszt(double a,double b)
        {
            if (b==0)
            {
                throw new ArgumentException();
            } else
            {
                return a / b;
            }
            
        }
    }
}
