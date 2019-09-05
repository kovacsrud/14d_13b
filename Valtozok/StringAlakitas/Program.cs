using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlakitas
{
    class Program
    {
        static void Main(string[] args)
        {

            var szoveg = "ValaMi SzÖVeg696";

            Char[] szovegCh = szoveg.ToCharArray();

            for (int i = 0; i < szovegCh.Length; i++)
            {
                if (Char.IsLower(szovegCh[i]))
                {
                    szovegCh[i] = Char.ToUpper(szovegCh[i]);
                } else
                {
                    szovegCh[i] = Char.ToLower(szovegCh[i]);
                }
            }



            szoveg = new string(szovegCh);

            Console.WriteLine(szoveg);

            Console.ReadKey();
        }
    }
}
