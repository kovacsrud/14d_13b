using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace WpfKutyakok
{
    public class KutyanevAdapter
    {
        SQLiteConnection conn;
        SQLiteDataAdapter adapter;
        DataTable table;

        public KutyanevAdapter(string connString)
        {
            conn = new SQLiteConnection(connString);
            adapter = new SQLiteDataAdapter("", conn);
            table = new DataTable();

            adapter.SelectCommand = new SQLiteCommand(conn);
            adapter.SelectCommand.CommandText = "select * from kutyanevek";

            adapter.InsertCommand = new SQLiteCommand(conn);
            adapter.InsertCommand.CommandText = "insert into kutyanevek "+
                "(kutyanev) "+
                "values "+
                "(@kutyanev)";
            adapter.InsertCommand.Parameters.Add("@kutyanev", DbType.String, 0, "kutyanev");

            adapter.UpdateCommand = new SQLiteCommand(conn);
            adapter.UpdateCommand.CommandText = "update kutyanevek set "+
                "kutyanev=@kutyanev "+
                "where Id=@old_Id";
            adapter.UpdateCommand.Parameters.Add("@kutyanev", DbType.String, 0, "kutyanev");
            adapter.UpdateCommand.Parameters.Add("@old_Id", DbType.Int32, 0, "Id").SourceVersion = DataRowVersion.Original;

            adapter.DeleteCommand = new SQLiteCommand(conn);
            adapter.DeleteCommand.CommandText = "delete from kutyanevek "+
                "where Id=@old_Id";
            adapter.DeleteCommand.Parameters.Add("@old_Id", DbType.Int32, 0, "Id").SourceVersion = DataRowVersion.Original;

        }

        public DataTable GetKutyanevek()
        {
            adapter.Fill(table);
            return table;
        }

        public void UpdateKutyanevek()
        {
            adapter.Update(table);
        }

    }
}
