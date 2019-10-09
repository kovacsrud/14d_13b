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

namespace WpfDinamikus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SokLabel(100);
        }

        public void SokLabel(int db)
        {
            for (int i = 0; i < db; i++)
            {
                //címkét hozunk létre futási időben
                Label label = new Label();
                //pár tulajdonságát beállítjuk
                label.Content = i + 1;
                label.FontSize = 16;
                label.Margin = new Thickness(5);
                //hozzá kell adni ahhoz az elemhez amely tartalmazni fogja a címkét
                elemek.Children.Add(label);
            }
        }
    }
}
