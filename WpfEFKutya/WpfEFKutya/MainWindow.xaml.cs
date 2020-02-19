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
using System.Data.Entity;
using System.Diagnostics;

namespace WpfEFKutya
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KutyaContext kutyacontext;
        public MainWindow()
        {
            InitializeComponent();
            kutyacontext = new KutyaContext();
            kutyacontext.Kutyak.Load();
            kutyacontext.Kutyanevek.Load();
            kutyacontext.Kutyafajtak.Load();
            DataContext= kutyacontext.Kutyak.Local;
            kutyanevAdatok.DataContext = kutyacontext.Kutyanevek.Local;
            kutyafajtaAdatok.DataContext = kutyacontext.Kutyafajtak.Local;
            comboFelKutyanev.ItemsSource= kutyacontext.Kutyanevek.Local;
            comboFelKutyafajta.ItemsSource= kutyacontext.Kutyafajtak.Local;
            comboModKutyanev.ItemsSource = kutyacontext.Kutyanevek.Local;
            comboModKutyafajta.ItemsSource = kutyacontext.Kutyafajtak.Local;


        }

        private void buttonKnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                kutyacontext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nem törölhető!");
            }
            
        }

        private void buttonKfUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                kutyacontext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nem törölhető!");
            }
        }

        private void buttonUjKezeles_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Kutyak ujkutya = new Kutyak
                {
                    nevid = Convert.ToInt32(comboFelKutyanev.SelectedValue),
                    fajtaid = Convert.ToInt32(comboFelKutyafajta.SelectedValue),
                    eletkor = Convert.ToInt32(textBoxEletkor.Text),
                    utolsoellenorzes = Convert.ToDateTime(textBoxUtolsoEllenorzes.Text)

                };

                kutyacontext.Kutyak.Add(ujkutya);
                kutyacontext.SaveChanges();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Hiba!");
            }

            Debug.WriteLine(comboFelKutyanev.SelectedValue);
            Debug.WriteLine(comboFelKutyafajta.SelectedValue);
        }

        private void GridAdatChanged(object sender,SelectionChangedEventArgs e)
        {
            Kutyak selectedKutya = (Kutyak)adatok.SelectedItem;
            textBoxModId.Text = Convert.ToString(selectedKutya.id);
            textBoxModEletkor.Text = Convert.ToString(selectedKutya.eletkor);
            textBoxModUtolsoEllenorzes.Text = Convert.ToString(selectedKutya.utolsoellenorzes);
            comboModKutyanev.SelectedValue = selectedKutya.nevid;
            comboModKutyafajta.SelectedValue = selectedKutya.fajtaid;
        }

        private void buttonModKezeles_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var modositas = kutyacontext.Kutyak.Local.Where(x => x.id == Convert.ToInt32(textBoxModId.Text));
                modositas.First().nevid = Convert.ToInt32(comboModKutyanev.SelectedValue);
                modositas.First().fajtaid = Convert.ToInt32(comboModKutyafajta.SelectedValue);
                modositas.First().eletkor = Convert.ToInt32(textBoxModEletkor.Text);
                modositas.First().utolsoellenorzes = Convert.ToDateTime(textBoxModUtolsoEllenorzes.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hiba!");
            }
            

            kutyacontext.SaveChanges();
        }

        private void buttonKereses_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
