namespace W_DICTIONARY
{
    partial class frmManagerWord
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_search = new System.Windows.Forms.TextBox();
            this.txt_id_Manager = new System.Windows.Forms.TextBox();
            this.btn_Manager_Search = new System.Windows.Forms.Button();
            this.btn_EditWord = new System.Windows.Forms.Button();
            this.btn_DeleteWord = new System.Windows.Forms.Button();
            this.btn_AddWord = new System.Windows.Forms.Button();
            this.txtVNLong_Manager = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVNShort_Manager = new System.Windows.Forms.TextBox();
            this.txtEnglish_Manager = new System.Windows.Forms.TextBox();
            this.txtShorVN = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.Label();
            this.btn_Reput = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridItemData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Back);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_id_search);
            this.groupBox1.Controls.Add(this.txt_id_Manager);
            this.groupBox1.Controls.Add(this.btn_Manager_Search);
            this.groupBox1.Controls.Add(this.btn_EditWord);
            this.groupBox1.Controls.Add(this.btn_DeleteWord);
            this.groupBox1.Controls.Add(this.btn_AddWord);
            this.groupBox1.Controls.Add(this.txtVNLong_Manager);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtVNShort_Manager);
            this.groupBox1.Controls.Add(this.txtEnglish_Manager);
            this.groupBox1.Controls.Add(this.txtShorVN);
            this.groupBox1.Controls.Add(this.txtEnglish);
            this.groupBox1.Controls.Add(this.btn_Reput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm từ mới";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(843, 209);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(86, 23);
            this.btn_Back.TabIndex = 9;
            this.btn_Back.Text = "Quay lại";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(719, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Từ cần tìm";
            // 
            // txt_id_search
            // 
            this.txt_id_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_search.Location = new System.Drawing.Point(665, 149);
            this.txt_id_search.Multiline = true;
            this.txt_id_search.Name = "txt_id_search";
            this.txt_id_search.Size = new System.Drawing.Size(208, 33);
            this.txt_id_search.TabIndex = 7;
            // 
            // txt_id_Manager
            // 
            this.txt_id_Manager.Location = new System.Drawing.Point(105, 236);
            this.txt_id_Manager.Name = "txt_id_Manager";
            this.txt_id_Manager.Size = new System.Drawing.Size(168, 20);
            this.txt_id_Manager.TabIndex = 10;
            this.txt_id_Manager.Visible = false;
            // 
            // btn_Manager_Search
            // 
            this.btn_Manager_Search.Location = new System.Drawing.Point(712, 198);
            this.btn_Manager_Search.Name = "btn_Manager_Search";
            this.btn_Manager_Search.Size = new System.Drawing.Size(100, 45);
            this.btn_Manager_Search.TabIndex = 8;
            this.btn_Manager_Search.Text = "Tìm kiếm";
            this.btn_Manager_Search.UseVisualStyleBackColor = true;
            this.btn_Manager_Search.Click += new System.EventHandler(this.btn_Manager_Search_Click);
            // 
            // btn_EditWord
            // 
            this.btn_EditWord.Location = new System.Drawing.Point(723, 56);
            this.btn_EditWord.Name = "btn_EditWord";
            this.btn_EditWord.Size = new System.Drawing.Size(100, 38);
            this.btn_EditWord.TabIndex = 4;
            this.btn_EditWord.Text = "Sửa";
            this.btn_EditWord.UseVisualStyleBackColor = true;
            this.btn_EditWord.Click += new System.EventHandler(this.btn_EditWord_Click);
            // 
            // btn_DeleteWord
            // 
            this.btn_DeleteWord.Location = new System.Drawing.Point(829, 56);
            this.btn_DeleteWord.Name = "btn_DeleteWord";
            this.btn_DeleteWord.Size = new System.Drawing.Size(100, 38);
            this.btn_DeleteWord.TabIndex = 5;
            this.btn_DeleteWord.Text = "Xóa";
            this.btn_DeleteWord.UseVisualStyleBackColor = true;
            this.btn_DeleteWord.Click += new System.EventHandler(this.btn_DeleteWord_Click);
            // 
            // btn_AddWord
            // 
            this.btn_AddWord.Location = new System.Drawing.Point(613, 56);
            this.btn_AddWord.Name = "btn_AddWord";
            this.btn_AddWord.Size = new System.Drawing.Size(100, 38);
            this.btn_AddWord.TabIndex = 3;
            this.btn_AddWord.Text = "Thêm";
            this.btn_AddWord.UseVisualStyleBackColor = true;
            this.btn_AddWord.Click += new System.EventHandler(this.btn_AddWord_Click);
            // 
            // txtVNLong_Manager
            // 
            this.txtVNLong_Manager.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtVNLong_Manager.Location = new System.Drawing.Point(361, 61);
            this.txtVNLong_Manager.Multiline = true;
            this.txtVNLong_Manager.Name = "txtVNLong_Manager";
            this.txtVNLong_Manager.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVNLong_Manager.Size = new System.Drawing.Size(194, 154);
            this.txtVNLong_Manager.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Dịch chi tiết nghĩa";
            // 
            // txtVNShort_Manager
            // 
            this.txtVNShort_Manager.Location = new System.Drawing.Point(105, 149);
            this.txtVNShort_Manager.Multiline = true;
            this.txtVNShort_Manager.Name = "txtVNShort_Manager";
            this.txtVNShort_Manager.Size = new System.Drawing.Size(168, 66);
            this.txtVNShort_Manager.TabIndex = 1;
            // 
            // txtEnglish_Manager
            // 
            this.txtEnglish_Manager.Location = new System.Drawing.Point(105, 61);
            this.txtEnglish_Manager.Multiline = true;
            this.txtEnglish_Manager.Name = "txtEnglish_Manager";
            this.txtEnglish_Manager.Size = new System.Drawing.Size(168, 68);
            this.txtEnglish_Manager.TabIndex = 0;
            // 
            // txtShorVN
            // 
            this.txtShorVN.AutoSize = true;
            this.txtShorVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShorVN.Location = new System.Drawing.Point(23, 147);
            this.txtShorVN.Name = "txtShorVN";
            this.txtShorVN.Size = new System.Drawing.Size(41, 20);
            this.txtShorVN.TabIndex = 17;
            this.txtShorVN.Text = "Dịch";
            // 
            // txtEnglish
            // 
            this.txtEnglish.AutoSize = true;
            this.txtEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglish.Location = new System.Drawing.Point(23, 61);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(61, 20);
            this.txtEnglish.TabIndex = 16;
            this.txtEnglish.Text = "English";
            // 
            // btn_Reput
            // 
            this.btn_Reput.Location = new System.Drawing.Point(27, 19);
            this.btn_Reput.Name = "btn_Reput";
            this.btn_Reput.Size = new System.Drawing.Size(88, 23);
            this.btn_Reput.TabIndex = 6;
            this.btn_Reput.Text = "Nhập lại";
            this.btn_Reput.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridItemData);
            this.groupBox2.Location = new System.Drawing.Point(12, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(973, 279);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách từ đã có";
            // 
            // gridItemData
            // 
            this.gridItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItemData.Location = new System.Drawing.Point(27, 19);
            this.gridItemData.Name = "gridItemData";
            this.gridItemData.Size = new System.Drawing.Size(926, 248);
            this.gridItemData.TabIndex = 0;
            this.gridItemData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItemData_RowEnter);
            // 
            // frmManagerWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManagerWord";
            this.Text = "frmSearchWord_User";
            this.Load += new System.EventHandler(this.frmManagerWord_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItemData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Manager_Search;
        private System.Windows.Forms.Button btn_EditWord;
        private System.Windows.Forms.Button btn_DeleteWord;
        private System.Windows.Forms.Button btn_AddWord;
        private System.Windows.Forms.TextBox txtVNLong_Manager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVNShort_Manager;
        private System.Windows.Forms.TextBox txtEnglish_Manager;
        private System.Windows.Forms.Label txtShorVN;
        private System.Windows.Forms.Label txtEnglish;
        private System.Windows.Forms.Button btn_Reput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridItemData;
        private System.Windows.Forms.TextBox txt_id_Manager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_search;
        private System.Windows.Forms.Button btn_Back;
    }
}