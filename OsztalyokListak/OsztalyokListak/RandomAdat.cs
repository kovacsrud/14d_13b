using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyokListak
{
    class RandomAdat
    {
        public string[] VezetekNevek { get; set; }
        public string[] KeresztNevek { get; set; }
        public string[] SzuletesiHelyek {get; set; }
        public int SzuletesiEv { get; set; }
        Random rand = new Random();

        public RandomAdat()
        {
            VezetekNevek= new string[] { "Kiss", "Kovács", "Nagy", "Muhari", "Kósa", "Veszelovszki" };
            KeresztNevek= new string[] { "Ágnes", "Lajos", "Ignác", "Anita", "Szilvia", "István" };
            SzuletesiHelyek= new string[] { "Békéscsaba", "Bélmegyer", "Lőkösháza", "Szeged", "Miskolc", "Tatabánya", "Veszprém" };
            

        }

        public string getVezetekNev()
        {
            return VezetekNevek[rand.Next(0, VezetekNevek.Length)];
        }

        public string getKeresztNev()
        {
            return KeresztNevek[rand.Next(0, KeresztNevek.Length)];
        }

        public string getSzuletesiHely()
        {
            return SzuletesiHelyek[rand.Next(0, SzuletesiHelyek.Length)];
        }

        public int getSzuletesiEv()
        {
            return rand.Next(1940, 2019);
        }
    }
}
