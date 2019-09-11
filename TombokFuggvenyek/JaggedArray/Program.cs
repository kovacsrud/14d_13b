using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaráció
            int[][] betomb = new int[3][];

            betomb[0] = new int[] {1,2,3,7,8 };
            betomb[1] = new int[] {4,5,6 };
            betomb[2] = new int[] { 11, 26, 85, 44 };

            //Hogyan írjuk vajon ki?
            for (int i = 0; i < betomb.Length; i++)
            {
                for (int j = 0; j < betomb[i].Length; j++)
                {
                    Console.Write(betomb[i][j]+" ");
                }
                Console.WriteLine();
            }
            // Készítsen programot, amely beágyazott tömböt hoz létre,
            // az elemszám 6-10 közötti legyen véletlenszerűen kiválasztva
            // A beágyazott tömbök elemszáma 10-20 közötti, a tömbelemek pedig
            // 1-200 közötti számok legyenek!
            Random rand = new Random();
            int elemSzam = rand.Next(6, 11);
            int[][] vTomb = new int[elemSzam][];

            for (int i = 0; i < vTomb.Length; i++)
            {

            }




            Console.ReadKey();
        }
    }
}
