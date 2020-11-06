using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace W_DICTIONARY
{
    public partial class frmDictionary : Form
    {
        public frmDictionary()
        {
            InitializeComponent();
            this.AcceptButton = btn_confirm;    //when enter
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();  // new form Register
            frm.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            picPanel.Hide();
            grLogin.Show();  
        }

        private void btnSearchWord_Click(object sender, EventArgs e)
        {
            frmSearchWord_Guest frm = new frmSearchWord_Guest();        //new from SearchWord
            frm.Show();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Dictionary;Integrated Security=True"); //Connection sql
            try
            {
                con.Open();  //open data
                string user = txtUser.Text.Trim();
                string pass = txtPass.Text.Trim();
                
                
                string sql = "select * from UserInfo where username='"+user+"'and pass = '"+pass+"'  "; //statement query sql
                SqlCommand cmd = new SqlCommand(sql,con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);                                    //load data
                if (dt.Rows.Count > 0 && user == "admin")       //if exist values , rows is 1 ,if not rows is 0;
                {
                    
                    MessageBox.Show("Đăng nhập thành công với tư cách admin!");
                    frmManagerWord frm = new frmManagerWord();                   
                    frm.Show();
                    grLogin.Hide();
                    this.Hide();
                    
                }
                else if(dt.Rows.Count > 0 && user != "admin")
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    frmSearchWord_User frm = new frmSearchWord_User();
                    frm.User = user;
                    frm.Show();
                    grLogin.Hide();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                }   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void frmDictionary_Load(object sender, EventArgs e)
        {

        }
    }
}
