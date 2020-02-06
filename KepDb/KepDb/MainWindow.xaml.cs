using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
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

namespace KepDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InsertGumi();
            ReadKep();
        }
        public void InsertGumi()
        {
            byte[] kepfilebytes = File.ReadAllBytes(@"michelin.jpg");

            string connString = "Data Source=gumiabroncs.db;Version=3";
            SQLiteConnection conn = new SQLiteConnection(connString);
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand(conn);
            comm.CommandText = "INSERT INTO abroncsok (marka,meret,gumikep) "+
                "values (@marka,@meret,@gumikep)";

            comm.Parameters.Add("@marka", DbType.String, 8).Value = "Michelin";
            comm.Parameters.Add("@meret", DbType.String, 8).Value = "165*70*R14";
            comm.Parameters.Add("@gumikep", DbType.Binary, kepfilebytes.Length).Value = kepfilebytes;

            var sor=comm.ExecuteNonQuery();
            Debug.WriteLine(sor);


            conn.Close();

        }

        public void ReadKep()
        {
            string connString = "Data Source=gumiabroncs.db;Version=3";
            SQLiteConnection conn = new SQLiteConnection(connString);
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand(conn);
            comm.CommandText = "select gumikep from abroncsok where Id=1";
            byte[] gumipic = (byte [])comm.ExecuteScalar();

            MemoryStream ms = new MemoryStream(gumipic);
            BitmapImage gumibitmap = new BitmapImage();
            gumibitmap.BeginInit();
            gumibitmap.StreamSource = ms;
            gumibitmap.EndInit();

            gumikep.Source = gumibitmap;

            conn.Close();
        }



    }
}
