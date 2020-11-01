using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace W_DICTIONARY
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            this.AcceptButton = btn_Register;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Dictionary;Integrated Security=True");
            try
            {
                con.Open();
                string user = txt_User.Text.Trim();
                string pass = Txt_pass.Text.Trim();
                string pass_reput = txt_Pass_reput.Text.Trim();
                int user_permission = 2;
                string sqlInsert = "INSERT INTO UserInfo(username,pass,permission)"+ "VALUES(@user,@pass,@user_permission)";    
                SqlCommand cmd = new SqlCommand(sqlInsert, con);
                if (user != "" && pass != "" && pass_reput != "")
                {
                    if (pass == pass_reput)
                    {
                        
                        cmd.Parameters.AddWithValue("user", user);
                        cmd.Parameters.AddWithValue("pass", pass);
                        cmd.Parameters.AddWithValue("user_permission", user_permission);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đăng ký thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu nhập lại của bạn không khớp,vui lòng thử lại!");
                    }
                }    
                else
                {
                    MessageBox.Show("Bạn còn để trống thông tin, vui lòng nhập đầy đủ thông tin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_User.Text = "";
            Txt_pass.Text = "";
            txt_Pass_reput.Text = "";
        }
    }
}
