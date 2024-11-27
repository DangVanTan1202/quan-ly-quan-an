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
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            conn.Open();
            string sqlrl = "select *from HOADON";
            SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DGVDanhSachHD.DataSource = dt;
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaHoaDon = txtMaHoaDon.Text;
            string TongTien = txtTongTien.Text;
            DateTime dateTime = dtpNgayLaHD.Value;
            string ngaylap = dateTime.ToString("MM/dd/yyyy");

            if(MaHoaDon.Length == 0 ||  TongTien.Length == 0)
            {
                MessageBox.Show("Nhập đủ thông tin");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
                conn.Open();
                string sql = "insert into HOADON values('" + MaHoaDon + "', '" + TongTien + "', '" + ngaylap + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                string sqlrl = "select *from HOADON";
                SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DGVDanhSachHD.DataSource = dt;
                conn.Close();
            }
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            FrmCTHD frmCTHD = new FrmCTHD();
            this.Hide();
            frmCTHD.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaHoaDon = txtMaHoaDon.Text;

            if (MaHoaDon.Length == 0 )
            {
                MessageBox.Show("Nhập mã hóa đơn");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
                conn.Open();
                string sql = "delete from HOADON where MaHoaDon = '" + MaHoaDon + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                string sqlrl = "select *from HOADON";
                SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DGVDanhSachHD.DataSource = dt;
                conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaHoaDon = txtMaHoaDon.Text;
            string TongTien = txtTongTien.Text;
            DateTime dateTime = dtpNgayLaHD.Value;
            string ngaylap = dateTime.ToString("MM/dd/yyyy");
            if (MaHoaDon.Length == 0)
            {
                MessageBox.Show("Nhập mã hóa đơn");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
                conn.Open();
                string sql = "update HOADON set TongTien = '"+TongTien+"', NgayLapHD = '"+ngaylap+"' where MaHoaDon = '" + MaHoaDon + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                string sqlrl = "select *from HOADON";
                SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DGVDanhSachHD.DataSource = dt;
                conn.Close();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtpNgayLaHD.Value;
            string ngaylap = dateTime.ToString("MM/dd/yyyy");

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            conn.Open();
            string sql = "select *from HOADON where NgayLapHD = '" + ngaylap + "'";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DGVDanhSachHD.DataSource = dt;
            conn.Close();
        }
    }
}
