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

namespace WpfDataAdapter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Adapter adapter;

        public MainWindow()
        {
            InitializeComponent();
            adapter = new Adapter("Data Source=idojarasadatok.db;Version=3");
            adatok.ItemsSource = adapter.GetData().DefaultView;
            adatok.RowEditEnding += ColorTheRow;

        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                adapter.UpdateData();
                adatok.Items.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        public void ColorTheRow(object sender,DataGridRowEditEndingEventArgs e)
        {
            e.Row.Background = Brushes.Magenta;
        }


        public void hide_rowid(object sender,DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.Header.ToString()=="rowid")
            {
                e.Column.Visibility = Visibility.Hidden;
            }
        }
    }
}
