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
    public partial class NGUOIOCUNG : Form
    {
        string strConnectionString = @"Data Source=DESKTOP-OPB6A1C\HOANG0903;Initial Catalog=QuanLyKhachSan12;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection conn = null;
        // đối tượng đưa dữ liệu vào DataTable dtTableName
        SqlDataAdapter daTableName = null;
        // Đối tượng hiển thị dữ liệu lên form
        DataTable dtTableName = null;
        public NGUOIOCUNG()
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
            daTableName = new SqlDataAdapter("select *from NguoiOCung", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
        public void PHOMRONG()
        {
            dataGridView1.Columns[0].Width = 95;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 199;

        }
        private void clearData()
        {
            tb_IDKH.Text = "";
            tb_IDTP.Text = "";
            tb_nguoidicung.Text = "";
            tb_hoten.Text = "";
        }
            private void NGUOIOCUNG_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            tb_IDKH.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            tb_IDTP.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            tb_nguoidicung.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            tb_hoten.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlINSET = "INSERT INTO NguoiOCung VALUES (@ID, @IDBangThuePhong, @Songuoiocung, @TenNguoiOCung)";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", tb_IDKH.Text);
                cmd.Parameters.AddWithValue("@IDBangThuePhong", tb_IDTP.Text);
                cmd.Parameters.AddWithValue("@Songuoiocung", tb_nguoidicung.Text);
                cmd.Parameters.AddWithValue("@TenNguoiOCung", tb_hoten.Text);

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
                string sqlDELETE = "DELETE from NguoiOCung WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlDELETE, conn);
                cmd.Parameters.AddWithValue("@ID", tb_IDKH.Text);
                cmd.Parameters.AddWithValue("@IDBangThuePhong", tb_IDTP.Text);
                cmd.Parameters.AddWithValue("@Songuoiocung", tb_nguoidicung.Text);
                cmd.Parameters.AddWithValue("@TenNguoiOCung", tb_hoten.Text);
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối
            try
            {
                string sqlINSET = "UPDATE NguoiOCung SET IDBangThuePhong = @IDBangThuePhong, Songuoiocung = @Songuoiocung, TenNguoiOCung = @TenNguoiOCung WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", tb_IDKH.Text);
                cmd.Parameters.AddWithValue("@IDBangThuePhong", tb_IDTP.Text);
                cmd.Parameters.AddWithValue("@Songuoiocung", tb_nguoidicung.Text);
                cmd.Parameters.AddWithValue("@TenNguoiOCung", tb_hoten.Text);
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

        private void button_TIMKIEM_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from NguoiOCung WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", tb_timkiem.Text);
                cmd.Parameters.AddWithValue("@IDBangThuePhong", tb_IDTP.Text);
                cmd.Parameters.AddWithValue("@Songuoiocung", tb_nguoidicung.Text);
                cmd.Parameters.AddWithValue("@TenNguoiOCung", tb_hoten.Text);
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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            QUANLYPHONG qUANLYPHONG = new QUANLYPHONG();
            qUANLYPHONG.Show();
        }
    }
}
