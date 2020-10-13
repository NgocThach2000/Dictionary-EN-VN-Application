using SpeechLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_DICTIONARY
{
    public partial class frmSearchWord_User : frmSearchWord_Guest
    {
        string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public frmSearchWord_User()
        {
            InitializeComponent();
        }

        private void frmSearchWord_User_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Dictionary;Integrated Security=True");  //connect sql

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmSearchWord_Guest_Load(object sender, EventArgs e)
        {
            con.Open();
            Loaddata();
        }

        private void Loaddata()
        {

            string sql = "SELECT * FROM ListWord";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            LboxItem.DataSource = dt;
            LboxItem.DisplayMember = "English";   //display data on listbox
            LboxItem.ValueMember = "idword";            //get id 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSEARCH = "SELECT *FROM ListWord Where English=@english";
                SqlCommand cmd = new SqlCommand(sqlSEARCH, con);
                cmd.Parameters.AddWithValue("English", txtEnglish.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    txtID.Text = dt.Rows[0]["id"].ToString();
                    txtVNShort.Text = dt.Rows[0]["VNShort"].ToString();
                    txtVNLong.Text = dt.Rows[0]["VNLong"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy từ của bạn vừa nhập");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LboxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sqlSEARCH = "SELECT *FROM ListWord Where English=@english";
                SqlCommand cmd = new SqlCommand(sqlSEARCH, con);
                cmd.Parameters.AddWithValue("English", LboxItem.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                txtEnglish.Text = LboxItem.Text;
                if (dt.Rows.Count > 0)
                {
                    txtID.Text = dt.Rows[0]["id"].ToString();
                    txtVNShort.Text = dt.Rows[0]["VNShort"].ToString();
                    txtVNLong.Text = dt.Rows[0]["VNLong"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            SpVoice phatam = new SpVoice();
            phatam.Speak(txtEnglish.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void LboxItem_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_AddLikeWord_Click(object sender, EventArgs e)
        {
                con.Open();
                string user2 = user;
                string sqlINSERT = "INSERT INTO UserLikeWord VALUES (@username,@id,@english,@vnshort,@vnlong)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);
                cmd.Parameters.AddWithValue("username", user2);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("English", txtEnglish.Text);  //statement add
                cmd.Parameters.AddWithValue("VNShort", txtVNShort.Text);
                cmd.Parameters.AddWithValue("VNLong", txtVNLong.Text);
                cmd.ExecuteNonQuery();              //Sql Client add
                MessageBox.Show("Thêm thành công");
            con.Close();
        }

        private void bt_frm_like_Click(object sender, EventArgs e)
        {
            frmLikeWord frm = new frmLikeWord();
            frm.User = user;
            frm.Show();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }
    }
}
