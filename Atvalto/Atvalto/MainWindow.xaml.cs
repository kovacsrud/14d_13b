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

namespace Atvalto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                kmhSebesseg.Content = Convert.ToString(Convert.ToDouble(mphSebesseg.Text) * 1.6);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Hiba!",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
