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

namespace WpfIP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String apiKey = "57e7f2daa88da7119dc6c575f1232c0f";
        JObject ipData;

        public MainWindow()
        {
            InitializeComponent();
            GetIPData("2.16.7.2");
            Debug.WriteLine(ipData);
            Debug.WriteLine(ipData["city"]);
            stackData.Children.Add(DataToLabel((string)ipData["continent_name"]));
            stackData.Children.Add(DataToLabel((string)ipData["country_name"]));
            stackData.Children.Add(DataToLabel((string)ipData["city"]));

            imageDown.Source = DownPic("http://bekszi.hu/userfiles/Linux_meghivo_WEB.jpg");
        }

        public void GetIPData(string ip)
        {
            ipData = JObject.Parse(new WebClient().DownloadString($"http://api.ipstack.com/{ip}?access_key={apiKey}"));
        }

        public Label DataToLabel(string data)
        {
            Label label = new Label();
            label.Content = data;
            return label;
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
