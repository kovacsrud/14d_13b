using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    class Program
    {
        static void Main(string[] args)
        {
            //A betöltést az osztály végezze, és adja vissza 
            //a kész listát
            Kutyanevek kutyanevAdat = new Kutyanevek("KutyaNevek.csv");
            var kutyanevek = kutyanevAdat.GetKutyaNevek();
            Kutyafajtak fajtaAdat = new Kutyafajtak("KutyaFajtak.csv");
            var kutyafajtak = fajtaAdat.GetKutyaFajtak();
            Kutyak kutyaAdat = new Kutyak("Kutyak.csv");
            var kutyak = kutyaAdat.GetKutyak();


            Console.WriteLine($"{kutyanevek.Count},{kutyafajtak.Count},{kutyak.Count}");

            var nevvel = kutyak.Join(kutyanevek,
                k=>k.NevId,
                kn=>kn.Id,
                (k,kn)=>new {Kutyanev=kn.KutyaNeve,Idopont=k.UtolsoVizsgalat});

            
            foreach (var i in nevvel)
            {
                Console.WriteLine($"{i.Idopont},{i.Kutyanev}");
            }

            Console.ReadKey();

        }
    }
}
