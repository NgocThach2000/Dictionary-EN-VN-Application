using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using SpeechLib;

namespace DoAnTuDienAV
{
    public partial class FrmMainApp : Form
    {
        public FrmMainApp()
        {
            InitializeComponent();
            
        }
        private void FrmMainApp_Load(object sender, EventArgs e)
        {
            LoaddataListBoxData();
        }

        private void LoaddataListBoxData()
        {
            try
            {
                
                //Lay cac Item co trong database ra
                DataTable ds = SqlHelper.SqlHelper.ExecuteDataset(SQLstring.strCon,"TuDien_Select").Tables[0];
                //Đổ Item ra ListBox
                lbItem.DataSource = ds;
                lbItem.DisplayMember = "English"; //Cho hiển thị cột English
                lbItem.ValueMember = "ID";//Giá trị theo cột English

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btTraTu_Click(object sender, EventArgs e)
        {
            try
            {
                string eng = txtEnglish2.Text.Trim();
                //Giá trị tìm được sẽ chứa trong 1 Table tạm để đưa ra textbox
                DataTable ds = SqlHelper.SqlHelper.ExecuteDataset(SQLstring.strCon, "TuDien_TraTu",eng).Tables[0];
                //Kiểm tra có tồn tại trong cơ sở dữ liệu không?
                if(ds.Rows.Count>0)
                {
                    txtVN2.Text = ds.Rows[0]["ShortVN"].ToString();
                    txtVNDetail.Text = ds.Rows[0]["VN"].ToString();
                    
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

        private void lbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string temp = lbItem.Text; //biến temp tạm chứa giá trị của Item người dùng đang click vào
                //giá trị ở đây không phải từ englissh mà là ID theo từ english đó
                //tạo một Store Procedure để bắt nó ra
                DataTable ds = SqlHelper.SqlHelper.ExecuteDataset(SQLstring.strCon, "TuDien_TraTu", temp).Tables[0];
                //Tryền giá trị mà người dùng click vào textboxx
                txtEnglish2.Text = lbItem.Text;
                if(ds.Rows.Count>0)
                {
                    txtVN2.Text = ds.Rows[0]["ShortVN"].ToString();
                    txtVNDetail.Text = ds.Rows[0]["VN"].ToString();
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
            phatam.Speak(txtEnglish2.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void txtVNDetail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
