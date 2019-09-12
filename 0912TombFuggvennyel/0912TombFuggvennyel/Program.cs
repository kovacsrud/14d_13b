using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0912TombFuggvennyel
{
    class Program
    {
        public static int[] TombGyar(int elem,int min,int max)
        {
            Random rand = new Random();
            int[] tomb = new int[elem];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rand.Next(min, max);
            }
            return tomb;
        }
        public static void TombLista(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]+" ");
            }
            Console.WriteLine();
        }
        public static void Csere(ref int a,ref int b)
        {
            var temp = a;
            a=b;
            b = temp;


        }


        static void Main(string[] args)
        {
            var s1 = TombGyar(25, 100, 200);
            TombLista(s1);
            var s2 = TombGyar(100, -10, 10);
            TombLista(s2);
            var s3 = TombGyar(33, -99, 119);
            TombLista(s3);
            var a = 12;
            var b = 25;
            Csere(ref a, ref b);
            Console.WriteLine($"A:{a},B:{b}");

            Console.ReadKey();
        }
    }
}
