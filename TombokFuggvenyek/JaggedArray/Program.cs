﻿using System;
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
            
            int[][] vTomb = new int[rand.Next(6, 11)][];

            for (int i = 0; i < vTomb.Length; i++)
            {
                vTomb[i] = new int[rand.Next(10,21)];
                for (int j = 0; j < vTomb[i].Length; j++)
                {
                    vTomb[i][j] = rand.Next(1,201);
                }
            }

            for (int i = 0; i < vTomb.Length; i++)
            {
                for (int j = 0; j < vTomb[i].Length; j++)
                {
                    Console.Write(vTomb[i][j] + " ");
                }
                Console.Write("Összeg:" + vTomb[i].Sum());
                Console.Write(" Átlag:" + vTomb[i].Average());
                Console.Write(" Min:" + vTomb[i].Min());
                Console.Write(" Max:" + vTomb[i].Max());


                Console.WriteLine();
                
            }


            Console.ReadKey();
        }
    }
}
