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

namespace Mathematical
{
    public partial class Form1 : Form
    {
        List<Panel> pages = new List<Panel>();
        List<User> users = new List<User>();
        Image true_image = Mathematical.Properties.Resources._true;
        Image false_image = Mathematical.Properties.Resources._false;
        List<PictureBox> hearts = new List<PictureBox>();
        Level Question;
        User player;
        byte[] picn = null;
        int Operation = 0;
        List<Level> sum_level = new List<Level>();
        List<Level> oper1_level = new List<Level>();
        byte[] hear = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pages.Add(main);
            pages.Add(login);
            pages.Add(sign);
            pages.Add(account);
            pages.Add(levels);
            pages.Add(lev);
            pages.Add(level);
            //371; 228
            //474; 228
            //474; 258
            this.Width = 371;
            this.Height = 228 + 31;
            pages[0].BringToFront();
            MemoryStream ms = new MemoryStream();
            MemoryStream ms2 = new MemoryStream();
            picture_account.SizeMode = PictureBoxSizeMode.StretchImage;
            set_size_heart();
            picture_account.Image.Save(ms, picture_account.Image.RawFormat);
            heart1_level.Image.Save(ms, heart1_level.Image.RawFormat);
            picn = ms.GetBuffer();
            hear = ms2.GetBuffer();
            ms.Close();
            ms2.Close();
            setLevels();
            DataConnection();
            hearts.Add(heart1_level);
            hearts.Add(heart2_level);
            hearts.Add(heart3_level);
        }
        
        void set_size_heart()
        {
            heart1_level.SizeMode = PictureBoxSizeMode.StretchImage;
            heart2_level.SizeMode = PictureBoxSizeMode.StretchImage;
            heart3_level.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        void set_Hearts()
        {
            Image imga = Image.FromStream(new MemoryStream(hear));
            heart1_level.Image = imga;
            heart2_level.Image = imga;
            heart3_level.Image = imga;
            set_size_heart();
        }

        void setLevels() {
            sum_level.Add(new Level(10,1,3,0));
            sum_level.Add(new Level(25,5,10,10));
            sum_level.Add(new Level(50, 30,15,25));
            sum_level.Add(new Level(75, 45, 25,75));
            sum_level.Add(new Level(100, 50, 35,100));
            sum_level.Add(new Level(150, 75, 50,150));
            sum_level.Add(new Level(250, 100, 100,250));
            sum_level.Add(new Level(275, 150, 130,500));
            sum_level.Add(new Level(310, 200, 150,750));
            sum_level.Add(new Level(420, 300, 200,1000));
            sum_level.Add(new Level(530, 400, 250,1500));
            sum_level.Add(new Level(640, 500, 300,1750));
            sum_level.Add(new Level(750, 600, 350,3000));
            sum_level.Add(new Level(860, 700, 400,3500));
            sum_level.Add(new Level(970, 800, 450,5000));
            sum_level.Add(new Level(1200, 1000, 550,6000));
            sum_level.Add(new Level(1305, 1000, 650,7500));
            sum_level.Add(new Level(1520, 1000, 780,9000));
            sum_level.Add(new Level(1650, 1200, 900,10000));
            sum_level.Add(new Level(1780, 1400, 1000,12500));
            sum_level.Add(new Level(1900, 1500, 1200,17500));
            sum_level.Add(new Level(2000, 1500, 1400,20000));
            sum_level.Add(new Level(4000, 2500, 2000,26000));
            sum_level.Add(new Level(6700, 5000, 3000,35000));
            sum_level.Add(new Level(12300, 8000, 5000,50000));
            sum_level.Add(new Level(14000, 10000, 7500,75000));
            sum_level.Add(new Level(16300, 12000, 10000,100000));
            sum_level.Add(new Level(16500, 13500, 12500,150000));
            sum_level.Add(new Level(18000, 16000, 15000,250000));
            sum_level.Add(new Level(19500, 18000, 17500,370000));
            sum_level.Add(new Level(20000, 18600, 20000,500000));
            sum_level.Add(new Level(22000, 19000, 21000,750000));
            sum_level.Add(new Level(25000, 20000, 22000,1000000));
            sum_level.Add(new Level(27500, 25000, 23000,1100000));
            sum_level.Add(new Level(30000, 25000, 24000,1200000));
            sum_level.Add(new Level(34500, 30000, 25000,1300000));
            sum_level.Add(new Level(35000, 33000, 26000,1400000));
            sum_level.Add(new Level(37600, 35000, 27000,1500000));
            sum_level.Add(new Level(41000, 40000, 28000,1600000));
            sum_level.Add(new Level(45000, 43000, 29000,1700000));
            sum_level.Add(new Level(45630, 44000, 31000,1800000));
            sum_level.Add(new Level(50000, 45000, 33000,1900000));
            sum_level.Add(new Level(56000, 52000, 35000,2000000));
            sum_level.Add(new Level(57800, 54000, 38000,2200000));
            sum_level.Add(new Level(60000, 54000, 40000,2400000));
            sum_level.Add(new Level(61000, 55000, 45000,2600000));
            sum_level.Add(new Level(67500, 60000, 50000,2800000));
            sum_level.Add(new Level(70000, 64000, 60000,3000000));
            sum_level.Add(new Level(85000, 20000, 75000,3300000));
            sum_level.Add(new Level(100000, 1, 100000,4000000));
            int mix = 5;
            int min = 2;
            for(int x = 0;x<50; x++)
            {
                oper1_level.Add(new Level(mix+=5,min+=2,sum_level[x].score,sum_level[x].lev));
            }

        }


        void addLevels(int oper)
        {
            comboBox_levels.Items.Clear();
            if (oper == 1)
            {
                for (int x = 0; x < sum_level.Count;x++)
                {
                    if (player.level >= sum_level[x].lev)
                    {
                        comboBox_levels.Items.Add("Level " + (x + 1));
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        void DataConnection()
        {
            try
             {
                 using (SQLiteConnection conn = new SQLiteConnection("data source=Data.db3"))
                 {
                     using (SQLiteCommand cmd = new SQLiteCommand(conn))
                     {
                        
                         conn.Open();
                         cmd.CommandText = "SELECT * FROM users";
                         using (SQLiteDataReader reader = cmd.ExecuteReader())
                         {
                             while (reader.Read())
                             {
                                users.Add(new User(reader.GetInt32(1),reader.GetString(3),reader.GetInt32(4),reader.GetString(2)));
                             }
                         }
                         conn.Cancel();

                     }
                 }
             }
             catch (SQLiteException ex)
             {
                 SQLiteConnection.CreateFile("Data.db3");
                 using (SQLiteConnection conn = new SQLiteConnection("data source=Data.db3"))
                 {
                     using (SQLiteCommand cmd = new SQLiteCommand(conn))
                     {
                         conn.Open();
                         cmd.CommandText = "CREATE TABLE `users` ( `Image` BLOB,`id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `name` NVARCHAR (2048), `password` NVARCHAR(2048),`level` INTEGER);";
                         cmd.ExecuteNonQuery();
                         conn.Cancel();

                     }
                 }
             }
        }
        

        private void exit_top_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_main_Click(object sender, EventArgs e)
        {
            this.Width = 474;
            this.Height = 228 + 31;
            pages[1].BringToFront();
        }

        private void sign_main_Click(object sender, EventArgs e)
        {
            //474; 258
            this.Width = 474;
            this.Height = 258 + 31;
            pages[2].BringToFront();            
        }

        private void login_login_Click(object sender, EventArgs e)
        {
            for(int x = 0;x < users.Count; x++)
            {
                if (name_login.Text == users[x].name && pass_login.Text == users[x].password)
                {
                    player = users[x];
                    change_level();
                    picture_account.Image = GetImage(users[x].id);
                    name_account.Text = player.name;
                    //508; 404
                    this.Width = 508;
                    this.Height = 404 + 31;
                    pages[3].BringToFront();
                }
            }
        }

        private void back_login_Click(object sender, EventArgs e)
        {
            this.Width = 371;
            this.Height = 228 + 31;
            pages[0].BringToFront();
            name_login.Text = "";
            pass_login.Text = "";
        }
        
        private void sign_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sign_sign_Click(object sender, EventArgs e)
        {
            Boolean isfound = false;
            Boolean ispass = false;
            String name = name_sign.Text;
            for (int x = 0; x < users.Count; x++)
            {
                if (name == users[x].name)
                {
                    isfound = true;
                    return;
                }
            }
            if (pass_sign.Text == repass_sign.Text)
            {
                ispass = true;
            }
            if (isfound == false && ispass == true)
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source=Data.db3"))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        conn.Open();
                        MemoryStream ms = new MemoryStream();
                        picture_account.Image.Save(ms, picture_account.Image.RawFormat);
                        byte[] d = ms.GetBuffer();
                        ms.Close();
                        cmd.Parameters.AddWithValue("@pic", d);
                        users.Add(new User(users.Count, pass_sign.Text, 0, name));
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@pass", pass_sign.Text);
                        cmd.Parameters.AddWithValue("@level", 0);
                        cmd.CommandText = "INSERT INTO users(Image,name,password,level) values(@pic,@name,@pass,@level)";
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            else if (ispass == false)
            {
                pass_sign.Text = "";
                repass_sign.Text = "";
                MessageBox.Show("error in your password");
            }
            else
            {
                MessageBox.Show("your name is used");
            }
        }

        private void back_sign_Click(object sender, EventArgs e)
        {
            this.Width = 371;
            this.Height = 228 + 31;
            pages[0].BringToFront();
            name_sign.Text = "";
            pass_sign.Text = "";
            repass_sign.Text = "";
        }

        Image GetImage(int id)
        {
            Image img;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source=Data.db3"))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        conn.Open();
                        SQLiteCommand cmda = new SQLiteCommand(conn);
                        cmda.CommandText = "SELECT image FROM users where id='" + id + "'";
                        SQLiteDataAdapter ade = new SQLiteDataAdapter(cmda);
                        SQLiteCommandBuilder cms = new SQLiteCommandBuilder(ade);
                        DataSet dsd = new DataSet();
                        ade.Fill(dsd);
                        img = Image.FromStream( new MemoryStream((byte[])(dsd.Tables[0].Rows[0]["image"])));
                        conn.Cancel();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                img = Image.FromStream(new MemoryStream(picn));
            }
            return img;
        }

        class User
        {
            public User(int id, string password,int level, string name)
            {
                this.id = id;
                this.name = name;
                this.level = level;
                this.password = password;
            }
            public User(int id, string password, string name,int level, byte[] image)
            {
                this.id = id;
                this.name = name;
                this.password = password;
                this.level = level;
                this.image = image;
            }
            public int id;
            public string password;
            public string name;
            public byte[] image = null;
            public int level;
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void levelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player = null;
            this.Width = 371;
            this.Height = 228 + 31;
            pages[0].BringToFront();
            name_login.Text = "";
            pass_login.Text = "";
        }

        private void tol_account_Click(object sender, EventArgs e)
        {
            //508; 277
            this.Width = 508;
            this.Height = 277 + 31;
            pages[5].BringToFront();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void account_Paint(object sender, PaintEventArgs e)
        {

        }
        Boolean ischoose = false;
        private void picture_account_Click(object sender, EventArgs e)
        {
            //294; 79
            //350; 79
            //300; 148
            //370; 148
            try
            {
                OpenFileDialog fil = new OpenFileDialog();
                fil.Filter = "All Files|*.*|JPG Files|*.jpg|PNG Files|*.png";
                fil.FilterIndex = 2;
                if (fil.ShowDialog() == DialogResult.OK)
                {
                    if(MessageBox.Show("You Want This Pictue ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Image ims = Image.FromFile(fil.FileName);
                        if (ims.Height > ims.Width)
                        {
                            name_account.Location = new Point(294, 79);
                            tol_account.Location = new Point(300, 148);
                            picture_account.Height = 275;
                            picture_account.Width = 200;
                        }
                        else if (ims.Height < ims.Width)
                        {
                            name_account.Location = new Point(360, 79);
                            tol_account.Location = new Point(370, 148);
                            picture_account.Height = 227;
                            picture_account.Width = 275;
                        }
                        picture_account.Image = Image.FromFile(fil.FileName);
                        change_picture();
                        ischoose = true;
                        picture_account.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (OutOfMemoryException ex)
            {
                if (ex.Message == "Out of memory.")
                {
                    MessageBox.Show("Error in Your File");
                }
            }
        }

        void change_picture()
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=Data.db3"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    conn.Open();
                    cmd.Parameters.Clear();
                    MemoryStream ms = new MemoryStream();
                    picture_account.Image.Save(ms, picture_account.Image.RawFormat);
                    byte[] image = ms.GetBuffer();
                    ms.Close();
                    cmd.Parameters.AddWithValue("@pic", image);
                    cmd.CommandText = "update users set image=@pic where id='" + player.id + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        int[] levs = new int[] { 10,25,50,100,150,250,500,750,1000,2500,3500,5000,7500,10000,12500,15000,17500,25000,35000,50000,100000,250000,500000,1000000,5000000};

        void change_level()
        {
            int score = 0;
            int ends = 0;
            for(int x = 0; x < levs.Length; x++)
            {
                if (player.level >= levs[x])
                {
                    score = x + 1;
                }
                else
                {
                    ends = levs[x] - player.level;
                    level_account.Text = "your Level is " + score + " , " + ends + " Coin for Next Level";
                    return;
                }
            }
            level_account.Text = "you End this Game";
        }

        private void sum_lev_Click(object sender, EventArgs e)
        {
            //378; 241
            Operation = 1;
            this.Width = 378;
            this.Height = 241 + 31;
            addLevels(1);
            comboBox_levels.SelectedIndex = 0;
            pages[4].BringToFront();
        }

        private void back_lev_Click(object sender, EventArgs e)
        {
            change_level();
            //508; 404
            this.Width = 508;
            this.Height = 404 + 31;
            pages[3].BringToFront();
        }

        private void oper1_lev_Click(object sender, EventArgs e)
        {
            Operation = 3;
            this.Width = 378;
            this.Height = 241 + 31;
            addLevels(1);
            comboBox_levels.SelectedIndex = 0;
            pages[4].BringToFront();
        }

        private void oper2_lev_Click(object sender, EventArgs e)
        {
            Operation = 2;
            this.Width = 378;
            this.Height = 241 + 31;
            addLevels(1);
            comboBox_levels.SelectedIndex = 0;
            pages[4].BringToFront();
        }

        private void comboBox_levels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void start_levels_Click(object sender, EventArgs e)
        {
            if (Operation == 1 || Operation == 2)
            {
                Question = sum_level[comboBox_levels.SelectedIndex];
                //583; 363
                setQuestion();
            }
            else
            {
                Question = oper1_level[comboBox_levels.SelectedIndex];
                setQuestion();

            }
            this.Width = 583;
            this.Height = 363 + 31;
            pages[6].BringToFront();
        }

        private void comboBox_levels_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void level_account_Click(object sender, EventArgs e)
        {

        }

        class Level
        {
            public int lev;
            public int mix;
            public int min;
            public int score;
            public Level(int mix,int min,int coin,int levle)
            {
                this.mix = mix;
                this.min = min;
                this.score = coin;
                lev = levle;
            }
        }
        int comp_ques = 0;
        private void text_answer_level_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Ans();
            }
        }

        void Ans()
        {
            if (!string.IsNullOrEmpty(text_answer_level.Text))
            {
                if (text_answer_level.Text == Convert.ToString(resault))
                {
                    setQuestion();
                    answr_pic_level.Image = true_image;
                    answr_pic_level.SizeMode = PictureBoxSizeMode.StretchImage;
                    text_answer_level.Text = "";
                    act();
                }
                else
                {
                    setQuestion();
                    answr_pic_level.Image = false_image;
                    answr_pic_level.SizeMode = PictureBoxSizeMode.StretchImage;
                    text_answer_level.Text = "";
                    kill();
                }
            }
        }

        int coun = 3;
        void kill()
        {
            hearts[coun-- - 1].Image = null;
            if (coun == 0)
            {
                this.Width = 378;
                this.Height = 241 + 31;
                comboBox_levels.SelectedIndex = 0;
                pages[4].BringToFront();
                answr_pic_level.Image = null;
                change_hearts();
                ant = 1;
                From_level.Text = "1 / 10";
            }
        }

        void change_hearts()
        {
            coun = 3;
            hearts[0].Image = Mathematical.Properties.Resources.heart;
            hearts[1].Image = Mathematical.Properties.Resources.heart;
            hearts[2].Image = Mathematical.Properties.Resources.heart;
            hearts[0].SizeMode = PictureBoxSizeMode.StretchImage;
            hearts[1].SizeMode = PictureBoxSizeMode.StretchImage;
            hearts[2].SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void answer_level_Click(object sender, EventArgs e)
        {
            Ans();
        }
        int resault = 0;
        void setQuestion()
        {
            if(Operation == 1)
            {
                Random rd = new Random();
                int one = rd.Next(Question.min,Question.mix);
                int tow = rd.Next(Question.min, Question.mix);
                resault = one + tow;
                Question_level.Text = one + " + " + tow;
            }
            else if (Operation == 2)
            {
                Random rd = new Random();
                int one = rd.Next(Question.min, Question.mix);
                int tow = rd.Next(Question.min, Question.mix);
                resault = one - tow;
                Question_level.Text = one + " - " + tow;
            }
            else if (Operation == 3)
            {
                Random rd = new Random();
                int one = rd.Next(Question.min, Question.mix);
                int tow = rd.Next(Question.min, Question.mix);
                resault = one * tow;
                Question_level.Text = one + " X " + tow;
            }
        }

        int ant = 1;
        void act()
        {
            From_level.Text = (ant++ + 1) + " / 10";
            if (ant == 11)
            {
                this.Width = 378;
                this.Height = 241 + 31;
                pages[4].BringToFront();
                comboBox_levels.SelectedIndex = 0;
                answr_pic_level.Image = null;
                ant = 1;
                From_level.Text = "1 / 10";
                change_coin();
                change_hearts();
            }
        }

        
        private void exit_level_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are You Want Exit","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                this.Width = 378;
                this.Height = 241 + 31;
                pages[4].BringToFront();
                comboBox_levels.SelectedIndex = 0;
                answr_pic_level.Image = null;
                change_hearts();
                ant = 1;
                From_level.Text = "1 / 10";
            }
        }

        private void From_level_Click(object sender, EventArgs e)
        {

        }

        void change_coin()
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=Data.db3"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    conn.Open();
                    cmd.Parameters.Clear();
                    MemoryStream ms = new MemoryStream();
                    picture_account.Image.Save(ms, picture_account.Image.RawFormat);
                    byte[] image = ms.GetBuffer();
                    ms.Close();
                    cmd.Parameters.AddWithValue("@level", player.level + Question.score);
                    cmd.CommandText = "update users set level=@level where id='" + player.id + "'";
                    player.level+=Question.score;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private void back_levels_Click(object sender, EventArgs e)
        {
            this.Width = 508;
            this.Height = 277 + 31;
            pages[5].BringToFront();
        }

        private void Menu_account_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want Delete This Account", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection("data source=Data.db3"))
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            conn.Open();
                            cmd.CommandText = "delete from users where id='" + player.id.ToString() + "'";
                            cmd.ExecuteNonQuery();
                            users.Remove(player);
                            picture_account.Image = null;
                            conn.Close();
                            player = null;
                            this.Width = 371;
                            this.Height = 228 + 31;
                            pages[0].BringToFront();
                            name_login.Text = "";
                            pass_login.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
