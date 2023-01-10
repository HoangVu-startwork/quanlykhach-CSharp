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
    public partial class QUANLYPHONG2 : Form
    {
        // chuỗi kết nối 
        string strConnectionString = @"Data Source=DESKTOP-OPB6A1C\HOANG0903;Initial Catalog=QuanLyKhachSan7;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection conn = null;
        // đối tượng đưa dữ liệu vào DataTable dtTableName
        SqlDataAdapter daTableName = null;
        // Đối tượng hiển thị dữ liệu lên form
        DataTable dtTableName = null;

        public QUANLYPHONG2()
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
            comboBox1.DataSource = listItem;
            comboBox1.DisplayMember = "Name";
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
        private void HienThi()
        {
            string SqlSELECT = "Select *FROM Phong";
            SqlCommand cmd = new SqlCommand(SqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void QUANLYPHONG2_Load(object sender, EventArgs e)
        {
                    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void AddBinding()
        {
            textBox_giaphong.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "Price"));
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public class Food
        {
            public string Name { get; set; }
            public float Price { get; set; }
        }
        private void clearData()
        {
            tb_ID.Text = "";
            tb_Tenphong.Text = "";
            comboBox1.Text = "";
            tb_tinhtrangphong.Text = "";
            tb_roll.Text = "";
            tb_sogiuong.Text = "";
            tb_songuoitoida.Text = "";
            textBox_giaphong.Text = "";
            tb_tienphucvu.Text = "";

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            tb_ID.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            tb_Tenphong.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            tb_tinhtrangphong.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            tb_roll.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            tb_sogiuong.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            tb_songuoitoida.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            textBox_giaphong.Text = dataGridView1.Rows[r].Cells[7].Value.ToString();
            tb_tienphucvu.Text = dataGridView1.Rows[r].Cells[8].Value.ToString();
            
        }

         private void btn_them_Click(object sender, EventArgs e)
         {
            conn.Open(); // mở kết nối

            try
            {

                string sqlINSET = "INSERT INTO Phong VALUES (@ID, @Ten, @LoaiPhong, @TinhTrang, @Roll, @SoGiuong, @SoNguoiToiDa, @Gia, @TienPhucVu)";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@Ten", tb_Tenphong.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox1.Text);
                cmd.Parameters.AddWithValue("@TinhTrang", tb_tinhtrangphong.Text);
                cmd.Parameters.AddWithValue("@Roll", tb_roll.Text);
                cmd.Parameters.AddWithValue("@SoGiuong", tb_sogiuong.Text);
                cmd.Parameters.AddWithValue("@SoNguoiToiDa", tb_songuoitoida.Text);
                cmd.Parameters.AddWithValue("@Gia", textBox_giaphong.Text);
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlINSET = "UPDATE Phong SET Ten = @Ten, LoaiPhong = @LoaiPhong, TinhTrang = @TinhTrang, Roll = @Roll, SoGiuong = @SoGiuong, SoNguoiToiDa = @SoNguoiToiDa, TienPhucVu= @TienPhucVu WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@Ten", tb_Tenphong.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox1.Text);
                cmd.Parameters.AddWithValue("@TinhTrang", tb_tinhtrangphong.Text);
                cmd.Parameters.AddWithValue("@Roll", tb_roll.Text);
                cmd.Parameters.AddWithValue("@SoGiuong", tb_sogiuong.Text);
                cmd.Parameters.AddWithValue("@SoNguoiToiDa", tb_songuoitoida.Text);
                cmd.Parameters.AddWithValue("@Gia", textBox_giaphong.Text);
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

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from Phong WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", tb_camtim.Text);
                cmd.Parameters.AddWithValue("@Ten", tb_Tenphong.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox1.Text);
                cmd.Parameters.AddWithValue("@TinhTrang", tb_tinhtrangphong.Text);
                cmd.Parameters.AddWithValue("@Roll", tb_roll.Text);
                cmd.Parameters.AddWithValue("@SoGiuong", tb_sogiuong.Text);
                cmd.Parameters.AddWithValue("@SoNguoiToiDa", tb_songuoitoida.Text);
                cmd.Parameters.AddWithValue("@Gia", textBox_giaphong.Text);
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlDELETE = "DELETE from Phong WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlDELETE, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@Ten", tb_Tenphong.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox1.Text);
                cmd.Parameters.AddWithValue("@TinhTrang", tb_tinhtrangphong.Text);
                cmd.Parameters.AddWithValue("@Roll", tb_roll.Text);
                cmd.Parameters.AddWithValue("@SoGiuong", tb_sogiuong.Text);
                cmd.Parameters.AddWithValue("@SoNguoiToiDa", tb_songuoitoida.Text);
                cmd.Parameters.AddWithValue("@Gia", textBox_giaphong.Text);
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

        private void btn_thoat(object sender, EventArgs e)
        {
            this.Hide();
            QUANLYPHONG qUANLYPHONG = new QUANLYPHONG();
            qUANLYPHONG.Show();
        }
    }
}
