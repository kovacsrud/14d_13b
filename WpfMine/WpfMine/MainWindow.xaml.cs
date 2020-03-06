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

namespace WpfMine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MineItems mineItems = new MineItems();
            mineField.Children.Add(mineItems.num1);
            Grid.SetColumn(mineItems.num1, 3);
            mineField.Children.Add(mineItems.flag);
            Grid.SetColumn(mineItems.flag, 0);
            Grid.SetRow(mineItems.flag, 1);
        }
    }
}
