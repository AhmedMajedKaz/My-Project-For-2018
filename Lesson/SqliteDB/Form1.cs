using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SqliteDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datas.Columns.Add("Asd","Name");
            datas.Columns.Add("Asda", "Gender");
            String quer = @"CREATE TABLE IF NOT EXISTS [mytable] (
[id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
[name] NVARCHAR(2048) NULL,
[gender] NVARCHAR(2048) NULL)";
            SQLiteConnection.CreateFile("sample.db3");
            using (SQLiteConnection conn = new SQLiteConnection("data source=sample.db3"))
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
                            datas.Rows.Add(new String[] { reader.GetString(1), reader.GetString(2) });
                        }
                        conn.Cancel();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
