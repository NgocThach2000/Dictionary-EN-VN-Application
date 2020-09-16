using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTuDienAV
{
    
     public partial class frm_User_Search : FrmMainApp
    {
        string user;

        
        public frm_User_Search()
        {
            InitializeComponent();
            
            

        }
        public string User
        {
            get { return user; }
            set { user = value; }
        }

        
        

        private void frm_User_Search_Load(object sender, EventArgs e)
        {
            Name_User.Text = user.Trim();
        }

        

        private void loaddata()
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {       
            try
            {

                //khai báo các biến sẽ truyền vào
                //int id = int.Parse(txtID.Text.Trim());
                string user2 = user;
                string id = "ID";
                string eng = txtEnglish2.Text.Trim();
                string shortvn = txtVN2.Text.Trim();
                string dich = txtVNDetail.Text.Trim();

                //string eng = txtEnglish.Text.Trim();
                //string shortvn = txtShorVN.Text.Trim();
                //string dich = txtDich.Text.Trim();

                //truyen du lieu len SQL
                SqlHelper.SqlHelper.ExecuteNonQuery(SQLstring.strCon, "TuDien_Them_user",user2,id,eng,shortvn, dich);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void bt_frm_like_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.User = user;
            frm.Show();
        }

        private void txtVNDetail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
