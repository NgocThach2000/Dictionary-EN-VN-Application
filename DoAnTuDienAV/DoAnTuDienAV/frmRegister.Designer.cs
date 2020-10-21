namespace DoAnTuDienAV
{
    partial class frmRegister
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
            this.txtID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_userRegister = new System.Windows.Forms.TextBox();
            this.txt_passRegister = new System.Windows.Forms.TextBox();
            this.txt_rppassRegister = new System.Windows.Forms.TextBox();
            this.bt_Register = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRegisterLogan = new System.Windows.Forms.Label();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.painRollBar = new System.Windows.Forms.Panel();
            this.PicBack = new System.Windows.Forms.PictureBox();
            this.PicTurnOff = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.painRollBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTurnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(32, 77);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(116, 20);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_userRegister
            // 
            this.txt_userRegister.Location = new System.Drawing.Point(175, 77);
            this.txt_userRegister.Name = "txt_userRegister";
            this.txt_userRegister.Size = new System.Drawing.Size(168, 20);
            this.txt_userRegister.TabIndex = 1;
            // 
            // txt_passRegister
            // 
            this.txt_passRegister.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_passRegister.Location = new System.Drawing.Point(175, 126);
            this.txt_passRegister.Name = "txt_passRegister";
            this.txt_passRegister.PasswordChar = '*';
            this.txt_passRegister.Size = new System.Drawing.Size(168, 20);
            this.txt_passRegister.TabIndex = 2;
            this.txt_passRegister.UseSystemPasswordChar = true;
            // 
            // txt_rppassRegister
            // 
            this.txt_rppassRegister.Location = new System.Drawing.Point(175, 177);
            this.txt_rppassRegister.Name = "txt_rppassRegister";
            this.txt_rppassRegister.PasswordChar = '*';
            this.txt_rppassRegister.Size = new System.Drawing.Size(168, 20);
            this.txt_rppassRegister.TabIndex = 3;
            this.txt_rppassRegister.UseSystemPasswordChar = true;
            // 
            // bt_Register
            // 
            this.bt_Register.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Register.Location = new System.Drawing.Point(103, 219);
            this.bt_Register.Name = "bt_Register";
            this.bt_Register.Size = new System.Drawing.Size(84, 35);
            this.bt_Register.TabIndex = 4;
            this.bt_Register.Text = "Đăng Ký";
            this.bt_Register.UseVisualStyleBackColor = false;
            this.bt_Register.Click += new System.EventHandler(this.bt_Register_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbRegisterLogan);
            this.panel1.Controls.Add(this.bt_Reset);
            this.panel1.Controls.Add(this.bt_Register);
            this.panel1.Controls.Add(this.txt_userRegister);
            this.panel1.Controls.Add(this.txt_passRegister);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txt_rppassRegister);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(65, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 267);
            this.panel1.TabIndex = 9;
            // 
            // lbRegisterLogan
            // 
            this.lbRegisterLogan.BackColor = System.Drawing.Color.Transparent;
            this.lbRegisterLogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegisterLogan.ForeColor = System.Drawing.Color.Black;
            this.lbRegisterLogan.Location = new System.Drawing.Point(60, 0);
            this.lbRegisterLogan.Name = "lbRegisterLogan";
            this.lbRegisterLogan.Size = new System.Drawing.Size(272, 41);
            this.lbRegisterLogan.TabIndex = 10;
            this.lbRegisterLogan.Text = "ĐĂNG KÝ TÀI KHOẢN";
            this.lbRegisterLogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Reset
            // 
            this.bt_Reset.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_Reset.Location = new System.Drawing.Point(220, 219);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(84, 35);
            this.bt_Reset.TabIndex = 5;
            this.bt_Reset.Text = "Nhập Lại";
            this.bt_Reset.UseVisualStyleBackColor = false;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // painRollBar
            // 
            this.painRollBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.painRollBar.Controls.Add(this.PicBack);
            this.painRollBar.Controls.Add(this.PicTurnOff);
            this.painRollBar.Location = new System.Drawing.Point(418, 1);
            this.painRollBar.Name = "painRollBar";
            this.painRollBar.Size = new System.Drawing.Size(84, 23);
            this.painRollBar.TabIndex = 11;
            // 
            // PicBack
            // 
            this.PicBack.BackColor = System.Drawing.Color.White;
            this.PicBack.Image = global::DoAnTuDienAV.Properties.Resources.backimg;
            this.PicBack.Location = new System.Drawing.Point(3, 0);
            this.PicBack.Name = "PicBack";
            this.PicBack.Size = new System.Drawing.Size(35, 20);
            this.PicBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBack.TabIndex = 11;
            this.PicBack.TabStop = false;
            // 
            // PicTurnOff
            // 
            this.PicTurnOff.BackColor = System.Drawing.Color.DodgerBlue;
            this.PicTurnOff.Image = global::DoAnTuDienAV.Properties.Resources.LogoutImage;
            this.PicTurnOff.Location = new System.Drawing.Point(44, 0);
            this.PicTurnOff.Name = "PicTurnOff";
            this.PicTurnOff.Size = new System.Drawing.Size(36, 20);
            this.PicTurnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTurnOff.TabIndex = 10;
            this.PicTurnOff.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DoAnTuDienAV.Properties.Resources.formimage;
            this.pictureBox2.Location = new System.Drawing.Point(338, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DoAnTuDienAV.Properties.Resources.formimage;
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(504, 316);
            this.Controls.Add(this.painRollBar);
            this.Controls.Add(this.panel1);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painRollBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTurnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_userRegister;
        private System.Windows.Forms.TextBox txt_passRegister;
        private System.Windows.Forms.TextBox txt_rppassRegister;
        private System.Windows.Forms.Button bt_Register;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Label lbRegisterLogan;
        private System.Windows.Forms.PictureBox PicTurnOff;
        private System.Windows.Forms.Panel painRollBar;
        private System.Windows.Forms.PictureBox PicBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}