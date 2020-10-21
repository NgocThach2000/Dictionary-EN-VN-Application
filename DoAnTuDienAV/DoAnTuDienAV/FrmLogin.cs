using SpeechLib;
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
    public partial class FrmLogin : Form
    {
        string user;
        public FrmLogin()
        {
            InitializeComponent();
 
        }

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LoaddataListBoxData();
        }

        private void btTraTu_Click(object sender, EventArgs e)
        {
            frm_User_Search frm = new frm_User_Search();
            frm.Show();
           
        }

        private void LoaddataListBoxData()
        {
            string string_user = user.Trim();
            DataTable ds = SqlHelper.SqlHelper.ExecuteDataset(SQLstring.strCon, "TuDIen_TraTu_user", string_user).Tables[0];
            
            try
            {
                DataTable ds2 = SqlHelper.SqlHelper.ExecuteDataset(SQLstring.strCon, "TuDien_Select_user").Tables[0];
                lbItem_user.DataSource = ds;
                lbItem_user.DisplayMember = "English"; //Cho hiển thị cột English
                lbItem_user.ValueMember = "ID";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbItem_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string temp = lbItem_user.Text;
                DataTable ds = SqlHelper.SqlHelper.ExecuteDataset(SQLstring.strCon, "TuDIen_TraTu", temp).Tables[0];
                txtEnglish2_user.Text = lbItem_user.Text;
                if (ds.Rows.Count > 0)
                {
                    
                    txtVN2_user.Text = ds.Rows[0]["ShortVN"].ToString();
                    txtVNDetail_user.Text = ds.Rows[0]["VN"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpVoice phatam = new SpVoice();
            phatam.Speak(txtEnglish2_user.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string eng = txtEnglish2_user.Text.Trim();
                SqlHelper.SqlHelper.ExecuteNonQuery(SQLstring.strCon, "User_information_xoa", eng);
                LoaddataListBoxData();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                    
        }
      
    }
}
