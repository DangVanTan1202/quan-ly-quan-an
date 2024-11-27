namespace QuanLyQuanAn
{
    partial class FrmQLChiTieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonTimkiem = new System.Windows.Forms.Button();
            this.dataGridViewChitieu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpNgaymua = new System.Windows.Forms.DateTimePicker();
            this.textBoxGiatien = new System.Windows.Forms.TextBox();
            this.textBoxTennguyenlieu = new System.Windows.Forms.TextBox();
            this.labelGiaTien = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelNgay = new System.Windows.Forms.Label();
            this.labelTenNguyenLieu = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChitieu)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.Lime;
            this.buttonSua.Location = new System.Drawing.Point(752, 106);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(84, 54);
            this.buttonSua.TabIndex = 68;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.Red;
            this.buttonXoa.Location = new System.Drawing.Point(626, 105);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(84, 58);
            this.buttonXoa.TabIndex = 67;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.Cyan;
            this.buttonThem.Location = new System.Drawing.Point(485, 103);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(84, 57);
            this.buttonThem.TabIndex = 66;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonTimkiem
            // 
            this.buttonTimkiem.BackColor = System.Drawing.Color.Bisque;
            this.buttonTimkiem.Image = global::QuanLyQuanAn.Properties.Resources.Magnifying_Glass_Tilted_Left_icon;
            this.buttonTimkiem.Location = new System.Drawing.Point(372, 105);
            this.buttonTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTimkiem.Name = "buttonTimkiem";
            this.buttonTimkiem.Size = new System.Drawing.Size(60, 53);
            this.buttonTimkiem.TabIndex = 65;
            this.buttonTimkiem.UseVisualStyleBackColor = false;
            this.buttonTimkiem.Click += new System.EventHandler(this.buttonTimkiem_Click);
            // 
            // dataGridViewChitieu
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChitieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewChitieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChitieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewChitieu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewChitieu.Location = new System.Drawing.Point(0, 203);
            this.dataGridViewChitieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewChitieu.Name = "dataGridViewChitieu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChitieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewChitieu.RowHeadersWidth = 62;
            this.dataGridViewChitieu.RowTemplate.Height = 28;
            this.dataGridViewChitieu.Size = new System.Drawing.Size(845, 332);
            this.dataGridViewChitieu.TabIndex = 64;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenMatHang";
            this.Column1.HeaderText = "Tên Mặt Hàng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GiaTien";
            this.Column2.HeaderText = "Giá Tiền";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "NgayMua";
            this.Column3.HeaderText = "Ngày Mua";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(614, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 38);
            this.textBox1.TabIndex = 69;
            // 
            // dtpNgaymua
            // 
            this.dtpNgaymua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaymua.Location = new System.Drawing.Point(574, 6);
            this.dtpNgaymua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaymua.Name = "dtpNgaymua";
            this.dtpNgaymua.Size = new System.Drawing.Size(222, 38);
            this.dtpNgaymua.TabIndex = 63;
            // 
            // textBoxGiatien
            // 
            this.textBoxGiatien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGiatien.Location = new System.Drawing.Point(185, 50);
            this.textBoxGiatien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGiatien.Name = "textBoxGiatien";
            this.textBoxGiatien.Size = new System.Drawing.Size(285, 38);
            this.textBoxGiatien.TabIndex = 62;
            // 
            // textBoxTennguyenlieu
            // 
            this.textBoxTennguyenlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTennguyenlieu.Location = new System.Drawing.Point(185, 6);
            this.textBoxTennguyenlieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTennguyenlieu.Name = "textBoxTennguyenlieu";
            this.textBoxTennguyenlieu.Size = new System.Drawing.Size(285, 38);
            this.textBoxTennguyenlieu.TabIndex = 61;
            // 
            // labelGiaTien
            // 
            this.labelGiaTien.AutoSize = true;
            this.labelGiaTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaTien.Location = new System.Drawing.Point(26, 61);
            this.labelGiaTien.Name = "labelGiaTien";
            this.labelGiaTien.Size = new System.Drawing.Size(84, 23);
            this.labelGiaTien.TabIndex = 60;
            this.labelGiaTien.Text = "Giá Tiền";
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.Location = new System.Drawing.Point(516, 61);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(92, 23);
            this.labelSoLuong.TabIndex = 59;
            this.labelSoLuong.Text = "Số Lượng";
            // 
            // labelNgay
            // 
            this.labelNgay.AutoSize = true;
            this.labelNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgay.Location = new System.Drawing.Point(514, 14);
            this.labelNgay.Name = "labelNgay";
            this.labelNgay.Size = new System.Drawing.Size(54, 23);
            this.labelNgay.TabIndex = 58;
            this.labelNgay.Text = "Ngày";
            this.labelNgay.Click += new System.EventHandler(this.labelNgay_Click);
            // 
            // labelTenNguyenLieu
            // 
            this.labelTenNguyenLieu.AutoSize = true;
            this.labelTenNguyenLieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNguyenLieu.Location = new System.Drawing.Point(26, 14);
            this.labelTenNguyenLieu.Name = "labelTenNguyenLieu";
            this.labelTenNguyenLieu.Size = new System.Drawing.Size(153, 23);
            this.labelTenNguyenLieu.TabIndex = 57;
            this.labelTenNguyenLieu.Text = "Tên Nguyên Liệu";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(110, 113);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 38);
            this.textBox2.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 71;
            this.label1.Text = "Từ khóa";
            // 
            // FrmQLChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonTimkiem);
            this.Controls.Add(this.dataGridViewChitieu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtpNgaymua);
            this.Controls.Add(this.textBoxGiatien);
            this.Controls.Add(this.textBoxTennguyenlieu);
            this.Controls.Add(this.labelGiaTien);
            this.Controls.Add(this.labelSoLuong);
            this.Controls.Add(this.labelNgay);
            this.Controls.Add(this.labelTenNguyenLieu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmQLChiTieu";
            this.Text = "Quản lý chi tiêu";
            this.Load += new System.EventHandler(this.FrmQLChiTieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChitieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonTimkiem;
        private System.Windows.Forms.DataGridView dataGridViewChitieu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpNgaymua;
        private System.Windows.Forms.TextBox textBoxGiatien;
        private System.Windows.Forms.TextBox textBoxTennguyenlieu;
        private System.Windows.Forms.Label labelGiaTien;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelNgay;
        private System.Windows.Forms.Label labelTenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}