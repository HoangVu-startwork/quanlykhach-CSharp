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

namespace quanlykhach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OPB6A1C\HOANG0903;Initial Catalog=QuanLyKhachSan12;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txbDangnhap.Text;
                string mk = txbPassword.Text;
                string sql = "select * from DANGNHAP where Dangnhap = '"+tk+"' and MatKhau = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql,con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {                    
                    this.Hide();
                    QUANLYPHONG qUANLYPHONG = new QUANLYPHONG();
                    qUANLYPHONG.Show();
                }
                else
                {
                    MessageBox.Show("ĐĂNG NHẬP THẤT BẠI");
                }               
            }           
            catch (Exception ex)
            {
                MessageBox.Show("LỖI KẾT NỐI");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
