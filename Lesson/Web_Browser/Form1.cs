using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                web.Navigate(url.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            web.Refresh();
        }

        private void next_Click(object sender, EventArgs e)
        {
            web.GoForward();
        }

        private void back_Click(object sender, EventArgs e)
        {
            web.GoBack();
        }

        private void go_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(url.Text))
            {
                web.Navigate(url.Text);
            }
        }
    }
}
