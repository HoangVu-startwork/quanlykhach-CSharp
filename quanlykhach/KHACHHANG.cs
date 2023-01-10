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
    public partial class KHACHHANG : Form
    {
        // chuỗi kết nối 
        string strConnectionString = @"Data Source=DESKTOP-OPB6A1C\HOANG0903;Initial Catalog=QuanLyKhachSan12;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection conn = null;
        // đối tượng đưa dữ liệu vào DataTable dtTableName
        SqlDataAdapter daTableName = null;
        // Đối tượng hiển thị dữ liệu lên form
        DataTable dtTableName = null;
        public KHACHHANG()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTableName
            daTableName = new SqlDataAdapter("select *from KhachHang", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
        private void HienThi()
        {
            string SqlSELECT = "Select *FROM KhachHang";
            SqlCommand cmd = new SqlCommand(SqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void KHACHHANG_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            tb_ID.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            tb_hoten.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            tb_ngaysinh.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            comboBox_gioitinh.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            tb_email.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            tb_sdt.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            tb_CMND.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            tb_Quoctich.Text = dataGridView1.Rows[r].Cells[7].Value.ToString();
         
        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {

        }
        private void clearData()
        {
            tb_ID.Text = "";
            tb_hoten.Text = "";
            tb_ngaysinh.Text = "";
            comboBox_gioitinh.Text = "";
            tb_email.Text = "";
            tb_sdt.Text = "";
            tb_CMND.Text = "";
            tb_Quoctich.Text = "";            
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối

            try
            {

                string sqlINSET = "INSERT INTO KhachHang VALUES (@ID, @Ten, @NgaySinh, @GioiTinh, @Email, @SDT, @CMND, @QuocTich)";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@Ten", tb_hoten.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", tb_ngaysinh.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", comboBox_gioitinh.Text);
                cmd.Parameters.AddWithValue("@Email", tb_email.Text);
                cmd.Parameters.AddWithValue("@SDT", tb_sdt.Text);
                cmd.Parameters.AddWithValue("@CMND", tb_CMND.Text);
                cmd.Parameters.AddWithValue("@QuocTich", tb_Quoctich.Text);
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlINSET = "UPDATE KhachHang SET Ten = @Ten, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, Email = @Email, SDT = @SDT, CMND = @CMND, QuocTich = @QuocTich WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@Ten", tb_hoten.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", tb_ngaysinh.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", comboBox_gioitinh.Text);
                cmd.Parameters.AddWithValue("@Email", tb_email.Text);
                cmd.Parameters.AddWithValue("@SDT", tb_sdt.Text);
                cmd.Parameters.AddWithValue("@CMND", tb_CMND.Text);
                cmd.Parameters.AddWithValue("@QuocTich", tb_Quoctich.Text);
                cmd.Connection = conn;


                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();


                LoadData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không sửa được, Lỗi rồi !");
            }


            conn.Close(); // đóng kết nối
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlDELETE = "DELETE from KhachHang WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlDELETE, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@Ten", tb_hoten.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", tb_ngaysinh.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", comboBox_gioitinh.Text);
                cmd.Parameters.AddWithValue("@Email", tb_email.Text);
                cmd.Parameters.AddWithValue("@SDT", tb_sdt.Text);
                cmd.Parameters.AddWithValue("@CMND", tb_CMND.Text);
                cmd.Parameters.AddWithValue("@QuocTich", tb_Quoctich.Text);
                cmd.Connection = conn;


                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();


                LoadData();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được, Lỗi rồi !");
            }


            conn.Close(); // đóng kết nối
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            QUANLYPHONG qUANLYPHONG = new QUANLYPHONG();
            qUANLYPHONG.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from KhachHang WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@Ten", tb_hoten.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", tb_ngaysinh.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", comboBox_gioitinh.Text);
                cmd.Parameters.AddWithValue("@Email", tb_email.Text);
                cmd.Parameters.AddWithValue("@SDT", tb_sdt.Text);
                cmd.Parameters.AddWithValue("@CMND", tb_CMND.Text);
                cmd.Parameters.AddWithValue("@QuocTich", tb_Quoctich.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;


            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm được, Lỗi rồi !");
            }


            conn.Close(); // đóng kết nối
        }

        private void comboBox_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

