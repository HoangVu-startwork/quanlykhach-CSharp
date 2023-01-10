
namespace quanlykhach
{
    partial class BAOCAOTHONGKE
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
            this.btnExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.quanLyKhachSan12DataSet = new quanlykhach.QuanLyKhachSan12DataSet();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new quanlykhach.QuanLyKhachSan12DataSetTableAdapters.HoaDonTableAdapter();
            this.quanLyKhachSan12DataSet1 = new quanlykhach.QuanLyKhachSan12DataSet1();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new quanlykhach.QuanLyKhachSan12DataSet1TableAdapters.NHANVIENTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.quanLyKhachSan12DataSet2 = new quanlykhach.QuanLyKhachSan12DataSet2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hovsTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBoPhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLamViecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tangLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHANVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhachSan12DataSet3 = new quanlykhach.QuanLyKhachSan12DataSet3();
            this.nHANVIENTableAdapter1 = new quanlykhach.QuanLyKhachSan12DataSet3TableAdapters.NHANVIENTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mucluong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSan12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSan12DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSan12DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSan12DataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Lime;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(419, 95);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(302, 35);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "IN";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // quanLyKhachSan12DataSet
            // 
            this.quanLyKhachSan12DataSet.DataSetName = "QuanLyKhachSan12DataSet";
            this.quanLyKhachSan12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.quanLyKhachSan12DataSet;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyKhachSan12DataSet1
            // 
            this.quanLyKhachSan12DataSet1.DataSetName = "QuanLyKhachSan12DataSet1";
            this.quanLyKhachSan12DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.quanLyKhachSan12DataSet1;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(328, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "BÁO CÁO THỐNG KÊ DANH SÁCH VÀ TIỀN LƯƠNG NHÂN VIÊN\r\n";
            // 
            // quanLyKhachSan12DataSet2
            // 
            this.quanLyKhachSan12DataSet2.DataSetName = "QuanLyKhachSan12DataSet2";
            this.quanLyKhachSan12DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.hovsTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.tenBoPhanDataGridViewTextBoxColumn,
            this.ngayLamViecDataGridViewTextBoxColumn,
            this.luongDataGridViewTextBoxColumn,
            this.tangLuongDataGridViewTextBoxColumn,
            this.troCapDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nHANVIENBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1245, 231);
            this.dataGridView1.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // hovsTenDataGridViewTextBoxColumn
            // 
            this.hovsTenDataGridViewTextBoxColumn.DataPropertyName = "HovsTen";
            this.hovsTenDataGridViewTextBoxColumn.HeaderText = "HovsTen";
            this.hovsTenDataGridViewTextBoxColumn.Name = "hovsTenDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // tenBoPhanDataGridViewTextBoxColumn
            // 
            this.tenBoPhanDataGridViewTextBoxColumn.DataPropertyName = "TenBoPhan";
            this.tenBoPhanDataGridViewTextBoxColumn.HeaderText = "TenBoPhan";
            this.tenBoPhanDataGridViewTextBoxColumn.Name = "tenBoPhanDataGridViewTextBoxColumn";
            // 
            // ngayLamViecDataGridViewTextBoxColumn
            // 
            this.ngayLamViecDataGridViewTextBoxColumn.DataPropertyName = "NgayLamViec";
            this.ngayLamViecDataGridViewTextBoxColumn.HeaderText = "NgayLamViec";
            this.ngayLamViecDataGridViewTextBoxColumn.Name = "ngayLamViecDataGridViewTextBoxColumn";
            // 
            // luongDataGridViewTextBoxColumn
            // 
            this.luongDataGridViewTextBoxColumn.DataPropertyName = "Luong";
            this.luongDataGridViewTextBoxColumn.HeaderText = "Luong";
            this.luongDataGridViewTextBoxColumn.Name = "luongDataGridViewTextBoxColumn";
            // 
            // tangLuongDataGridViewTextBoxColumn
            // 
            this.tangLuongDataGridViewTextBoxColumn.DataPropertyName = "TangLuong";
            this.tangLuongDataGridViewTextBoxColumn.HeaderText = "TangLuong";
            this.tangLuongDataGridViewTextBoxColumn.Name = "tangLuongDataGridViewTextBoxColumn";
            // 
            // troCapDataGridViewTextBoxColumn
            // 
            this.troCapDataGridViewTextBoxColumn.DataPropertyName = "TroCap";
            this.troCapDataGridViewTextBoxColumn.HeaderText = "TroCap";
            this.troCapDataGridViewTextBoxColumn.Name = "troCapDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // nHANVIENBindingSource1
            // 
            this.nHANVIENBindingSource1.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource1.DataSource = this.quanLyKhachSan12DataSet3;
            // 
            // quanLyKhachSan12DataSet3
            // 
            this.quanLyKhachSan12DataSet3.DataSetName = "QuanLyKhachSan12DataSet3";
            this.quanLyKhachSan12DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENTableAdapter1
            // 
            this.nHANVIENTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.tb_mucluong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_timkiem);
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 133);
            this.panel1.TabIndex = 4;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.White;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(1122, 95);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(107, 35);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.White;
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(722, 45);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(117, 26);
            this.btn_timkiem.TabIndex = 4;
            this.btn_timkiem.Text = "TÌM KIẾM";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "TÌM KIẾM MỨC LƯƠNG";
            // 
            // tb_mucluong
            // 
            this.tb_mucluong.Location = new System.Drawing.Point(493, 47);
            this.tb_mucluong.Name = "tb_mucluong";
            this.tb_mucluong.Size = new System.Drawing.Size(179, 20);
            this.tb_mucluong.TabIndex = 6;
            // 
            // BAOCAOTHONGKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1247, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MinimizeBox = false;
            this.Name = "BAOCAOTHONGKE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAOCAOTHONGKE";
            this.Load += new System.EventHandler(this.BAOCAOTHONGKE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSan12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSan12DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSan12DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSan12DataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private QuanLyKhachSan12DataSet quanLyKhachSan12DataSet;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QuanLyKhachSan12DataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private QuanLyKhachSan12DataSet1 quanLyKhachSan12DataSet1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QuanLyKhachSan12DataSet1TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.Label label1;
        private QuanLyKhachSan12DataSet2 quanLyKhachSan12DataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyKhachSan12DataSet3 quanLyKhachSan12DataSet3;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource1;
        private QuanLyKhachSan12DataSet3TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovsTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBoPhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLamViecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tangLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox tb_mucluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_timkiem;
    }
}