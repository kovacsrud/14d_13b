using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetDimenziosTomb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] szamok = new int[10, 10];

            var masikSzamok = new int[20, 20];

            Random veletlenSzam = new Random();

            

            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                for (int j = 0; j < szamok.GetLength(1); j++)
                {
                    szamok[i, j] = veletlenSzam.Next(1,100);
                }
            }

            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                for (int j = 0; j < szamok.GetLength(1); j++)
                {
                    Console.Write(szamok[i, j]+" ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}
