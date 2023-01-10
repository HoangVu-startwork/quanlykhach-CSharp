
namespace quanlykhach
{
    partial class HOIVIEN
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_THEM = new System.Windows.Forms.Button();
            this.btn_IDKH = new System.Windows.Forms.Button();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.comboBox_loaihoivien = new System.Windows.Forms.ComboBox();
            this.tb_phantramgiam = new System.Windows.Forms.TextBox();
            this.tb_HOTEN = new System.Windows.Forms.TextBox();
            this.tb_IDKHACHHANG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(478, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 480);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ HỘI VIỆN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.btn_THEM);
            this.panel1.Controls.Add(this.btn_IDKH);
            this.panel1.Controls.Add(this.tb_timkiem);
            this.panel1.Controls.Add(this.comboBox_loaihoivien);
            this.panel1.Controls.Add(this.tb_phantramgiam);
            this.panel1.Controls.Add(this.tb_HOTEN);
            this.panel1.Controls.Add(this.tb_IDKHACHHANG);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 479);
            this.panel1.TabIndex = 2;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_thoat.Location = new System.Drawing.Point(371, 430);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(88, 26);
            this.btn_thoat.TabIndex = 19;
            this.btn_thoat.Text = "THOÁT\r\n";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_xoa.Location = new System.Drawing.Point(256, 430);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(85, 26);
            this.btn_xoa.TabIndex = 18;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_sua.Location = new System.Drawing.Point(131, 430);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(86, 26);
            this.btn_sua.TabIndex = 17;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_THEM
            // 
            this.btn_THEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_THEM.Location = new System.Drawing.Point(12, 430);
            this.btn_THEM.Name = "btn_THEM";
            this.btn_THEM.Size = new System.Drawing.Size(89, 26);
            this.btn_THEM.TabIndex = 16;
            this.btn_THEM.Text = "THÊM";
            this.btn_THEM.UseVisualStyleBackColor = false;
            this.btn_THEM.Click += new System.EventHandler(this.btn_THEM_Click);
            // 
            // btn_IDKH
            // 
            this.btn_IDKH.Location = new System.Drawing.Point(30, 378);
            this.btn_IDKH.Name = "btn_IDKH";
            this.btn_IDKH.Size = new System.Drawing.Size(102, 26);
            this.btn_IDKH.TabIndex = 15;
            this.btn_IDKH.Text = "TÌM ID KH";
            this.btn_IDKH.UseVisualStyleBackColor = true;
            this.btn_IDKH.Click += new System.EventHandler(this.btn_IDKH_Click);
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(191, 378);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(186, 26);
            this.tb_timkiem.TabIndex = 13;
            // 
            // comboBox_loaihoivien
            // 
            this.comboBox_loaihoivien.FormattingEnabled = true;
            this.comboBox_loaihoivien.Location = new System.Drawing.Point(215, 221);
            this.comboBox_loaihoivien.Name = "comboBox_loaihoivien";
            this.comboBox_loaihoivien.Size = new System.Drawing.Size(162, 28);
            this.comboBox_loaihoivien.TabIndex = 12;
            // 
            // tb_phantramgiam
            // 
            this.tb_phantramgiam.Location = new System.Drawing.Point(215, 306);
            this.tb_phantramgiam.Name = "tb_phantramgiam";
            this.tb_phantramgiam.Size = new System.Drawing.Size(162, 26);
            this.tb_phantramgiam.TabIndex = 11;
            // 
            // tb_HOTEN
            // 
            this.tb_HOTEN.Location = new System.Drawing.Point(215, 143);
            this.tb_HOTEN.Name = "tb_HOTEN";
            this.tb_HOTEN.Size = new System.Drawing.Size(162, 26);
            this.tb_HOTEN.TabIndex = 10;
            // 
            // tb_IDKHACHHANG
            // 
            this.tb_IDKHACHHANG.Location = new System.Drawing.Point(215, 66);
            this.tb_IDKHACHHANG.Name = "tb_IDKHACHHANG";
            this.tb_IDKHACHHANG.Size = new System.Drawing.Size(162, 26);
            this.tb_IDKHACHHANG.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "PHẦN TRĂM GIẢM % :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "LOẠI HỘI VIỆN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "HỌ TÊN : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID KHÁCH HÀNG :";
            // 
            // HOIVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HOIVIEN";
            this.Text = "HOIVIEN";
            this.Load += new System.EventHandler(this.HOIVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_THEM;
        private System.Windows.Forms.Button btn_IDKH;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.ComboBox comboBox_loaihoivien;
        private System.Windows.Forms.TextBox tb_phantramgiam;
        private System.Windows.Forms.TextBox tb_HOTEN;
        private System.Windows.Forms.TextBox tb_IDKHACHHANG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}