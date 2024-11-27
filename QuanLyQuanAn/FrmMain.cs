using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void GioiThieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGioiThieu frmgioithieu = new FrmGioiThieu();
            frmgioithieu.MdiParent = this;
            frmgioithieu.Show();
        }

        private void toolStripGoiMon_Click(object sender, EventArgs e)
        {
            FrmGoiMon frmgoi = new FrmGoiMon();
            frmgoi.MdiParent = this;
            frmgoi.Show();
        }

        private void toolStripQLMonAn_Click(object sender, EventArgs e)
        {
            FrmQLMonAn frmQLAn = new FrmQLMonAn();
            frmQLAn.MdiParent = this;
            frmQLAn.Show();
        }

        private void toolStripQLNhanVien_Click(object sender, EventArgs e)
        {
            FrmQLNhanVien frmQLNV = new FrmQLNhanVien();
            frmQLNV.MdiParent = this;
            frmQLNV.Show();
        }

        private void toolstripQLChiTieu_Click(object sender, EventArgs e)
        {
            FrmQLChiTieu frmQLCT = new FrmQLChiTieu();
            frmQLCT.MdiParent = this;
            frmQLCT.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FrmHoaDon frmHoaDon = new FrmHoaDon();
            frmHoaDon.MdiParent = this;
            frmHoaDon.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
