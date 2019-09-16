using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP0916
{
    class Program
    {
        static void Main(string[] args)
        {
            //az UjEmber osztály példányosítása
            UjEmber zeno = new UjEmber("Zabos Zénó",23,"férfi",78);

            UjEmber elek = new UjEmber();

            Console.WriteLine(zeno.getNev());
            Console.WriteLine(elek.getNev());

            elek.setNev("Elek");
            Console.WriteLine(elek.getNev());

            JobbEmber gerzson = new JobbEmber();
            gerzson.Kor = 12;
            gerzson.Nev = "Gerzson";
            gerzson.Neme = "férfi";
            gerzson.Suly = 78;

            JobbEmber lajos = new JobbEmber("Lajos", 29, "férfi", 96);
            JobbEmber matyas = new JobbEmber("Mátyás",45,"szöcske",88);

            JobbEmber sandor = new JobbEmber
                {
                Kor = 12,
                Neme = "férfi",
                Suly = 45,
                Nev = "Jobb Sándor"
                }
                ;

            Console.WriteLine($"Neme:{matyas.Neme}");
            Console.WriteLine($"Nev:{sandor.Nev}");


           

            Console.ReadKey();
        }
    }
}
