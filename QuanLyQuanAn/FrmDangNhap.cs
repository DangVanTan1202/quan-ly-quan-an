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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy frmDangKy = new FrmDangKy();
            frmDangKy.Show();
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txttendangnhap.Text;
            string MatKhau = txtMatkhau.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");

            if ( TenDangNhap.Length == 0 || MatKhau.Length == 0 )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                string sql = "select tendangnhap, matkhau, quyen from NHANVIEN where tendangnhap = '" + TenDangNhap + "' and matkhau = '" + MatKhau + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if ( rdr.HasRows )
                {
                    rdr.Read();
                    string q = rdr["quyen"].ToString();
                    if(q == "Quản lý")
                    {
                        FrmMain frmMain = new FrmMain();
                        frmMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        FrmGoiMon frmGoiMon = new FrmGoiMon();
                        this.Hide();
                        frmGoiMon.Show();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }
        }
    }
}
