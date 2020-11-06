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

        private void btnSearch_Click(object sender, EventArgs e)  //Search Word
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

        private void LboxItem_SelectedIndexChanged(object sender, EventArgs e) //When you click word on ListBox, another Textbox will show corresponding data to the word. 
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

        private void btn_AddLikeWord_Click(object sender, EventArgs e)  //Add Like Word
        {
            
                con.Open(); 
                string user2 = user;
                string sqlINSERT = "INSERT INTO UserLikeWord VALUES (@username,@id,@english,@vnshort,@vnlong,@Image,@ImgLocation)";  //Query
                string queryString2 = "Select Image FROM ListWord WHERE idword=@id";
                string queryString = "Select ImgLocation FROM ListWord WHERE idword=@id";

                SqlCommand cm = new SqlCommand(queryString, con);           //Excute the query with your database
                SqlCommand cm2 = new SqlCommand(queryString2, con);

                cm.Parameters.AddWithValue("@id", txtID.Text);
                cm2.Parameters.AddWithValue("@id", txtID.Text);

                SqlCommand cmd = new SqlCommand(sqlINSERT, con);

                cmd.Parameters.AddWithValue("username", user2);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("English", txtEnglish.Text);  //statement add
                cmd.Parameters.AddWithValue("VNShort", txtVNShort.Text);
                cmd.Parameters.AddWithValue("VNLong", txtVNLong.Text);
                cmd.Parameters.AddWithValue("Image", cm2.ExecuteScalar()); ;
                cmd.Parameters.AddWithValue("ImgLocation", cm.ExecuteScalar().ToString());   //ExecuteScalar return the same value 

                cmd.ExecuteNonQuery();              //ExecuteNonquery Update Value to Database
                MessageBox.Show("Thêm thành công");

                con.Close();
            

        }

        private void bt_frm_like_Click(object sender, EventArgs e)  //Show Form Like_Word
        {
            frmLikeWord frm = new frmLikeWord();
            frm.User = user;
            frm.Show();
        }

        

        

        private void btn_Getout_Click(object sender, EventArgs e)  //Get out this form
        {
            this.Hide();
            frmDictionary frm = new frmDictionary();
            
            frm.Show();
            MessageBox.Show("Đăng xuất thành công!");


        }

        
    }
}
