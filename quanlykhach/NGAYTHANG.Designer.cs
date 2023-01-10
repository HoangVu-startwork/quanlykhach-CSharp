
namespace quanlykhach
{
    partial class NGAYTHANG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_TIMKIEM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.quanLyKhachSan12DataSet4 = new quanlykhach.QuanLyKhachSan12DataSet4();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new quanlykhach.QuanLyKhachSan12DataSet4TableAdapters.HoaDonTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNhanvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDQUANLYDANGKYTHUEPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDatPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiHoiVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sophongthueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayThueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dichVuThemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanTramGiamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienCocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSan12DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDPhongDataGridViewTextBoxColumn,
            this.iDNhanvienDataGridViewTextBoxColumn,
            this.iDKhachHangDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.iDQUANLYDANGKYTHUEPHONGDataGridViewTextBoxColumn,
            this.ngayDatPhongDataGridViewTextBoxColumn,
            this.ngayTraPhongDataGridViewTextBoxColumn,
            this.loaiPhongDataGridViewTextBoxColumn,
            this.loaiHoiVienDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.sophongthueDataGridViewTextBoxColumn,
            this.soNgayThueDataGridViewTextBoxColumn,
            this.dichVuThemDataGridViewTextBoxColumn,
            this.phanTramGiamDataGridViewTextBoxColumn,
            this.tienCocDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hoaDonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1293, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(491, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN PHÒNG";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(545, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // button_TIMKIEM
            // 
            this.button_TIMKIEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_TIMKIEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TIMKIEM.Location = new System.Drawing.Point(741, 32);
            this.button_TIMKIEM.Name = "button_TIMKIEM";
            this.button_TIMKIEM.Size = new System.Drawing.Size(128, 23);
            this.button_TIMKIEM.TabIndex = 3;
            this.button_TIMKIEM.Text = "TÌM KIẾM";
            this.button_TIMKIEM.UseVisualStyleBackColor = false;
            this.button_TIMKIEM.Click += new System.EventHandler(this.button_TIMKIEM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "TÌM KIẾM :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(545, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "IN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // quanLyKhachSan12DataSet4
            // 
            this.quanLyKhachSan12DataSet4.DataSetName = "QuanLyKhachSan12DataSet4";
            this.quanLyKhachSan12DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.quanLyKhachSan12DataSet4;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 45;
            // 
            // iDPhongDataGridViewTextBoxColumn
            // 
            this.iDPhongDataGridViewTextBoxColumn.DataPropertyName = "IDPhong";
            this.iDPhongDataGridViewTextBoxColumn.HeaderText = "IDPhong";
            this.iDPhongDataGridViewTextBoxColumn.Name = "iDPhongDataGridViewTextBoxColumn";
            this.iDPhongDataGridViewTextBoxColumn.Width = 55;
            // 
            // iDNhanvienDataGridViewTextBoxColumn
            // 
            this.iDNhanvienDataGridViewTextBoxColumn.DataPropertyName = "IDNhanvien";
            this.iDNhanvienDataGridViewTextBoxColumn.HeaderText = "IDNhanvien";
            this.iDNhanvienDataGridViewTextBoxColumn.Name = "iDNhanvienDataGridViewTextBoxColumn";
            this.iDNhanvienDataGridViewTextBoxColumn.Width = 85;
            // 
            // iDKhachHangDataGridViewTextBoxColumn
            // 
            this.iDKhachHangDataGridViewTextBoxColumn.DataPropertyName = "IDKhachHang";
            this.iDKhachHangDataGridViewTextBoxColumn.HeaderText = "IDKhachHang";
            this.iDKhachHangDataGridViewTextBoxColumn.Name = "iDKhachHangDataGridViewTextBoxColumn";
            this.iDKhachHangDataGridViewTextBoxColumn.Width = 90;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // iDQUANLYDANGKYTHUEPHONGDataGridViewTextBoxColumn
            // 
            this.iDQUANLYDANGKYTHUEPHONGDataGridViewTextBoxColumn.DataPropertyName = "IDQUANLYDANGKYTHUEPHONG";
            this.iDQUANLYDANGKYTHUEPHONGDataGridViewTextBoxColumn.HeaderText = "IDQUANLYDANGKYTHUEPHONG";
            this.iDQUANLYDANGKYTHUEPHONGDataGridViewTextBoxColumn.Name = "iDQUANLYDANGKYTHUEPHONGDataGridViewTextBoxColumn";
            // 
            // ngayDatPhongDataGridViewTextBoxColumn
            // 
            this.ngayDatPhongDataGridViewTextBoxColumn.DataPropertyName = "NgayDatPhong";
            this.ngayDatPhongDataGridViewTextBoxColumn.HeaderText = "NgayDatPhong";
            this.ngayDatPhongDataGridViewTextBoxColumn.Name = "ngayDatPhongDataGridViewTextBoxColumn";
            this.ngayDatPhongDataGridViewTextBoxColumn.Width = 90;
            // 
            // ngayTraPhongDataGridViewTextBoxColumn
            // 
            this.ngayTraPhongDataGridViewTextBoxColumn.DataPropertyName = "NgayTraPhong";
            this.ngayTraPhongDataGridViewTextBoxColumn.HeaderText = "NgayTraPhong";
            this.ngayTraPhongDataGridViewTextBoxColumn.Name = "ngayTraPhongDataGridViewTextBoxColumn";
            this.ngayTraPhongDataGridViewTextBoxColumn.Width = 90;
            // 
            // loaiPhongDataGridViewTextBoxColumn
            // 
            this.loaiPhongDataGridViewTextBoxColumn.DataPropertyName = "LoaiPhong";
            this.loaiPhongDataGridViewTextBoxColumn.HeaderText = "LoaiPhong";
            this.loaiPhongDataGridViewTextBoxColumn.Name = "loaiPhongDataGridViewTextBoxColumn";
            this.loaiPhongDataGridViewTextBoxColumn.Width = 70;
            // 
            // loaiHoiVienDataGridViewTextBoxColumn
            // 
            this.loaiHoiVienDataGridViewTextBoxColumn.DataPropertyName = "LoaiHoiVien";
            this.loaiHoiVienDataGridViewTextBoxColumn.HeaderText = "LoaiHoiVien";
            this.loaiHoiVienDataGridViewTextBoxColumn.Name = "loaiHoiVienDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // sophongthueDataGridViewTextBoxColumn
            // 
            this.sophongthueDataGridViewTextBoxColumn.DataPropertyName = "sophongthue";
            this.sophongthueDataGridViewTextBoxColumn.HeaderText = "sophongthue";
            this.sophongthueDataGridViewTextBoxColumn.Name = "sophongthueDataGridViewTextBoxColumn";
            // 
            // soNgayThueDataGridViewTextBoxColumn
            // 
            this.soNgayThueDataGridViewTextBoxColumn.DataPropertyName = "SoNgayThue";
            this.soNgayThueDataGridViewTextBoxColumn.HeaderText = "SoNgayThue";
            this.soNgayThueDataGridViewTextBoxColumn.Name = "soNgayThueDataGridViewTextBoxColumn";
            // 
            // dichVuThemDataGridViewTextBoxColumn
            // 
            this.dichVuThemDataGridViewTextBoxColumn.DataPropertyName = "DichVuThem";
            this.dichVuThemDataGridViewTextBoxColumn.HeaderText = "DichVuThem";
            this.dichVuThemDataGridViewTextBoxColumn.Name = "dichVuThemDataGridViewTextBoxColumn";
            // 
            // phanTramGiamDataGridViewTextBoxColumn
            // 
            this.phanTramGiamDataGridViewTextBoxColumn.DataPropertyName = "PhanTramGiam";
            this.phanTramGiamDataGridViewTextBoxColumn.HeaderText = "PhanTramGiam";
            this.phanTramGiamDataGridViewTextBoxColumn.Name = "phanTramGiamDataGridViewTextBoxColumn";
            // 
            // tienCocDataGridViewTextBoxColumn
            // 
            this.tienCocDataGridViewTextBoxColumn.DataPropertyName = "TienCoc";
            this.tienCocDataGridViewTextBoxColumn.HeaderText = "TienCoc";
            this.tienCocDataGridViewTextBoxColumn.Name = "tienCocDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Yellow;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(1173, 74);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(111, 33);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_TIMKIEM);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 110);
            this.panel1.TabIndex = 7;
            // 
            // NGAYTHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1298, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NGAYTHANG";
            this.Text = "NGAYTHANG";
            this.Load += new System.EventHandler(this.NGAYTHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSan12DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_TIMKIEM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private QuanLyKhachSan12DataSet4 quanLyKhachSan12DataSet4;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QuanLyKhachSan12DataSet4TableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNhanvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDQUANLYDANGKYTHUEPHONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDatPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiHoiVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sophongthueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayThueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dichVuThemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanTramGiamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienCocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Panel panel1;
    }
}