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
            Console.WriteLine(szamok[0]);
            Console.WriteLine(szovegek[1]);

            for (int i=0;i<szamok.Length;i++)
            {
                szamok[i] = i;
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }


            for (int i = szamok.Length-1; i >=0 ; i--)
            {
                Console.WriteLine(szamok[i]);
            }

            //String-ek
            var n = 15.54556;

            var szoveg = "Valami Szöveg";

            Console.WriteLine(szoveg.Length);



            Console.ReadKey();
        }
    }
}
