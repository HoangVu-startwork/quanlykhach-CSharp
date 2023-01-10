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
    public partial class QUANLYTHONGTINNHANPHONG : Form
    {
        // chuỗi kết nối 
        string strConnectionString = @"Data Source=DESKTOP-OPB6A1C\HOANG0903;Initial Catalog=QuanLyKhachSan12;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection conn = null;
        // đối tượng đưa dữ liệu vào DataTable dtTableName
        SqlDataAdapter daTableName = null;
        // Đối tượng hiển thị dữ liệu lên form
        DataTable dtTableName = null;
        public QUANLYTHONGTINNHANPHONG()
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
            daTableName = new SqlDataAdapter("select *from QUANLYTHONGTINNHANPHONG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
        private void HienThi()
        {
            string SqlSELECT = "Select *FROM QUANLYTHONGTINNHANPHONG";
            SqlCommand cmd = new SqlCommand(SqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        public void PHOMRONG()
        {
            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[3].Width = 76;
            dataGridView1.Columns[4].Width = 100;
        }
        private void QUANLYTHONGTINNHANPHONG_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            textBox_ID.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            textBox_IDKHACHHANG.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            textBox_TENKHACHHANG.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            textBox_GIONHAN.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
        }
        private void clearData()
        {
            textBox_ID.Text = "";
            textBox_IDKHACHHANG.Text = "";
            textBox_TENKHACHHANG.Text = "";
            textBox_GIONHAN.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
        }
        private void button_THEM_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối
            try
            {
                string sqlINSET = "INSERT INTO QUANLYTHONGTINNHANPHONG VALUES (@IDPhong, @IDkhachHang, @TENkhachhang, @gionhan, @Ngaynhan, @LoaiPhong)";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_ID.Text);
                cmd.Parameters.AddWithValue("@IDkhachHang", textBox_IDKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@TENkhachhang", textBox_TENKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@gionhan", textBox_GIONHAN.Text);
                cmd.Parameters.AddWithValue("@Ngaynhan", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox1.Text);
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

        private void button_SUA_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối
            try
            {
                string sqlINSET = "UPDATE QUANLYTHONGTINNHANPHONG SET  IDkhachHang = @IDkhachHang, TENkhachhang = @TENkhachhang, gionhan = @gionhan, Ngaynhan = @Ngaynhan, LoaiPhong= @LoaiPhong WHERE IDPhong = @IDPhong";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_ID.Text);
                cmd.Parameters.AddWithValue("@IDkhachHang", textBox_IDKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@TENkhachhang", textBox_TENKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@gionhan", textBox_GIONHAN.Text);
                cmd.Parameters.AddWithValue("@Ngaynhan", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox1.Text);
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

        private void button_XOA_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlDELETE = "DELETE from QUANLYTHONGTINNHANPHONG WHERE IDPhong = @IDPhong";
                SqlCommand cmd = new SqlCommand(sqlDELETE, conn);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_ID.Text);
                cmd.Parameters.AddWithValue("@IDkhachHang", textBox_IDKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@TENkhachhang", textBox_TENKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@gionhan", textBox_GIONHAN.Text);
                cmd.Parameters.AddWithValue("@Ngaynhan", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox1.Text);
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

        private void button_THOAT_Click(object sender, EventArgs e)
        {
            this.Hide();
            QUANLYPHONG qUANLYPHONG = new QUANLYPHONG();
            qUANLYPHONG.Show();
        }

        private void button_TIMKIEM_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from QUANLYTHONGTINNHANPHONG WHERE IDPhong = @IDPhong";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_CANTIM.Text);
                cmd.Parameters.AddWithValue("@IDkhachHang", textBox_IDKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@TENkhachhang", textBox_TENKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@gionhan", textBox_GIONHAN.Text);
                cmd.Parameters.AddWithValue("@Ngaynhan", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox1.Text);
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

        private void button_TIMKIEM2_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from QUANLYTHONGTINNHANPHONG WHERE IDkhachHang = @IDkhachHang";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_ID.Text);
                cmd.Parameters.AddWithValue("@IDkhachHang", textBox_CANTIM.Text);
                cmd.Parameters.AddWithValue("@TENkhachhang", textBox_TENKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@gionhan", textBox_GIONHAN.Text);
                cmd.Parameters.AddWithValue("@Ngaynhan", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox1.Text);
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
    }
}
