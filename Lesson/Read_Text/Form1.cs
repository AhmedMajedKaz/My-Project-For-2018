using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read_Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using(OpenFileDialog open = new OpenFileDialog() {Filter = "Text Documents|*.txt",Multiselect = false,ValidateNames = true })
                {
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader sr = new StreamReader(open.FileName)) {
                            txt.Text = await sr.ReadToEndAsync();
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
