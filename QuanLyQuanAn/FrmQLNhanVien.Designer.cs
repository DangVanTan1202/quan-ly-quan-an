namespace QuanLyQuanAn
{
    partial class FrmQLNhanVien
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
			this.button3 = new System.Windows.Forms.Button();
			this.thoat = new System.Windows.Forms.Button();
			this.listBoxquyen = new System.Windows.Forms.ListBox();
			this.timkiem = new System.Windows.Forms.Button();
			this.xoa = new System.Windows.Forms.Button();
			this.sua = new System.Windows.Forms.Button();
			this.nhapthongtintimkiem = new System.Windows.Forms.TextBox();
			this.thongtinlienquan = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nhapngaysinh = new System.Windows.Forms.DateTimePicker();
			this.nhapmatkhau = new System.Windows.Forms.TextBox();
			this.nhaptendangnhap = new System.Windows.Forms.TextBox();
			this.txtluongcoban = new System.Windows.Forms.TextBox();
			this.nhapsodienthoai = new System.Windows.Forms.TextBox();
			this.texthoten = new System.Windows.Forms.TextBox();
			this.txtmanhanvien = new System.Windows.Forms.TextBox();
			this.quyen = new System.Windows.Forms.Label();
			this.matkhau = new System.Windows.Forms.Label();
			this.tendangnhap = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.sodt = new System.Windows.Forms.Label();
			this.ngaysinh = new System.Windows.Forms.Label();
			this.hoTen = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Cyan;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.Location = new System.Drawing.Point(1052, 11);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(88, 63);
			this.button3.TabIndex = 116;
			this.button3.Text = "Thêm";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// thoat
			// 
			this.thoat.BackColor = System.Drawing.Color.Red;
			this.thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.thoat.Location = new System.Drawing.Point(1052, 302);
			this.thoat.Name = "thoat";
			this.thoat.Size = new System.Drawing.Size(88, 62);
			this.thoat.TabIndex = 115;
			this.thoat.Text = "Thoát";
			this.thoat.UseVisualStyleBackColor = false;
			this.thoat.Click += new System.EventHandler(this.thoat_Click);
			// 
			// listBoxquyen
			// 
			this.listBoxquyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxquyen.FormattingEnabled = true;
			this.listBoxquyen.ItemHeight = 22;
			this.listBoxquyen.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản Lý"});
			this.listBoxquyen.Location = new System.Drawing.Point(740, 261);
			this.listBoxquyen.Name = "listBoxquyen";
			this.listBoxquyen.Size = new System.Drawing.Size(198, 48);
			this.listBoxquyen.TabIndex = 114;
			this.listBoxquyen.SelectedIndexChanged += new System.EventHandler(this.listBoxquyen_SelectedIndexChanged);
			// 
			// timkiem
			// 
			this.timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.timkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.timkiem.Location = new System.Drawing.Point(1052, 236);
			this.timkiem.Name = "timkiem";
			this.timkiem.Size = new System.Drawing.Size(88, 60);
			this.timkiem.TabIndex = 113;
			this.timkiem.Text = "tìm kiếm";
			this.timkiem.UseVisualStyleBackColor = false;
			this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
			// 
			// xoa
			// 
			this.xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.xoa.Location = new System.Drawing.Point(1052, 157);
			this.xoa.Name = "xoa";
			this.xoa.Size = new System.Drawing.Size(88, 73);
			this.xoa.TabIndex = 112;
			this.xoa.Text = "xóa";
			this.xoa.UseVisualStyleBackColor = false;
			this.xoa.Click += new System.EventHandler(this.xoa_Click);
			// 
			// sua
			// 
			this.sua.BackColor = System.Drawing.Color.Lime;
			this.sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.sua.Location = new System.Drawing.Point(1052, 80);
			this.sua.Name = "sua";
			this.sua.Size = new System.Drawing.Size(88, 71);
			this.sua.TabIndex = 111;
			this.sua.Text = "sửa";
			this.sua.UseVisualStyleBackColor = false;
			this.sua.Click += new System.EventHandler(this.sua_Click);
			// 
			// nhapthongtintimkiem
			// 
			this.nhapthongtintimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nhapthongtintimkiem.Location = new System.Drawing.Point(286, 336);
			this.nhapthongtintimkiem.Name = "nhapthongtintimkiem";
			this.nhapthongtintimkiem.Size = new System.Drawing.Size(567, 30);
			this.nhapthongtintimkiem.TabIndex = 110;
			// 
			// thongtinlienquan
			// 
			this.thongtinlienquan.AutoSize = true;
			this.thongtinlienquan.BackColor = System.Drawing.Color.White;
			this.thongtinlienquan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.thongtinlienquan.Location = new System.Drawing.Point(68, 341);
			this.thongtinlienquan.Name = "thongtinlienquan";
			this.thongtinlienquan.Size = new System.Drawing.Size(176, 22);
			this.thongtinlienquan.TabIndex = 109;
			this.thongtinlienquan.Text = "Thông Tin Liên Quan";
			this.thongtinlienquan.Click += new System.EventHandler(this.thongtinlienquan_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
			this.dataGridView.Location = new System.Drawing.Point(27, 393);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(1057, 409);
			this.dataGridView.TabIndex = 108;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaNhanVien";
			this.Column1.HeaderText = "Mã Nhân Viên";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 125;
			// 
			// column2
			// 
			this.column2.DataPropertyName = "HoTen";
			this.column2.HeaderText = "Họ Tên";
			this.column2.MinimumWidth = 6;
			this.column2.Name = "column2";
			this.column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "NgaySinh";
			this.Column3.HeaderText = "Ngày Sinh";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "SoDienThoai";
			this.Column4.HeaderText = "Số Điện Thoại";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "LuongCoBan";
			this.Column5.HeaderText = "Lương Cơ Bản";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.Width = 125;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "TenDangNhap";
			this.Column6.HeaderText = "Tên Đăng Nhập";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.Width = 125;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "MatKhau";
			this.Column7.HeaderText = "Mật Khẩu";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.Width = 125;
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "Quyen";
			this.Column8.HeaderText = "Quyền";
			this.Column8.MinimumWidth = 6;
			this.Column8.Name = "Column8";
			this.Column8.Width = 125;
			// 
			// nhapngaysinh
			// 
			this.nhapngaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nhapngaysinh.Location = new System.Drawing.Point(242, 185);
			this.nhapngaysinh.Name = "nhapngaysinh";
			this.nhapngaysinh.Size = new System.Drawing.Size(213, 30);
			this.nhapngaysinh.TabIndex = 107;
			// 
			// nhapmatkhau
			// 
			this.nhapmatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nhapmatkhau.Location = new System.Drawing.Point(740, 187);
			this.nhapmatkhau.Name = "nhapmatkhau";
			this.nhapmatkhau.Size = new System.Drawing.Size(198, 30);
			this.nhapmatkhau.TabIndex = 106;
			this.nhapmatkhau.TextChanged += new System.EventHandler(this.nhapmatkhau_TextChanged);
			// 
			// nhaptendangnhap
			// 
			this.nhaptendangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nhaptendangnhap.Location = new System.Drawing.Point(740, 108);
			this.nhaptendangnhap.Name = "nhaptendangnhap";
			this.nhaptendangnhap.Size = new System.Drawing.Size(198, 30);
			this.nhaptendangnhap.TabIndex = 105;
			// 
			// txtluongcoban
			// 
			this.txtluongcoban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtluongcoban.Location = new System.Drawing.Point(740, 45);
			this.txtluongcoban.Name = "txtluongcoban";
			this.txtluongcoban.Size = new System.Drawing.Size(198, 30);
			this.txtluongcoban.TabIndex = 104;
			// 
			// nhapsodienthoai
			// 
			this.nhapsodienthoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nhapsodienthoai.Location = new System.Drawing.Point(242, 259);
			this.nhapsodienthoai.Name = "nhapsodienthoai";
			this.nhapsodienthoai.Size = new System.Drawing.Size(213, 30);
			this.nhapsodienthoai.TabIndex = 103;
			// 
			// texthoten
			// 
			this.texthoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.texthoten.Location = new System.Drawing.Point(242, 115);
			this.texthoten.Name = "texthoten";
			this.texthoten.Size = new System.Drawing.Size(213, 30);
			this.texthoten.TabIndex = 102;
			// 
			// txtmanhanvien
			// 
			this.txtmanhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmanhanvien.Location = new System.Drawing.Point(242, 49);
			this.txtmanhanvien.Name = "txtmanhanvien";
			this.txtmanhanvien.Size = new System.Drawing.Size(213, 30);
			this.txtmanhanvien.TabIndex = 101;
			// 
			// quyen
			// 
			this.quyen.AutoSize = true;
			this.quyen.BackColor = System.Drawing.Color.White;
			this.quyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quyen.Location = new System.Drawing.Point(543, 262);
			this.quyen.Name = "quyen";
			this.quyen.Size = new System.Drawing.Size(60, 22);
			this.quyen.TabIndex = 100;
			this.quyen.Text = "Quyền";
			this.quyen.Click += new System.EventHandler(this.quyen_Click);
			// 
			// matkhau
			// 
			this.matkhau.AutoSize = true;
			this.matkhau.BackColor = System.Drawing.Color.White;
			this.matkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.matkhau.Location = new System.Drawing.Point(543, 190);
			this.matkhau.Name = "matkhau";
			this.matkhau.Size = new System.Drawing.Size(87, 22);
			this.matkhau.TabIndex = 99;
			this.matkhau.Text = "Mật Khẩu";
			this.matkhau.Click += new System.EventHandler(this.matkhau_Click);
			// 
			// tendangnhap
			// 
			this.tendangnhap.AutoSize = true;
			this.tendangnhap.BackColor = System.Drawing.Color.White;
			this.tendangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tendangnhap.Location = new System.Drawing.Point(543, 112);
			this.tendangnhap.Name = "tendangnhap";
			this.tendangnhap.Size = new System.Drawing.Size(138, 22);
			this.tendangnhap.TabIndex = 98;
			this.tendangnhap.Text = "Tên Đăng Nhập ";
			this.tendangnhap.Click += new System.EventHandler(this.tendangnhap_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(543, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 22);
			this.label3.TabIndex = 97;
			this.label3.Text = "Lương Cơ Bản";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// sodt
			// 
			this.sodt.AutoSize = true;
			this.sodt.BackColor = System.Drawing.Color.White;
			this.sodt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sodt.Location = new System.Drawing.Point(68, 262);
			this.sodt.Name = "sodt";
			this.sodt.Size = new System.Drawing.Size(125, 22);
			this.sodt.TabIndex = 96;
			this.sodt.Text = "Số Điện Thoại";
			this.sodt.Click += new System.EventHandler(this.sodt_Click);
			// 
			// ngaysinh
			// 
			this.ngaysinh.AutoSize = true;
			this.ngaysinh.BackColor = System.Drawing.Color.White;
			this.ngaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ngaysinh.Location = new System.Drawing.Point(68, 195);
			this.ngaysinh.Name = "ngaysinh";
			this.ngaysinh.Size = new System.Drawing.Size(91, 22);
			this.ngaysinh.TabIndex = 95;
			this.ngaysinh.Text = "Ngày Sinh";
			this.ngaysinh.Click += new System.EventHandler(this.ngaysinh_Click);
			// 
			// hoTen
			// 
			this.hoTen.AutoSize = true;
			this.hoTen.BackColor = System.Drawing.Color.White;
			this.hoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hoTen.Location = new System.Drawing.Point(68, 117);
			this.hoTen.Name = "hoTen";
			this.hoTen.Size = new System.Drawing.Size(96, 22);
			this.hoTen.TabIndex = 94;
			this.hoTen.Text = "Họ Và Tên";
			this.hoTen.Click += new System.EventHandler(this.hoTen_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(70, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 22);
			this.label4.TabIndex = 93;
			this.label4.Text = "Mã Nhân Viên";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// FrmQLNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1166, 812);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.thoat);
			this.Controls.Add(this.listBoxquyen);
			this.Controls.Add(this.timkiem);
			this.Controls.Add(this.xoa);
			this.Controls.Add(this.sua);
			this.Controls.Add(this.nhapthongtintimkiem);
			this.Controls.Add(this.thongtinlienquan);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.nhapngaysinh);
			this.Controls.Add(this.nhapmatkhau);
			this.Controls.Add(this.nhaptendangnhap);
			this.Controls.Add(this.txtluongcoban);
			this.Controls.Add(this.nhapsodienthoai);
			this.Controls.Add(this.texthoten);
			this.Controls.Add(this.txtmanhanvien);
			this.Controls.Add(this.quyen);
			this.Controls.Add(this.matkhau);
			this.Controls.Add(this.tendangnhap);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.sodt);
			this.Controls.Add(this.ngaysinh);
			this.Controls.Add(this.hoTen);
			this.Controls.Add(this.label4);
			this.Name = "FrmQLNhanVien";
			this.Text = "Quản lý nhân viên";
			this.Load += new System.EventHandler(this.FrmQLNhanVien_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.ListBox listBoxquyen;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.TextBox nhapthongtintimkiem;
        private System.Windows.Forms.Label thongtinlienquan;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DateTimePicker nhapngaysinh;
        private System.Windows.Forms.TextBox nhapmatkhau;
        private System.Windows.Forms.TextBox nhaptendangnhap;
        private System.Windows.Forms.TextBox txtluongcoban;
        private System.Windows.Forms.TextBox nhapsodienthoai;
        private System.Windows.Forms.TextBox texthoten;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.Label quyen;
        private System.Windows.Forms.Label matkhau;
        private System.Windows.Forms.Label tendangnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sodt;
        private System.Windows.Forms.Label ngaysinh;
        private System.Windows.Forms.Label hoTen;
        private System.Windows.Forms.Label label4;
    }
}