using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Mindent külön osztályba teszünk, itt csak a legszükségesebb kódot használjuk
        Jatek jatek;

        public MainWindow()
        {
            InitializeComponent();
            //Dependency injection
            jatek = new Jatek(this, 90, 5, 9, 10);

        }
    }
}
