using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hány számmal játszunk?:");
            var szamDb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mennyiből sorsolunk?:");
            var osszSzam = Convert.ToInt32(Console.ReadLine());
            Random veletlenSzam = new Random();
            var talalat = 0;

            int[] tippek = new int[szamDb];
            int[] nyeroSzamok = new int[szamDb];

            //Bekérés
            //Ugyanaz a szám nem szerepelhet
            //1-nél kisebb nem lehet
            //osszSzam-nal nagyobb nem lehet
            var temp = 0;
            for (int i = 0; i < szamDb; i++)
            {
                Console.Write($"{i + 1}.tipp:");
                temp = Convert.ToInt32(Console.ReadLine());
                while (temp < 1 || temp > osszSzam || Array.IndexOf(tippek, temp) > -1)
                {
                    Console.Write($"Rossz! Újra{i + 1}.tipp:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek[i] = temp;
            }

            //Nyerőszámok sorsolása


            for (int i = 0; i < szamDb; i++)
            {
                //Véletlenszámot kell generálni
                temp = veletlenSzam.Next(1, osszSzam + 1);
                while (Array.IndexOf(nyeroSzamok, temp) > -1)
                {
                    temp = veletlenSzam.Next(1, osszSzam + 1);
                }
                nyeroSzamok[i] = temp;
            }

            TombLista(tippek);
            TombLista(nyeroSzamok);

            for (int i = 0; i < tippek.Length; i++)
            {
                for (int j = 0; j < nyeroSzamok.Length; j++)
                {
                    if (tippek[i]==nyeroSzamok[j])
                    {
                        talalat++;
                    }
                }
            }

            var talalat2 = 0;
            for (int i = 0; i < tippek.Length; i++)
            {
                if (nyeroSzamok.Contains(tippek[i]))
                {
                    talalat2++;
                }
                //Kiíratás az OUTPUT ablakba
                //Debug.WriteLine(tippek[i]);
            }

            Console.WriteLine();
            
            Console.WriteLine($"Találatok:{talalat},{talalat2}");
            
            Console.ReadKey();
        }

        private static void TombLista(int[] tippek)
        {
            for (int i = 0; i < tippek.Length; i++)
            {
                Console.Write(tippek[i] + " ");
            }
        }
    }
}
