namespace Proto
{
    partial class Main
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
            this.datas = new System.Windows.Forms.DataGridView();
            this.name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.grade = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ins = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.asd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // datas
            // 
            this.datas.AllowUserToAddRows = false;
            this.datas.AllowUserToDeleteRows = false;
            this.datas.AllowUserToResizeColumns = false;
            this.datas.AllowUserToResizeRows = false;
            this.datas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asd,
            this.id,
            this.asda});
            this.datas.Dock = System.Windows.Forms.DockStyle.Right;
            this.datas.EnableHeadersVisualStyles = false;
            this.datas.Location = new System.Drawing.Point(511, 0);
            this.datas.MultiSelect = false;
            this.datas.Name = "datas";
            this.datas.ReadOnly = true;
            this.datas.RowHeadersVisible = false;
            this.datas.ShowCellErrors = false;
            this.datas.ShowCellToolTips = false;
            this.datas.ShowEditingIcon = false;
            this.datas.ShowRowErrors = false;
            this.datas.Size = new System.Drawing.Size(433, 541);
            this.datas.TabIndex = 0;
            this.datas.TabStop = false;
            this.datas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datas_CellClick);
            // 
            // name
            // 
            this.name.BorderColorFocused = System.Drawing.Color.Blue;
            this.name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.name.BorderThickness = 3;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name.isPassword = false;
            this.name.Location = new System.Drawing.Point(105, 73);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(230, 34);
            this.name.TabIndex = 1;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // grade
            // 
            this.grade.BorderColorFocused = System.Drawing.Color.Blue;
            this.grade.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grade.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.grade.BorderThickness = 3;
            this.grade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.grade.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.grade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grade.isPassword = false;
            this.grade.Location = new System.Drawing.Point(105, 150);
            this.grade.Margin = new System.Windows.Forms.Padding(4);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(230, 34);
            this.grade.TabIndex = 2;
            this.grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grade :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Picture :";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Select Image";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(105, 480);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(230, 38);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Text = "Select Image";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 541);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(36, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 41);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(398, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ins
            // 
            this.ins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ins.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ins.Location = new System.Drawing.Point(356, 73);
            this.ins.Name = "ins";
            this.ins.Size = new System.Drawing.Size(149, 34);
            this.ins.TabIndex = 10;
            this.ins.Text = "Insert";
            this.ins.UseVisualStyleBackColor = false;
            this.ins.Click += new System.EventHandler(this.ins_Click);
            // 
            // upd
            // 
            this.upd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.upd.Location = new System.Drawing.Point(356, 150);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(149, 34);
            this.upd.TabIndex = 11;
            this.upd.Text = "Update";
            this.upd.UseVisualStyleBackColor = false;
            this.upd.Visible = false;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.Red;
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Font = new System.Drawing.Font("Tahoma", 12F);
            this.del.Location = new System.Drawing.Point(356, 233);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(149, 34);
            this.del.TabIndex = 12;
            this.del.Text = "Remove";
            this.del.UseVisualStyleBackColor = false;
            this.del.Visible = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picture.Image = global::Proto.Properties.Resources.guest2;
            this.picture.Location = new System.Drawing.Point(105, 233);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(230, 220);
            this.picture.TabIndex = 5;
            this.picture.TabStop = false;
            // 
            // asd
            // 
            this.asd.HeaderText = "Name";
            this.asd.Name = "asd";
            this.asd.ReadOnly = true;
            this.asd.Width = 210;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // asda
            // 
            this.asda.HeaderText = "Grade";
            this.asda.Name = "asda";
            this.asda.ReadOnly = true;
            this.asda.Width = 210;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 541);
            this.Controls.Add(this.del);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.ins);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.name);
            this.Controls.Add(this.datas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Click += new System.EventHandler(this.Main_Click);
            ((System.ComponentModel.ISupportInitialize)(this.datas)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMetroTextbox name;
        private Bunifu.Framework.UI.BunifuMetroTextbox grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ins;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.DataGridView datas;
        private System.Windows.Forms.DataGridViewTextBoxColumn asd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn asda;
    }
}