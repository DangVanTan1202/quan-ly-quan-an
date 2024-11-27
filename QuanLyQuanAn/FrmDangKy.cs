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
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            this.Hide();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string HoTen = txtHoten.Text;
            string TenDangNhap = txtTenDangNhap.Text;
            string MatKhau = txtMatKhau.Text;
            string MatKhau2 = txtMatKhau2.Text;
            DateTime dtns = dtpNgaySinh.Value;
            string NgaySinh = dtns.ToString("MM/dd/yyyy");
            string sdt = txtSDT.Text;
            string ChucVu = cbbChucVu.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            
            if( HoTen.Length == 0 || TenDangNhap.Length == 0 || MatKhau.Length == 0 || MatKhau2.Length == 0
                || sdt.Length == 0 || ChucVu.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                if(MatKhau2 != MatKhau)
                {
                    MessageBox.Show("Mật khẩu chưa trùng khớp!");
                }
                else
                {
                    conn.Open();
                    string sqls = "select tendangnhap from NHANVIEN where tendangnhap = '" + TenDangNhap + "'";
                    SqlCommand sqlCommand = new SqlCommand(sqls, conn);
                    SqlDataReader rdr = sqlCommand.ExecuteReader();
                    if (rdr.Read())
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại");
                        conn.Close();
                    }
                    else
                    {
                        rdr.Close();
                        string sql = "insert into NHANVIEN(hoten, ngaysinh, sodienthoai, tendangnhap, matkhau, quyen ) values(N'" + HoTen + "', '" + NgaySinh + "', '" + sdt + "', '" + TenDangNhap + "', '" + MatKhau + "', N'" + ChucVu + "' )";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã đăng ký thành công");

                    }
                }
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

		private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
