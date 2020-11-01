namespace W_DICTIONARY
{
    partial class frmSearchWord_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchWord_User));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Getout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AddLikeWord = new System.Windows.Forms.Button();
            this.bt_frm_like = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(268, 529);
            this.groupBox1.Text = "Danh Sách Từ";
            // 
            // LboxItem
            // 
            this.LboxItem.DisplayMember = "English";
            this.LboxItem.Margin = new System.Windows.Forms.Padding(5);
            this.LboxItem.Size = new System.Drawing.Size(240, 644);
            this.LboxItem.ValueMember = "idword";
            this.LboxItem.SelectedIndexChanged += new System.EventHandler(this.LboxItem_SelectedIndexChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(884, 556);
            this.groupBox2.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox2.Controls.SetChildIndex(this.txtID, 0);
            this.groupBox2.Controls.SetChildIndex(this.txtEnglish, 0);
            this.groupBox2.Controls.SetChildIndex(this.txtVNShort, 0);
            this.groupBox2.Controls.SetChildIndex(this.label1, 0);
            this.groupBox2.Controls.SetChildIndex(this.label2, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnSearch, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnListen, 0);
            this.groupBox2.Controls.SetChildIndex(this.txtVNLong, 0);
            this.groupBox2.Controls.SetChildIndex(this.label3, 0);
            // 
            // txtVNShort
            // 
            this.txtVNShort.Margin = new System.Windows.Forms.Padding(5);
            this.txtVNShort.Size = new System.Drawing.Size(279, 51);
            this.txtVNShort.Text = "23123";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Margin = new System.Windows.Forms.Padding(5);
            this.txtEnglish.Size = new System.Drawing.Size(279, 51);
            this.txtEnglish.TabIndex = 0;
            this.txtEnglish.Text = "khoi";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(141, 191);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Size = new System.Drawing.Size(109, 49);
            this.btnSearch.TabIndex = 1;
            // 
            // txtVNLong
            // 
            this.txtVNLong.Margin = new System.Windows.Forms.Padding(5);
            this.txtVNLong.Size = new System.Drawing.Size(575, 243);
            this.txtVNLong.TabIndex = 4;
            this.txtVNLong.Text = "123";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(300, 191);
            this.btnListen.Margin = new System.Windows.Forms.Padding(5);
            this.btnListen.Size = new System.Drawing.Size(108, 49);
            this.btnListen.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            this.txtID.Size = new System.Drawing.Size(155, 26);
            this.txtID.Text = "17";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Getout);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(596, 303);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(267, 246);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tài khoản";
            // 
            // btn_Getout
            // 
            this.btn_Getout.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Getout.Location = new System.Drawing.Point(45, 186);
            this.btn_Getout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Getout.Name = "btn_Getout";
            this.btn_Getout.Size = new System.Drawing.Size(181, 40);
            this.btn_Getout.TabIndex = 0;
            this.btn_Getout.Text = "Đăng Xuất";
            this.btn_Getout.UseVisualStyleBackColor = false;
            this.btn_Getout.Click += new System.EventHandler(this.btn_Getout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::W_DICTIONARY.Properties.Resources.hoa2_min1;
            this.pictureBox1.Location = new System.Drawing.Point(45, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 567);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thêm vào danh sách yêu thích";
            // 
            // btn_AddLikeWord
            // 
            this.btn_AddLikeWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_AddLikeWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddLikeWord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddLikeWord.Location = new System.Drawing.Point(53, 608);
            this.btn_AddLikeWord.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddLikeWord.Name = "btn_AddLikeWord";
            this.btn_AddLikeWord.Size = new System.Drawing.Size(178, 55);
            this.btn_AddLikeWord.TabIndex = 0;
            this.btn_AddLikeWord.Text = "Yêu Thích";
            this.btn_AddLikeWord.UseVisualStyleBackColor = false;
            this.btn_AddLikeWord.Click += new System.EventHandler(this.btn_AddLikeWord_Click);
            // 
            // bt_frm_like
            // 
            this.bt_frm_like.BackColor = System.Drawing.Color.Yellow;
            this.bt_frm_like.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_frm_like.Location = new System.Drawing.Point(336, 571);
            this.bt_frm_like.Margin = new System.Windows.Forms.Padding(4);
            this.bt_frm_like.Name = "bt_frm_like";
            this.bt_frm_like.Size = new System.Drawing.Size(296, 96);
            this.bt_frm_like.TabIndex = 1;
            this.bt_frm_like.Text = "DANH SÁCH TỪ YÊU THÍCH";
            this.bt_frm_like.UseVisualStyleBackColor = false;
            this.bt_frm_like.Click += new System.EventHandler(this.bt_frm_like_Click);
            // 
            // frmSearchWord_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 678);
            this.Controls.Add(this.bt_frm_like);
            this.Controls.Add(this.btn_AddLikeWord);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSearchWord_User";
            this.Load += new System.EventHandler(this.frmSearchWord_User_Load);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btn_AddLikeWord, 0);
            this.Controls.SetChildIndex(this.bt_frm_like, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Getout;
        
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_AddLikeWord;
        private System.Windows.Forms.Button bt_frm_like;
    }
}