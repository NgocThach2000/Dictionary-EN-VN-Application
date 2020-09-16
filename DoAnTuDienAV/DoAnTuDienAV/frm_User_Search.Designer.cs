namespace DoAnTuDienAV
{
    partial class frm_User_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_User_Search));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.bt_frm_like = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Name_User = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Text = "Danh sách từ yêu thích";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.SetChildIndex(this.txtID, 0);
            this.groupBox2.Controls.SetChildIndex(this.label1, 0);
            this.groupBox2.Controls.SetChildIndex(this.label2, 0);
            this.groupBox2.Controls.SetChildIndex(this.txtVNDetail, 0);
            this.groupBox2.Controls.SetChildIndex(this.btTraTu, 0);
            this.groupBox2.Controls.SetChildIndex(this.txtEnglish2, 0);
            this.groupBox2.Controls.SetChildIndex(this.txtVN2, 0);
            this.groupBox2.Controls.SetChildIndex(this.button1, 0);
            this.groupBox2.Controls.SetChildIndex(this.groupBox3, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 97);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(10, 44);
            // 
            // txtVN2
            // 
            this.txtVN2.Location = new System.Drawing.Point(93, 102);
            this.txtVN2.Multiline = true;
            this.txtVN2.Size = new System.Drawing.Size(155, 40);
            this.txtVN2.Text = "bàn viết, bàn làm việc, bàn học sinh";
            // 
            // txtEnglish2
            // 
            this.txtEnglish2.Location = new System.Drawing.Point(96, 46);
            this.txtEnglish2.Multiline = true;
            this.txtEnglish2.Size = new System.Drawing.Size(155, 32);
            this.txtEnglish2.Text = "desk";
            // 
            // btTraTu
            // 
            this.btTraTu.Location = new System.Drawing.Point(270, 44);
            // 
            // txtVNDetail
            // 
            this.txtVNDetail.Location = new System.Drawing.Point(10, 237);
            this.txtVNDetail.Size = new System.Drawing.Size(462, 200);
            this.txtVNDetail.Text = resources.GetString("txtVNDetail.Text");
            this.txtVNDetail.TextChanged += new System.EventHandler(this.txtVNDetail_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 191);
            // 
            // lbItem
            // 
            this.lbItem.DisplayMember = "English";
            this.lbItem.Location = new System.Drawing.Point(6, 19);
            this.lbItem.ValueMember = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 102);
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.Text = "Nghe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thêm vào danh sách yêu thích";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(56, 472);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 27);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // bt_frm_like
            // 
            this.bt_frm_like.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_frm_like.Location = new System.Drawing.Point(244, 454);
            this.bt_frm_like.Name = "bt_frm_like";
            this.bt_frm_like.Size = new System.Drawing.Size(164, 78);
            this.bt_frm_like.TabIndex = 5;
            this.bt_frm_like.Text = "DANH SÁCH TỪ YÊU THÍCH";
            this.bt_frm_like.UseVisualStyleBackColor = true;
            this.bt_frm_like.Click += new System.EventHandler(this.bt_frm_like_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnTuDienAV.Properties.Resources.May_bay_1;
            this.pictureBox1.Location = new System.Drawing.Point(43, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.Name_User);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(351, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 212);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tài khoản";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Đăng xuất";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Name_User
            // 
            this.Name_User.BackColor = System.Drawing.SystemColors.Menu;
            this.Name_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name_User.Location = new System.Drawing.Point(89, 159);
            this.Name_User.Name = "Name_User";
            this.Name_User.Size = new System.Drawing.Size(100, 13);
            this.Name_User.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên tài khoản:";
            // 
            // frm_User_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 544);
            this.Controls.Add(this.bt_frm_like);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Name = "frm_User_Search";
            this.Text = "frm_User_Search";
            this.Load += new System.EventHandler(this.frm_User_Search_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btn_add, 0);
            this.Controls.SetChildIndex(this.bt_frm_like, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button bt_frm_like;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Name_User;
    }
}