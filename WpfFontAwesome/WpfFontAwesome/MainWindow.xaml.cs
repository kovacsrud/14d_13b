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

namespace WpfFontAwesome
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand;
        MineItem item;
        public MainWindow()
        {
            InitializeComponent();
            item = new MineItem();
            //items.num4.FontSize = 50;
            //items.num4.HorizontalAlignment = HorizontalAlignment.Center;
            //aws.Children.Add(items.num4);
            //Grid.SetRow(items.num4, 1);
            rand = new Random();
            RandomGrid(20, 20);
        }

        public void RandomGrid(int sor,int oszlop)
        {
            Grid mineGrid = new Grid();
            //sor ill. oszlop definíciókat kell hozzáadni
            //először
            for (int i = 0; i < sor; i++)
            {
                RowDefinition rowdef = new RowDefinition();
                mineGrid.RowDefinitions.Add(rowdef);
            }
            for (int i = 0; i < oszlop; i++)
            {
                ColumnDefinition coldef = new ColumnDefinition();
                mineGrid.ColumnDefinitions.Add(coldef);
            }

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    //switch (rand.Next(1,9))
                    switch (1)
                    {
                        case 1:
                            MineItem num1 = new MineItem();
                            mineGrid.Children.Add(num1.num1);
                            Grid.SetRow(num1.num1, i);
                            Grid.SetColumn(num1.num1, j);
                            break;
                        default:
                            break;
                    }
                }

            }
            alapGrid.Children.Add(mineGrid);
        }
            
    }
}
