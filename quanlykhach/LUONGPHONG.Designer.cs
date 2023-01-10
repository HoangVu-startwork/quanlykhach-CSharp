
namespace quanlykhach
{
    partial class LUONGPHONG
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_soluongphong = new System.Windows.Forms.TextBox();
            this.tb_giaphong = new System.Windows.Forms.TextBox();
            this.button_THEM = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.button_tim = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.tb_IDtimkiem = new System.Windows.Forms.TextBox();
            this.tb_loaiphong = new System.Windows.Forms.ComboBox();
            this.tb_sogiuong = new System.Windows.Forms.ComboBox();
            this.tb_timkiemloaiphong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(424, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 414);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tb_timkiemloaiphong);
            this.panel1.Controls.Add(this.tb_sogiuong);
            this.panel1.Controls.Add(this.tb_loaiphong);
            this.panel1.Controls.Add(this.tb_IDtimkiem);
            this.panel1.Controls.Add(this.timkiem);
            this.panel1.Controls.Add(this.button_tim);
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.button_THEM);
            this.panel1.Controls.Add(this.tb_giaphong);
            this.panel1.Controls.Add(this.tb_soluongphong);
            this.panel1.Controls.Add(this.tb_ID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 414);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SỐ LƯỢNG PHÒNG CỦA KHÁCH SẠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "SỐ LƯỢNG PHÒNG :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "LOẠI PHÒNG :\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "GIÁ PHÒNG : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "SỐ GIƯỜNG :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(244, 53);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(159, 20);
            this.tb_ID.TabIndex = 6;
            // 
            // tb_soluongphong
            // 
            this.tb_soluongphong.Location = new System.Drawing.Point(244, 111);
            this.tb_soluongphong.Name = "tb_soluongphong";
            this.tb_soluongphong.Size = new System.Drawing.Size(159, 20);
            this.tb_soluongphong.TabIndex = 7;
            // 
            // tb_giaphong
            // 
            this.tb_giaphong.Location = new System.Drawing.Point(244, 235);
            this.tb_giaphong.Name = "tb_giaphong";
            this.tb_giaphong.Size = new System.Drawing.Size(159, 20);
            this.tb_giaphong.TabIndex = 9;
            // 
            // button_THEM
            // 
            this.button_THEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_THEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_THEM.Location = new System.Drawing.Point(0, 388);
            this.button_THEM.Name = "button_THEM";
            this.button_THEM.Size = new System.Drawing.Size(89, 23);
            this.button_THEM.TabIndex = 11;
            this.button_THEM.Text = "THÊM";
            this.button_THEM.UseVisualStyleBackColor = false;
            this.button_THEM.Click += new System.EventHandler(this.button_THEM_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(117, 388);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(85, 23);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(229, 388);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(80, 23);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(328, 388);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(84, 23);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // button_tim
            // 
            this.button_tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_tim.Location = new System.Drawing.Point(14, 328);
            this.button_tim.Name = "button_tim";
            this.button_tim.Size = new System.Drawing.Size(93, 23);
            this.button_tim.TabIndex = 15;
            this.button_tim.Text = "TÌM KIẾM";
            this.button_tim.UseVisualStyleBackColor = false;
            this.button_tim.Click += new System.EventHandler(this.button_tim_Click);
            // 
            // timkiem
            // 
            this.timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem.ForeColor = System.Drawing.Color.Red;
            this.timkiem.Location = new System.Drawing.Point(161, 359);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(92, 23);
            this.timkiem.TabIndex = 16;
            this.timkiem.Text = "TÌM KIẾM";
            this.timkiem.UseVisualStyleBackColor = false;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // tb_IDtimkiem
            // 
            this.tb_IDtimkiem.Location = new System.Drawing.Point(113, 328);
            this.tb_IDtimkiem.Name = "tb_IDtimkiem";
            this.tb_IDtimkiem.Size = new System.Drawing.Size(130, 20);
            this.tb_IDtimkiem.TabIndex = 17;
            // 
            // tb_loaiphong
            // 
            this.tb_loaiphong.FormattingEnabled = true;
            this.tb_loaiphong.Location = new System.Drawing.Point(244, 170);
            this.tb_loaiphong.Name = "tb_loaiphong";
            this.tb_loaiphong.Size = new System.Drawing.Size(159, 21);
            this.tb_loaiphong.TabIndex = 19;
            // 
            // tb_sogiuong
            // 
            this.tb_sogiuong.FormattingEnabled = true;
            this.tb_sogiuong.Items.AddRange(new object[] {
            "ĐƠN",
            " ĐÔI",
            "BA",
            "BỐN"});
            this.tb_sogiuong.Location = new System.Drawing.Point(244, 298);
            this.tb_sogiuong.Name = "tb_sogiuong";
            this.tb_sogiuong.Size = new System.Drawing.Size(159, 21);
            this.tb_sogiuong.TabIndex = 20;
            // 
            // tb_timkiemloaiphong
            // 
            this.tb_timkiemloaiphong.FormattingEnabled = true;
            this.tb_timkiemloaiphong.Items.AddRange(new object[] {
            "ĐƠN",
            " ĐÔI",
            "BA",
            "BỐN"});
            this.tb_timkiemloaiphong.Location = new System.Drawing.Point(269, 359);
            this.tb_timkiemloaiphong.Name = "tb_timkiemloaiphong";
            this.tb_timkiemloaiphong.Size = new System.Drawing.Size(134, 21);
            this.tb_timkiemloaiphong.TabIndex = 21;
            // 
            // LUONGPHONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LUONGPHONG";
            this.Text = "LUONGPHONG";
            this.Load += new System.EventHandler(this.LUONGPHONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_IDtimkiem;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button button_tim;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button button_THEM;
        private System.Windows.Forms.TextBox tb_giaphong;
        private System.Windows.Forms.TextBox tb_soluongphong;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.ComboBox tb_sogiuong;
        private System.Windows.Forms.ComboBox tb_loaiphong;
        private System.Windows.Forms.ComboBox tb_timkiemloaiphong;
    }
}