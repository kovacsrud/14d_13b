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
            //var vezetekNevek =new string[] {"Kiss","Kovács","Nagy","Muhari","Kósa","Veszelovszki" };
            //var keresztNevek = new string[] {"Ágnes","Lajos","Ignác","Anita","Szilvia","István"};
            //var szuletesiHelyek = new string[] {"Békéscsaba","Bélmegyer","Lőkösháza","Szeged","Miskolc","Tatabánya","Veszprém"};



            RandomAdat radat = new RandomAdat();
            
            //Random rand = new Random();
            List<Szemely> szemelyek = new List<Szemely>();
            var adatSzam = 100;

            for (int i = 0; i < adatSzam; i++)
            {
                //példányosítás
                Szemely szemely = new Szemely(
                    
                    radat.getKeresztNev(),
                    radat.getVezetekNev(),
                    radat.getSzuletesiEv(),
                    radat.getSzuletesiHely()

                    );
                szemelyek.Add(szemely);
            }
            //Lista elemének a megjelenítése
            //for (int i = 0; i < szemelyek.Count; i++)
            //{
            //    Console.WriteLine(szemelyek[i].VezetekNev);
            //}

            foreach (var s in szemelyek)
            {
                Console.WriteLine($"{s.VezetekNev},{s.KeresztNev},{s.Eletkor()},{s.SzuletesiHely}");
            }

            var kosak = szemelyek.FindAll(x => x.VezetekNev == "Kósa" && x.SzuletesiEv>1980);

            Console.WriteLine($"Kósák száma:{kosak.Count}");

            foreach (var s in kosak)
            {
                Console.WriteLine($"{s.VezetekNev},{s.KeresztNev},{s.SzuletesiEv},{s.SzuletesiHely}");
            }

            Console.WriteLine(szemelyek.Count);
            

            Console.ReadKey();

        }
    }
}
