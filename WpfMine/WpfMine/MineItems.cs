using FontAwesome.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfMine
{
    public class MineItems
    {
        public ImageAwesome bomb=new ImageAwesome();
        public ImageAwesome flag = new ImageAwesome();
        public FontAwesome.WPF.FontAwesome num1 = new FontAwesome.WPF.FontAwesome();
        public FontAwesome.WPF.FontAwesome num2 = new FontAwesome.WPF.FontAwesome();
        public FontAwesome.WPF.FontAwesome num3 = new FontAwesome.WPF.FontAwesome();
        public FontAwesome.WPF.FontAwesome num4 = new FontAwesome.WPF.FontAwesome();
        public FontAwesome.WPF.FontAwesome num5 = new FontAwesome.WPF.FontAwesome();
        public FontAwesome.WPF.FontAwesome num6 = new FontAwesome.WPF.FontAwesome();
        public FontAwesome.WPF.FontAwesome num7 = new FontAwesome.WPF.FontAwesome();
        public FontAwesome.WPF.FontAwesome num8 = new FontAwesome.WPF.FontAwesome();

        public MineItems()
        {
            bomb.Icon = FontAwesomeIcon.Bomb;
            flag.Icon = FontAwesomeIcon.Flag;
            num1.Text = "1";
            num1.FontSize = 50;
            num1.Foreground = Brushes.Blue;
            num2.Text = "2";
            num3.Text = "3";
            num4.Text = "4";
            num5.Text = "5";
            num6.Text = "6";
            num7.Text = "7";
            num8.Text = "8";
        }
    }

    

}
