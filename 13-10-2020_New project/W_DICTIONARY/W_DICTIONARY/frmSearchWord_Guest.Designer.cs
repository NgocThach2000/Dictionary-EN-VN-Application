namespace W_DICTIONARY
{
      partial class frmSearchWord_Guest
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
            this.LboxItem = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVNLong = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnListen = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVNShort = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LboxItem);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách từ ";
            // 
            // LboxItem
            // 
            this.LboxItem.FormattingEnabled = true;
            this.LboxItem.Location = new System.Drawing.Point(13, 19);
            this.LboxItem.Name = "LboxItem";
            this.LboxItem.Size = new System.Drawing.Size(188, 381);
            this.LboxItem.TabIndex = 0;
            this.LboxItem.SelectedIndexChanged += new System.EventHandler(this.LboxItem_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtVNLong);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnListen);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtVNShort);
            this.groupBox2.Controls.Add(this.txtEnglish);
            this.groupBox2.Location = new System.Drawing.Point(243, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 416);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(106, 130);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(117, 19);
            this.txtID.TabIndex = 11;
            this.txtID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nghĩa chi tiết";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtVNLong
            // 
            this.txtVNLong.Location = new System.Drawing.Point(9, 238);
            this.txtVNLong.Multiline = true;
            this.txtVNLong.Name = "txtVNLong";
            this.txtVNLong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVNLong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVNLong.Size = new System.Drawing.Size(432, 163);
            this.txtVNLong.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(148, 155);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(67, 23);
            this.btnListen.TabIndex = 7;
            this.btnListen.Text = "Nghe";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(49, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tra từ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nghĩa rút gọn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ cần tra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtVNShort
            // 
            this.txtVNShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVNShort.Location = new System.Drawing.Point(106, 89);
            this.txtVNShort.Multiline = true;
            this.txtVNShort.Name = "txtVNShort";
            this.txtVNShort.Size = new System.Drawing.Size(210, 35);
            this.txtVNShort.TabIndex = 3;
            this.txtVNShort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglish.Location = new System.Drawing.Point(106, 31);
            this.txtEnglish.Multiline = true;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(210, 35);
            this.txtEnglish.TabIndex = 2;
            this.txtEnglish.TextChanged += new System.EventHandler(this.txtEnglish_TextChanged);
            // 
            // frmSearchWord_Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSearchWord_Guest";
            this.Text = "frmSeachWord_Guest";
            this.Load += new System.EventHandler(this.frmSearchWord_Guest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.ListBox LboxItem;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtVNShort;
        protected System.Windows.Forms.TextBox txtEnglish;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnSearch;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox txtVNLong;
        protected System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Button btnListen;
        protected System.Windows.Forms.TextBox txtID;
    }
}