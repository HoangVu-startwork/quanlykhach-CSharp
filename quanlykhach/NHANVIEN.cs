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
    public partial class NHANVIEN : Form
    {
        string strConnectionString = @"Data Source=DESKTOP-OPB6A1C\HOANG0903;Initial Catalog=QuanLyKhachSan12;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection conn = null;
        // đối tượng đưa dữ liệu vào DataTable dtTableName
        SqlDataAdapter daTableName = null;
        // Đối tượng hiển thị dữ liệu lên form
        DataTable dtTableName = null;
        public NHANVIEN()
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
            daTableName = new SqlDataAdapter("select *from NHANVIEN", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
        public void PHOMRONG()
        {
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 85;
            dataGridView1.Columns[3].Width = 85;
            dataGridView1.Columns[4].Width = 138;
            dataGridView1.Columns[5].Width = 79;
            dataGridView1.Columns[6].Width = 120;
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[8].Width = 80;
            dataGridView1.Columns[9].Width = 90;
        }
        private void HienThi()
        {
            string SqlSELECT = "Select *FROM NHANVIEN";
            SqlCommand cmd = new SqlCommand(SqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void clearData()
        {
            tb_ID.Text = "";
            tb_hoten.Text = "";
            dateTimePicker_ngaysinh.Text = "";
            comboBox_gioitinh.Text = "";           
            tb_diachi.Text = "";
            tb_sdt.Text = "";
            tb_tenbophan.Text = "";
            dateTimePicker_ngaylam.Text = "";
            tb_luongthang.Text = "";
            comboBox1.Text = "";
            tb_trocap.Text = "";
            tb_tongtien.Text = "";
        }
        private void NHANVIEN_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            tb_ID.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            tb_hoten.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            dateTimePicker_ngaysinh.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();      
            comboBox_gioitinh.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            tb_diachi.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            tb_sdt.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            tb_tenbophan.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            dateTimePicker_ngaylam.Text = dataGridView1.Rows[r].Cells[7].Value.ToString();
            tb_luongthang.Text = dataGridView1.Rows[r].Cells[8].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[r].Cells[9].Value.ToString();
            tb_trocap.Text = dataGridView1.Rows[r].Cells[10].Value.ToString();
            tb_tongtien.Text = dataGridView1.Rows[r].Cells[11].Value.ToString();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            QUANLYPHONG qUANLYPHONG = new QUANLYPHONG();
            qUANLYPHONG.Show();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlINSET = "INSERT INTO NHANVIEN VALUES (@ID, @HovsTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @TenBoPhan, @NgayLamViec, @Luong, @TangLuong, @TroCap, @TongTien)";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@HovsTen", tb_hoten.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker_ngaysinh.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", comboBox_gioitinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", tb_diachi.Text);
                cmd.Parameters.AddWithValue("@SDT", tb_sdt.Text);
                cmd.Parameters.AddWithValue("@TenBoPhan", tb_tenbophan.Text);
                cmd.Parameters.AddWithValue("@NgayLamViec", dateTimePicker_ngaylam.Text);
                cmd.Parameters.AddWithValue("@Luong", tb_luongthang.Text);
                cmd.Parameters.AddWithValue("@TangLuong", comboBox1.Text);
                cmd.Parameters.AddWithValue("@TroCap", tb_trocap.Text);
                cmd.Parameters.AddWithValue("@TongTien", tb_tongtien.Text);
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
                string sqlDELETE = "DELETE from NHANVIEN WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlDELETE, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@HovsTen", tb_hoten.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker_ngaysinh.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", comboBox_gioitinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", tb_diachi.Text);
                cmd.Parameters.AddWithValue("@SDT", tb_sdt.Text);
                cmd.Parameters.AddWithValue("@TenBoPhan", tb_tenbophan.Text);
                cmd.Parameters.AddWithValue("@NgayLamViec", dateTimePicker_ngaylam.Text);
                cmd.Parameters.AddWithValue("@Luong", tb_luongthang.Text);
                cmd.Parameters.AddWithValue("@TangLuong", comboBox1.Text);
                cmd.Parameters.AddWithValue("@TroCap", tb_trocap.Text);
                cmd.Parameters.AddWithValue("@TongTien", tb_tongtien.Text);
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối
            try
            {
                string sqlINSET = "UPDATE NHANVIEN SET HovsTen = @HovsTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi= @DiaChi, SDT = @SDT, TenBoPhan = @TenBoPhan, NgayLamViec = @NgayLamViec, Luong = @Luong, TangLuong = @TangLuong, TroCap = @TroCap, TongTien = @TongTien WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@HovsTen", tb_hoten.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker_ngaysinh.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", comboBox_gioitinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", tb_diachi.Text);
                cmd.Parameters.AddWithValue("@SDT", tb_sdt.Text);
                cmd.Parameters.AddWithValue("@TenBoPhan", tb_tenbophan.Text);
                cmd.Parameters.AddWithValue("@NgayLamViec", dateTimePicker_ngaylam.Text);
                cmd.Parameters.AddWithValue("@Luong", tb_luongthang.Text);
                cmd.Parameters.AddWithValue("@TangLuong", comboBox1.Text);
                cmd.Parameters.AddWithValue("@TroCap", tb_trocap.Text);
                cmd.Parameters.AddWithValue("@TongTien", tb_tongtien.Text);
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
                string sqlTimKiem = "SELECT *from NHANVIEN WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", tb_timkiem.Text);
                cmd.Parameters.AddWithValue("@HovsTen", tb_hoten.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker_ngaysinh.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", comboBox_gioitinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", tb_diachi.Text);
                cmd.Parameters.AddWithValue("@SDT", tb_sdt.Text);
                cmd.Parameters.AddWithValue("@TenBoPhan", tb_tenbophan.Text);
                cmd.Parameters.AddWithValue("@NgayLamViec", dateTimePicker_ngaylam.Text);
                cmd.Parameters.AddWithValue("@Luong", tb_luongthang.Text);
                cmd.Parameters.AddWithValue("@TangLuong", comboBox1.Text);
                cmd.Parameters.AddWithValue("@TroCap", tb_trocap.Text);
                cmd.Parameters.AddWithValue("@TongTien", tb_tongtien.Text);
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

        private void btn_tinhtien_Click(object sender, EventArgs e)
        {
            int luongthang = 0;
            int trocap = 0;
            double tongtien = 0;
            double phantram = 0;

            if (comboBox1.Text == "0")
                phantram = 1;
            if (comboBox1.Text == "10")
                phantram = 0.1;
            if (comboBox1.Text == "20")
                phantram = 0.2;
            if (comboBox1.Text == "30")
                phantram = 0.3;
            if (comboBox1.Text == "40")
                phantram = 0.4;
            if (comboBox1.Text == "50")
                phantram = 0.5;
            if (comboBox1.Text == "60")
                phantram = 0.6;
            if (comboBox1.Text == "70")
                phantram = 0.7;
            if (comboBox1.Text == "80")
                phantram = 0.8;
            if (comboBox1.Text == "90")
                phantram = 0.9;
            if (comboBox1.Text == "100")
                phantram = 2;


            luongthang = Convert.ToInt32(tb_luongthang.Text);
            trocap = Convert.ToInt32(tb_trocap.Text);
            tongtien = (luongthang * phantram)+ luongthang + trocap;
            MessageBox.Show(" ID : " + tb_ID.Text +
                "\n  HỌ TÊN : " + tb_hoten.Text +
                "\n Lương Tháng : " + tb_luongthang.Text +
                "\n Phần Trăm tăng lương % : " + comboBox1.Text +  
                "\n Trợ Cấp : " + tb_trocap.Text +
                "\n tổng tiền là : " + tongtien.ToString(), DateTime.Now.ToShortDateString());
            tb_tongtien.Text = tongtien.ToString();
        }
    }
}
