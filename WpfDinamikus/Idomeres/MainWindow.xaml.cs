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

namespace Idomeres
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stopwatch stopper = new Stopwatch();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void startstop_Click(object sender, RoutedEventArgs e)
        {
            if (stopper.IsRunning)
            {
                startstop.Content = "Stop";
                stopper.Stop();
                elteltIdo.Content = stopper.ElapsedTicks;
                stopper.Reset();
                
            } else
            {
                stopper.Start();
                startstop.Content = "Start";
            }
        }
    }
}
