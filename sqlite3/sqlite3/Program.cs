using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sqlite3
{
    class Program
    {
        static void Main(string[] args)

        {
            string connectionString = "Data Source=idojarasadatok.db;Version=3;";
            //kapcsolat létrehozása

            //select
            using (SQLiteConnection db_connect=new SQLiteConnection(connectionString))
            {
                db_connect.Open();
                using (SQLiteCommand sqlc=new SQLiteCommand())
                {
                    string sqlComm = "select * from idojarasadatok limit 10";
                    sqlc.Connection = db_connect;
                    sqlc.CommandText = sqlComm;

                    using (SQLiteDataReader reader=sqlc.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["ev"]},{reader["honap"]}");
                            }
                        } else
                        {
                            Console.WriteLine("Nincs ilyen adat");
                        }
                    }
                }


            }
            //insert
            using (SQLiteConnection db_connect = new SQLiteConnection(connectionString))
            {
                db_connect.Open();
                using (SQLiteCommand sqlc = new SQLiteCommand())
                {
                    //string sqlComm = "INSERT INTO idojarasadatok (ev,honap,nap,ora,homerseklet,szelsebesseg,paratartalom) values(2020,1,1,0,12,13,14)";
                    string sqlComm = "INSERT INTO idojarasadatok (ev,honap,nap,ora,homerseklet,szelsebesseg,paratartalom) values(@ev,@honap,@nap,@ora,@homerseklet,@szelsebesseg,@paratartalom)";
                    sqlc.Connection = db_connect;
                    sqlc.CommandText = sqlComm;
                    sqlc.Parameters.Add("@ev", DbType.Int32).Value = 2020;
                    sqlc.Parameters.Add("@honap", DbType.Int32).Value = 2;
                    sqlc.Parameters.Add("@nap", DbType.Int32).Value = 2;
                    sqlc.Parameters.Add("@ora", DbType.Int32).Value = 0;
                    sqlc.Parameters.Add("@homerseklet", DbType.Double).Value = 15.2;
                    sqlc.Parameters.Add("@szelsebesseg", DbType.Double).Value = 15.3;
                    sqlc.Parameters.Add("@paratartalom", DbType.Double).Value = 15.4;


                    var sor=sqlc.ExecuteNonQuery();
                    Console.WriteLine($"{sor} beillesztve.");

                }


            }

            //update
            using (SQLiteConnection db_connect = new SQLiteConnection(connectionString))
            {
                db_connect.Open();
                using (SQLiteCommand sqlc = new SQLiteCommand())
                {
                   
                    string sqlComm = "UPDATE idojarasadatok SET ev=@upev WHERE ev=@ev";
                    sqlc.Connection = db_connect;
                    sqlc.CommandText = sqlComm;
                    sqlc.Parameters.Add("@ev", DbType.Int32).Value = 2020;
                    sqlc.Parameters.Add("@upev", DbType.Int32).Value = 2021;
                    


                    var sor = sqlc.ExecuteNonQuery();
                    Console.WriteLine($"{sor} módosítva.");

                }


            }

            //delete
            using (SQLiteConnection db_connect = new SQLiteConnection(connectionString))
            {
                db_connect.Open();
                using (SQLiteCommand sqlc = new SQLiteCommand())
                {
                    
                    string sqlComm = "DELETE FROM idojarasadatok WHERE ev>@ev";
                    sqlc.Connection = db_connect;
                    sqlc.CommandText = sqlComm;
                    sqlc.Parameters.Add("@ev", DbType.Int32).Value = 2016;
                   
                    var sor = sqlc.ExecuteNonQuery();
                    Console.WriteLine($"{sor} törölve.");

                }


            }

            Console.ReadKey();
        }
    }
}
