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
        public static bool CdvEll(string adat)
        {
            var charAdat = adat.ToCharArray();
            bool megfelelo = false;
            var osszeg = 0;

            for (int i = 0; i < charAdat.Length; i++)
            {

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
                    var e = sr.ReadLine().Split('-');
                    //Itt ellenőrizni kellene, hogy jó-e az adatsor
                    //és csak akkor felvenni a listába, ha jó
                    gyerek.neme = e[0];
                    gyerek.szuletesiDatum = e[1];
                    gyerek.sssk = e[1];
                    gyerekek.Add(gyerek);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
