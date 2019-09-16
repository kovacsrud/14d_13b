using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP0916
{
    class UjEmber
    {
        //az osztály adattagjai
        private String nev;
        private int kor;
        private String neme;
        private int suly;

        //konstruktor -> olyan metódus, amellyel be lehet
        //állítani az objektum kezdeti adatait
        //nincs visszatérési érték, és nem void
        public UjEmber()
        {
            nev = "_default";
            kor = 0;
            suly = 0;
        }

        public UjEmber(string pnev,int pkor,string pneme,int psuly)
        {
            nev = pnev;
            kor = pkor;
            neme = pneme;
            suly = psuly;
        }

        //a név lekérdezése
        public string getNev()
        {
            return nev;
        }
        public void setNev(string pnev)
        {
            nev = pnev;
        }


    }
}
