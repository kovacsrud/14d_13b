using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasmegyeFeladat
{
    class Program
    {
        struct Gyerek
        {
            public string neme;
            public string szuletesiDatum;
            public string sssk;
        }
        /// <summary>
        /// A személyi azonosító ellenőrzése.
        /// </summary>
        /// <param name="adat">String típusú paraméter..</param>
        /// <returns></returns>
        public static bool CdvEll(string adat)
        {
            adat = adat.Replace("-","");
            var charAdat = adat.ToCharArray();
            bool megfelelo = false;
            var osszeg = 0;
            int k = 10;

            for (int i = 0; i < charAdat.Length; i++)
            {
                osszeg += (int)Char.GetNumericValue(charAdat[i]) * k;
                k--;
            }
            osszeg = osszeg % 11;

            if (osszeg==(int)Char.GetNumericValue(charAdat[charAdat.Length-1]))
            {
                megfelelo = true;
            }

            return megfelelo;
        }

        static void Main(string[] args)
        {
            List<Gyerek> gyerekek = new List<Gyerek>();
            Gyerek gyerek = new Gyerek();
            try
            {
                FileStream fajl = new FileStream(@"vas.txt",FileMode.Open);
                using (StreamReader sr=new StreamReader(fajl,Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {

                    
                        var sor = sr.ReadLine();
                        if (CdvEll(sor)==true)
                        {
                    
                            var e = sor.Split('-');
                  

                    //Itt ellenőrizni kellene, hogy jó-e az adatsor
                    //és csak akkor felvenni a listába, ha jó
                            gyerek.neme = e[0];
                            gyerek.szuletesiDatum = e[1];
                            gyerek.sssk = e[1];
                            gyerekek.Add(gyerek);
                        } else
                        {
                            Console.WriteLine($"Hibás adat:{sor}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            //Időszak kezdő és befejező éve

            var idoszak = gyerekek.ToLookup(x=>x.szuletesiDatum.Substring(0,2));
                       

            var elso=idoszak.First();
            Console.WriteLine("19"+elso.Key);

            var utolso = idoszak.Last();
            Console.WriteLine("20"+utolso.Key);

            Console.ReadKey();
        }
    }
}
