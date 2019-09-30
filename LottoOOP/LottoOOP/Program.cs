using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            LottoJatek lotto = new LottoJatek(5,90);
            //lotto.Tippeles();
            //lotto.Sorsolas();
            //lotto.Kiiras(lotto.GetTippek());
            //lotto.Kiiras(lotto.GetNyeroszamok());
            //lotto.Talalatok();
            //Console.WriteLine($"Találatok:{lotto.GetTalalat()}");
            lotto.Jatek();

            var huzas = 0;
            while (lotto.GetTalalat()!=5)
            {
                lotto.HosszuJatek();
                huzas++;
                Console.WriteLine(huzas);
            }

            Console.WriteLine($"{huzas/52} évbe telt.");
            

            Console.ReadKey();
        }
    }
}
