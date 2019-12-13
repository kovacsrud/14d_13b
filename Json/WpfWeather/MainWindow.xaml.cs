using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
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

namespace WpfWeather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        JObject weatherData;
        String apiKey = "cee47ae14c4e2b23dd70220929479c28";

        //https://tile.openweathermap.org/map/{layer}/{z}/{x}/{y}.png?appid={api_key}

        public MainWindow()
        {
            InitializeComponent();
           
            
        }

        public JObject GetWeatherData(string telepules)
        {
            JObject wData = JObject.Parse(new WebClient().DownloadString($"http://api.openweathermap.org/data/2.5/weather?q={telepules}&appid={apiKey}&units=metric"));

            return wData;
        }

        public Label WLabel(string data)
        {
            Label label = new Label();
            label.FontSize = 20;
            label.Content = data;
            return label;
        }

        private void buttonLekerdez_Click(object sender, RoutedEventArgs e)
        {
            stackIdoAdatok.Children.Clear();

            if (textboxTelepules.Text.Length>=3)
            {
                try
                {
                    weatherData = GetWeatherData(textboxTelepules.Text);
                    stackIdoAdatok.Children.Add(WLabel($"Helyiség: {Convert.ToString(weatherData["name"])}"));
                    stackIdoAdatok.Children.Add(WLabel($"Hőmérséklet: {Convert.ToString(weatherData["main"]["temp"])}"));
                    stackIdoAdatok.Children.Add(WLabel($"Hőérzet: {Convert.ToString(weatherData["main"]["feels_like"])}"));
                    stackIdoAdatok.Children.Add(WLabel($"Minimum: {Convert.ToString(weatherData["main"]["temp_min"])}"));
                    stackIdoAdatok.Children.Add(WLabel($"Maximum: {Convert.ToString(weatherData["main"]["temp_max"])}"));
                    imageWeather.Source = DownPic($"https://tile.openweathermap.org/map/temp_new/{3}/{2}/{1}.png?appid={apiKey}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba!");
                    
                }


                

            } else
            {
                MessageBox.Show("A település hossza min 3 karakter!", "Hiba!");
            }
            
            Debug.WriteLine(weatherData);
        }

        public BitmapImage DownPic(string url)
        {
            WebClient imgClient = new WebClient();
            BitmapImage img = new BitmapImage();

            byte[] imgdata = imgClient.DownloadData(url);

            MemoryStream ms = new MemoryStream(imgdata);

            img.BeginInit();
            img.StreamSource = ms;
            img.EndInit();


            return img;
        }
    }
}
