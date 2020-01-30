using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfKutyakok
{
    public class KutyafajtaAdapter
    {
        SQLiteConnection conn;
        SQLiteDataAdapter adapter;
        DataTable table;

        public KutyafajtaAdapter(string connString)
        {
            conn = new SQLiteConnection(connString);
            adapter = new SQLiteDataAdapter("", conn);
            table = new DataTable();

            adapter.SelectCommand = new SQLiteCommand(conn);
            adapter.SelectCommand.CommandText = "select * from kutyafajtak";

            adapter.InsertCommand = new SQLiteCommand(conn);
            adapter.InsertCommand.CommandText = "insert into kutyafajtak " +
                "(nev,eredetinev) " +
                "values " +
                "(@nev,@eredetinev)";
            adapter.InsertCommand.Parameters.Add("@nev", DbType.String, 0, "nev");
            adapter.InsertCommand.Parameters.Add("@eredetinev", DbType.String, 0, "eredetinev");

            adapter.UpdateCommand = new SQLiteCommand(conn);
            adapter.UpdateCommand.CommandText = "update kutyafajtak set " +
                "nev=@nev " +
                "eredetinev=@eredetinev " +
                "where Id=@old_Id";
            adapter.UpdateCommand.Parameters.Add("@nev", DbType.String, 0, "nev");
            adapter.UpdateCommand.Parameters.Add("@eredetinev", DbType.String, 0, "eredetinev");
            adapter.UpdateCommand.Parameters.Add("@old_Id", DbType.Int32, 0, "Id").SourceVersion = DataRowVersion.Original;

            adapter.DeleteCommand = new SQLiteCommand(conn);
            adapter.DeleteCommand.CommandText = "delete from kutyafajtak " +
                "where Id=@old_Id";
            adapter.DeleteCommand.Parameters.Add("@old_Id", DbType.Int32, 0, "Id").SourceVersion = DataRowVersion.Original;
        }

        public DataTable GetKutyafajtak()
        {
            adapter.Fill(table);
            return table;
        }

        public void UpdateKutyafajtak()
        {
            adapter.Update(table);
        }
    }
}
