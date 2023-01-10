using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;
using Microsoft.Office.Interop;
using System.IO;
using System.Xml.XPath;
using System.Xml;

namespace quanlykhach
{
    public partial class BAOCAOTHONGKE : Form
    {
        // chuỗi kết nối 
        string strConnectionString = @"Data Source=DESKTOP-OPB6A1C\HOANG0903;Initial Catalog=QuanLyKhachSan12;Integrated Security=True";
        // đối tượng kết nối
        SqlConnection conn = null;
        // đối tượng đưa dữ liệu vào DataTable dtTableName
        SqlDataAdapter daTableName = null;
        // Đối tượng hiển thị dữ liệu lên form
        DataTable dtTableName = null;
        public BAOCAOTHONGKE()
        {
            InitializeComponent();
            LoadData();
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
        private void BAOCAOTHONGKE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSan12DataSet3.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter1.Fill(this.quanLyKhachSan12DataSet3.NHANVIEN);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CustomerDetail";

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "output";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }
       
        private void button_SE_Click(object sender, EventArgs e)
        {
            


        }

        private void button_SE_SystemColorsChanged(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            QUANLYPHONG qUANLYPHONG = new QUANLYPHONG();
            qUANLYPHONG.Show();
        }
        private void clearData()
        {
            tb_mucluong.Text = "";
        }
            private void btn_timkiem_Click(object sender, EventArgs e)
        {
            conn.Open(); // mở kết nối


            try
            {
                string sqlTimKiem = "SELECT *from NHANVIEN WHERE Luong = @Luong";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@Luong", tb_mucluong.Text);
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
