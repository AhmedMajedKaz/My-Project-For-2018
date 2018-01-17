namespace Email
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.send = new System.Windows.Forms.Button();
            this.smtp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ssl = new System.Windows.Forms.CheckBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.htm = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(105, 13);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(286, 20);
            this.To.TabIndex = 1;
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(105, 104);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(543, 205);
            this.Message.TabIndex = 7;
            this.Message.TextChanged += new System.EventHandler(this.Message_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message:";
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(105, 56);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(286, 20);
            this.Subject.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subject:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.htm);
            this.groupBox1.Controls.Add(this.send);
            this.groupBox1.Controls.Add(this.smtp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ssl);
            this.groupBox1.Controls.Add(this.Pass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.User);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(105, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 252);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(214, 120);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 13;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // smtp
            // 
            this.smtp.Location = new System.Drawing.Point(214, 179);
            this.smtp.Name = "smtp";
            this.smtp.Size = new System.Drawing.Size(259, 20);
            this.smtp.TabIndex = 12;
            this.smtp.Text = "smtp.gmail.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "SMTP:";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(53, 179);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(72, 20);
            this.port.TabIndex = 10;
            this.port.Text = "587";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Port:";
            // 
            // ssl
            // 
            this.ssl.AutoSize = true;
            this.ssl.Location = new System.Drawing.Point(430, 21);
            this.ssl.Name = "ssl";
            this.ssl.Size = new System.Drawing.Size(43, 17);
            this.ssl.TabIndex = 8;
            this.ssl.Text = "SSL";
            this.ssl.UseVisualStyleBackColor = true;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(86, 67);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(241, 20);
            this.Pass.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(86, 19);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(241, 20);
            this.User.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "User Name:";
            // 
            // htm
            // 
            this.htm.AutoSize = true;
            this.htm.Location = new System.Drawing.Point(430, 67);
            this.htm.Name = "htm";
            this.htm.Size = new System.Drawing.Size(52, 17);
            this.htm.TabIndex = 14;
            this.htm.Text = "HTML";
            this.htm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.To);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "w";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox smtp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ssl;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.CheckBox htm;
    }
}

