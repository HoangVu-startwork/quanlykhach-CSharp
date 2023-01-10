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

    public partial class COSOVATCHAT : Form
    {
        // chuỗi kết nối 
        string strConnectionString = @"Data Source=DESKTOP-OPB6A1C\HOANG0903;Initial Catalog=QuanLyKhachSan12;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection conn = null;
        // đối tượng đưa dữ liệu vào DataTable dtTableName
        SqlDataAdapter daTableName = null;
        // Đối tượng hiển thị dữ liệu lên form
        DataTable dtTableName = null;
        public COSOVATCHAT()
        {
            InitializeComponent();
            LoadData();
            LoadData1();
            PHOMRONG();
            PHOMRONG1();
            listItem = new List<Food>()
            {
                new Food(){ Name = "Thường", Price = 500000},
                new Food(){ Name = "Tốt", Price = 750000},
                new Food(){ Name = "Đặt biệt", Price = 1200000},
                new Food(){ Name = "VIP", Price = 2000000}
            };
            comboBox1_loaiphong.DataSource = listItem;
            comboBox1_loaiphong.DisplayMember = "Name";
            AddBinding();
        }

        List<Food> listItem;

        private void LoadData()
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTableName
            daTableName = new SqlDataAdapter("select *from Phong", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }

        
            void AddBinding()
        {
            tb_giaphong.DataBindings.Add(new Binding("Text", comboBox1_loaiphong.DataSource, "Price"));
        }
        public class Food
        {
            public string Name { get; set; }
            public float Price { get; set; }
        }
        private void LoadData1()
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTableName
            daTableName = new SqlDataAdapter("select *from COSOVATCHAT", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView2.DataSource = dtTableName;
        }
        private void HienThi()
        {
            string SqlSELECT = "Select *FROM Phong";
            SqlCommand cmd = new SqlCommand(SqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void HienThi1()
        {
            string SqlSELECT = "Select *FROM COSOVATCHAT";
            SqlCommand cmd = new SqlCommand(SqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void clearData()
        {
            tb_ID.Text = "";
            textBox_TINHTRANG.Text = "";
            tb_soluongphong.Text = "";
            comboBox1_loaiphong.Text = "";
            tb_sogiuong.Text = "";
            tb_songuoitoida.Text = "";
            tb_giaphong.Text = "";
            tb_tienphucvu.Text = "";
        }
        private void COSOVATCHAT_Load(object sender, EventArgs e)
        {

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối
            try
            {
                string sqlINSET = "INSERT INTO Phong VALUES (@ID, @TINHTRANGPHONG,@SoLau, @LoaiPhong, @SoGiuong, @SoNguoiToiDa, @Gia, @TienPhucVu)";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@TINHTRANGPHONG", textBox_TINHTRANG.Text);
                cmd.Parameters.AddWithValue("@SoLau", tb_soluongphong.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox1_loaiphong.Text);
                cmd.Parameters.AddWithValue("@SoGiuong", tb_sogiuong.Text);
                cmd.Parameters.AddWithValue("@SoNguoiToiDa", tb_songuoitoida.Text);
                cmd.Parameters.AddWithValue("@Gia", tb_giaphong.Text);
                cmd.Parameters.AddWithValue("@TienPhucVu", tb_tienphucvu.Text);
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
                string sqlINSET = "UPDATE Phong SET TINHTRANGPHONG = @TINHTRANGPHONG, SoLau = @SoLau, LoaiPhong = @LoaiPhong, SoGiuong = @SoGiuong, SoNguoiToiDa = @SoNguoiToiDa, Gia = @Gia, TienPhucVu= @TienPhucVu WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@TINHTRANGPHONG", textBox_TINHTRANG.Text);
                cmd.Parameters.AddWithValue("@SoLau", tb_soluongphong.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox1_loaiphong.Text);
                cmd.Parameters.AddWithValue("@SoGiuong", tb_sogiuong.Text);
                cmd.Parameters.AddWithValue("@SoNguoiToiDa", tb_songuoitoida.Text);
                cmd.Parameters.AddWithValue("@Gia", tb_giaphong.Text);
                cmd.Parameters.AddWithValue("@TienPhucVu", tb_tienphucvu.Text);
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
            tb_ID.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            textBox_TINHTRANG.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            tb_soluongphong.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            comboBox1_loaiphong.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            tb_sogiuong.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            tb_songuoitoida.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            tb_giaphong.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            tb_tienphucvu.Text = dataGridView1.Rows[r].Cells[7].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlDELETE = "DELETE from Phong WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlDELETE, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@TINHTRANGPHONG", textBox_TINHTRANG.Text);
                cmd.Parameters.AddWithValue("@SoLau", tb_soluongphong.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox1_loaiphong.Text);
                cmd.Parameters.AddWithValue("@SoGiuong", tb_sogiuong.Text);
                cmd.Parameters.AddWithValue("@SoNguoiToiDa", tb_songuoitoida.Text);
                cmd.Parameters.AddWithValue("@Gia", tb_giaphong.Text);
                cmd.Parameters.AddWithValue("@TienPhucVu", tb_tienphucvu.Text);
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

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from Phong WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", TB_Timkiem.Text);
                cmd.Parameters.AddWithValue("@TINHTRANGPHONG", textBox_TINHTRANG.Text);
                cmd.Parameters.AddWithValue("@SoLau", tb_soluongphong.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox1_loaiphong.Text);
                cmd.Parameters.AddWithValue("@SoGiuong", tb_sogiuong.Text);
                cmd.Parameters.AddWithValue("@SoNguoiToiDa", tb_songuoitoida.Text);
                cmd.Parameters.AddWithValue("@Gia", tb_giaphong.Text);
                cmd.Parameters.AddWithValue("@TienPhucVu", tb_tienphucvu.Text);
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


         public void PHOMRONG() 
         {
              dataGridView2.Columns[0].Width = 70;
            dataGridView2.Columns[1].Width = 70;
            dataGridView2.Columns[2].Width = 240;
            dataGridView2.Columns[3].Width = 70;
            dataGridView2.Columns[4].Width = 100;
         }
        public void PHOMRONG1()
        {
            dataGridView1.Columns[0].Width = 63;
            dataGridView1.Columns[1].Width = 63;
            dataGridView1.Columns[4].Width = 70;
        }
        private void clearData1()
        {
            textBox_ID.Text = "";
            textBox_IDPHONG.Text = "";
            textBox_TENTRANGTHIETBI.Text = "";
            textBox_SOLUONG.Text = "";
            textBox_GIA.Text = "";
        }
        private void button_THEM_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối
            try
            {
                string sqlINSET = "INSERT INTO COSOVATCHAT VALUES (@ID, @IDPhong, @Tentrangthietbi, @soluong, @GiaBoiThuong)";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", textBox_ID.Text);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_IDPHONG.Text);
                cmd.Parameters.AddWithValue("@Tentrangthietbi", textBox_TENTRANGTHIETBI.Text);
                cmd.Parameters.AddWithValue("@soluong", textBox_SOLUONG.Text);
                cmd.Parameters.AddWithValue("@GiaBoiThuong", textBox_GIA.Text);
                cmd.Connection = conn;
                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();
                LoadData1();
                clearData1();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi !");
            }
            conn.Close(); // đóng kết nối
        }

        private void button_SUA1_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối
            try
            {
                string sqlINSET = "UPDATE COSOVATCHAT SET IDPhong = @IDPhong, Tentrangthietbi = @Tentrangthietbi, soluong = @soluong, GiaBoiThuong = @GiaBoiThuong WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", textBox_ID.Text);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_IDPHONG.Text);
                cmd.Parameters.AddWithValue("@Tentrangthietbi", textBox_TENTRANGTHIETBI.Text);
                cmd.Parameters.AddWithValue("@soluong", textBox_SOLUONG.Text);
                cmd.Parameters.AddWithValue("@GiaBoiThuong", textBox_GIA.Text);
                cmd.Connection = conn;
                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();

                LoadData1();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không sửa được, Lỗi rồi !");
            }
            conn.Close(); // đóng kết nối
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView2.CurrentCell.RowIndex;
            textBox_ID.Text = dataGridView2.Rows[r].Cells[0].Value.ToString();
            textBox_IDPHONG.Text = dataGridView2.Rows[r].Cells[1].Value.ToString();
            textBox_TENTRANGTHIETBI.Text = dataGridView2.Rows[r].Cells[2].Value.ToString();
            textBox_SOLUONG.Text = dataGridView2.Rows[r].Cells[3].Value.ToString();
            textBox_GIA.Text = dataGridView2.Rows[r].Cells[4].Value.ToString();
        }

        private void button_XOA_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlDELETE = "DELETE from COSOVATCHAT WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlDELETE, conn);
                cmd.Parameters.AddWithValue("@ID", textBox_ID.Text);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_IDPHONG.Text);
                cmd.Parameters.AddWithValue("@Tentrangthietbi", textBox_TENTRANGTHIETBI.Text);
                cmd.Parameters.AddWithValue("@soluong", textBox_SOLUONG.Text);
                cmd.Parameters.AddWithValue("@GiaBoiThuong", textBox_GIA.Text);
                cmd.Connection = conn;



                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();


                LoadData1();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được, Lỗi rồi !");
            }


            conn.Close(); // đóng kết nối
        }

        private void button_TIMVATCHAT_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from COSOVATCHAT WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", textBox_IDVATCHAT.Text);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_IDPHONG.Text);
                cmd.Parameters.AddWithValue("@Tentrangthietbi", textBox_TENTRANGTHIETBI.Text);
                cmd.Parameters.AddWithValue("@soluong", textBox_SOLUONG.Text);
                cmd.Parameters.AddWithValue("@GiaBoiThuong", textBox_GIA.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;


            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm được, Lỗi rồi !");
            }


            conn.Close(); // đóng kết nối
        }

        private void button_TIMIDPHONG_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from COSOVATCHAT WHERE IDPhong = @IDPhong";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", textBox_ID.Text);
                cmd.Parameters.AddWithValue("@IDPhong", textBox_TIMIDPHONG.Text);
                cmd.Parameters.AddWithValue("@Tentrangthietbi", textBox_TENTRANGTHIETBI.Text);
                cmd.Parameters.AddWithValue("@soluong", textBox_SOLUONG.Text);
                cmd.Parameters.AddWithValue("@GiaBoiThuong", textBox_GIA.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;


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

        private void btn_tin_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from Phong WHERE SoGiuong = @SoGiuong";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@TINHTRANGPHONG", textBox_TINHTRANG.Text);
                cmd.Parameters.AddWithValue("@SoLau", tb_soluongphong.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox1_loaiphong.Text);
                cmd.Parameters.AddWithValue("@SoGiuong", tb_giuong.Text);
                cmd.Parameters.AddWithValue("@SoNguoiToiDa", tb_songuoitoida.Text);
                cmd.Parameters.AddWithValue("@Gia", tb_giaphong.Text);
                cmd.Parameters.AddWithValue("@TienPhucVu", tb_tienphucvu.Text);
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

