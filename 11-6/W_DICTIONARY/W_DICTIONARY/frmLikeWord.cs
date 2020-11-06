using SpeechLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_DICTIONARY
{
    public partial class frmLikeWord : Form
    {
        string user;    //get User from form Dictionary
        public string User
        {
            get { return user; }
            set { user = value; }
        }


        public frmLikeWord()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Dictionary;Integrated Security=True");  //connect sql



        private void frmLikeWord_Load(object sender, EventArgs e)
        {
            con.Open();
            Loaddata();

        }

        
        private void Loaddata()
        {
            string user2 = user;
            string sql = "SELECT * FROM UserLikeWord where username=@username"; //Load data depend UserLikeWord
            SqlCommand cmd = new SqlCommand(sql, con);
            
            cmd.Parameters.AddWithValue("username", user2);        //depend values username 
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            lbItem_Like.DataSource = dt;
            lbItem_Like.DisplayMember = "English";   //display data on listbox
            lbItem_Like.ValueMember = "id";            //get id 
        }

        
        private void lbItem_Like_SelectedIndexChanged(object sender, EventArgs e)
        {
            


            string sqlSEARCH = "SELECT *FROM UserLikeWord Where English=@english"; //get data 
             SqlCommand cmd = new SqlCommand(sqlSEARCH, con);
             cmd.Parameters.AddWithValue("English", lbItem_Like.Text);
             cmd.ExecuteNonQuery();
             SqlDataReader dr = cmd.ExecuteReader();
             DataTable dt = new DataTable();          
             dt.Load(dr);         //Load table
             if (dt.Rows.Count > 0)
             {
                txtID_Like.Text = dt.Rows[0]["id"].ToString();                  //Display value from dât
                 txtEnglish_Like.Text = dt.Rows[0]["English"].ToString();
                 txtVNShort_Like.Text = dt.Rows[0]["VNShort"].ToString();
                 txtVNLong_Like.Text = dt.Rows[0]["VNLong"].ToString();
                pb_Like_Word.Image = Image.FromFile(dt.Rows[0]["ImgLocation"].ToString());
            }
            
        }

        
        private void btn_Lisen_Like_Click(object sender, EventArgs e)  //voice
        {
            SpVoice phatam = new SpVoice();
            phatam.Speak(txtEnglish_Like.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user2 = user;
            string sqlSEARCH = "SELECT *FROM UserLikeWord Where English=@english";
            SqlCommand cmd = new SqlCommand(sqlSEARCH, con);         
            cmd.Parameters.AddWithValue("English", txtEnglish_Like.Text);     //add  id which can reference to data           
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();                     //Read
            DataTable dt = new DataTable();
            dt.Load(dr);                                                //Load data in Table
            if (dt.Rows.Count > 0)
            {
                //statement add
                txtVNShort_Like.Text = dt.Rows[0]["VNShort"].ToString();  //display on the textbox
                txtVNLong_Like.Text = dt.Rows[0]["VNLong"].ToString();      
                txtID_Like.Text = dt.Rows[0]["id"].ToString();
                pb_Like_Word.Image = Image.FromFile(dt.Rows[0]["ImgLocation"].ToString());
            }
            else
            {
                MessageBox.Show("Không tìm thấy từ của bạn vừa nhập");
            }
        }




        private void btn_DeleteLikeWord_Click(object sender, EventArgs e) //delete
        {
            string user2 = user;
            string sqlDELETE = "DELETE FROM UserLikeWord Where id=@id ";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);          
            cmd.Parameters.AddWithValue("id", txtID_Like.Text);     //add  id which can reference to data           
            cmd.ExecuteNonQuery();
            Loaddata();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
