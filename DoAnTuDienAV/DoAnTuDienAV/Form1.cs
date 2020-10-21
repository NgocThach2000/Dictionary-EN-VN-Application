using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using Microsoft.ApplicationBlocks.Data;


namespace DoAnTuDienAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
           this.AcceptButton = this.button1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btTraTu_Click(object sender, EventArgs e)
        {
            //khi cần tra từ hiện thẳng chương trình
            FrmMainApp frmMain = new FrmMainApp();
            frmMain.Show();
            
        }

        private void btQL_Click(object sender, EventArgs e)
        {
            //khi cần  thêm từ thì hiện form đăng nhập để quản lý từ
            PicBackground.Hide();
            groupBox1.Show();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Khai báo 2 giá trị chuỗi nhập từ textbox
                string user = txtUser.Text.Trim();//Trim để xóa khoảng trống ở đầu và cuối chuỗi nếu user có nhập nhầm
                string user2 = txtUser.Text.Trim();
                string pass = txtPass.Text.Trim();

                DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLstring.strCon, "Login_Select",user,pass).Tables[0];

                if(dt.Rows.Count>0 && user=="admin" )
                {
                    frmQuanLyTu frm = new frmQuanLyTu();
                    frm.Permission = "1";
                    MessageBox.Show("Đăng nhập thành công với tư cách admin", "Thông báo");
                    frm.Show();
                    groupBox1.Hide();
               
                }
                else if(dt.Rows.Count > 0 && user != "admin")
                {
                    
                    frm_User_Search frm2 = new frm_User_Search();
                    frm2.User = user;
                    MessageBox.Show("Đăng nhập thành công với tư cách thành viên", "Thông báo");
                    frm2.Show();
                    groupBox1.Hide();

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            FrmLogin lg = new FrmLogin();
            lg.Show();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }
    }
}
