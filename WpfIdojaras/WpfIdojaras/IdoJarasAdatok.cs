using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfIdojaras
{
    public class IdoJarasAdatok
    {
        private string filePath;
        private List<IdoJarasAdat> adatlista = new List<IdoJarasAdat>();

        public IdoJarasAdatok(string filepath)
        {
            //elérési út beállítása
            filePath = filepath;
            fileLoad();

        }

        private void fileLoad()
        {
            try
            {
                var sorok = File.ReadAllLines(filePath,Encoding.Default);

                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    IdoJarasAdat adat = new IdoJarasAdat(
                            Convert.ToInt32(e[0]),
                            Convert.ToInt32(e[1]),
                            Convert.ToInt32(e[2]),
                            Convert.ToInt32(e[3]),
                            Convert.ToDouble(e[4]),
                            Convert.ToDouble(e[5]),
                            Convert.ToDouble(e[6])
                        );

                    adatlista.Add(adat);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hiba!",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        public int GetLength()
        {
            return adatlista.Count;
        }

        public List<int> GetEvek()
        {
            List<int> evek = new List<int>();

            var evekegyszer = adatlista.ToLookup(x=>x.Ev).OrderBy(x=>x.Key);

            foreach (var e in evekegyszer)
            {
                evek.Add(e.Key);
            }
           

            return evek;
        }

        public List<int> GetHonapok(int ev)
        {
            List<int> honapok = new List<int>();
            var honapokegyszer = adatlista.Where(x => x.Ev == ev).ToLookup(x=>x.Honap).OrderBy(x => x.Key);

            foreach (var h in honapokegyszer)
            {
                honapok.Add(h.Key);
            }

            return honapok;
        }

        public List<int> GetNapok(int ev,int honap)
        {
            List<int> napok = new List<int>();
            var napokegyszer = adatlista.Where(x => x.Ev == ev && x.Honap==honap).
                ToLookup(x => x.Nap).OrderBy(x => x.Key);

            foreach (var n in napokegyszer)
            {
                napok.Add(n.Key);
            }

            return napok;
        }
    }
}
