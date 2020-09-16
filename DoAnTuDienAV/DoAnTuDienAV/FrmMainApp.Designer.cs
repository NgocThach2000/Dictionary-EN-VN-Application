namespace DoAnTuDienAV
{
    partial class FrmMainApp
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
            this.lbItem = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtVN2 = new System.Windows.Forms.TextBox();
            this.txtEnglish2 = new System.Windows.Forms.TextBox();
            this.btTraTu = new System.Windows.Forms.Button();
            this.txtVNDetail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbItem);
            this.groupBox1.Location = new System.Drawing.Point(-1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách từ";
            // 
            // lbItem
            // 
            this.lbItem.FormattingEnabled = true;
            this.lbItem.Location = new System.Drawing.Point(0, 20);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(208, 420);
            this.lbItem.TabIndex = 0;
            this.lbItem.SelectedIndexChanged += new System.EventHandler(this.lbItem_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtVN2);
            this.groupBox2.Controls.Add(this.txtEnglish2);
            this.groupBox2.Controls.Add(this.btTraTu);
            this.groupBox2.Controls.Add(this.txtVNDetail);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Location = new System.Drawing.Point(230, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 447);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra từ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVN2
            // 
            this.txtVN2.Location = new System.Drawing.Point(144, 97);
            this.txtVN2.Name = "txtVN2";
            this.txtVN2.Size = new System.Drawing.Size(136, 20);
            this.txtVN2.TabIndex = 8;
            // 
            // txtEnglish2
            // 
            this.txtEnglish2.Location = new System.Drawing.Point(144, 46);
            this.txtEnglish2.Name = "txtEnglish2";
            this.txtEnglish2.Size = new System.Drawing.Size(136, 20);
            this.txtEnglish2.TabIndex = 7;
            // 
            // btTraTu
            // 
            this.btTraTu.Location = new System.Drawing.Point(332, 46);
            this.btTraTu.Name = "btTraTu";
            this.btTraTu.Size = new System.Drawing.Size(75, 23);
            this.btTraTu.TabIndex = 6;
            this.btTraTu.Text = "Tra Từ";
            this.btTraTu.UseVisualStyleBackColor = true;
            this.btTraTu.Click += new System.EventHandler(this.btTraTu_Click);
            // 
            // txtVNDetail
            // 
            this.txtVNDetail.Location = new System.Drawing.Point(37, 238);
            this.txtVNDetail.Multiline = true;
            this.txtVNDetail.Name = "txtVNDetail";
            this.txtVNDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVNDetail.Size = new System.Drawing.Size(182, 179);
            this.txtVNDetail.TabIndex = 5;
            this.txtVNDetail.TextChanged += new System.EventHandler(this.txtVNDetail_TextChanged);
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
            // FrmMainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMainApp";
            this.Text = "FrmMainApp";
            this.Load += new System.EventHandler(this.FrmMainApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label txtID;
        protected System.Windows.Forms.TextBox txtVN2;
        protected System.Windows.Forms.TextBox txtEnglish2;
        protected System.Windows.Forms.Button btTraTu;
        protected System.Windows.Forms.TextBox txtVNDetail;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.ListBox lbItem;
        protected System.Windows.Forms.Button button1;
    }
}