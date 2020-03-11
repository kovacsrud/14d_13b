using FontAwesome.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfFontAwesome
{
    public  class MineItem
    {
        public ImageAwesome bomb = new ImageAwesome();
        public ImageAwesome flag = new ImageAwesome();

        public FontAwesome.WPF.FontAwesome num1 = new FontAwesome.WPF.FontAwesome();
        public FontAwesome.WPF.FontAwesome num2 = new FontAwesome.WPF.FontAwesome();
        public FontAwesome.WPF.FontAwesome num3 = new FontAwesome.WPF.FontAwesome();
        public FontAwesome.WPF.FontAwesome num4 = new FontAwesome.WPF.FontAwesome();
        public FontAwesome.WPF.FontAwesome num5 = new FontAwesome.WPF.FontAwesome();
        public FontAwesome.WPF.FontAwesome num6 = new FontAwesome.WPF.FontAwesome();
        

        public  MineItem()
        {
            flag.Icon = FontAwesomeIcon.Flag;
            bomb.Icon = FontAwesomeIcon.Bomb;
            num1.Text = "1";
            num1.Foreground = Brushes.Blue;
            num2.Text = "2";
            num2.Foreground = Brushes.Green;
            num3.Text = "3";
            num3.Foreground = Brushes.Red;
            num4.Text = "4";
            num4.Foreground = Brushes.Orange;
            num5.Text = "5";
            num5.Foreground = Brushes.Purple;
            num6.Text = "6";
            num6.Foreground = Brushes.Pink;

        }

        

        
        
    }
}
