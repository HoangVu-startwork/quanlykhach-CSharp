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
    public partial class QUANLYDANGKYTHUEPHONG : Form
    {
        // chuỗi kết nối 
        string strConnectionString = @"Data Source=DESKTOP-OPB6A1C\HOANG0903;Initial Catalog=QuanLyKhachSan12;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection conn = null;
        // đối tượng đưa dữ liệu vào DataTable dtTableName
        SqlDataAdapter daTableName = null;
        // Đối tượng hiển thị dữ liệu lên form
        DataTable dtTableName = null;
        public QUANLYDANGKYTHUEPHONG()
        {
            InitializeComponent();
            LoadData();
            PHOMRONG();
            listItem = new List<Food>()
            {
                new Food(){ Name = "Thường", Price = 500000},
                new Food(){ Name = "Tốt", Price = 750000},
                new Food(){ Name = "Đặt biệt", Price = 1200000},
                new Food(){ Name = "VIP", Price = 2000000}
            };
            comboBox_LOAIPHONG.DataSource = listItem;
            comboBox_LOAIPHONG.DisplayMember = "Name";
            AddBinding();
        }

        List<Food> listItem;
    
        private void LoadData()
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTableName
            daTableName = new SqlDataAdapter("select *from QUANLYDANGKYTHUEPHONG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
        private void HienThi()
        {
            string SqlSELECT = "Select *FROM QUANLYDANGKYTHUEPHONG";
            SqlCommand cmd = new SqlCommand(SqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        public void PHOMRONG()
        {
            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 92;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 220;
            dataGridView1.Columns[4].Width = 100;
        }
        void AddBinding()
        {
            textBox_GIAPHONG.DataBindings.Add(new Binding("Text", comboBox_LOAIPHONG.DataSource, "Price"));
        }
        public class Food
        {
            public string Name { get; set; }
            public float Price { get; set; }
        }
        private void clearData()
        {
            textBox_ID.Text = "";
            textBox_IDPHONG.Text = "";
            textBox_IDKHACHHANG.Text = "";
            textBox_TENKHACHHANG.Text = "";
            textBox_SOPHONG.Text = "";
            dateTimePicker_NGAYDATPHONG.Text = "";
            dateTimePicker_NGAYTRAPHONG.Text = "";
            comboBox_LOAIPHONG.Text = "";
            textBox_GIAPHONG.Text = "";
            textBox_TRATRUOC.Text = "";
        }
        private void QUANLYDANGKYTHUEPHONG_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối
            try
            {
                string sqlINSET = "INSERT INTO QUANLYDANGKYTHUEPHONG VALUES (@ID, @IDPhong, @IDKhachHang, @TenKhachHang, @SoPhong, @NgayDatPhong, @NgayTraPhong, @LoaiPhong, @Gia, @DacCoc)";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", textBox_ID.Text);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_IDPHONG.Text);
                cmd.Parameters.AddWithValue("@IDKhachHang", textBox_IDKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@TenKhachHang", textBox_TENKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@SoPhong", textBox_SOPHONG.Text);
                cmd.Parameters.AddWithValue("@NgayDatPhong", dateTimePicker_NGAYDATPHONG.Text);
                cmd.Parameters.AddWithValue("@NgayTraPhong", dateTimePicker_NGAYTRAPHONG.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox_LOAIPHONG.Text);
                cmd.Parameters.AddWithValue("@Gia", textBox_GIAPHONG.Text);
                cmd.Parameters.AddWithValue("@DacCoc", textBox_TRATRUOC.Text);
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
                string sqlINSET = "UPDATE QUANLYDANGKYTHUEPHONG SET IDPhong = @IDPhong, IDKhachHang = @IDKhachHang, TenKhachHang = @TenKhachHang, SoPhong = @SoPhong, NgayDatPhong= @NgayDatPhong, NgayTraPhong = @NgayTraPhong, LoaiPhong = @LoaiPhong, Gia=@Gia, DacCoc = @DacCoc WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", textBox_ID.Text);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_IDPHONG.Text);
                cmd.Parameters.AddWithValue("@IDKhachHang", textBox_IDKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@TenKhachHang", textBox_TENKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@SoPhong", textBox_SOPHONG.Text);
                cmd.Parameters.AddWithValue("@NgayDatPhong", dateTimePicker_NGAYDATPHONG.Text);
                cmd.Parameters.AddWithValue("@NgayTraPhong", dateTimePicker_NGAYTRAPHONG.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox_LOAIPHONG.Text);
                cmd.Parameters.AddWithValue("@Gia", textBox_GIAPHONG.Text);
                cmd.Parameters.AddWithValue("@DacCoc", textBox_TRATRUOC.Text);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            textBox_ID.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            textBox_IDPHONG.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            textBox_IDKHACHHANG.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            textBox_TENKHACHHANG.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            textBox_SOPHONG.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            dateTimePicker_NGAYDATPHONG.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            dateTimePicker_NGAYTRAPHONG.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            comboBox_LOAIPHONG.Text = dataGridView1.Rows[r].Cells[7].Value.ToString();
            textBox_GIAPHONG.Text = dataGridView1.Rows[r].Cells[8].Value.ToString();
            textBox_TRATRUOC.Text = dataGridView1.Rows[r].Cells[9].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlDELETE = "DELETE from QUANLYDANGKYTHUEPHONG WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlDELETE, conn);
                cmd.Parameters.AddWithValue("@ID", textBox_ID.Text);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_IDPHONG.Text);
                cmd.Parameters.AddWithValue("@IDKhachHang", textBox_IDKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@TenKhachHang", textBox_TENKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@SoPhong", textBox_SOPHONG.Text);
                cmd.Parameters.AddWithValue("@NgayDatPhong", dateTimePicker_NGAYDATPHONG.Text);
                cmd.Parameters.AddWithValue("@NgayTraPhong", dateTimePicker_NGAYTRAPHONG.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox_LOAIPHONG.Text);
                cmd.Parameters.AddWithValue("@Gia", textBox_GIAPHONG.Text);
                cmd.Parameters.AddWithValue("@DacCoc", textBox_TRATRUOC.Text);
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

        private void btn_ID_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from QUANLYDANGKYTHUEPHONG WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", tb_timkiem.Text);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_IDPHONG.Text);
                cmd.Parameters.AddWithValue("@IDKhachHang", textBox_IDKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@TenKhachHang", textBox_TENKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@SoPhong", textBox_SOPHONG.Text);
                cmd.Parameters.AddWithValue("@NgayDatPhong", dateTimePicker_NGAYDATPHONG.Text);
                cmd.Parameters.AddWithValue("@NgayTraPhong", dateTimePicker_NGAYTRAPHONG.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox_LOAIPHONG.Text);
                cmd.Parameters.AddWithValue("@Gia", textBox_GIAPHONG.Text);
                cmd.Parameters.AddWithValue("@DacCoc", textBox_TRATRUOC.Text);
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

        private void btn_IDPHONG_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from QUANLYDANGKYTHUEPHONG WHERE IDPhong = @IDPhong";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", textBox_ID.Text);
                cmd.Parameters.AddWithValue("@IDPhong", tb_timkiem.Text);
                cmd.Parameters.AddWithValue("@IDKhachHang", textBox_IDKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@TenKhachHang", textBox_TENKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@SoPhong", textBox_SOPHONG.Text);
                cmd.Parameters.AddWithValue("@NgayDatPhong", dateTimePicker_NGAYDATPHONG.Text);
                cmd.Parameters.AddWithValue("@NgayTraPhong", dateTimePicker_NGAYTRAPHONG.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox_LOAIPHONG.Text);
                cmd.Parameters.AddWithValue("@Gia", textBox_GIAPHONG.Text);
                cmd.Parameters.AddWithValue("@DacCoc", textBox_TRATRUOC.Text);
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

        private void btn_IDKHACHHANG_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from QUANLYDANGKYTHUEPHONG WHERE IDKhachHang = @IDKhachHang";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", textBox_ID.Text);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_IDPHONG.Text);
                cmd.Parameters.AddWithValue("@IDKhachHang", tb_timkiem.Text);
                cmd.Parameters.AddWithValue("@TenKhachHang", textBox_TENKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@SoPhong", textBox_SOPHONG.Text);
                cmd.Parameters.AddWithValue("@NgayDatPhong", dateTimePicker_NGAYDATPHONG.Text);
                cmd.Parameters.AddWithValue("@NgayTraPhong", dateTimePicker_NGAYTRAPHONG.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox_LOAIPHONG.Text);
                cmd.Parameters.AddWithValue("@Gia", textBox_GIAPHONG.Text);
                cmd.Parameters.AddWithValue("@DacCoc", textBox_TRATRUOC.Text);
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
