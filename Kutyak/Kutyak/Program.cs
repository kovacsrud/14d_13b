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
                (k,kn)=>new {Kor=k.Eletkor,Kutyanev=kn.KutyaNeve,FajtaId=k.FajtaId});

            var osszes = nevvel.Join(kutyafajtak,
                        n=>n.FajtaId,
                        kf=>kf.Id,
                        (n, kf) =>new {Kor=n.Kor,Kutyanev=n.Kutyanev,Fajta=kf.Nev }
                );


            foreach (var i in osszes)
            {
               // Console.WriteLine($"{i.Kor},{i.Kutyanev},{i.Fajta}");
            }

            var legoregebb = osszes.Where(x => x.Kor==osszes.Max(y=>y.Kor));


            
            

            

            Console.ReadKey();

        }
    }
}
