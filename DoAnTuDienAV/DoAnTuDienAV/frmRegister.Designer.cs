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
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(70, 77);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(116, 20);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_userRegister
            // 
            this.txt_userRegister.Location = new System.Drawing.Point(220, 79);
            this.txt_userRegister.Name = "txt_userRegister";
            this.txt_userRegister.Size = new System.Drawing.Size(168, 20);
            this.txt_userRegister.TabIndex = 5;
            // 
            // txt_passRegister
            // 
            this.txt_passRegister.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_passRegister.Location = new System.Drawing.Point(220, 113);
            this.txt_passRegister.Name = "txt_passRegister";
            this.txt_passRegister.PasswordChar = '*';
            this.txt_passRegister.Size = new System.Drawing.Size(168, 20);
            this.txt_passRegister.TabIndex = 6;
            // 
            // txt_rppassRegister
            // 
            this.txt_rppassRegister.Location = new System.Drawing.Point(220, 150);
            this.txt_rppassRegister.Name = "txt_rppassRegister";
            this.txt_rppassRegister.PasswordChar = '*';
            this.txt_rppassRegister.Size = new System.Drawing.Size(168, 20);
            this.txt_rppassRegister.TabIndex = 7;
            // 
            // bt_Register
            // 
            this.bt_Register.Location = new System.Drawing.Point(188, 198);
            this.bt_Register.Name = "bt_Register";
            this.bt_Register.Size = new System.Drawing.Size(75, 23);
            this.bt_Register.TabIndex = 8;
            this.bt_Register.Text = "Đăng ký";
            this.bt_Register.UseVisualStyleBackColor = true;
            this.bt_Register.Click += new System.EventHandler(this.bt_Register_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 316);
            this.Controls.Add(this.bt_Register);
            this.Controls.Add(this.txt_rppassRegister);
            this.Controls.Add(this.txt_passRegister);
            this.Controls.Add(this.txt_userRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_userRegister;
        private System.Windows.Forms.TextBox txt_passRegister;
        private System.Windows.Forms.TextBox txt_rppassRegister;
        private System.Windows.Forms.Button bt_Register;
    }
}