namespace QuanLyQuanAn
{
    partial class FrmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GioiThieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripGoiMon = new System.Windows.Forms.ToolStripLabel();
			this.toolStripQLMonAn = new System.Windows.Forms.ToolStripLabel();
			this.toolStripQLNhanVien = new System.Windows.Forms.ToolStripLabel();
			this.toolstripQLChiTieu = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.GioiThieuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1924, 30);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// GioiThieuToolStripMenuItem
			// 
			this.GioiThieuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GioiThieuToolStripMenuItem.Name = "GioiThieuToolStripMenuItem";
			this.GioiThieuToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
			this.GioiThieuToolStripMenuItem.Text = "Giới thiệu";
			this.GioiThieuToolStripMenuItem.Click += new System.EventHandler(this.GioiThieuToolStripMenuItem_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGoiMon,
            this.toolStripQLMonAn,
            this.toolStripQLNhanVien,
            this.toolstripQLChiTieu,
            this.toolStripLabel1,
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 30);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1924, 27);
			this.toolStrip1.TabIndex = 5;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripGoiMon
			// 
			this.toolStripGoiMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripGoiMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.toolStripGoiMon.Name = "toolStripGoiMon";
			this.toolStripGoiMon.Size = new System.Drawing.Size(81, 24);
			this.toolStripGoiMon.Text = "Gọi món";
			this.toolStripGoiMon.Click += new System.EventHandler(this.toolStripGoiMon_Click);
			// 
			// toolStripQLMonAn
			// 
			this.toolStripQLMonAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripQLMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.toolStripQLMonAn.Name = "toolStripQLMonAn";
			this.toolStripQLMonAn.Size = new System.Drawing.Size(141, 24);
			this.toolStripQLMonAn.Text = "Quản lý món ăn";
			this.toolStripQLMonAn.Click += new System.EventHandler(this.toolStripQLMonAn_Click);
			// 
			// toolStripQLNhanVien
			// 
			this.toolStripQLNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripQLNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.toolStripQLNhanVien.Name = "toolStripQLNhanVien";
			this.toolStripQLNhanVien.Size = new System.Drawing.Size(160, 24);
			this.toolStripQLNhanVien.Text = "Quản lý nhân viên";
			this.toolStripQLNhanVien.Click += new System.EventHandler(this.toolStripQLNhanVien_Click);
			// 
			// toolstripQLChiTieu
			// 
			this.toolstripQLChiTieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolstripQLChiTieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.toolstripQLChiTieu.Name = "toolstripQLChiTieu";
			this.toolstripQLChiTieu.Size = new System.Drawing.Size(141, 24);
			this.toolstripQLChiTieu.Text = "Quản lý chi tiêu";
			this.toolstripQLChiTieu.Click += new System.EventHandler(this.toolstripQLChiTieu_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(147, 24);
			this.toolStripLabel1.Text = "Quản lý hóa đơn";
			this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::QuanLyQuanAn.Properties.Resources.Nha_hang_Khong_Gian_Xua_Hue_70612;
			this.ClientSize = new System.Drawing.Size(1924, 1055);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmMain";
			this.Text = "Quản lý quán ăn";
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GioiThieuToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripGoiMon;
        private System.Windows.Forms.ToolStripLabel toolStripQLMonAn;
        private System.Windows.Forms.ToolStripLabel toolStripQLNhanVien;
        private System.Windows.Forms.ToolStripLabel toolstripQLChiTieu;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
	}
}