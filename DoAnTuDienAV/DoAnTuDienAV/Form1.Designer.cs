namespace DoAnTuDienAV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btTraTu = new System.Windows.Forms.Button();
            this.btQL = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.btRegister = new System.Windows.Forms.Button();
            this.pnEventHome = new System.Windows.Forms.Panel();
            this.lbRegisterLogan = new System.Windows.Forms.Label();
            this.pnHomeBackgrond = new System.Windows.Forms.Panel();
            this.PicBackground = new System.Windows.Forms.PictureBox();
            this.Pic02 = new System.Windows.Forms.PictureBox();
            this.Pic01 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.pnEventHome.SuspendLayout();
            this.pnHomeBackgrond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic01)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Nhập";
            this.groupBox1.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Lime;
            this.btnReset.Location = new System.Drawing.Point(264, 121);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 32);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Nhập Lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(142, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(204, 81);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(171, 22);
            this.txtPass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(204, 33);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(171, 22);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // btTraTu
            // 
            this.btTraTu.BackColor = System.Drawing.Color.Lime;
            this.btTraTu.Location = new System.Drawing.Point(45, 62);
            this.btTraTu.Name = "btTraTu";
            this.btTraTu.Size = new System.Drawing.Size(96, 43);
            this.btTraTu.TabIndex = 1;
            this.btTraTu.Text = "Tra Từ";
            this.btTraTu.UseVisualStyleBackColor = false;
            this.btTraTu.Click += new System.EventHandler(this.btTraTu_Click);
            // 
            // btQL
            // 
            this.btQL.BackColor = System.Drawing.Color.Lime;
            this.btQL.Location = new System.Drawing.Point(204, 62);
            this.btQL.Name = "btQL";
            this.btQL.Size = new System.Drawing.Size(96, 43);
            this.btQL.TabIndex = 2;
            this.btQL.Text = "Đăng Nhập   ";
            this.btQL.UseVisualStyleBackColor = false;
            this.btQL.Click += new System.EventHandler(this.btQL_Click);
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.Lime;
            this.btRegister.Location = new System.Drawing.Point(354, 62);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(96, 43);
            this.btRegister.TabIndex = 3;
            this.btRegister.Text = "Đăng Ký";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // pnEventHome
            // 
            this.pnEventHome.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnEventHome.Controls.Add(this.Pic02);
            this.pnEventHome.Controls.Add(this.Pic01);
            this.pnEventHome.Controls.Add(this.lbRegisterLogan);
            this.pnEventHome.Controls.Add(this.btRegister);
            this.pnEventHome.Controls.Add(this.btTraTu);
            this.pnEventHome.Controls.Add(this.btQL);
            this.pnEventHome.Location = new System.Drawing.Point(6, 4);
            this.pnEventHome.Name = "pnEventHome";
            this.pnEventHome.Size = new System.Drawing.Size(483, 139);
            this.pnEventHome.TabIndex = 5;
            // 
            // lbRegisterLogan
            // 
            this.lbRegisterLogan.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbRegisterLogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegisterLogan.ForeColor = System.Drawing.Color.White;
            this.lbRegisterLogan.Location = new System.Drawing.Point(99, 8);
            this.lbRegisterLogan.Name = "lbRegisterLogan";
            this.lbRegisterLogan.Size = new System.Drawing.Size(304, 41);
            this.lbRegisterLogan.TabIndex = 11;
            this.lbRegisterLogan.Text = "TỪ ĐIỂN ANH-VIỆT";
            this.lbRegisterLogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnHomeBackgrond
            // 
            this.pnHomeBackgrond.BackColor = System.Drawing.Color.Transparent;
            this.pnHomeBackgrond.Controls.Add(this.groupBox1);
            this.pnHomeBackgrond.Controls.Add(this.PicBackground);
            this.pnHomeBackgrond.Location = new System.Drawing.Point(3, 135);
            this.pnHomeBackgrond.Name = "pnHomeBackgrond";
            this.pnHomeBackgrond.Size = new System.Drawing.Size(489, 181);
            this.pnHomeBackgrond.TabIndex = 5;
            // 
            // PicBackground
            // 
            this.PicBackground.Image = global::DoAnTuDienAV.Properties.Resources.DictionaryHomeback;
            this.PicBackground.Location = new System.Drawing.Point(3, 3);
            this.PicBackground.Name = "PicBackground";
            this.PicBackground.Size = new System.Drawing.Size(483, 175);
            this.PicBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBackground.TabIndex = 0;
            this.PicBackground.TabStop = false;
            // 
            // Pic02
            // 
            this.Pic02.BackColor = System.Drawing.Color.Transparent;
            this.Pic02.Image = global::DoAnTuDienAV.Properties.Resources.dicPic02;
            this.Pic02.Location = new System.Drawing.Point(409, 8);
            this.Pic02.Name = "Pic02";
            this.Pic02.Size = new System.Drawing.Size(51, 38);
            this.Pic02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic02.TabIndex = 13;
            this.Pic02.TabStop = false;
            // 
            // Pic01
            // 
            this.Pic01.Image = global::DoAnTuDienAV.Properties.Resources.dicPic02;
            this.Pic01.Location = new System.Drawing.Point(22, 8);
            this.Pic01.Name = "Pic01";
            this.Pic01.Size = new System.Drawing.Size(51, 38);
            this.Pic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic01.TabIndex = 12;
            this.Pic01.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 316);
            this.Controls.Add(this.pnHomeBackgrond);
            this.Controls.Add(this.pnEventHome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnEventHome.ResumeLayout(false);
            this.pnHomeBackgrond.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btTraTu;
        private System.Windows.Forms.Button btQL;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Panel pnEventHome;
        private System.Windows.Forms.Panel pnHomeBackgrond;
        private System.Windows.Forms.PictureBox PicBackground;
        private System.Windows.Forms.Label lbRegisterLogan;
        private System.Windows.Forms.PictureBox Pic01;
        private System.Windows.Forms.PictureBox Pic02;
        private System.Windows.Forms.Button btnReset;
    }
}

