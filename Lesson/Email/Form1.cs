using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage(User.Text, To.Text, Subject.Text, Message.Text);
            msg.IsBodyHtml = htm.Checked;
            SmtpClient sc = new SmtpClient(smtp.Text, Convert.ToInt32(port.Text));
            sc.UseDefaultCredentials = false;
            NetworkCredential cre = new NetworkCredential(User.Text, Pass.Text);//your mail password
            sc.Credentials = cre;
            sc.EnableSsl = ssl.Checked;
            sc.Send(msg);
            MessageBox.Show("Mail Send.");
        }

        

        private void Message_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
