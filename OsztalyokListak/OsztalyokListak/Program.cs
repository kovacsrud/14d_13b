using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyokListak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Írjunk programot, amely személyi adatokat generál, amelyeket azután
            //egy listában eltárolunk, és kinyerünk belőle adatokat
            //Az adatok: vezetéknév, keresztnév, születés éve, születés helye
            var vezetekNevek =new string[] {"Kiss","Kovács","Nagy","Muhari","Kósa","Veszelovszki" };
            var keresztNevek = new string[] {"Ágnes","Lajos","Ignác","Anita","Szilvia","István"};
            var szuletesiHelyek = new string[] {"Békéscsaba","Bélmegyer","Lőkösháza","Szeged","Miskolc","Tatabánya","Veszprém"};

            Random rand = new Random();
            List<Szemely> szemelyek = new List<Szemely>();
            var adatSzam = 100;

            for (int i = 0; i < adatSzam; i++)
            {
                //példányosítás
                Szemely szemely = new Szemely(
                    keresztNevek[rand.Next(0, keresztNevek.Length)],
                    vezetekNevek[rand.Next(0,vezetekNevek.Length)],
                    rand.Next(1940,2020),
                    szuletesiHelyek[rand.Next(0,szuletesiHelyek.Length)]

                    );
                szemelyek.Add(szemely);
            }


            Console.WriteLine(szemelyek.Count);
            

            Console.ReadKey();

        }
    }
}
