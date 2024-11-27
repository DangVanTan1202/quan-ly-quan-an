namespace QuanLyQuanAn
{
    partial class FrmGoiMon
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtThongTinTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbSoBan = new System.Windows.Forms.ComboBox();
            this.LSVKetQua = new System.Windows.Forms.ListView();
            this.colMaMonAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenMonAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvDSMon = new System.Windows.Forms.DataGridView();
            this.MaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDatMon = new System.Windows.Forms.Button();
            this.btnHuyBan = new System.Windows.Forms.Button();
            this.btnInTamTinh = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numUDSoLuong = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món";
            // 
            // txtThongTinTK
            // 
            this.txtThongTinTK.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTinTK.Location = new System.Drawing.Point(100, 19);
            this.txtThongTinTK.Name = "txtThongTinTK";
            this.txtThongTinTK.Size = new System.Drawing.Size(300, 39);
            this.txtThongTinTK.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số bàn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbbSoBan
            // 
            this.cbbSoBan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSoBan.FormattingEnabled = true;
            this.cbbSoBan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbbSoBan.Location = new System.Drawing.Point(100, 64);
            this.cbbSoBan.Name = "cbbSoBan";
            this.cbbSoBan.Size = new System.Drawing.Size(82, 39);
            this.cbbSoBan.TabIndex = 3;
            this.cbbSoBan.SelectedIndexChanged += new System.EventHandler(this.cbbSoBan_SelectedIndexChanged);
            // 
            // LSVKetQua
            // 
            this.LSVKetQua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaMonAn,
            this.colTenMonAn,
            this.colGia});
            this.LSVKetQua.FullRowSelect = true;
            this.LSVKetQua.HideSelection = false;
            this.LSVKetQua.Location = new System.Drawing.Point(468, 1);
            this.LSVKetQua.Name = "LSVKetQua";
            this.LSVKetQua.Size = new System.Drawing.Size(513, 231);
            this.LSVKetQua.TabIndex = 4;
            this.LSVKetQua.UseCompatibleStateImageBehavior = false;
            this.LSVKetQua.View = System.Windows.Forms.View.Details;
            this.LSVKetQua.SelectedIndexChanged += new System.EventHandler(this.LSVKetQua_SelectedIndexChanged);
            // 
            // colMaMonAn
            // 
            this.colMaMonAn.Text = "Mã món ăn";
            this.colMaMonAn.Width = 87;
            // 
            // colTenMonAn
            // 
            this.colTenMonAn.Text = "Tên món ăn";
            this.colTenMonAn.Width = 200;
            // 
            // colGia
            // 
            this.colGia.Text = "Giá";
            this.colGia.Width = 150;
            // 
            // dgvDSMon
            // 
            this.dgvDSMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonAn,
            this.TenMonAn,
            this.Gia,
            this.SoLuong,
            this.ThanhTien});
            this.dgvDSMon.Location = new System.Drawing.Point(0, 303);
            this.dgvDSMon.Name = "dgvDSMon";
            this.dgvDSMon.RowHeadersWidth = 51;
            this.dgvDSMon.RowTemplate.Height = 24;
            this.dgvDSMon.Size = new System.Drawing.Size(981, 354);
            this.dgvDSMon.TabIndex = 5;
            // 
            // MaMonAn
            // 
            this.MaMonAn.DataPropertyName = "MaMonAn";
            this.MaMonAn.HeaderText = "Mã món ăn";
            this.MaMonAn.MinimumWidth = 6;
            this.MaMonAn.Name = "MaMonAn";
            this.MaMonAn.Width = 125;
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.HeaderText = "Tên món ăn";
            this.TenMonAn.MinimumWidth = 6;
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.Width = 150;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // btnDatMon
            // 
            this.btnDatMon.BackColor = System.Drawing.Color.Cyan;
            this.btnDatMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatMon.Location = new System.Drawing.Point(860, 238);
            this.btnDatMon.Name = "btnDatMon";
            this.btnDatMon.Size = new System.Drawing.Size(121, 59);
            this.btnDatMon.TabIndex = 6;
            this.btnDatMon.Text = "Đặt món";
            this.btnDatMon.UseVisualStyleBackColor = false;
            this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click);
            // 
            // btnHuyBan
            // 
            this.btnHuyBan.BackColor = System.Drawing.Color.Red;
            this.btnHuyBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBan.Location = new System.Drawing.Point(742, 238);
            this.btnHuyBan.Name = "btnHuyBan";
            this.btnHuyBan.Size = new System.Drawing.Size(121, 59);
            this.btnHuyBan.TabIndex = 7;
            this.btnHuyBan.Text = "Hủy bàn";
            this.btnHuyBan.UseVisualStyleBackColor = false;
            this.btnHuyBan.Click += new System.EventHandler(this.btnHuyBan_Click);
            // 
            // btnInTamTinh
            // 
            this.btnInTamTinh.BackColor = System.Drawing.Color.Yellow;
            this.btnInTamTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInTamTinh.Location = new System.Drawing.Point(624, 238);
            this.btnInTamTinh.Name = "btnInTamTinh";
            this.btnInTamTinh.Size = new System.Drawing.Size(121, 59);
            this.btnInTamTinh.TabIndex = 8;
            this.btnInTamTinh.Text = "In tạm tính";
            this.btnInTamTinh.UseVisualStyleBackColor = false;
            this.btnInTamTinh.Click += new System.EventHandler(this.btnInTamTinh_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(507, 238);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(121, 59);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(144, 131);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(318, 39);
            this.txtTongTien.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(54, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "Danh sách món ăn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số lượng";
            // 
            // numUDSoLuong
            // 
            this.numUDSoLuong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDSoLuong.Location = new System.Drawing.Point(319, 64);
            this.numUDSoLuong.Name = "numUDSoLuong";
            this.numUDSoLuong.Size = new System.Drawing.Size(143, 39);
            this.numUDSoLuong.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(391, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 59);
            this.button1.TabIndex = 16;
            this.button1.Text = "Kiểm món";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QuanLyQuanAn.Properties.Resources.Magnifying_Glass_Tilted_Left_icon;
            this.btnTimKiem.Location = new System.Drawing.Point(406, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(56, 51);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FrmGoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numUDSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnInTamTinh);
            this.Controls.Add(this.btnHuyBan);
            this.Controls.Add(this.btnDatMon);
            this.Controls.Add(this.dgvDSMon);
            this.Controls.Add(this.LSVKetQua);
            this.Controls.Add(this.cbbSoBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtThongTinTK);
            this.Controls.Add(this.label1);
            this.Name = "FrmGoiMon";
            this.Text = "Gọi món";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThongTinTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbSoBan;
        private System.Windows.Forms.ListView LSVKetQua;
        private System.Windows.Forms.DataGridView dgvDSMon;
        private System.Windows.Forms.Button btnDatMon;
        private System.Windows.Forms.Button btnHuyBan;
        private System.Windows.Forms.Button btnInTamTinh;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader colMaMonAn;
        private System.Windows.Forms.ColumnHeader colTenMonAn;
        private System.Windows.Forms.ColumnHeader colGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numUDSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button button1;
    }
}