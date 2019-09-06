using System;
using System.Collections.Generic;
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

            int[] tippek = new int[szamDb];
            int[] nyeroSzamok = new int[osszSzam];

            //Bekérés
            //Ugyanaz a szám nem szerepelhet
            //1-nél kisebb nem lehet
            //osszSzam-nal nagyobb nem lehet
            var temp = 0;
            for (int i = 0; i < szamDb; i++)
            {
                Console.Write($"{i+1}.tipp:");
                temp = Convert.ToInt32(Console.ReadLine());
                while (temp<1 || temp>osszSzam || Array.IndexOf(tippek,temp)>-1)
                {
                    Console.Write($"Rossz! Újra{i + 1}.tipp:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek[i] = temp;
            }



            //Nyerőszámok sorsolása
            Console.ReadKey();
        }
    }
}
