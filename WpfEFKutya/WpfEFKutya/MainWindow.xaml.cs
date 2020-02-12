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
using System.Data.Entity;

namespace WpfEFKutya
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KutyaContext kutyacontext;
        public MainWindow()
        {
            InitializeComponent();
            kutyacontext = new KutyaContext();
            kutyacontext.Kutyak.Load();
            kutyacontext.Kutyanevek.Load();
            kutyacontext.Kutyafajtak.Load();
            DataContext= kutyacontext.Kutyak.Local;
            kutyanevAdatok.DataContext = kutyacontext.Kutyanevek.Local;
            //adatok.ItemsSource = kutyacontext.Kutyak.Local;

        }

        private void buttonKnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                kutyacontext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nem törölhető!");
            }
            
        }
    }
}
