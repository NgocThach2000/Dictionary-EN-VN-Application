﻿namespace W_DICTIONARY
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
            this.groupBox1.Size = new System.Drawing.Size(201, 430);
            // 
            // LboxItem
            // 
            this.LboxItem.DisplayMember = "English";
            this.LboxItem.ValueMember = "idword";
            this.LboxItem.SelectedIndexChanged += new System.EventHandler(this.LboxItem_SelectedIndexChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Size = new System.Drawing.Size(663, 452);
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
            this.txtVNShort.Text = "23123";
            // 
            // txtEnglish
            // 
            this.txtEnglish.TabIndex = 0;
            this.txtEnglish.Text = "khoi";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(82, 156);
            this.btnSearch.Size = new System.Drawing.Size(82, 40);
            this.btnSearch.TabIndex = 1;
            // 
            // txtVNLong
            // 
            this.txtVNLong.TabIndex = 4;
            this.txtVNLong.Text = "123";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(225, 155);
            this.btnListen.Size = new System.Drawing.Size(81, 40);
            this.btnListen.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Text = "17";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Getout);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(447, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 200);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tài khoản";
            // 
            // btn_Getout
            // 
            this.btn_Getout.Location = new System.Drawing.Point(60, 171);
            this.btn_Getout.Name = "btn_Getout";
            this.btn_Getout.Size = new System.Drawing.Size(87, 23);
            this.btn_Getout.TabIndex = 0;
            this.btn_Getout.Text = "Đăng xuất";
            this.btn_Getout.UseVisualStyleBackColor = true;
            this.btn_Getout.Click += new System.EventHandler(this.btn_Getout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::W_DICTIONARY.Properties.Resources.May_bay_1;
            this.pictureBox1.Location = new System.Drawing.Point(34, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thêm vào danh sách yêu thích";
            // 
            // btn_AddLikeWord
            // 
            this.btn_AddLikeWord.Location = new System.Drawing.Point(54, 491);
            this.btn_AddLikeWord.Name = "btn_AddLikeWord";
            this.btn_AddLikeWord.Size = new System.Drawing.Size(108, 27);
            this.btn_AddLikeWord.TabIndex = 0;
            this.btn_AddLikeWord.Text = "Thêm";
            this.btn_AddLikeWord.UseVisualStyleBackColor = true;
            this.btn_AddLikeWord.Click += new System.EventHandler(this.btn_AddLikeWord_Click);
            // 
            // bt_frm_like
            // 
            this.bt_frm_like.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_frm_like.Location = new System.Drawing.Point(243, 461);
            this.bt_frm_like.Name = "bt_frm_like";
            this.bt_frm_like.Size = new System.Drawing.Size(164, 78);
            this.bt_frm_like.TabIndex = 1;
            this.bt_frm_like.Text = "DANH SÁCH TỪ YÊU THÍCH";
            this.bt_frm_like.UseVisualStyleBackColor = true;
            this.bt_frm_like.Click += new System.EventHandler(this.bt_frm_like_Click);
            // 
            // frmSearchWord_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 551);
            this.Controls.Add(this.bt_frm_like);
            this.Controls.Add(this.btn_AddLikeWord);
            this.Controls.Add(this.label5);
            this.Name = "frmSearchWord_User";
            this.Text = "Manage_Word";
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