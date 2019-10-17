using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfIdojaras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IdoJarasAdatok idoadatok;

        public MainWindow()
        {
            InitializeComponent();

            idoadatok = new IdoJarasAdatok(@"d:/rud/idojaras.csv");
            Debug.WriteLine(idoadatok.GetLength());
            evek.SelectionChanged += KivalasztottEv;
            honapok.SelectionChanged += KivalasztottHonap;

            evek.ItemsSource = idoadatok.GetEvek();
        }

        public void KivalasztottEv(object sender,RoutedEventArgs e)
        {
            honapok.ItemsSource = idoadatok.GetHonapok(Convert.ToInt32(evek.SelectedItem));
            honapok.Items.Refresh();
        }

        public void KivalasztottHonap(object sender,RoutedEventArgs e)
        {
            napok.ItemsSource = idoadatok.
            GetNapok(Convert.ToInt32(evek.SelectedItem), Convert.ToInt32(honapok.SelectedItem));
        }
    }
}
