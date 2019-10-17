using Microsoft.Win32;
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
using System.Windows.Threading;

namespace SlideShow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    //Feladat: olyan program készítése, amely valamennyi képfájlból
    //egy egyszerű slideshow-t mutat.

    public partial class MainWindow : Window
    {
        OpenFileDialog openFile;
        string[] fajlok;
        int szamlalo;
        DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            szamlalo = 0;
            timer = new DispatcherTimer(TimeSpan.FromMilliseconds(1000),DispatcherPriority.Normal,KepValto,Dispatcher.CurrentDispatcher);
            timer.Stop();
        }

        private void buttonLoad_Click(object sender, RoutedEventArgs e)
        {
            openFile = new OpenFileDialog();

            openFile.Multiselect = true;

            if (openFile.ShowDialog()==true)
            {
                //itt történik majd valami
                fajlok = openFile.FileNames;
                timer.Start();
            }
        }

        private void KepValto(object sender, EventArgs e)
        {
            //itt kellene képet tölteni
            kep.Source = new BitmapImage(new Uri(fajlok[szamlalo]));
            szamlalo++;
            if (szamlalo>=fajlok.Length)
            {
                szamlalo = 0;
            }
        }
    }
}
