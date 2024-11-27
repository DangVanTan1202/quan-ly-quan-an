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
    public partial class FrmCTHD : Form
    {
        public FrmCTHD()
        {
            InitializeComponent();
        }

        private void FrmCTHD_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            conn.Open();
            string cbb = "select MaHoaDon from HOADON";
            SqlCommand cmdcbb = new SqlCommand(cbb, conn);
            SqlDataAdapter sqlDataAdaptercbb = new SqlDataAdapter(cmdcbb);
            DataTable dataTablecbb = new DataTable();
            sqlDataAdaptercbb.Fill(dataTablecbb);
            foreach (DataRow row in dataTablecbb.Rows)
            {
                cbbMaHoaDon.Items.Add(row["MaHoaDon"].ToString());
            }
            string sqlrl = "select *from CHITIETHOADON";
            SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DGVDanhSachMon.DataSource = dt;
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mhd = cbbMaHoaDon.Text;
            string tma = cbbTenmonan.Text;
            string gia = txtGia.Text;
            string sl = NUDSoLuong.Text;
            int soluong = int.Parse(sl);
            if(mhd.Length == 0 )
            {
                MessageBox.Show("Nhập mã hóa đơn");
            }
            else
            {
                if(tma.Length == 0 || gia.Length == 0 || soluong == 0 ) 
                {
                    MessageBox.Show("Nhập đủ thông tin");
                }
                else
                {
                    int Gia = int.Parse(gia);
                    int TT = Gia * soluong;
                    SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
                    conn.Open();
                    string sql = "insert into CHITIETHOADON values('" + mhd + "', N'" + tma + "', '" + soluong + "','"+gia+"', '" + TT + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    string update = "update HOADON set TongTien = ( select sum(ThanhTien) from CHITIETHOADON where MaHoaDon = '" + mhd + "') where MaHoaDon = '" + mhd + "'";
                    SqlCommand sqlCommand1 = new SqlCommand(update, conn);
                    sqlCommand1.ExecuteNonQuery();

                    string sqlrl = "select *from CHITIETHOADON";
                    SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DGVDanhSachMon.DataSource = dt;
                    conn.Close();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mhd = cbbMaHoaDon.Text;
            string tma = cbbTenmonan.Text;
            if (mhd.Length == 0 || tma.Length == 0)
            {
                MessageBox.Show("Nhập mã hóa đơn và tên món ăn cần xóa");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
                conn.Open();
                string sql = "delete from CHITIETHOADON where MaHoaDon = '" + mhd + "' and TenMonAn like N'%" + tma + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                string update = "update HOADON set TongTien = ( select sum(ThanhTien) from CHITIETHOADON where MaHoaDon = '" + mhd + "') where MaHoaDon = '" + mhd + "'";
                SqlCommand sqlCommand1 = new SqlCommand(update, conn);
                sqlCommand1.ExecuteNonQuery();

                string sqlrl = "select *from CHITIETHOADON";
                SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DGVDanhSachMon.DataSource = dt;
                conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mhd = cbbMaHoaDon.Text;
            string tma = cbbTenmonan.Text;
            string sl = NUDSoLuong.Text;

            if (mhd.Length == 0 || tma.Length == 0)
            {
                MessageBox.Show("Nhập mã hóa đơn và tên món ăn cần xóa");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
                conn.Open();
                string sql = "update CHITIETHOADON set SoLuong = '"+sl+"' where MaHoaDon = '" + mhd + "' and TenMonAn like N'%" + tma + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                string update = "update HOADON set TongTien = ( select sum(ThanhTien) from CHITIETHOADON where MaHoaDon = '" + mhd + "') where MaHoaDon = '" + mhd + "'";
                SqlCommand sqlCommand1 = new SqlCommand(update, conn);
                sqlCommand1.ExecuteNonQuery();

                string sqlrl = "select *from CHITIETHOADON";
                SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DGVDanhSachMon.DataSource = dt;
                conn.Close();
            } 
        }

        private void cbbMaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTenmonan.Items.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            conn.Open();
            string mhd = cbbMaHoaDon.Text;
            string cbb = "select TenMonAn from CHITIETHOADON where MaHoaDon = '"+mhd+"'";
            SqlCommand cmdcbb = new SqlCommand(cbb, conn);
            SqlDataAdapter sqlDataAdaptercbb = new SqlDataAdapter(cmdcbb);
            DataTable dataTablecbb = new DataTable();
            sqlDataAdaptercbb.Fill(dataTablecbb);
            foreach (DataRow row in dataTablecbb.Rows)
            {
                cbbTenmonan.Items.Add(row["TenMonAn"].ToString());
            }
        }

        private void cbbTenmonan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            conn.Open();
            string tma = cbbTenmonan.Text;
            string mhd = cbbMaHoaDon.Text;
            string sqlrl = "select *from CHITIETHOADON where MaHoaDon ='" + mhd + "' and TenMonAn = N'" + tma + "' ";
            SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DGVDanhSachMon.DataSource = dt;
        }
    }
}
