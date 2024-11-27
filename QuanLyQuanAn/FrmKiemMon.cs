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
    public partial class FrmKiemMon : Form
    {
        public FrmKiemMon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtThongTinTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbSoBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KEST8LBE\SQLEXPRESS01;Initial Catalog=QLQuanAn;Integrated Security=True");
            string SoBan = cbbSoBan.Text;
            //MessageBox.Show("Chọn bàn '" + SoBan + "'");

            conn.Open();

            string sqlrl = "select MaMonAn, TenMonAn, Gia, SoLuong, ThanhTien from GOIMON where SoBan = '" + SoBan + "'";
            SqlCommand cmd = new SqlCommand(sqlrl, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dgvDSMon.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FrmGoiMon frmGoiMon = new FrmGoiMon();
            this.Hide();
            frmGoiMon.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            
            string SoBan = cbbSoBan.Text;
            string TenMA = txttenmonan.Text;
            int SoLuong = Convert.ToInt32(numUDSoLuong.Value);

            conn.Open();
            string sql = " update GOIMON set SoLuong = '" + SoLuong + "'where SoBan = '" + SoBan + "' and TenMonAn = N'" + TenMA + "' ";
            SqlCommand cmd = new SqlCommand( sql, conn);
            cmd.ExecuteNonQuery();

            string sql1 = "update GOIMON set ThanhTien = SoLuong * Gia";
            SqlCommand cmd1 = new SqlCommand( sql1, conn);
            cmd1.ExecuteNonQuery();

            string sqlrl = "select MaMonAn, TenMonAn, Gia, SoLuong, ThanhTien from GOIMON where SoBan = '" + SoBan + "'";
            SqlCommand cmd2 = new SqlCommand(sqlrl, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dgvDSMon.DataSource = dt;
        }

        private void btnHuymon_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");

            string SoBan = cbbSoBan.Text;
            string TenMA = txttenmonan.Text;

            conn.Open();
            string sql = " delete from GOIMON where SoBan = '" + SoBan + "' and TenMonAn = N'" + TenMA + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã xóa món '" + TenMA + "'");
            

            string sqlrl = "select MaMonAn, TenMonAn, Gia, SoLuong, ThanhTien from GOIMON where SoBan = '" + SoBan + "'";
            SqlCommand cmd2 = new SqlCommand(sqlrl, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dgvDSMon.DataSource = dt;
        }
    }
}
