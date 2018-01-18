namespace Encrypt_Password
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
            this.passl = new System.Windows.Forms.Label();
            this.resl = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passl
            // 
            this.passl.AutoSize = true;
            this.passl.Font = new System.Drawing.Font("Tahoma", 12F);
            this.passl.Location = new System.Drawing.Point(12, 13);
            this.passl.Name = "passl";
            this.passl.Size = new System.Drawing.Size(87, 19);
            this.passl.TabIndex = 0;
            this.passl.Text = "Password :";
            // 
            // resl
            // 
            this.resl.AutoSize = true;
            this.resl.Font = new System.Drawing.Font("Tahoma", 12F);
            this.resl.Location = new System.Drawing.Point(36, 59);
            this.resl.Name = "resl";
            this.resl.Size = new System.Drawing.Size(63, 19);
            this.resl.TabIndex = 1;
            this.resl.Text = "Result :";
            this.resl.Click += new System.EventHandler(this.label2_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(105, 12);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(498, 20);
            this.pass.TabIndex = 2;
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(105, 57);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(498, 20);
            this.res.TabIndex = 3;
            // 
            // Encrypt
            // 
            this.Encrypt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Encrypt.Location = new System.Drawing.Point(528, 83);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(75, 32);
            this.Encrypt.TabIndex = 4;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 120);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.res);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.resl);
            this.Controls.Add(this.passl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passl;
        private System.Windows.Forms.Label resl;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Button Encrypt;
    }
}

