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
            this.btXoaTrang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1165, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Từ Mới";
            // 
            // btLam
            // 
            this.btLam.Location = new System.Drawing.Point(934, 133);
            this.btLam.Name = "btLam";
            this.btLam.Size = new System.Drawing.Size(100, 73);
            this.btLam.TabIndex = 12;
            this.btLam.Text = "Làm Mới";
            this.btLam.UseVisualStyleBackColor = true;
            this.btLam.Click += new System.EventHandler(this.btLam_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(731, 133);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 73);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(934, 29);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 73);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(731, 26);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 73);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dịch chi tiết nghĩa";
            // 
            // txtDich
            // 
            this.txtDich.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDich.Location = new System.Drawing.Point(351, 53);
            this.txtDich.Multiline = true;
            this.txtDich.Name = "txtDich";
            this.txtDich.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDich.Size = new System.Drawing.Size(194, 127);
            this.txtDich.TabIndex = 7;
            // 
            // txtShortVN
            // 
            this.txtShortVN.Location = new System.Drawing.Point(135, 160);
            this.txtShortVN.Name = "txtShortVN";
            this.txtShortVN.Size = new System.Drawing.Size(168, 20);
            this.txtShortVN.TabIndex = 6;
            // 
            // txtEnglish1
            // 
            this.txtEnglish1.Location = new System.Drawing.Point(135, 108);
            this.txtEnglish1.Name = "txtEnglish1";
            this.txtEnglish1.Size = new System.Drawing.Size(168, 20);
            this.txtEnglish1.TabIndex = 5;
            // 
            // txtID1
            // 
            this.txtID1.Location = new System.Drawing.Point(135, 53);
            this.txtID1.Name = "txtID1";
            this.txtID1.Size = new System.Drawing.Size(168, 20);
            this.txtID1.TabIndex = 4;
            // 
            // txtShorVN
            // 
            this.txtShorVN.AutoSize = true;
            this.txtShorVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShorVN.Location = new System.Drawing.Point(42, 158);
            this.txtShorVN.Name = "txtShorVN";
            this.txtShorVN.Size = new System.Drawing.Size(41, 20);
            this.txtShorVN.TabIndex = 3;
            this.txtShorVN.Text = "Dịch";
            this.txtShorVN.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEnglish
            // 
            this.txtEnglish.AutoSize = true;
            this.txtEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglish.Location = new System.Drawing.Point(42, 106);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(61, 20);
            this.txtEnglish.TabIndex = 2;
            this.txtEnglish.Text = "English";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(42, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(26, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridItemData);
            this.groupBox2.Location = new System.Drawing.Point(13, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1164, 338);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách từ đã có";
            // 
            // gridItemData
            // 
            this.gridItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItemData.Location = new System.Drawing.Point(17, 35);
            this.gridItemData.Name = "gridItemData";
            this.gridItemData.Size = new System.Drawing.Size(1128, 282);
            this.gridItemData.TabIndex = 0;
            this.gridItemData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItemData_RowEnter);
            // 
            // btXoaTrang
            // 
            this.btXoaTrang.Location = new System.Drawing.Point(37, 20);
            this.btXoaTrang.Name = "btXoaTrang";
            this.btXoaTrang.Size = new System.Drawing.Size(88, 23);
            this.btXoaTrang.TabIndex = 13;
            this.btXoaTrang.Text = "Nhập lại";
            this.btXoaTrang.UseVisualStyleBackColor = true;
            this.btXoaTrang.Click += new System.EventHandler(this.btXoaTrang_Click);
            // 
            // frmQuanLyTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 646);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyTu";
            this.Text = "Chương Trình Quản Lý ThêmTừ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItemData)).EndInit();
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
    }
}