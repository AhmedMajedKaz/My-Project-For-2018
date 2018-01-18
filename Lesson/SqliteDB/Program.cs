using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SqliteDB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            String quer = @"CREATE TABLE IF NOT EXISTS [mytable] (
[id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
[name] NVARCHAR(2048) NULL,
[gender] NVARCHAR(2048) NULL)";
            SQLiteConnection.CreateFile("sample.db3");
            using (SQLiteConnection conn = new SQLiteConnection("data source = sample.db3"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    conn.Open();
                    cmd.CommandText = quer;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO mytable(name,gender) values('ahmed','man')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO mytable(name,gender) values('mhmd','roman')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT * FROM mytable";
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["name"] + ":" + reader["gender"]);
                        }
                        conn.Cancel();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
