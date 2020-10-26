﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace W_DICTIONARY
{
    public partial class frmManagerWord : Form
    {
        public frmManagerWord()
        {
            InitializeComponent();
           
        }

        SqlConnection con= new SqlConnection(@"Data Source=.;Initial Catalog=Dictionary;Integrated Security=True");
    
        public void  Loaddata()
        {
            
            string SqlSelect = "SELECT * FROM ListWord ";
            SqlCommand cmd = new SqlCommand(SqlSelect, con);    
            SqlDataReader dr = cmd.ExecuteReader();                     //Read
            DataTable dt = new DataTable();                         
            dt.Load(dr);                                                //Load data in Table
            gridItemData.DataSource = dt;                               //Display Data in Datagird View
            //hide column id;
        }

        private void setValue(int index)        //display values when you hover to listview
        {
            try
            {
                //tao mot datagridview
                DataGridViewRow row = gridItemData.Rows[index];
                //truyen nguoc gia tri tu datagridview len text boxa
                txt_id_Manager.Text = row.Cells[0].Value.ToString();
                txtEnglish_Manager.Text = row.Cells[1].Value.ToString();
                txtVNShort_Manager.Text = row.Cells[2].Value.ToString();
                txtVNLong_Manager.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_AddWord_Click(object sender, EventArgs e)   //ADD WORD to Data
        {
            
            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation,FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            string sqlINSERT = "INSERT INTO ListWord VALUES (@english,@vnshort,@vnlong,@images,@imglocation)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("English", txtEnglish_Manager.Text);  //statement add
            cmd.Parameters.AddWithValue("VNShort", txtVNShort_Manager.Text);
            cmd.Parameters.AddWithValue("VNLong", txtVNLong_Manager.Text);
            cmd.Parameters.AddWithValue("@images", images);
            cmd.Parameters.AddWithValue("@imglocation", imgLocation);     //display img from Location
            cmd.ExecuteNonQuery();              //Sql Client add
            Loaddata();      
        }

        private void btn_EditWord_Click(object sender, EventArgs e)  //EDIT WORD in Data
        {
            string sqlEDIT = "UPDATE ListWord SET English=@english,VNShort=@vnshort,VNlong=@vnlong where idword=@idword";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("idword", txt_id_Manager.Text);     //add  id which can reference to data
            cmd.Parameters.AddWithValue("English", txtEnglish_Manager.Text);  //statement add
            cmd.Parameters.AddWithValue("VNShort", txtVNShort_Manager.Text);
            cmd.Parameters.AddWithValue("VNLong", txtVNLong_Manager.Text);
            cmd.ExecuteNonQuery();              //Sql Client add
            Loaddata();
        }

        private void btn_DeleteWord_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM ListWord where idword=@idword";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("idword", txt_id_Manager.Text);     //add  id which can reference to data
            cmd.Parameters.AddWithValue("English", txtEnglish_Manager.Text);  //statement add
            cmd.Parameters.AddWithValue("VNShort", txtVNShort_Manager.Text);
            cmd.Parameters.AddWithValue("VNLong", txtVNLong_Manager.Text);
            cmd.ExecuteNonQuery();              //Sql Client add
            Loaddata();
        }

        private void btn_Manager_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSEARCH = "SELECT *FROM ListWord Where English=@english  ";
                SqlCommand cmd = new SqlCommand(sqlSEARCH, con);

                cmd.Parameters.AddWithValue("English", txt_id_search.Text); //add  id which can reference to data          
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();                     //Read
                DataTable dt = new DataTable();
                dt.Load(dr);                                                //Load data in Table
                if (dt.Rows.Count > 0)
                {
                    gridItemData.DataSource = dt;                               //display only data that you search in dât gridview
                    pictureBox1.Image = Image.FromFile(dt.Rows[0]["ImgLocation"].ToString());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy từ bạn muốn tìm kiếm!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi!");
            }

        }


        private void gridItemData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            setValue(e.RowIndex); //when you hover to data , it will show in textbox

        }


        private void btn_Back_Click(object sender, EventArgs e)  //back
        {
            Loaddata();
        }

        private void frmManagerWord_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dictionaryDataSet1.ListWord' table. You can move, or remove it, as needed.
            this.listWordTableAdapter1.Fill(this.dictionaryDataSet1.ListWord);
            // TODO: This line of code loads data into the 'dictionaryDataSet.ListWord' table. You can move, or remove it, as needed.
            this.listWordTableAdapter.Fill(this.dictionaryDataSet.ListWord);

            con.Open();
            Loaddata();
        }

        private void btn_Reput_Click(object sender, EventArgs e)  //Reput
        {
            txtEnglish_Manager.Clear();
            txtVNShort_Manager.Clear();
            txtVNLong_Manager.Clear();
        }

        string imgLocation = "";
        private void btn_Browse_Image_Click(object sender, EventArgs e)  //browse image from your PC
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
            

        }
    }
}
