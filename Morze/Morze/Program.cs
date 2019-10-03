using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    class Program
    {
        struct morzekod
        {
            public char betu;
            public string kod;
        }
        struct kodolt
        {
            public string szerzo;
            public string idezet;
        }

        struct dekodolt
        {
            public string szerzo;
            public string idezet;
        }

        static void Main(string[] args)
        {
            List<morzekod> morzekodok = new List<morzekod>();
            List<kodolt> kodoltszovegek = new List<kodolt>();
            List<dekodolt> dekodoltszovegek = new List<dekodolt>();

            morzekod morzekod = new morzekod();
            kodolt kodoltszoveg = new kodolt();
            dekodolt dekodoltszoveg = new dekodolt();

            FajlToltes(morzekodok, kodoltszovegek, morzekod, kodoltszoveg);

            Console.WriteLine("Adjon meg egy karaktert:");
            var bekertbetu = Console.ReadKey().KeyChar;
            string kod = GetKod(morzekodok, bekertbetu);

            if (kod != null)
            {
                Console.WriteLine($"{bekertbetu} morze kódja:{kod}");
            }
            else
            {
                Console.WriteLine($"{bekertbetu} nem szerepel a morze abc-ben!");
            }

            //Console.WriteLine($"{Morze2Szoveg(morzekodok,kodoltszovegek[0].szerzo)}:{Morze2Szoveg(morzekodok, kodoltszovegek[0].idezet)}");
            //Szövegek dekódolása
            Dekodolas(morzekodok, kodoltszovegek, dekodoltszovegek, dekodoltszoveg);

            var leghosszabb = dekodoltszovegek.Find(x => x.idezet.Length == dekodoltszovegek.Max(y => y.idezet.Length)).idezet;
            Console.WriteLine(leghosszabb);

            Console.ReadKey();
        }

        private static void Dekodolas(List<morzekod> morzekodok, List<kodolt> kodoltszovegek, List<dekodolt> dekodoltszovegek, dekodolt dekodoltszoveg)
        {
            for (int i = 0; i < kodoltszovegek.Count; i++)
            {
                dekodoltszoveg.szerzo = Morze2Szoveg(morzekodok, kodoltszovegek[i].szerzo);
                dekodoltszoveg.idezet = Morze2Szoveg(morzekodok, kodoltszovegek[i].idezet);

                dekodoltszovegek.Add(dekodoltszoveg);
            }
        }

        private static string Morze2Szoveg(List<morzekod> morzekodok, string dekodolando)
        {
            List<char> karakterek = new List<char>();

            var inputElemek = dekodolando.Split(new string[] {"       "},StringSplitOptions.None);
            for (int i = 0; i < inputElemek.Length; i++)
            {
                var inputBetuk = inputElemek[i].Split(new string[] {"   "}, StringSplitOptions.None);
                for (int j = 0; j < inputBetuk.Length; j++)
                {
                    //dekódolás
                    karakterek.Add(GetBetu(morzekodok,inputBetuk[j]));
                }
                karakterek.Add(' ');
            }



            return new string(karakterek.ToArray()).TrimEnd();
        }


        private static char GetBetu(List<morzekod> morzekodok,string bekod)
        {
             return morzekodok.Find(x => x.kod == bekod).betu;
        }

        private static string GetKod(List<morzekod> morzekodok, char bekertbetu)
        {
            return morzekodok.Find(x => x.betu == Char.ToUpper(bekertbetu)).kod;
        }

        private static void FajlToltes(List<morzekod> morzekodok, List<kodolt> kodoltszovegek, morzekod morzekod, kodolt kodoltszoveg)
        {
            try
            {
                var morzeabc = File.ReadAllLines(@"d:/rud/morze_feladat/morzeabc.txt", Encoding.Default);
                var kodolt = File.ReadAllLines(@"d:/rud/morze_feladat/morze.txt", Encoding.Default);

                for (int i = 1; i < morzeabc.Length; i++)
                {
                    var e = morzeabc[i].Split('\t');
                    morzekod.betu = Convert.ToChar(e[0]);
                    morzekod.kod = e[1];
                    morzekodok.Add(morzekod);

                }
                for (int i = 0; i < kodolt.Length; i++)
                {
                    var e = kodolt[i].Split(';');
                    kodoltszoveg.szerzo = e[0];
                    kodoltszoveg.idezet = e[1];
                    kodoltszovegek.Add(kodoltszoveg);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
