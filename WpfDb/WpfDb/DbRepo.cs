using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfDb
{
    public class DbRepo
    {
        private string connectionString;
        private DataGrid datagrid;

        public DbRepo(string connectionString, DataGrid datagrid)
        {
            this.connectionString = connectionString;
            this.datagrid = datagrid;
        }

        public void DbLekerdez()
        {
            using (SQLiteConnection conn=new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand sqlc=new SQLiteCommand())
                {
                    sqlc.Connection = conn;
                    sqlc.CommandText = "select * from idojarasadatok";
                    DataTable table = new DataTable();
                    table.Load(sqlc.ExecuteReader());
                    datagrid.ItemsSource = table.DefaultView;
                }
            }
        }
        public void DbBeilleszt(int ev, int honap, int nap, int ora, double homerseklet, double szelsebesseg, double paratartalom)
        {

        }
    }
}
