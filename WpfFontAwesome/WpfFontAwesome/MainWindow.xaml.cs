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
            //RandomGrid(20, 20);
            Aknarako(10, 10);
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
                    switch (rand.Next(1,9))
                    
                    {
                        case 1:
                            MineItem num1 = new MineItem();
                            mineGrid.Children.Add(num1.num1);
                            Grid.SetRow(num1.num1, i);
                            Grid.SetColumn(num1.num1, j);
                            break;
                        case 2:
                            MineItem num2 = new MineItem();
                            mineGrid.Children.Add(num2.num2);
                            Grid.SetRow(num2.num2, i);
                            Grid.SetColumn(num2.num2, j);
                            break;
                        case 3:
                            MineItem num3 = new MineItem();
                            mineGrid.Children.Add(num3.num3);
                            Grid.SetRow(num3.num3, i);
                            Grid.SetColumn(num3.num3, j);
                            break;
                        case 4:
                            MineItem num4 = new MineItem();
                            mineGrid.Children.Add(num4.num4);
                            Grid.SetRow(num4.num4, i);
                            Grid.SetColumn(num4.num4, j);
                            break;
                        case 5:
                            MineItem num5 = new MineItem();
                            mineGrid.Children.Add(num5.num5);
                            Grid.SetRow(num5.num5, i);
                            Grid.SetColumn(num5.num5, j);
                            break;
                        case 6:
                            MineItem num6 = new MineItem();
                            mineGrid.Children.Add(num6.num6);
                            Grid.SetRow(num6.num6, i);
                            Grid.SetColumn(num6.num6, j);
                            break;
                        case 7:
                            MineItem flag = new MineItem();
                            mineGrid.Children.Add(flag.flag);
                            Grid.SetRow(flag.flag, i);
                            Grid.SetColumn(flag.flag, j);
                            break;
                        case 8:
                            MineItem bomb = new MineItem();
                            mineGrid.Children.Add(bomb.bomb);
                            Grid.SetRow(bomb.bomb, i);
                            Grid.SetColumn(bomb.bomb, j);
                            break;
                        default:
                            break;
                    }
                }

            }
            alapGrid.Children.Add(mineGrid);
        }

        public void Aknarako(int sor,int oszlop)
        {
            var aknaSzam = (sor * oszlop) / 10;
            Grid mineGrid = new Grid();
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

            //???
            
            while (aknaSzam>0)
            {
                var sorPoz = rand.Next(0, sor + 1);
                var oszlopPoz = rand.Next(0, oszlop + 1);
                                
                MineItem bomb = new MineItem();
                mineGrid.Children.Add(bomb.bomb);
                Grid.SetRow(bomb.bomb,sorPoz);
                Grid.SetColumn(bomb.bomb, oszlopPoz);
        
                aknaSzam--;

            }
            
            alapGrid.Children.Add(mineGrid);
        }
        
        public void Bejaras(Grid grid)
        {

            foreach (Grid mineGrid in grid.Children)
            {
                foreach (UIElement item in mineGrid.Children)
                {

                    var s = Grid.GetRow(item);
                    var o = Grid.GetColumn(item);
                    Debug.WriteLine($"Elem:{s},{o}");
                }
            }

            

        }
    }
}
