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

namespace WpfKutyakok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KutyanevAdapter kutyanevAdapter;
        KutyafajtaAdapter kutyafajtaAdapter;

        public MainWindow()
        {
            InitializeComponent();
            kutyanevAdapter = new KutyanevAdapter("Data Source=kutyak.db;Version=3");
            kutyafajtaAdapter = new KutyafajtaAdapter("Data Source=kutyak.db;Version=3");
            kutyanevAdatok.ItemsSource = kutyanevAdapter.GetKutyanevek().DefaultView;
            kutyafajtaAdatok.ItemsSource = kutyafajtaAdapter.GetKutyafajtak().DefaultView;
        }

        private void buttonKutyanevUpdate_Click(object sender, RoutedEventArgs e)
        {
            kutyanevAdapter.UpdateKutyanevek();
            
        }

        private void buttonKutyafajtaUpdate_Click(object sender, RoutedEventArgs e)
        {
            kutyafajtaAdapter.UpdateKutyafajtak();
           
        }
    }
}
