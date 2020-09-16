using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;

namespace DoAnTuDienAV
{
    public partial class frmQuanLyTu : Form
    {

        string permission;

        public frmQuanLyTu()
        {
            InitializeComponent();
            //khi chay form se load data
            loaddata();
            btXoaTrang.PerformClick();
        }

        public string Permission
        {
            get { return permission; }
            set { permission = value; }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(permission);
            if(permission=="1")
            {
                try
                {

                    //khai báo các biến sẽ truyền vào
                    //int id = int.Parse(txtID.Text.Trim());
                    string id = txtID1.Text.Trim();
                    string eng = txtEnglish1.Text.Trim();
                    string shortvn = txtShortVN.Text.Trim();
                    string dich = txtDich.Text.Trim();

                    //string eng = txtEnglish.Text.Trim();
                    //string shortvn = txtShorVN.Text.Trim();
                    //string dich = txtDich.Text.Trim();

                    //truyen du lieu len SQL
                    SqlHelper.SqlHelper.ExecuteNonQuery(SQLstring.strCon, "TuDien_Them1", id, eng, shortvn, dich);
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không có quyền");
            }
        }
            
            
            
            
        

        private void loaddata() 
        {
            gridItemData.DataSource = SqlHelper.SqlHelper.ExecuteDataset(SQLstring.strCon, "TuDien_Select").Tables[0];
        }

        private void btLam_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void setValue(int index)
        {
            try
            {
                //tao mot datagridview
                DataGridViewRow row = gridItemData.Rows[index];
                //truyen nguoc gia tri tu datagridview len text boxa
                txtID1.Text = row.Cells[0].Value.ToString();
                txtEnglish1.Text = row.Cells[1].Value.ToString();
                txtShortVN.Text = row.Cells[2].Value.ToString();
                txtDich.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void gridItemData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            setValue(e.RowIndex);
        }

        private void btXoaTrang_Click(object sender, EventArgs e)
        {
            txtID1.Clear();
            txtEnglish1.Clear();
            txtShortVN.Clear();
            txtDich.Clear();

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string id = txtID1.Text.Trim();
            SqlHelper.SqlHelper.ExecuteNonQuery(SQLstring.strCon, "TuDien_Xoa", id);
            loaddata();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID1.Text.Trim();
                string eng = txtEnglish1.Text.Trim();
                string shortvn = txtShortVN.Text.Trim();
                string dich = txtDich.Text.Trim();
                SqlHelper.SqlHelper.ExecuteNonQuery(SQLstring.strCon, "TuDien_Sua", id, eng, shortvn, dich);
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
   
