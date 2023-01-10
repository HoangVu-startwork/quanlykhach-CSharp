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
    public partial class HOIVIEN : Form
    {
        string strConnectionString = @"Data Source=DESKTOP-OPB6A1C\HOANG0903;Initial Catalog=QuanLyKhachSan12;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection conn = null;
        // đối tượng đưa dữ liệu vào DataTable dtTableName
        SqlDataAdapter daTableName = null;
        // Đối tượng hiển thị dữ liệu lên form
        DataTable dtTableName = null;
        public HOIVIEN()
        {
            InitializeComponent();
            LoadData();
            PHOMRONG();
            listItem = new List<Food>()
            {
                new Food(){ Name = "Không Hội Viên",Price = 0},
                new Food(){ Name = "Thẻ Bạc", Price = 10},
                new Food(){ Name = "Thẻ Vàng", Price = 20},
                new Food(){ Name = "Thẻ Kim Cương", Price = 35},
                new Food(){ Name = "Thẻ Đen", Price = 50}
            };
            comboBox_loaihoivien.DataSource = listItem;
            comboBox_loaihoivien.DisplayMember = "Name";
            AddBinding();
        }

        List<Food> listItem;

        private void LoadData()
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTableName
            daTableName = new SqlDataAdapter("select *from HOIVIEN", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
        void AddBinding()
        {
            tb_phantramgiam.DataBindings.Add(new Binding("Text", comboBox_loaihoivien.DataSource, "Price"));
        }
        public class Food
        {
            public string Name { get; set; }
            public float Price { get; set; }
        }
        public void PHOMRONG()
        {
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 148;
            dataGridView1.Columns[2].Width = 95;
            dataGridView1.Columns[3].Width = 104;      
        }
        private void clearData()
        {
           
            tb_IDKHACHHANG.Text = "";
            tb_HOTEN.Text = "";
            comboBox_loaihoivien.Text = "";
            tb_phantramgiam.Text = "";
        }
        private void HOIVIEN_Load(object sender, EventArgs e)
        {

        }

        private void btn_THEM_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối
            try
            {
                string sqlINSET = "INSERT INTO HOIVIEN VALUES ( @IDKhachHang, @HoTen, @LoaiHoiVien, @PhanTramGiamGia)";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                
                cmd.Parameters.AddWithValue("@IDKhachHang", tb_IDKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@HoTen", tb_HOTEN.Text);
                cmd.Parameters.AddWithValue("@LoaiHoiVien", comboBox_loaihoivien.Text);
                cmd.Parameters.AddWithValue("@PhanTramGiamGia", tb_phantramgiam.Text);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
       
            tb_IDKHACHHANG.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            tb_HOTEN.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            comboBox_loaihoivien.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            tb_phantramgiam.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối
            try
            {
                string sqlINSET = "UPDATE HOIVIEN SET HoTen = @HoTen, LoaiHoiVien = @LoaiHoiVien, PhanTramGiamGia = @PhanTramGiamGia WHERE IDKhachHang = @IDKhachHang";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);                
                cmd.Parameters.AddWithValue("@IDKhachHang", tb_IDKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@HoTen", tb_HOTEN.Text);
                cmd.Parameters.AddWithValue("@LoaiHoiVien", comboBox_loaihoivien.Text);
                cmd.Parameters.AddWithValue("@PhanTramGiamGia", tb_phantramgiam.Text);
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
                string sqlDELETE = "DELETE from HOIVIEN WHERE IDKhachHang = @IDKhachHang";
                SqlCommand cmd = new SqlCommand(sqlDELETE, conn);
              
                cmd.Parameters.AddWithValue("@IDKhachHang", tb_IDKHACHHANG.Text);
                cmd.Parameters.AddWithValue("@HoTen", tb_HOTEN.Text);
                cmd.Parameters.AddWithValue("@LoaiHoiVien", comboBox_loaihoivien.Text);
                cmd.Parameters.AddWithValue("@PhanTramGiamGia", tb_phantramgiam.Text);
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

            private void btn_thoat_Click(object sender, EventArgs e)
            {
                this.Hide();
                QUANLYPHONG qUANLYPHONG = new QUANLYPHONG();
                qUANLYPHONG.Show();
            }

       

        private void btn_IDKH_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from HOIVIEN WHERE IDKhachHang = @IDKhachHang";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@IDKhachHang", tb_timkiem.Text);
                cmd.Parameters.AddWithValue("@HoTen", tb_HOTEN.Text);
                cmd.Parameters.AddWithValue("@LoaiHoiVien", comboBox_loaihoivien.Text);
                cmd.Parameters.AddWithValue("@PhanTramGiamGia", tb_phantramgiam.Text);
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