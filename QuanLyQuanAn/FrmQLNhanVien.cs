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
    public partial class FrmQLNhanVien : Form
    {
        public FrmQLNhanVien()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mnv = txtmanhanvien.Text;
            string hovaten = texthoten.Text;
            DateTime dtns = nhapngaysinh.Value;
            string ns = dtns.ToString("MM/dd/yyyy");
            string sdt = nhapsodienthoai.Text;
            string luong = txtluongcoban.Text;
            int LCB = int.Parse(luong);
            string tendn = nhaptendangnhap.Text;
            string mkh = nhapmatkhau.Text;
            string quyen = listBoxquyen.Text;
            if (mnv.Length == 0 || hovaten.Length == 0 || ns.Length == 0 || sdt.Length == 0 || luong.Length == 0 || tendn.Length == 0 || mkh.Length == 0 || quyen.Length == 0)
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
                conn.Open();
                string sql = "insert into NHANVIEN values('" + mnv + "', N'" + hovaten + "', '" + ns + "', '" + sdt + "','" + LCB + "', '" + tendn + "', '" + mkh + "', N'" + quyen + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MNV", mnv);
                cmd.Parameters.AddWithValue("@HoTen", hovaten);
                cmd.Parameters.AddWithValue("@NgaySinh", dtns);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@Luong", LCB);
                cmd.Parameters.AddWithValue("@TenDN", tendn);
                cmd.Parameters.AddWithValue("@MatKhau", mkh);
                cmd.Parameters.AddWithValue("@Quyen", quyen);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công");
                string sqlrl = "select *from NHANVIEN";
                SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
                conn.Close();
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            conn.Open();
            string mnv = txtmanhanvien.Text;
            string hovaten = texthoten.Text;
            DateTime dtns = nhapngaysinh.Value;
            string ns = dtns.ToString("MM/dd/yyyy");
            string sdt = nhapsodienthoai.Text;
            string luong = txtluongcoban.Text;
            int LCB = int.Parse(luong);
            string tendn = nhaptendangnhap.Text;
            string mkh = nhapmatkhau.Text;
            string quyen = listBoxquyen.Text;
            if (mnv.Length == 0)
            {
                MessageBox.Show("Nhập mã nhân viên ");
            }
            else
            {
                if (mnv.Length == 0 || hovaten.Length == 0 || ns.Length == 0 || sdt.Length == 0 || luong.Length == 0 || tendn.Length == 0 || mkh.Length == 0 || quyen.Length == 0)
                {
                    MessageBox.Show("Hãy nhập đủ thông tin");
                }
                string sql = "update NHANVIEN set HoTen = '" + hovaten + "',  NgaySinh= '" + ns + "', SoDienThoai = '" + sdt + "', LuongCoBan ='" + LCB + "' ,TenDangNhap = '" + tendn + "', MatKhau = '" + mkh + "', Quyen  = '" + quyen + "'  where MaNhanVien = '" + mnv + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã cập nhật thành công");
                string sqlrl = "select *from NHANVIEN";
                SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
                conn.Close();

            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            conn.Open();
            string mnv = txtmanhanvien.Text;
            if (mnv.Length != 0)
            {
                string sql = "delete from NHANVIEN where MaNhanVien = '" + mnv + "' ";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                string sqlrl = "select *from NHANVIEN";
                SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Nhập mã nhân viên");

            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = nhapthongtintimkiem.Text;
            string sqlQuery = "SELECT * FROM NhanVien WHERE HoTen LIKE @TuKhoa";
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                    conn.Close();
                }
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmQLNhanVien_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            conn.Open();
            string sqlrl = "select *from NHANVIEN";
            SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }

        private void sodt_Click(object sender, EventArgs e)
        {

        }

        private void ngaysinh_Click(object sender, EventArgs e)
        {

        }

        private void hoTen_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void thongtinlienquan_Click(object sender, EventArgs e)
        {

        }

        private void quyen_Click(object sender, EventArgs e)
        {

        }

        private void matkhau_Click(object sender, EventArgs e)
        {

        }

        private void tendangnhap_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

		private void nhapmatkhau_TextChanged(object sender, EventArgs e)
		{

		}

		private void listBoxquyen_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
