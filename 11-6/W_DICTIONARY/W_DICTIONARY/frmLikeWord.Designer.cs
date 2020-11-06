namespace W_DICTIONARY
{
    partial class frmLikeWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLikeWord));
            this.btn_SearchLikeWord = new System.Windows.Forms.Button();
            this.btn_DeleteLikeWord = new System.Windows.Forms.Button();
            this.lb_Like = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbItem_Like = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtID_Like = new System.Windows.Forms.TextBox();
            this.btn_Lisen_Like = new System.Windows.Forms.Button();
            this.txtVNShort_Like = new System.Windows.Forms.TextBox();
            this.txtEnglish_Like = new System.Windows.Forms.TextBox();
            this.btn_Search_Like = new System.Windows.Forms.Button();
            this.txtVNLong_Like = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_Like_Word = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Like_Word)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SearchLikeWord
            // 
            this.btn_SearchLikeWord.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_SearchLikeWord.Location = new System.Drawing.Point(16, 77);
            this.btn_SearchLikeWord.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SearchLikeWord.Name = "btn_SearchLikeWord";
            this.btn_SearchLikeWord.Size = new System.Drawing.Size(113, 53);
            this.btn_SearchLikeWord.TabIndex = 3;
            this.btn_SearchLikeWord.Text = "Tra từ";
            this.btn_SearchLikeWord.UseVisualStyleBackColor = false;
            // 
            // btn_DeleteLikeWord
            // 
            this.btn_DeleteLikeWord.BackColor = System.Drawing.Color.Red;
            this.btn_DeleteLikeWord.Location = new System.Drawing.Point(16, 171);
            this.btn_DeleteLikeWord.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DeleteLikeWord.Name = "btn_DeleteLikeWord";
            this.btn_DeleteLikeWord.Size = new System.Drawing.Size(113, 50);
            this.btn_DeleteLikeWord.TabIndex = 8;
            this.btn_DeleteLikeWord.Text = "Xóa từ ";
            this.btn_DeleteLikeWord.UseVisualStyleBackColor = false;
            this.btn_DeleteLikeWord.Click += new System.EventHandler(this.btn_DeleteLikeWord_Click);
            // 
            // lb_Like
            // 
            this.lb_Like.AutoSize = true;
            this.lb_Like.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Like.Location = new System.Drawing.Point(169, 11);
            this.lb_Like.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Like.Name = "lb_Like";
            this.lb_Like.Size = new System.Drawing.Size(210, 25);
            this.lb_Like.TabIndex = 9;
            this.lb_Like.Text = "Danh sách từ yêu thích";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbItem_Like);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(175, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(285, 513);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Từ Yêu Thích";
            // 
            // lbItem_Like
            // 
            this.lbItem_Like.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem_Like.FormattingEnabled = true;
            this.lbItem_Like.ItemHeight = 20;
            this.lbItem_Like.Location = new System.Drawing.Point(0, 25);
            this.lbItem_Like.Margin = new System.Windows.Forms.Padding(4);
            this.lbItem_Like.Name = "lbItem_Like";
            this.lbItem_Like.Size = new System.Drawing.Size(276, 504);
            this.lbItem_Like.TabIndex = 0;
            this.lbItem_Like.SelectedIndexChanged += new System.EventHandler(this.lbItem_Like_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtID_Like);
            this.groupBox2.Controls.Add(this.btn_Lisen_Like);
            this.groupBox2.Controls.Add(this.txtVNShort_Like);
            this.groupBox2.Controls.Add(this.txtEnglish_Like);
            this.groupBox2.Controls.Add(this.btn_Search_Like);
            this.groupBox2.Controls.Add(this.txtVNLong_Like);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Location = new System.Drawing.Point(516, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(535, 540);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra từ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtID_Like
            // 
            this.txtID_Like.Location = new System.Drawing.Point(179, 165);
            this.txtID_Like.Margin = new System.Windows.Forms.Padding(4);
            this.txtID_Like.Name = "txtID_Like";
            this.txtID_Like.Size = new System.Drawing.Size(83, 22);
            this.txtID_Like.TabIndex = 10;
            // 
            // btn_Lisen_Like
            // 
            this.btn_Lisen_Like.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Lisen_Like.Location = new System.Drawing.Point(383, 117);
            this.btn_Lisen_Like.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Lisen_Like.Name = "btn_Lisen_Like";
            this.btn_Lisen_Like.Size = new System.Drawing.Size(100, 40);
            this.btn_Lisen_Like.TabIndex = 9;
            this.btn_Lisen_Like.Text = "Nghe";
            this.btn_Lisen_Like.UseVisualStyleBackColor = false;
            this.btn_Lisen_Like.Click += new System.EventHandler(this.btn_Lisen_Like_Click);
            // 
            // txtVNShort_Like
            // 
            this.txtVNShort_Like.Location = new System.Drawing.Point(179, 119);
            this.txtVNShort_Like.Margin = new System.Windows.Forms.Padding(4);
            this.txtVNShort_Like.Multiline = true;
            this.txtVNShort_Like.Name = "txtVNShort_Like";
            this.txtVNShort_Like.Size = new System.Drawing.Size(180, 38);
            this.txtVNShort_Like.TabIndex = 8;
            // 
            // txtEnglish_Like
            // 
            this.txtEnglish_Like.Location = new System.Drawing.Point(179, 57);
            this.txtEnglish_Like.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnglish_Like.Multiline = true;
            this.txtEnglish_Like.Name = "txtEnglish_Like";
            this.txtEnglish_Like.Size = new System.Drawing.Size(180, 40);
            this.txtEnglish_Like.TabIndex = 7;
            // 
            // btn_Search_Like
            // 
            this.btn_Search_Like.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search_Like.Location = new System.Drawing.Point(383, 55);
            this.btn_Search_Like.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search_Like.Name = "btn_Search_Like";
            this.btn_Search_Like.Size = new System.Drawing.Size(100, 42);
            this.btn_Search_Like.TabIndex = 6;
            this.btn_Search_Like.Text = "Tra Từ";
            this.btn_Search_Like.UseVisualStyleBackColor = false;
            this.btn_Search_Like.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtVNLong_Like
            // 
            this.txtVNLong_Like.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVNLong_Like.Location = new System.Drawing.Point(49, 258);
            this.txtVNLong_Like.Margin = new System.Windows.Forms.Padding(4);
            this.txtVNLong_Like.Multiline = true;
            this.txtVNLong_Like.Name = "txtVNLong_Like";
            this.txtVNLong_Like.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVNLong_Like.Size = new System.Drawing.Size(461, 242);
            this.txtVNLong_Like.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nghĩa chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nghĩa gọn";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(44, 58);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 25);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "Từ cần tra";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pb_Like_Word);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(1087, 36);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(349, 329);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hình ảnh minh họa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::W_DICTIONARY.Properties.Resources.oke1;
            this.pictureBox1.Location = new System.Drawing.Point(1069, 373);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pb_Like_Word
            // 
            this.pb_Like_Word.Location = new System.Drawing.Point(20, 28);
            this.pb_Like_Word.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Like_Word.Name = "pb_Like_Word";
            this.pb_Like_Word.Size = new System.Drawing.Size(321, 273);
            this.pb_Like_Word.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Like_Word.TabIndex = 0;
            this.pb_Like_Word.TabStop = false;
            // 
            // frmLikeWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_Like);
            this.Controls.Add(this.btn_DeleteLikeWord);
            this.Controls.Add(this.btn_SearchLikeWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLikeWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DICTIONARY";
            this.Load += new System.EventHandler(this.frmLikeWord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Like_Word)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SearchLikeWord;
        private System.Windows.Forms.Button btn_DeleteLikeWord;
        private System.Windows.Forms.Label lb_Like;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.ListBox lbItem_Like;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Button btn_Lisen_Like;
        protected System.Windows.Forms.TextBox txtVNShort_Like;
        protected System.Windows.Forms.TextBox txtEnglish_Like;
        protected System.Windows.Forms.Button btn_Search_Like;
        protected System.Windows.Forms.TextBox txtVNLong_Like;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label txtID;
        private System.Windows.Forms.TextBox txtID_Like;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pb_Like_Word;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}