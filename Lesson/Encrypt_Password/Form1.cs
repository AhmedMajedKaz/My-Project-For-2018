using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Encrypt_Password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        static string Encrypts(String value) {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider()){
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pass.Text))
            {
                MessageBox.Show("Please enter your password", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            res.Text = Encrypts(pass.Text);
        }
    }
}
