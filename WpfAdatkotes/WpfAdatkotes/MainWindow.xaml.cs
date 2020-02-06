using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfAdatkotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            racs.DataContext = this;
            this.Probaszoveg = "";
        }

        private string probaszoveg;
        public String Probaszoveg {
            get { return probaszoveg; }
            set
            {
                probaszoveg = value;
                if (null!=this.PropertyChanged)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Probaszoveg"));
                }
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
