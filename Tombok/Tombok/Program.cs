using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tömb: több azonos típusú változó tárolására szolgál

            //deklaráció az elemszám megadásával
            int[] szamok = new int[5];

            //deklaráció az elemek felsorolásával
            String[] szovegek = {"egy","kettő","három"};

            //egy adott elemre az indexével(sorszámával) lehet hivatkozni
            //az elemek számozása 0-val kezdődik!
            //Console.WriteLine(szamok[0]);
            //Console.WriteLine(szovegek[1]);

            //for (int i=0;i<szamok.Length;i++)
            //{
            //    szamok[i] = i;
            //}

            //for (int i = 0; i < szamok.Length; i++)
            //{
            //    Console.WriteLine(szamok[i]);
            //}


            //for (int i = szamok.Length-1; i >=0 ; i--)
            //{
            //    Console.WriteLine(szamok[i]);
            //}

            //String-ek
            var n = 15.54556;

            var szoveg = "Valami Szöveg";

            //String hossza
            Console.WriteLine(szoveg.Length);
            Console.WriteLine(szoveg.StartsWith("Val"));
            Console.WriteLine(szoveg.Substring(1,4));
            Console.WriteLine(szoveg.ToLower());
            Console.WriteLine(szoveg.ToUpper());
            Console.WriteLine(szoveg.Replace('a','ö'));
            //Szóközök eltüntetése
            Console.WriteLine(szoveg.Replace("al", ""));

            var elemek = szoveg.Split(' ');

            Console.WriteLine(elemek[1]);

            //A string karaktertömbbé alakítása
            Char[] szovegCh = szoveg.ToCharArray();

            for (int i = 0; i < szovegCh.Count(); i++)
            {
                Console.Write(szovegCh[i]);
            }


            for (int i = 0; i < szovegCh.Count(); i++)
            {

                szovegCh[i] = char.ToUpper(szovegCh[i]);
                
            }

            for (int i = 0; i < szovegCh.Count(); i++)
            {
                Console.Write(szovegCh[i]);
            }

            
            

            Console.ReadKey();
        }
    }
}
