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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SearchLikeWord
            // 
            this.btn_SearchLikeWord.Location = new System.Drawing.Point(12, 52);
            this.btn_SearchLikeWord.Name = "btn_SearchLikeWord";
            this.btn_SearchLikeWord.Size = new System.Drawing.Size(85, 43);
            this.btn_SearchLikeWord.TabIndex = 3;
            this.btn_SearchLikeWord.Text = "Tra từ";
            this.btn_SearchLikeWord.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteLikeWord
            // 
            this.btn_DeleteLikeWord.Location = new System.Drawing.Point(12, 134);
            this.btn_DeleteLikeWord.Name = "btn_DeleteLikeWord";
            this.btn_DeleteLikeWord.Size = new System.Drawing.Size(85, 41);
            this.btn_DeleteLikeWord.TabIndex = 8;
            this.btn_DeleteLikeWord.Text = "Xóa từ ";
            this.btn_DeleteLikeWord.UseVisualStyleBackColor = true;
            this.btn_DeleteLikeWord.Click += new System.EventHandler(this.btn_DeleteLikeWord_Click);
            // 
            // lb_Like
            // 
            this.lb_Like.AutoSize = true;
            this.lb_Like.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Like.Location = new System.Drawing.Point(127, 9);
            this.lb_Like.Name = "lb_Like";
            this.lb_Like.Size = new System.Drawing.Size(171, 20);
            this.lb_Like.TabIndex = 9;
            this.lb_Like.Text = "Danh sách từ yêu thích";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbItem_Like);
            this.groupBox1.Location = new System.Drawing.Point(131, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 417);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách từ yêu thích";
            // 
            // lbItem_Like
            // 
            this.lbItem_Like.FormattingEnabled = true;
            this.lbItem_Like.Location = new System.Drawing.Point(0, 20);
            this.lbItem_Like.Name = "lbItem_Like";
            this.lbItem_Like.Size = new System.Drawing.Size(208, 420);
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
            this.groupBox2.Location = new System.Drawing.Point(387, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 439);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra từ";
            // 
            // txtID_Like
            // 
            this.txtID_Like.Location = new System.Drawing.Point(144, 140);
            this.txtID_Like.Name = "txtID_Like";
            this.txtID_Like.Size = new System.Drawing.Size(136, 20);
            this.txtID_Like.TabIndex = 10;
            // 
            // btn_Lisen_Like
            // 
            this.btn_Lisen_Like.Location = new System.Drawing.Point(301, 97);
            this.btn_Lisen_Like.Name = "btn_Lisen_Like";
            this.btn_Lisen_Like.Size = new System.Drawing.Size(75, 23);
            this.btn_Lisen_Like.TabIndex = 9;
            this.btn_Lisen_Like.Text = "Nghe";
            this.btn_Lisen_Like.UseVisualStyleBackColor = true;
            this.btn_Lisen_Like.Click += new System.EventHandler(this.btn_Lisen_Like_Click);
            // 
            // txtVNShort_Like
            // 
            this.txtVNShort_Like.Location = new System.Drawing.Point(144, 97);
            this.txtVNShort_Like.Name = "txtVNShort_Like";
            this.txtVNShort_Like.Size = new System.Drawing.Size(136, 20);
            this.txtVNShort_Like.TabIndex = 8;
            // 
            // txtEnglish_Like
            // 
            this.txtEnglish_Like.Location = new System.Drawing.Point(144, 46);
            this.txtEnglish_Like.Name = "txtEnglish_Like";
            this.txtEnglish_Like.Size = new System.Drawing.Size(136, 20);
            this.txtEnglish_Like.TabIndex = 7;
            // 
            // btn_Search_Like
            // 
            this.btn_Search_Like.Location = new System.Drawing.Point(301, 46);
            this.btn_Search_Like.Name = "btn_Search_Like";
            this.btn_Search_Like.Size = new System.Drawing.Size(75, 23);
            this.btn_Search_Like.TabIndex = 6;
            this.btn_Search_Like.Text = "Tra Từ";
            this.btn_Search_Like.UseVisualStyleBackColor = true;
            this.btn_Search_Like.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtVNLong_Like
            // 
            this.txtVNLong_Like.Location = new System.Drawing.Point(37, 210);
            this.txtVNLong_Like.Multiline = true;
            this.txtVNLong_Like.Name = "txtVNLong_Like";
            this.txtVNLong_Like.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVNLong_Like.Size = new System.Drawing.Size(219, 197);
            this.txtVNLong_Like.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nghĩa chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nghĩa gọn";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(33, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(80, 20);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "Từ cần tra";
            // 
            // frmLikeWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_Like);
            this.Controls.Add(this.btn_DeleteLikeWord);
            this.Controls.Add(this.btn_SearchLikeWord);
            this.Name = "frmLikeWord";
            this.Text = "frmLikeWord";
            this.Load += new System.EventHandler(this.frmLikeWord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}