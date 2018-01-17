using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSetting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = ExampleSetting.Properties.Settings.Default.height;
            this.Width = ExampleSetting.Properties.Settings.Default.width;
            this.Text = ExampleSetting.Properties.Settings.Default.Title;
            Location = new Point(ExampleSetting.Properties.Settings.Default.fx, ExampleSetting.Properties.Settings.Default.fy);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExampleSetting.Properties.Settings.Default.Title = textBox1.Text;
            ExampleSetting.Properties.Settings.Default.Save();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExampleSetting.Properties.Settings.Default.fx = Location.X;
            ExampleSetting.Properties.Settings.Default.fy = Location.Y;
            ExampleSetting.Properties.Settings.Default.Save();
        }
    }
}
