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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Browse_Image = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.listWordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryDataSet = new W_DICTIONARY.DictionaryDataSet();
            this.listWordTableAdapter = new W_DICTIONARY.DictionaryDataSetTableAdapters.ListWordTableAdapter();
            this.dictionaryDataSet1 = new W_DICTIONARY.DictionaryDataSet1();
            this.listWordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listWordTableAdapter1 = new W_DICTIONARY.DictionaryDataSet1TableAdapters.ListWordTableAdapter();
            this.idwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNShortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNLongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imgLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listWordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listWordBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Browse_Image);
            this.groupBox1.Controls.Add(this.pictureBox1);
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
            this.groupBox1.Size = new System.Drawing.Size(1232, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm từ mới";
            // 
            // btn_Browse_Image
            // 
            this.btn_Browse_Image.Location = new System.Drawing.Point(1067, 232);
            this.btn_Browse_Image.Name = "btn_Browse_Image";
            this.btn_Browse_Image.Size = new System.Drawing.Size(86, 23);
            this.btn_Browse_Image.TabIndex = 27;
            this.btn_Browse_Image.Text = "Browse";
            this.btn_Browse_Image.UseVisualStyleBackColor = true;
            this.btn_Browse_Image.Click += new System.EventHandler(this.btn_Browse_Image_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1003, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
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
            this.btn_Reput.Click += new System.EventHandler(this.btn_Reput_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridItemData);
            this.groupBox2.Location = new System.Drawing.Point(12, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(873, 279);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách từ đã có";
            // 
            // gridItemData
            // 
            this.gridItemData.AutoGenerateColumns = false;
            this.gridItemData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItemData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idwordDataGridViewTextBoxColumn,
            this.englishDataGridViewTextBoxColumn,
            this.vNShortDataGridViewTextBoxColumn,
            this.vNLongDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.imgLocationDataGridViewTextBoxColumn});
            this.gridItemData.DataSource = this.listWordBindingSource1;
            this.gridItemData.Location = new System.Drawing.Point(27, 19);
            this.gridItemData.Name = "gridItemData";
            this.gridItemData.RowHeadersVisible = false;
            this.gridItemData.RowHeadersWidth = 90;
            this.gridItemData.RowTemplate.Height = 64;
            this.gridItemData.Size = new System.Drawing.Size(758, 241);
            this.gridItemData.TabIndex = 0;
            this.gridItemData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItemData_RowEnter);
            // 
            // listWordBindingSource
            // 
            this.listWordBindingSource.DataMember = "ListWord";
            this.listWordBindingSource.DataSource = this.dictionaryDataSet;
            // 
            // dictionaryDataSet
            // 
            this.dictionaryDataSet.DataSetName = "DictionaryDataSet";
            this.dictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listWordTableAdapter
            // 
            this.listWordTableAdapter.ClearBeforeFill = true;
            // 
            // dictionaryDataSet1
            // 
            this.dictionaryDataSet1.DataSetName = "DictionaryDataSet1";
            this.dictionaryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listWordBindingSource1
            // 
            this.listWordBindingSource1.DataMember = "ListWord";
            this.listWordBindingSource1.DataSource = this.dictionaryDataSet1;
            // 
            // listWordTableAdapter1
            // 
            this.listWordTableAdapter1.ClearBeforeFill = true;
            // 
            // idwordDataGridViewTextBoxColumn
            // 
            this.idwordDataGridViewTextBoxColumn.DataPropertyName = "idword";
            this.idwordDataGridViewTextBoxColumn.HeaderText = "idword";
            this.idwordDataGridViewTextBoxColumn.Name = "idwordDataGridViewTextBoxColumn";
            this.idwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.idwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // englishDataGridViewTextBoxColumn
            // 
            this.englishDataGridViewTextBoxColumn.DataPropertyName = "English";
            this.englishDataGridViewTextBoxColumn.HeaderText = "English";
            this.englishDataGridViewTextBoxColumn.Name = "englishDataGridViewTextBoxColumn";
            // 
            // vNShortDataGridViewTextBoxColumn
            // 
            this.vNShortDataGridViewTextBoxColumn.DataPropertyName = "VNShort";
            this.vNShortDataGridViewTextBoxColumn.HeaderText = "VNShort";
            this.vNShortDataGridViewTextBoxColumn.Name = "vNShortDataGridViewTextBoxColumn";
            // 
            // vNLongDataGridViewTextBoxColumn
            // 
            this.vNLongDataGridViewTextBoxColumn.DataPropertyName = "VNLong";
            this.vNLongDataGridViewTextBoxColumn.HeaderText = "VNLong";
            this.vNLongDataGridViewTextBoxColumn.Name = "vNLongDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // imgLocationDataGridViewTextBoxColumn
            // 
            this.imgLocationDataGridViewTextBoxColumn.DataPropertyName = "ImgLocation";
            this.imgLocationDataGridViewTextBoxColumn.HeaderText = "ImgLocation";
            this.imgLocationDataGridViewTextBoxColumn.Name = "imgLocationDataGridViewTextBoxColumn";
            // 
            // frmManagerWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 644);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManagerWord";
            this.Text = "frmSearchWord_User";
            this.Load += new System.EventHandler(this.frmManagerWord_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItemData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listWordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listWordBindingSource1)).EndInit();
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
        private System.Windows.Forms.Button btn_Browse_Image;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DictionaryDataSet dictionaryDataSet;
        private System.Windows.Forms.BindingSource listWordBindingSource;
        private DictionaryDataSetTableAdapters.ListWordTableAdapter listWordTableAdapter;
        private DictionaryDataSet1 dictionaryDataSet1;
        private System.Windows.Forms.BindingSource listWordBindingSource1;
        private DictionaryDataSet1TableAdapters.ListWordTableAdapter listWordTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNShortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNLongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgLocationDataGridViewTextBoxColumn;
    }
}