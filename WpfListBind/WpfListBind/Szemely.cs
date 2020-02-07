using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WpfListBind
{
    public class Szemely
    {
        public Szemely(string szemelyiSzam, string vezeteknev, string keresztnev, string kepfajl)
        {
            SzemelyiSzam = szemelyiSzam;
            Vezeteknev = vezeteknev;
            Keresztnev = keresztnev;
            try
            {
                byte[] kepadatok = File.ReadAllBytes(kepfajl);
                MemoryStream ms = new MemoryStream(kepadatok);
                BitmapImage szemelyfoto = new BitmapImage();
                szemelyfoto.BeginInit();
                szemelyfoto.StreamSource = ms;
                szemelyfoto.EndInit();
                Szemelyfoto = szemelyfoto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }

            
        }

        public string SzemelyiSzam { get; set; }
        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }
        public BitmapImage Szemelyfoto { get; set; }

    }


}
