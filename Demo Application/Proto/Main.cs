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
using System.IO;

namespace Proto
{
    public partial class Main : Form
    {
        int index = 0;
        byte[] ma = null;
        int inss = 0;
        int ida;
        public Main()
        {
            InitializeComponent();
        }
        List<user> Users = new List<user>();
        private void Main_Load(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            picture.Image.Save(ms, picture.Image.RawFormat);
            ma = ms.GetBuffer();
            ms.Close();
            picture.Image = null;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source=Data.db3"))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        conn.Open();
                        cmd.CommandText = "SELECT * FROM users";
                        SQLiteCommand cmda = new SQLiteCommand(conn);
                        cmda.CommandText = "SELECT Image FROM users";
                        SQLiteDataAdapter ade = new SQLiteDataAdapter(cmda);
                        SQLiteCommandBuilder cms = new SQLiteCommandBuilder(ade);
                        DataSet dsd = new DataSet();
                        ade.Fill(dsd);
                        byte[] pir;
                        using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                            while (reader.Read())
                            {
                                pir = (byte[])(dsd.Tables[0].Rows[inss]["Image"]);
                                if (pir != null) {
                                    Users.Add(new user(reader.GetString(2),Convert.ToInt32( reader.GetString(3)), pir,reader.GetInt32(1)));
                                }
                                else
                                {
                                    Users.Add(new user(reader.GetString(2), Convert.ToInt32(reader.GetString(3)),ma,reader.GetInt32(1)));
                                }
                                datas.Rows.Add(reader.GetString(2),inss,Convert.ToInt32( reader.GetString(3)));
                                inss++;
                            }
                        }
                        conn.Cancel();
                        
                    }
                }
            }catch(SQLiteException ex)
            {
                SQLiteConnection.CreateFile("Data.db3");
                using (SQLiteConnection conn = new SQLiteConnection("data source=Data.db3"))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        conn.Open();
                        cmd.CommandText = "CREATE TABLE `users` ( `Image` BLOB, `id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `Name` NVARCHAR (2048), `Grade` NVARCHAR(2048));";
                        cmd.ExecuteNonQuery();
                        conn.Cancel();

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ins_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(grade.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Error In Grade");
                return;
            }
            using (SQLiteConnection conn = new SQLiteConnection("data source=Data.db3"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    conn.Open();
                    if (picture.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        picture.Image.Save(ms,picture.Image.RawFormat);
                        byte[] d = ms.GetBuffer();
                        ms.Close();
                        cmd.Parameters.AddWithValue("@pic",d);
                        Users.Add(new user(name.Text,Convert.ToInt32(grade.Text),d));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@pic", ma);
                        Users.Add(new user(name.Text, Convert.ToInt32(grade.Text), ma));
                    }
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@grade", grade.Text);
                    cmd.CommandText = "INSERT INTO users(Image,Name,Grade) values(@pic,@name,@grade)";
                    datas.Rows.Add(name.Text,inss++,grade.Text);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT * FROM users";
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        int isa = 0;
                        while (reader.Read())
                        {
                            Users[isa++].id = reader.GetInt32(1);
                        }
                    }
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fil = new OpenFileDialog();
            fil.Filter = "All Files|*.*|JPG Files|*.jpg|PNG Files|*.png";
            fil.FilterIndex = 2;
            if (fil.ShowDialog() == DialogResult.OK)
            {
                picture.Image = Image.FromFile(fil.FileName);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        

        private void Main_Click(object sender, EventArgs e)
        {
            if (ins.Visible == false)
            {
                ins.Show();
                upd.Hide();
                del.Hide();
                picture.Image = null;
                grade.Text = "";
                name.Text = "";
            }
        }

        private void datas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < datas.RowCount && e.RowIndex >= 0){
                upd.Show();
                del.Show();
                ins.Hide();
                picture.Image = Image.FromStream(new MemoryStream(Users[e.RowIndex].pic));
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                name.Text = Users[e.RowIndex].Name;
                grade.Text = Users[e.RowIndex].Grade.ToString();
                index = e.RowIndex;
            }
            else if(e.RowIndex >= 0)
            {
                if (ins.Visible == false)
                {
                    ins.Show();
                    upd.Hide();
                    del.Hide();
                    picture.Image = null;
                }
            }
        }

        private void upd_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(grade.Text);
            }
            catch (Exception exa)
            {
                MessageBox.Show("Error In Grade");
                return;
            }
            using (SQLiteConnection conn = new SQLiteConnection("data source=Data.db3"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    conn.Open();
                    cmd.Parameters.Clear();
                    if (picture.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        picture.Image.Save(ms, picture.Image.RawFormat);
                        byte[] d = ms.GetBuffer();
                        ms.Close();
                        cmd.Parameters.AddWithValue("@pic", d);
                        Users[index].Name = name.Text;
                        Users[index].Grade = Convert.ToInt32(grade.Text);
                        Users[index].pic = d;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@pic", ma);
                        Users[index].Name = name.Text;
                        Users[index].Grade = Convert.ToInt32(grade.Text);
                    }
                    cmd.CommandText = "update users set Name='" + name.Text + "',Grade='"+ grade.Text + "',Image=@pic where id='" + Users[index].id + "'";
                    DataGridViewRow dr = datas.Rows[index];
                    datas.Rows[index].SetValues(name.Text,dr.Cells[1], grade.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source=Data.db3"))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        conn.Open();
                        cmd.CommandText = "delete from users where id='" + Users[index].id.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        grade.Text = "";
                        name.Text = "";
                        DataGridViewRow ro = datas.Rows[index];
                        datas.Rows.Remove(ro);
                        Users.Remove(Users[index]);
                        picture.Image = null;
                        conn.Close();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    class user
    {
        public String Name;

        public int Grade;

        public byte[] pic = null;

        public int id;

        public user(String name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public user(String name, int grade,int isa)
        {
            Name = name;
            Grade = grade;
            id = isa;
        }

        public user(String name, int grade,byte[] pi)
        {
            Name = name;
            Grade = grade;
            pic = pi;
        }
        public user(String name, int grade, byte[] pi,int isa)
        {
            Name = name;
            Grade = grade;
            pic = pi;
            id = isa;
        }
    }
}
