namespace DoAnTuDienAV
{
    partial class frmQuanLyTu
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
            this.btXoaTrang = new System.Windows.Forms.Button();
            this.btLam = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDich = new System.Windows.Forms.TextBox();
            this.txtShortVN = new System.Windows.Forms.TextBox();
            this.txtEnglish1 = new System.Windows.Forms.TextBox();
            this.txtID1 = new System.Windows.Forms.TextBox();
            this.txtShorVN = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridItemData = new System.Windows.Forms.DataGridView();
            this.lbVerbs = new System.Windows.Forms.Label();
            this.PicVerbs = new System.Windows.Forms.PictureBox();
            this.painRollBar = new System.Windows.Forms.Panel();
            this.PicBack = new System.Windows.Forms.PictureBox();
            this.PicTurnOff = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicVerbs)).BeginInit();
            this.painRollBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTurnOff)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.painRollBar);
            this.groupBox1.Controls.Add(this.PicVerbs);
            this.groupBox1.Controls.Add(this.lbVerbs);
            this.groupBox1.Controls.Add(this.btXoaTrang);
            this.groupBox1.Controls.Add(this.btLam);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDich);
            this.groupBox1.Controls.Add(this.txtShortVN);
            this.groupBox1.Controls.Add(this.txtEnglish1);
            this.groupBox1.Controls.Add(this.txtID1);
            this.groupBox1.Controls.Add(this.txtShorVN);
            this.groupBox1.Controls.Add(this.txtEnglish);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Từ Mới";
            // 
            // btXoaTrang
            // 
            this.btXoaTrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btXoaTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaTrang.ForeColor = System.Drawing.Color.White;
            this.btXoaTrang.Location = new System.Drawing.Point(73, 21);
            this.btXoaTrang.Name = "btXoaTrang";
            this.btXoaTrang.Size = new System.Drawing.Size(89, 30);
            this.btXoaTrang.TabIndex = 15;
            this.btXoaTrang.Text = "Nhập lại";
            this.btXoaTrang.UseVisualStyleBackColor = false;
            this.btXoaTrang.Click += new System.EventHandler(this.btXoaTrang_Click);
            // 
            // btLam
            // 
            this.btLam.BackColor = System.Drawing.Color.Gray;
            this.btLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLam.ForeColor = System.Drawing.Color.White;
            this.btLam.Location = new System.Drawing.Point(681, 148);
            this.btLam.Name = "btLam";
            this.btLam.Size = new System.Drawing.Size(100, 73);
            this.btLam.TabIndex = 12;
            this.btLam.Text = "Làm Mới";
            this.btLam.UseVisualStyleBackColor = false;
            this.btLam.Click += new System.EventHandler(this.btLam_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.Location = new System.Drawing.Point(565, 148);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 73);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Red;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(681, 56);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 73);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Green;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Location = new System.Drawing.Point(565, 56);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 73);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(358, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dịch Chi Tiết Nghĩa";
            // 
            // txtDich
            // 
            this.txtDich.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDich.Location = new System.Drawing.Point(328, 57);
            this.txtDich.Multiline = true;
            this.txtDich.Name = "txtDich";
            this.txtDich.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDich.Size = new System.Drawing.Size(217, 164);
            this.txtDich.TabIndex = 7;
            // 
            // txtShortVN
            // 
            this.txtShortVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortVN.Location = new System.Drawing.Point(121, 129);
            this.txtShortVN.Name = "txtShortVN";
            this.txtShortVN.Size = new System.Drawing.Size(168, 22);
            this.txtShortVN.TabIndex = 6;
            // 
            // txtEnglish1
            // 
            this.txtEnglish1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglish1.Location = new System.Drawing.Point(121, 95);
            this.txtEnglish1.Name = "txtEnglish1";
            this.txtEnglish1.Size = new System.Drawing.Size(168, 22);
            this.txtEnglish1.TabIndex = 5;
            // 
            // txtID1
            // 
            this.txtID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID1.Location = new System.Drawing.Point(121, 57);
            this.txtID1.Name = "txtID1";
            this.txtID1.Size = new System.Drawing.Size(168, 22);
            this.txtID1.TabIndex = 4;
            // 
            // txtShorVN
            // 
            this.txtShorVN.AutoSize = true;
            this.txtShorVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShorVN.ForeColor = System.Drawing.Color.White;
            this.txtShorVN.Location = new System.Drawing.Point(54, 129);
            this.txtShorVN.Name = "txtShorVN";
            this.txtShorVN.Size = new System.Drawing.Size(45, 20);
            this.txtShorVN.TabIndex = 3;
            this.txtShorVN.Text = "Dịch";
            this.txtShorVN.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEnglish
            // 
            this.txtEnglish.AutoSize = true;
            this.txtEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglish.ForeColor = System.Drawing.Color.White;
            this.txtEnglish.Location = new System.Drawing.Point(14, 95);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(90, 20);
            this.txtEnglish.TabIndex = 2;
            this.txtEnglish.Text = "Tiếng Anh";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(69, 57);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(28, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridItemData);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Từ Đã Có";
            // 
            // gridItemData
            // 
            this.gridItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItemData.Location = new System.Drawing.Point(6, 19);
            this.gridItemData.Name = "gridItemData";
            this.gridItemData.Size = new System.Drawing.Size(782, 234);
            this.gridItemData.TabIndex = 0;
            this.gridItemData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItemData_RowEnter);
            // 
            // lbVerbs
            // 
            this.lbVerbs.AutoSize = true;
            this.lbVerbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVerbs.ForeColor = System.Drawing.Color.White;
            this.lbVerbs.Location = new System.Drawing.Point(20, 162);
            this.lbVerbs.Name = "lbVerbs";
            this.lbVerbs.Size = new System.Drawing.Size(83, 20);
            this.lbVerbs.TabIndex = 14;
            this.lbVerbs.Text = "Hình Ảnh";
            // 
            // PicVerbs
            // 
            this.PicVerbs.BackColor = System.Drawing.Color.White;
            this.PicVerbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicVerbs.Location = new System.Drawing.Point(121, 162);
            this.PicVerbs.Name = "PicVerbs";
            this.PicVerbs.Size = new System.Drawing.Size(168, 59);
            this.PicVerbs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicVerbs.TabIndex = 15;
            this.PicVerbs.TabStop = false;
            // 
            // painRollBar
            // 
            this.painRollBar.BackColor = System.Drawing.Color.Transparent;
            this.painRollBar.Controls.Add(this.PicBack);
            this.painRollBar.Controls.Add(this.PicTurnOff);
            this.painRollBar.Location = new System.Drawing.Point(711, 10);
            this.painRollBar.Name = "painRollBar";
            this.painRollBar.Size = new System.Drawing.Size(84, 23);
            this.painRollBar.TabIndex = 16;
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
            // frmQuanLyTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương Trình Quản Lý ThêmTừ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItemData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicVerbs)).EndInit();
            this.painRollBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTurnOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridItemData;
        private System.Windows.Forms.Label txtShorVN;
        private System.Windows.Forms.Label txtEnglish;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Button btLam;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDich;
        private System.Windows.Forms.TextBox txtShortVN;
        private System.Windows.Forms.TextBox txtEnglish1;
        private System.Windows.Forms.TextBox txtID1;
        private System.Windows.Forms.Button btXoaTrang;
        private System.Windows.Forms.PictureBox PicVerbs;
        private System.Windows.Forms.Label lbVerbs;
        private System.Windows.Forms.Panel painRollBar;
        private System.Windows.Forms.PictureBox PicBack;
        private System.Windows.Forms.PictureBox PicTurnOff;
    }
}