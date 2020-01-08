using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timestamp
{
    public static class TimeStampConvert
    {
        const Int32 nap = 86400;
        const Int32 ora = 3600;
        const Int32 atlagev = 31557600;
        const Int32 normalEv = nap * 365;
        const Int32 szokoEv = nap * 366;
        static int[] normalHonapok= {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static int[] szokoHonapok = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static int aktHonap = 0;

        public static string Convert(int timestamp)
        {
            var evek = timestamp / atlagev;
            var teljesIdo = timestamp;

            for (int i = 0; i < evek; i++)
            {
                //if(1970+i % 4==0 && 1970+i % 100!=0 || 1970+i %400==0)
                if ((((1970+i) % 4==0) || ((1970+i) % 400==0)) && ((1970+i) % 100!=0))
                {
                    teljesIdo -= szokoEv;
                }else
                {
                    teljesIdo -= normalEv;
                }

            }

            if (1970 + evek % 4 == 0 && 1970 + evek % 100 != 0 || 1970 + evek % 400 == 0)
            {
                for (int i = 0; i < szokoHonapok.Length; i++)
                {
                    if (teljesIdo>=szokoHonapok[i]*nap)
                    {
                        teljesIdo -= szokoHonapok[i] * nap;

                    } else
                    {
                        aktHonap = i;
                        break;
                    }
                }

            } else
            {
                for (int i = 0; i < normalHonapok.Length; i++)
                {
                    if (teljesIdo >= normalHonapok[i] * nap)
                    {
                        teljesIdo -= normalHonapok[i] * nap;

                    }
                    else
                    {
                        aktHonap = i;
                        break;
                    }
                }
            }
            aktHonap += 1;
            int aktNap = teljesIdo / nap;
            int aktOra = (teljesIdo % nap) / ora;
            int aktPerc= ((teljesIdo % nap) % ora)/60;
            int aktMasodperc = ((teljesIdo % nap) % ora) % 60;

            //a nap, óra, perc, másodperc maradt hátra

            return $"{1970+evek}.{aktHonap}.{aktNap} {aktOra}:{aktPerc}:{aktMasodperc}";
        }
    }
}
