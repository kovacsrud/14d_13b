using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class Kutyanevek
    {
        public class Kutyanev
        {
            public int Id { get; set; }
            public string KutyaNeve { get; set; }
        }

        private List<Kutyanev> kutyanevek = new List<Kutyanev>();

        public Kutyanevek(string fajl)
        {
            try
            {
                var sorok = File.ReadAllLines(fajl, Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    kutyanevek.Add(
                      new Kutyanev {
                          Id =Convert.ToInt32(e[0]),
                          KutyaNeve =e[1]
                      }
                     );
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
        }

        public List<Kutyanev> GetKutyaNevek()
        {
            return kutyanevek;
        }

    }
}
