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

namespace quanlykhach
{
    public partial class QUANLYPHONG : Form
    {
        public QUANLYPHONG()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void tabPagequanlyphong_Click(object sender, EventArgs e)
        {


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QUANLYPHONG_Load(object sender, EventArgs e)
        {

        }
        private void customizeDesign()
        {
            panel_courseSubmenu.Visible = false;
            panel_quanlykhach.Visible = false;
            panel_quanlynhansu.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panel_courseSubmenu.Visible == true)
                panel_courseSubmenu.Visible = false;
            if (panel_quanlykhach.Visible == true)
                panel_quanlykhach.Visible = false;
            if (panel_quanlynhansu.Visible == true)
                panel_quanlynhansu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button_quanlyphong_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_courseSubmenu);
        }

        private void button_quanlyphong1_Click(object sender, EventArgs e)
        {
            this.Hide();
            COSOVATCHAT cOSOVATCHAT = new COSOVATCHAT();
            cOSOVATCHAT.Show();
        }

        private void button_quanlythuephong_Click(object sender, EventArgs e)
        {
            this.Hide();
            QUANLYDANGKYTHUEPHONG qUANLYDANGKYTHUEPHONG = new QUANLYDANGKYTHUEPHONG();
            qUANLYDANGKYTHUEPHONG.Show();
        }

        private void buttoncosovatchat_Click(object sender, EventArgs e)
        {
            this.Hide();
            QUANLYTHONGTINNHANPHONG qUANLYTHONGTINNHANPHONG = new QUANLYTHONGTINNHANPHONG();
            qUANLYTHONGTINNHANPHONG.Show();
        }

        private void button_loaiphong_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_quanlykhach_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_quanlykhach);
        }

        private void button_quankykhachhang_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            this.Hide();
            KHACHHANG kHACHHANG = new KHACHHANG();
            kHACHHANG.Show();

        }

        private void button_hoivien_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_capnhathoivien_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            this.Hide();
            HOIVIEN hOIVIEN = new HOIVIEN();
            hOIVIEN.Show();
        }

        private void button_Nguoiocung_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            this.Hide();
            NGUOIOCUNG nGUOIOCUNG = new NGUOIOCUNG();
            nGUOIOCUNG.Show();
        }

        private void button_quanlynhansu_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_quanlynhansu);
        }

        private void button_nhanvien_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            this.Hide();
            NHANVIEN nHANVIEN = new NHANVIEN();
            nHANVIEN.Show();
        }

        private void button_bangluong_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_baocaothongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            BAOCAOTHONGKE bAOCAOTHONGKE = new BAOCAOTHONGKE();
            bAOCAOTHONGKE.Show();
        }

        private void button_doimatkhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            LUONGPHONG lUONGPHONG = new LUONGPHONG();
            lUONGPHONG.Show();
        }

        private void button_HOADON_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon hoaDon = new HoaDon();
            hoaDon.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_tinhtien_Click(object sender, EventArgs e)
        {
            this.Hide();
            NGAYTHANG nGAYTHANG= new NGAYTHANG();
            nGAYTHANG.Show();
        }

        private void button_Camnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            CAMNHATTAIKHOAN cAMNHATTAIKHOAN = new CAMNHATTAIKHOAN();
            cAMNHATTAIKHOAN.Show();
        }
    }
}

