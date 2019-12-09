using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfLotto
{
    public class Jatek
    {
        private MainWindow mainwindow;
        private int[] tippek;
        private int[] nyeroSzamok;
        private int hanySzam;
        private int hanyatHuzunk;
        private int szamlalo;
        private int talalat;
        private int sorSzam;
        private int oszlopSzam;
        private Random rand=new Random();

        public Jatek(MainWindow mainwindow,int hanyszam,int hanyathuzunk,int sorszam,int oszlopszam)
        {
            this.mainwindow = mainwindow;
            talalat = 0;
            hanySzam = hanyszam;
            hanyatHuzunk = hanyathuzunk;
            tippek = new int[hanyatHuzunk];
            nyeroSzamok = new int[hanyatHuzunk];
            sorSzam = sorszam;
            oszlopSzam = oszlopszam;
            Gombok();
            szamlalo = 0;
            mainwindow.buttonSorsolas.Click += sorsClick;
            mainwindow.buttonUj.IsEnabled = false;
            mainwindow.buttonSorsolas.IsEnabled = false;
            
        }

        public void Gombok()
        {
            Grid gombok = new Grid();

            for (int i = 0; i < sorSzam; i++)
            {
                RowDefinition rowdef = new RowDefinition();
                gombok.RowDefinitions.Add(rowdef);
            }

            for (int i = 0; i < oszlopSzam; i++)
            {
                ColumnDefinition coldef = new ColumnDefinition();
                gombok.ColumnDefinitions.Add(coldef);
            }

            var gombszam = 1;
            for (int i = 0; i < sorSzam; i++)
            {
                for (int j= 0; j < oszlopSzam; j++)
                {
                    Button gomb = new Button();
                    gomb.Content = gombszam++;
                    gomb.Click += gombClick;
                    gomb.Margin = new Thickness(5);
                    gombok.Children.Add(gomb);
                    Grid.SetRow(gomb, i);
                    Grid.SetColumn(gomb, j);
                }
            }
            //hozzá kéne adni az ablak grid-jéhez
            mainwindow.szamokGrid.Children.Add(gombok);
        } 

        public void gombClick(object sender,RoutedEventArgs e)
        {
            Button gomb = (Button)sender;

            if (szamlalo<hanyatHuzunk)
            {
                if (!tippek.Contains(Convert.ToInt32(gomb.Content)))
                {
                    gomb.Foreground = Brushes.Blue;
                    gomb.Background = Brushes.Yellow;
                    tippek[szamlalo] = Convert.ToInt32(gomb.Content);
                    Debug.WriteLine(tippek[szamlalo]);
                    szamlalo++;
                }
                if (szamlalo>=hanyatHuzunk)
                {
                    mainwindow.buttonSorsolas.IsEnabled = true;
                }
            }
        }

        public void sorsClick(object sender,RoutedEventArgs e)
        {
            Sorsolas();
            Kiemeles();
            mainwindow.buttonSorsolas.IsEnabled = false;
        }

        private void Sorsolas()
        {
            for (int i = 0; i < hanyatHuzunk; i++)
            {

                var temp = rand.Next(1, hanySzam + 1);

                while (nyeroSzamok.Contains(temp))
                {
                    temp = rand.Next(1, hanySzam + 1);
                }
                nyeroSzamok[i] = temp;
                Debug.WriteLine(nyeroSzamok[i]);

            }

        }

        private void Kiemeles()
        {
            foreach (Grid gr in mainwindow.szamokGrid.Children)
            {
                foreach (Button gomb in gr.Children)
                {
                    if (nyeroSzamok.Contains(Convert.ToInt32(gomb.Content)))
                    {
                        gomb.Foreground = Brushes.Gold;
                        gomb.Background = Brushes.Red;
                    }
                    if (nyeroSzamok.Contains(Convert.ToInt32(gomb.Content)) && tippek.Contains(Convert.ToInt32(gomb.Content)))
                    {
                        gomb.Foreground = Brushes.Gold;
                        gomb.Background = Brushes.Green;
                    }
                }
            }
        }

    }
}
