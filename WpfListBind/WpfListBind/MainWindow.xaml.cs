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

namespace WpfListBind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Szemely> szemelyek = new List<Szemely>();
            szemelyek.Add(new Szemely("3-191919-1234","Kiss","Anna", "p1.jpg"));
            szemelyek.Add(new Szemely("3-181818-4321", "Veress", "Eufrozina", "p2.jpg"));
            szemelyek.Add(new Szemely("3-201819-4322", "Korompai", "Ágnes", "p3.jpg"));

            DataContext = szemelyek;
        }
    }
}
