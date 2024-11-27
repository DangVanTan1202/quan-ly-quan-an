namespace QuanLyQuanAn
{
    partial class FrmThanhToan
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
			this.cbbSoBan = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvDSMon = new System.Windows.Forms.DataGridView();
			this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTongtien = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTienkhachdua = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTienthua = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtchietkhau = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btnThanhToan = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.labelNgayhientai = new System.Windows.Forms.Label();
			this.txtTienTT = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSMon)).BeginInit();
			this.SuspendLayout();
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
			this.cbbSoBan.Location = new System.Drawing.Point(457, 87);
			this.cbbSoBan.Name = "cbbSoBan";
			this.cbbSoBan.Size = new System.Drawing.Size(82, 39);
			this.cbbSoBan.TabIndex = 13;
			this.cbbSoBan.SelectedIndexChanged += new System.EventHandler(this.cbbSoBan_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(369, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Số bàn";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// dgvDSMon
			// 
			this.dgvDSMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMonAn,
            this.Gia,
            this.SoLuong,
            this.ThanhTien});
			this.dgvDSMon.Location = new System.Drawing.Point(-2, 141);
			this.dgvDSMon.Name = "dgvDSMon";
			this.dgvDSMon.RowHeadersWidth = 51;
			this.dgvDSMon.RowTemplate.Height = 24;
			this.dgvDSMon.Size = new System.Drawing.Size(554, 354);
			this.dgvDSMon.TabIndex = 11;
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
			this.Gia.Width = 80;
			// 
			// SoLuong
			// 
			this.SoLuong.DataPropertyName = "SoLuong";
			this.SoLuong.HeaderText = "Số lượng";
			this.SoLuong.MinimumWidth = 6;
			this.SoLuong.Name = "SoLuong";
			this.SoLuong.Width = 50;
			// 
			// ThanhTien
			// 
			this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ThanhTien.DataPropertyName = "ThanhTien";
			this.ThanhTien.HeaderText = "Thành tiền";
			this.ThanhTien.MinimumWidth = 6;
			this.ThanhTien.Name = "ThanhTien";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(267, 22);
			this.label2.TabIndex = 15;
			this.label2.Text = "Đ/c: 123 Ngô Mây, tp Quy Nhơn";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "Anh Nuôi quán";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(269, 35);
			this.label3.TabIndex = 16;
			this.label3.Text = "Hóa đơn thanh toán";
			// 
			// txtTongtien
			// 
			this.txtTongtien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTongtien.Location = new System.Drawing.Point(257, 515);
			this.txtTongtien.Name = "txtTongtien";
			this.txtTongtien.Size = new System.Drawing.Size(295, 34);
			this.txtTongtien.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(123, 513);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 32);
			this.label5.TabIndex = 17;
			this.label5.Text = "Tổng tiền";
			// 
			// txtTienkhachdua
			// 
			this.txtTienkhachdua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTienkhachdua.Location = new System.Drawing.Point(257, 555);
			this.txtTienkhachdua.Name = "txtTienkhachdua";
			this.txtTienkhachdua.Size = new System.Drawing.Size(295, 34);
			this.txtTienkhachdua.TabIndex = 20;
			this.txtTienkhachdua.TextChanged += new System.EventHandler(this.txtTienkhachdua_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(50, 553);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(201, 32);
			this.label6.TabIndex = 19;
			this.label6.Text = "Tiền khách đưa";
			// 
			// txtTienthua
			// 
			this.txtTienthua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTienthua.Location = new System.Drawing.Point(257, 675);
			this.txtTienthua.Name = "txtTienthua";
			this.txtTienthua.Size = new System.Drawing.Size(295, 34);
			this.txtTienthua.TabIndex = 22;
			this.txtTienthua.TextChanged += new System.EventHandler(this.txtTienthua_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(121, 673);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(130, 32);
			this.label7.TabIndex = 21;
			this.label7.Text = "Tiền thừa";
			// 
			// txtchietkhau
			// 
			this.txtchietkhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtchietkhau.Location = new System.Drawing.Point(257, 595);
			this.txtchietkhau.Name = "txtchietkhau";
			this.txtchietkhau.Size = new System.Drawing.Size(221, 34);
			this.txtchietkhau.TabIndex = 24;
			this.txtchietkhau.Text = "0";
			this.txtchietkhau.TextChanged += new System.EventHandler(this.txtchietkhau_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(104, 593);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(147, 32);
			this.label8.TabIndex = 23;
			this.label8.Text = "Chiết khấu";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(484, 597);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 32);
			this.label9.TabIndex = 25;
			this.label9.Text = "%";
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThanhToan.Location = new System.Drawing.Point(431, 733);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.Size = new System.Drawing.Size(121, 59);
			this.btnThanhToan.TabIndex = 26;
			this.btnThanhToan.Text = "Thanh toán";
			this.btnThanhToan.UseVisualStyleBackColor = false;
			this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Cyan;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(0, 733);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 60);
			this.button1.TabIndex = 27;
			this.button1.Text = "Thoát";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// labelNgayhientai
			// 
			this.labelNgayhientai.AutoSize = true;
			this.labelNgayhientai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNgayhientai.Location = new System.Drawing.Point(316, 28);
			this.labelNgayhientai.Name = "labelNgayhientai";
			this.labelNgayhientai.Size = new System.Drawing.Size(70, 22);
			this.labelNgayhientai.TabIndex = 28;
			this.labelNgayhientai.Text = "label10";
			this.labelNgayhientai.Click += new System.EventHandler(this.labelNgayhientai_Click);
			// 
			// txtTienTT
			// 
			this.txtTienTT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTienTT.Location = new System.Drawing.Point(257, 635);
			this.txtTienTT.Name = "txtTienTT";
			this.txtTienTT.Size = new System.Drawing.Size(295, 34);
			this.txtTienTT.TabIndex = 30;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(46, 637);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(205, 32);
			this.label10.TabIndex = 29;
			this.label10.Text = "Tiền thanh toán";
			// 
			// FrmThanhToan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 795);
			this.Controls.Add(this.txtTienTT);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.labelNgayhientai);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnThanhToan);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtchietkhau);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtTienthua);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtTienkhachdua);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtTongtien);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbbSoBan);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dgvDSMon);
			this.Name = "FrmThanhToan";
			this.Text = "Thanh toán";
			this.Load += new System.EventHandler(this.FrmThanhToan_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSMon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSoBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDSMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTienkhachdua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTienthua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtchietkhau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNgayhientai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TextBox txtTienTT;
        private System.Windows.Forms.Label label10;
    }
}