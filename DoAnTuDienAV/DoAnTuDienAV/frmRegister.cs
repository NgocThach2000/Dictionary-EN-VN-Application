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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            this.AcceptButton = bt_Register;
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            try
            {
                string user_register = txt_userRegister.Text.Trim();
                string user_password = txt_passRegister.Text.Trim();
                string user_password_repeat = txt_rppassRegister.Text.Trim();
                int user_permisstion = 2;

                if (user_register != "" && user_password != "" && user_password_repeat != "")
                {
                    if (user_password == user_password_repeat)
                    {
                        SqlHelper.SqlHelper.ExecuteNonQuery(SQLstring.strCon, "Login_Them", user_register, user_password, user_permisstion);
                        MessageBox.Show("Đăng ký thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu nhập lại của bạn không khớp,vui lòng thử lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn còn để trống thông tin, vui lòng nhập đầy đủ thông tin!");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            txt_userRegister.Text = "";
            txt_passRegister.Text = "";
            txt_rppassRegister.Text = "";
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
        }
    }

            
}
