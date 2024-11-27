using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class FrmInTamTinh : Form
    {
        public FrmInTamTinh()
        {
            InitializeComponent();
        }

        private void FrmInTamTinh_Load(object sender, EventArgs e)
        {

        }

        private void cbbSoBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            string SoBan = cbbSoBan.Text;
            //MessageBox.Show("Chọn bàn '" + SoBan + "'");

            conn.Open();
            string sql = "select  TenMonAn, Gia, SoLuong, ThanhTien from GOIMON where SoBan = '" + SoBan + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dgvDSMon.DataSource = dt;

            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgvDSMon.Rows)
            {
                if (row.Cells["ThanhTien"] != null && row.Cells["ThanhTien"].Value != null)
                {
                    decimal giaTri = Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                    tongTien += giaTri;
                }
            }
            txtTongtien.Text = tongTien.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FrmGoiMon frmGoiMon = new FrmGoiMon();
            this.Hide();
            frmGoiMon.Show();
        }
    }
}
