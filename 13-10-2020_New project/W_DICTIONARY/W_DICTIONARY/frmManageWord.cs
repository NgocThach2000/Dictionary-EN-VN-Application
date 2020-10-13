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
    public partial class frmManagerWord : Form
    {
        public frmManagerWord()
        {
            InitializeComponent();
            this.AcceptButton = btn_Manager_Search;
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
            gridItemData.Columns["idword"].Visible = false;                //hide column id;
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
            string sqlINSERT = "INSERT INTO ListWord VALUES (@english,@vnshort,@vnlong)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("English", txtEnglish_Manager.Text);  //statement add
            cmd.Parameters.AddWithValue("VNShort", txtVNShort_Manager.Text);
            cmd.Parameters.AddWithValue("VNLong", txtVNLong_Manager.Text);
            cmd.ExecuteNonQuery();              //Sql Client add
            Loaddata();      
        }

        private void btn_EditWord_Click(object sender, EventArgs e)
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
            con.Open();
            Loaddata();
        }
    }
}
