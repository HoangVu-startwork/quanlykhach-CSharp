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
    public partial class LUONGPHONG : Form
    {
        string strConnectionString = @"Data Source=DESKTOP-OPB6A1C\HOANG0903;Initial Catalog=QuanLyKhachSan12;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection conn = null;
        // đối tượng đưa dữ liệu vào DataTable dtTableName
        SqlDataAdapter daTableName = null;
        // Đối tượng hiển thị dữ liệu lên form
        DataTable dtTableName = null;
        public LUONGPHONG()
        {
            InitializeComponent();
            LoadData();


            listItem = new List<Food>()
            {
                new Food(){ Name = "Thường", Price = 500000},
                new Food(){ Name = "Tốt", Price = 750000},
                new Food(){ Name = "Đặt biệt", Price = 1200000},
                new Food(){ Name = "VIP", Price = 2000000}
            };
            tb_loaiphong.DataSource = listItem;
            tb_loaiphong.DisplayMember = "Name";
            AddBinding();
        }
        List<Food> listItem;
        void AddBinding()
        {
            tb_giaphong.DataBindings.Add(new Binding("Text", tb_loaiphong.DataSource, "Price"));
        }
        public class Food
        {
            public string Name { get; set; }
            public float Price { get; set; }
        }
        private void LoadData()
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTableName
            daTableName = new SqlDataAdapter("select *from LUONGPHONG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
        private void LUONGPHONG_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            tb_ID.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            tb_soluongphong.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            tb_loaiphong.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            tb_giaphong.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            tb_sogiuong.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
        }
        private void clearData()
        {
            tb_ID.Text = "";
            tb_soluongphong.Text = "";
            tb_loaiphong.Text = "";
            tb_giaphong.Text = "";
            tb_sogiuong.Text = "";
        }

        private void button_THEM_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối
            try
            {
                string sqlINSET = "INSERT INTO LUONGPHONG VALUES (@ID, @SOLUONGPHONG, @LOAIPHONG, @GIAPHONG, @SOGIUONG)";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@SOLUONGPHONG", tb_soluongphong.Text);
                cmd.Parameters.AddWithValue("@LOAIPHONG", tb_loaiphong.Text);
                cmd.Parameters.AddWithValue("@GIAPHONG", tb_giaphong.Text);
                cmd.Parameters.AddWithValue("@SOGIUONG", tb_sogiuong.Text);
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
                string sqlINSET = "UPDATE LUONGPHONG SET SOLUONGPHONG = @SOLUONGPHONG, LOAIPHONG = @LOAIPHONG, GIAPHONG = @GIAPHONG, SOGIUONG = @SOGIUONG WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@SOLUONGPHONG", tb_soluongphong.Text);
                cmd.Parameters.AddWithValue("@LOAIPHONG", tb_loaiphong.Text);
                cmd.Parameters.AddWithValue("@GIAPHONG", tb_giaphong.Text);
                cmd.Parameters.AddWithValue("@SOGIUONG", tb_sogiuong.Text);
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
                string sqlDELETE = "DELETE from LUONGPHONG WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlDELETE, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@SOLUONGPHONG", tb_soluongphong.Text);
                cmd.Parameters.AddWithValue("@LOAIPHONG", tb_loaiphong.Text);
                cmd.Parameters.AddWithValue("@GIAPHONG", tb_giaphong.Text);
                cmd.Parameters.AddWithValue("@SOGIUONG", tb_sogiuong.Text);
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

        private void button_tim_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from LUONGPHONG WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", tb_IDtimkiem.Text);
                cmd.Parameters.AddWithValue("@SOLUONGPHONG", tb_soluongphong.Text);
                cmd.Parameters.AddWithValue("@LOAIPHONG", tb_loaiphong.Text);
                cmd.Parameters.AddWithValue("@GIAPHONG", tb_giaphong.Text);
                cmd.Parameters.AddWithValue("@SOGIUONG", tb_sogiuong.Text);
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

        private void timkiem_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from LUONGPHONG WHERE SOGIUONG = @SOGIUONG";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@SOLUONGPHONG", tb_soluongphong.Text);
                cmd.Parameters.AddWithValue("@LOAIPHONG", tb_loaiphong.Text);
                cmd.Parameters.AddWithValue("@GIAPHONG", tb_giaphong.Text);
                cmd.Parameters.AddWithValue("@SOGIUONG", tb_timkiemloaiphong.Text);
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
