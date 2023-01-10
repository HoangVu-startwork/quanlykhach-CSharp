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
    public partial class CAMNHATTAIKHOAN : Form
    {
        // chuỗi kết nối 
        string strConnectionString = @"Data Source=DESKTOP-OPB6A1C\HOANG0903;Initial Catalog=QuanLyKhachSan12;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection conn = null;
        // đối tượng đưa dữ liệu vào DataTable dtTableName
        SqlDataAdapter daTableName = null;
        // Đối tượng hiển thị dữ liệu lên form
        DataTable dtTableName = null;
        public CAMNHATTAIKHOAN()
        {
            InitializeComponent();
            LoadData();
            PHOMRONG();
        }
        private void LoadData()
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTableName
            daTableName = new SqlDataAdapter("select *from DANGNHAP", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
        public void PHOMRONG()
        {
            dataGridView1.Columns[0].Width = 140;
            dataGridView1.Columns[1].Width = 140;
        }
        private void clearData()
        {
            tb_taikhoang.Text = "";
            tb_matkhau.Text = "";
        }
            private void CAMNHATTAIKHOAN_Load(object sender, EventArgs e)
        {

        }

        private void btn_dk_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlINSET = "INSERT INTO DANGNHAP VALUES (@Dangnhap, @MatKhau)";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@Dangnhap", tb_taikhoang.Text);
                cmd.Parameters.AddWithValue("@MatKhau", tb_matkhau.Text);
                
                cmd.Connection = conn;
                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();
                LoadData();
                clearData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi !");
            }
            conn.Close(); // đóng kết nối
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlDELETE = "DELETE from DANGNHAP WHERE Dangnhap = @Dangnhap";
                SqlCommand cmd = new SqlCommand(sqlDELETE, conn);
                cmd.Parameters.AddWithValue("@Dangnhap", tb_taikhoang.Text);
                cmd.Parameters.AddWithValue("@MatKhau", tb_matkhau.Text);
                cmd.Connection = conn;



                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();


                LoadData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được, Lỗi rồi !");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            tb_taikhoang.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            tb_matkhau.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            QUANLYPHONG qUANLYPHONG = new QUANLYPHONG();
            qUANLYPHONG.Show();
        }
    }
    }

