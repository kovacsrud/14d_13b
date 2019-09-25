using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fajlok
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. megoldás
            //try
            //{
            //    FileStream fajl = new FileStream(@"d:/rud/tesztadat_20k.txt", FileMode.Open);
            //    StreamReader sr = new StreamReader(fajl, Encoding.Default);

            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }

            //    sr.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //2. megoldás, fájl zárása a finally block-ban

            //FileStream fajl = null;
            //StreamReader sr = null;

            //try
            //{
            //    fajl = new FileStream(@"d:/rud/tesztadat_20k.txt", FileMode.Open);
            //    sr = new StreamReader(fajl, Encoding.Default);

            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }


            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);                
            //}
            //finally
            //{
            //    //Amit itt van az minden esetben végrehajtódik
            //    //Logikus, hogy itt zárjuk be a fájlt
            //    if (sr!=null)
            //    {
            //        sr.Close();
            //    }


            //}

            //3. megoldás

            List<Ember> emberek = new List<Ember>();
            
            try
            {
                FileStream fajl = new FileStream(@"d:/rud/tesztadat_20k.txt", FileMode.Open);

                using (StreamReader sr = new StreamReader(fajl, Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        var elemek=sr.ReadLine().Split(',');
                        Ember ember = new Ember
                        {
                            Vezeteknev = elemek[0],
                            Keresztnev = elemek[1],
                            SzuletesEve = Convert.ToInt32(elemek[2]),
                            Szuletesihely = elemek[3]

                        };
                        emberek.Add(ember);
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine(emberek.Count);

            var al = emberek.FindAll(x=>x.Vezeteknev.ToLower().StartsWith("al")).OrderBy(x=>x.Vezeteknev).ThenBy(x=>x.Keresztnev);

            Console.WriteLine(al.Count());

            foreach (var n in al)
            {
                Console.WriteLine($"{n.Vezeteknev},{n.Keresztnev},{n.SzuletesEve},{n.Szuletesihely}");
            }

            var alstat = al.ToLookup(x=>new { x.Vezeteknev,x.Keresztnev });

            foreach (var n in alstat)
            {
                Console.WriteLine($"{ n.Key.Vezeteknev},{n.Key.Keresztnev },{ n.Count()}");
            }

            //Kiírás fájlba
            try
            {
                FileStream outFajl = new FileStream($"d:/eredmeny.txt",FileMode.Create);

                using (StreamWriter sw = new StreamWriter(outFajl, Encoding.Default))
                {
                    foreach (var a in al)
                    {
                        sw.WriteLine($"{a.Vezeteknev},{a.Keresztnev},{a.SzuletesEve},{a.Szuletesihely}");
                    }
                }

              

                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                
            }

            



            Console.ReadKey();
        }
    }
}
