using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoOOP
{
    class LottoJatek
    {
        private int[] tippek;
        private int[] nyeroSzamok;
        private int talalat;
        private int szamDb;
        private int osszesSzam;
        Random rand = new Random();

        public LottoJatek(int szamdb,int osszesszam)
        {
            szamDb = szamdb;
            osszesSzam = osszesszam;
            tippek = new int[szamDb];
            nyeroSzamok = new int[szamDb];
            talalat = 0;

        }

        public void Jatek()
        {
            talalat = 0;
            Tippeles();
            Sorsolas();
            Kiiras(GetTippek());
            Kiiras(GetNyeroszamok());
            Talalatok();
            Console.WriteLine($"Találatok száma:{GetTalalat()}");

        }

        public void HosszuJatek()
        {
            talalat = 0;
            Sorsolas();          
            Talalatok();
            if (GetTalalat()>0)
            {
                Console.WriteLine($"Találatok száma:{GetTalalat()}");
            }
            
        }


        private void Tippeles()
        {
            for (int i = 0; i < tippek.Length; i++)
            {
                Console.Write($"{i+1}.tipp:");
                var temp = Convert.ToInt32(Console.ReadLine());

                while (temp<1 || temp>osszesSzam || tippek.Contains(temp))
                {
                    Console.Write($"Rossz!:{i+1}.tipp:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek[i] = temp;
            }
        }

        private void Sorsolas()
        {
            for (int i = 0; i < nyeroSzamok.Length; i++)
            {
                var temp = rand.Next(1,osszesSzam+1);

                while (nyeroSzamok.Contains(temp))
                {
                    temp = rand.Next(1, osszesSzam + 1);
                }
                nyeroSzamok[i] = temp;
            }
        }

        private void Kiiras(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]+" ");
            }
            Console.WriteLine();
        }

        private int[] GetTippek()
        {
            return tippek;
        }

        private int[] GetNyeroszamok()
        {
            return nyeroSzamok;
        }

        private void Talalatok()
        {
            for (int i = 0; i < tippek.Length; i++)
            {
                if (nyeroSzamok.Contains(tippek[i]))
                {
                    talalat++;
                }
            }
        }

        public int GetTalalat()
        {
            return talalat;
        }


    }
}
