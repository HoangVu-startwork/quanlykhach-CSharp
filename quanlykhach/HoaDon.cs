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
    public partial class HoaDon : Form
    {
        // chuỗi kết nối 
        string strConnectionString = @"Data Source=DESKTOP-OPB6A1C\HOANG0903;Initial Catalog=QuanLyKhachSan12;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection conn = null;
        // đối tượng đưa dữ liệu vào DataTable dtTableName
        SqlDataAdapter daTableName = null;
        // Đối tượng hiển thị dữ liệu lên form
        DataTable dtTableName = null;
        public HoaDon()
        {
            InitializeComponent();
            LoadData();
            PHOMRONG();
            LoadData1();
            PHOMROM1();
            LoadData2();
            PHOMROM4();
            LoadData3();
            hinh();          
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
            listItem = new List<Food>()
            {
                new Food(){ Name = "Không Hội Viên",Price = 0},
                new Food(){ Name = "Thẻ Bạc", Price = 10},
                new Food(){ Name = "Thẻ Vàng", Price = 20},
                new Food(){ Name = "Thẻ Kim Cương", Price = 35},
                new Food(){ Name = "Thẻ Đen", Price = 50}
            };
            comboBox_LOAIHOIVIEN.DataSource = listItem;
            comboBox_LOAIHOIVIEN.DisplayMember = "Name";
            AddBinding1();
        }

        List<Food> listItem;
        private void LoadData1()
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTableName
            daTableName = new SqlDataAdapter("select *from KhachHang", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView2.DataSource = dtTableName;
        }
        private void LoadData()
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTableName
            daTableName = new SqlDataAdapter("select *from HoaDon", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView1.DataSource = dtTableName;
        }
        private void LoadData2()
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTableName
            daTableName = new SqlDataAdapter("select *from QUANLYDANGKYTHUEPHONG", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView3.DataSource = dtTableName;
        }
        private void LoadData3()
        {
            // Khởi động kết nối
            conn = new SqlConnection(strConnectionString);
            // Vận chuyển dữ liệu lên DataTable dtTableName
            daTableName = new SqlDataAdapter("select *from HOIVIEN", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView4.DataSource = dtTableName;
        }
        void AddBinding()
        {
            tb_giaphong.DataBindings.Add(new Binding("Text", comboBox_LOAIPHONG.DataSource, "Price"));
        }
        void AddBinding1()
        {
            tb_giamphantrm.DataBindings.Add(new Binding("Text", comboBox_LOAIHOIVIEN.DataSource, "Price"));
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public class Food
        {
            public string Name { get; set; }
            public float Price { get; set; }
        }
        public void PHOMRONG()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 55;
            dataGridView1.Columns[2].Width = 68;
            dataGridView1.Columns[3].Width = 78;
            dataGridView1.Columns[4].Width = 155;
            dataGridView1.Columns[5].Width = 85;
            dataGridView1.Columns[6].Width = 85;
            dataGridView1.Columns[7].Width = 85;
            dataGridView1.Columns[8].Width = 76;
            dataGridView1.Columns[9].Width = 83;
            dataGridView1.Columns[10].Width = 85;
            dataGridView1.Columns[11].Width = 80;
            dataGridView1.Columns[12].Width = 80;
            dataGridView1.Columns[13].Width = 82;
            dataGridView1.Columns[14].Width = 85;
            dataGridView1.Columns[15].Width = 90;
        }
        public void PHOMROM1()
        {
            dataGridView2.Columns[0].Width = 50;
            dataGridView2.Columns[1].Width = 110;
            dataGridView2.Columns[2].Width = 60;
            dataGridView2.Columns[3].Width = 60;
        }
        public void PHOMROM4()
        {
            dataGridView3.Columns[0].Width = 70;
            dataGridView3.Columns[1].Width = 70;
            dataGridView3.Columns[2].Width = 100;
            dataGridView3.Columns[3].Width = 60;
        }
        public void hinh()
        {
            dataGridView4.Columns[0].Width = 110;
            dataGridView4.Columns[1].Width = 120;
            dataGridView4.Columns[2].Width = 121;
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {

        }

        private void textBox_songaythue_TextChanged(object sender, EventArgs e)
        {
        }
        private void btn_tinhtien_Click(object sender, EventArgs e)
        {
            double songaythue;
            int sophongthue = 0;
            double tongtien = 0;
            double giaphong = 0;
            int dichvuthem = 0;
            int tratruoc = 0;
            double hoivien = 0;            
            if (dateTimePicker1.Text == dateTimePicker2.Text)
                songaythue = 1;
            else
            {
                TimeSpan giatri = dateTimePicker2.Value - dateTimePicker1.Value;
                songaythue = Math.Round(giatri.TotalDays, 0);
                // songaythue = dateTimePicker2.Value - dateTimePicker1.Value;
                // textBox_songaythue.Text = Math.Round(songaythue.TotalDays, 0).ToString();
                //lb_ID.Text = Math.Round(songaythue.TotalDays, 0).ToString();            
            }            
            textBox_songaythue.Text = songaythue.ToString();
            if (comboBox_LOAIPHONG.Text == "Thường")
                giaphong = 500000;
            if (comboBox_LOAIPHONG.Text == "Tốt")
                giaphong = 750000;
            if (comboBox_LOAIPHONG.Text == "Đặt biệt")
                giaphong = 1200000;
            if (comboBox_LOAIPHONG.Text == "VIP")
                giaphong = 2000000;

            if (comboBox_LOAIHOIVIEN.Text == "Không Hội Viên")
                hoivien = 1;
            if (comboBox_LOAIHOIVIEN.Text == "Thẻ Bạc")
                hoivien = 0.1;
            if (comboBox_LOAIHOIVIEN.Text == "Thẻ Vàng")
                hoivien = 0.2;
            if (comboBox_LOAIHOIVIEN.Text == "Thẻ Kim Cương")
                hoivien = 0.35;
            if (comboBox_LOAIHOIVIEN.Text == "Thẻ Đen")
                hoivien = 0.5;

            int ID = 0;
            int khachhanh = 0;
            int tien = 0;
            int giamgia = 0;
            int IDBTP = 0;
            int songay = 0;

            ID = Convert.ToInt32(tb_ID.Text);
            lb_ID.Text = ID.ToString();

            khachhanh = Convert.ToInt32(tb_IDKH.Text);
            lb_idkh.Text = khachhanh.ToString();

            tien = Convert.ToInt32(tb_giaphong.Text);
            lb_GIAPHONG.Text = tien.ToString();

            giamgia = Convert.ToInt32(tb_giamphantrm.Text);
            lb_giamgia.Text = giamgia.ToString();
          
            IDBTP = Convert.ToInt32(tb_IDBDKTP.Text);
            lb_IDDKTP.Text = IDBTP.ToString();

            songay = Convert.ToInt32(textBox_songaythue.Text);
            lb_songaythue.Text = songay.ToString();
                  
            sophongthue = Convert.ToInt32(tb_sophongthue.Text);
            lb_sophongthue.Text = sophongthue.ToString();
            dichvuthem = Convert.ToInt32(tb_dichvu.Text);
            lb_dichvuthem.Text = dichvuthem.ToString();
            tratruoc = Convert.ToInt32(tb_tiencoc.Text);
            lb_tiencoc.Text = tratruoc.ToString();
            tongtien = ((giaphong * songaythue * sophongthue) + dichvuthem) * hoivien - tratruoc;
            MessageBox.Show("ID : " + tb_ID.Text +               
                "\n Khách hàng : " + tb_hoten.Text +
                "\n Ngày đặt : " + dateTimePicker1.Text +
                "\n Ngày trả : " + dateTimePicker2.Text +
                "\n Loại phòng : " + comboBox_LOAIPHONG.Text +
                "\n Loại hội viện : " + comboBox_LOAIHOIVIEN.Text +
                "\n Gía phòng : " + tb_giaphong.Text +
                "\n Giảm giá % : " + tb_giamphantrm.Text + 
                "\n Tiền dịch vụ : " + tb_dichvu.Text + 
                "\n Số ngày ở : " + songaythue.ToString() +
                "\n Tổng tiền là : " + tongtien.ToString(), DateTime.Now.ToShortDateString());
            tb_tongtien.Text = tongtien.ToString();
            lb_tien.Text = tongtien.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }
        private void clearData()
        {
            tb_ID.Text = "";
            tb_IDPHONG.Text = "";
            tb_IDNV.Text = "";
            tb_IDKH.Text = "";
            tb_hoten.Text = "";
            tb_IDBDKTP.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            comboBox_LOAIPHONG.Text = "";
            comboBox_LOAIHOIVIEN.Text = "";
            tb_giaphong.Text = "";
            tb_sophongthue.Text = "";
            textBox_songaythue.Text = "";
            tb_dichvu.Text = "";
            tb_giamphantrm.Text = "";
            tb_tiencoc.Text = "";
            tb_tongtien.Text = "";          
        }
        private void bt_thu_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from KhachHang WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", textBox_TIMKIEM.Text);
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

        private void button_TIMHV_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from HOIVIEN WHERE IDKhachHang = @IDKhachHang";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@IDKhachHang", textBox_TIMK.Text);

                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView4.DataSource = dt;


            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm được, Lỗi rồi !");
            }


            conn.Close(); // đóng kết nối
        }

        private void tb_timliembtp_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from QUANLYDANGKYTHUEPHONG WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@ID", textBox_tim.Text);

                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView3.DataSource = dt;


            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm được, Lỗi rồi !");
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            tb_ID.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            tb_IDPHONG.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            tb_IDNV.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            tb_IDKH.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            tb_hoten.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            tb_IDBDKTP.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[r].Cells[7].Value.ToString();
            comboBox_LOAIPHONG.Text = dataGridView1.Rows[r].Cells[8].Value.ToString();
            comboBox_LOAIHOIVIEN.Text = dataGridView1.Rows[r].Cells[9].Value.ToString();
            tb_giaphong.Text = dataGridView1.Rows[r].Cells[10].Value.ToString();
            tb_sophongthue.Text = dataGridView1.Rows[r].Cells[11].Value.ToString();
            textBox_songaythue.Text = dataGridView1.Rows[r].Cells[12].Value.ToString();
            tb_dichvu.Text = dataGridView1.Rows[r].Cells[13].Value.ToString();
            tb_giamphantrm.Text = dataGridView1.Rows[r].Cells[14].Value.ToString();
            tb_tiencoc.Text = dataGridView1.Rows[r].Cells[15].Value.ToString();
           tb_tongtien.Text = dataGridView1.Rows[r].Cells[16].Value.ToString();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlINSET = "INSERT INTO HoaDon VALUES (@ID, @IDPhong, @IDNhanvien, @IDKhachHang, @HoTen, @IDQUANLYDANGKYTHUEPHONG, @NgayDatPhong, @NgayTraPhong, @LoaiPhong, @LoaiHoiVien, @DonGia, @sophongthue, @SoNgayThue, @DichVuThem, @PhanTramGiam, @TienCoc, @TongTien)";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@IDPhong", tb_IDPHONG.Text);
                cmd.Parameters.AddWithValue("@IDNhanvien", tb_IDNV.Text);
                cmd.Parameters.AddWithValue("@IDKhachHang", tb_IDKH.Text);
                cmd.Parameters.AddWithValue("@HoTen", tb_hoten.Text);
                cmd.Parameters.AddWithValue("@IDQUANLYDANGKYTHUEPHONG", tb_IDBDKTP.Text);
                cmd.Parameters.AddWithValue("@NgayDatPhong", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@NgayTraPhong", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox_LOAIPHONG.Text);
                cmd.Parameters.AddWithValue("@LoaiHoiVien", comboBox_LOAIHOIVIEN.Text);
                cmd.Parameters.AddWithValue("@DonGia", tb_giaphong.Text);
                cmd.Parameters.AddWithValue("@sophongthue", tb_sophongthue.Text);
                cmd.Parameters.AddWithValue("@SoNgayThue", textBox_songaythue.Text);
                cmd.Parameters.AddWithValue("@DichVuThem", tb_dichvu.Text);
                cmd.Parameters.AddWithValue("@PhanTramGiam", tb_giamphantrm.Text);
                cmd.Parameters.AddWithValue("@TienCoc", tb_tiencoc.Text);
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

        private void button_SUA_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối
            try
            {
                string sqlINSET = "UPDATE HoaDon SET IDPhong = @IDPhong, IDNhanvien = @IDNhanvien, IDKhachHang = @IDKhachHang, HoTen = @HoTen, IDQUANLYDANGKYTHUEPHONG = @IDQUANLYDANGKYTHUEPHONG, NgayDatPhong = @NgayDatPhong, NgayTraPhong = @NgayTraPhong, LoaiPhong = @LoaiPhong, LoaiHoiVien = @LoaiHoiVien, DonGia = @DonGia, sophongthue = @sophongthue, SoNgayThue = @SoNgayThue, DichVuThem = @DichVuThem, PhanTramGiam = @PhanTramGiam, TienCoc = @TienCoc, TongTien = @TongTien WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(sqlINSET, conn);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@IDPhong", tb_IDPHONG.Text);
                cmd.Parameters.AddWithValue("@IDNhanvien", tb_IDNV.Text);
                cmd.Parameters.AddWithValue("@IDKhachHang", tb_IDKH.Text);
                cmd.Parameters.AddWithValue("@HoTen", tb_hoten.Text);
                cmd.Parameters.AddWithValue("@IDQUANLYDANGKYTHUEPHONG", tb_IDBDKTP.Text);
                cmd.Parameters.AddWithValue("@NgayDatPhong", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@NgayTraPhong", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@LoaiPhong", comboBox_LOAIPHONG.Text);
                cmd.Parameters.AddWithValue("@LoaiHoiVien", comboBox_LOAIHOIVIEN.Text);
                cmd.Parameters.AddWithValue("@DonGia", tb_giaphong.Text);
                cmd.Parameters.AddWithValue("@sophongthue", tb_sophongthue.Text);
                cmd.Parameters.AddWithValue("@SoNgayThue", textBox_songaythue.Text);
                cmd.Parameters.AddWithValue("@DichVuThem", tb_dichvu.Text);
                cmd.Parameters.AddWithValue("@PhanTramGiam", tb_giamphantrm.Text);
                cmd.Parameters.AddWithValue("@TienCoc", tb_tiencoc.Text);
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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            QUANLYPHONG qUANLYPHONG = new QUANLYPHONG();
            qUANLYPHONG.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView3.CurrentCell.RowIndex;
            tb_IDBDKTP.Text = dataGridView3.Rows[r].Cells[0].Value.ToString();
            tb_IDPHONG.Text = dataGridView3.Rows[r].Cells[1].Value.ToString();
            tb_IDKH.Text = dataGridView3.Rows[r].Cells[2].Value.ToString();
            tb_hoten.Text = dataGridView3.Rows[r].Cells[3].Value.ToString();
            tb_sophongthue.Text = dataGridView3.Rows[r].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView3.Rows[r].Cells[5].Value.ToString();
            dateTimePicker2.Text = dataGridView3.Rows[r].Cells[6].Value.ToString();
            comboBox_LOAIPHONG.Text = dataGridView3.Rows[r].Cells[7].Value.ToString();
            tb_giaphong.Text = dataGridView3.Rows[r].Cells[8].Value.ToString();
            tb_tiencoc.Text = dataGridView3.Rows[r].Cells[9].Value.ToString();
        }

        // private void button_IN_Click(object sender, EventArgs e)
        //  {
        //     Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
        //   Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
        //     Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
        //     worksheet = workbook.Sheets["Sheet1"];
        //     worksheet = workbook.ActiveSheet;
        //     worksheet.Name = "CustomerDetail";

        //    for (int i = 1; i < dataGridView1.Columns.Count+1; i++)
        //    {
        //       worksheet.Cells[1,i] = dataGridView1.Columns[i - 1].HeaderText;

        //            }
        //          for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //        {
        //          for (int j = 0; j < dataGridView1.Columns.Count; j++)
        //        {
        //          worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
        //            }
        //      }

        //    var saveFileDialoge = new SaveFileDialog();
        //  saveFileDialoge.FileName = "output";
        //         saveFileDialoge.DefaultExt = ".xlsx";
        //        if (saveFileDialoge.ShowDialog()==DialogResult.OK)
        //      {
        //         workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing);

        //    }
        //   app.Quit();
    }
    }

