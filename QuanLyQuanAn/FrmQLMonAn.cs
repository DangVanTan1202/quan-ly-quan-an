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
    public partial class FrmQLMonAn : Form
    {
        public FrmQLMonAn()
        {
            InitializeComponent();
        }

        private void FrmQLMonAn_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KEST8LBE\SQLEXPRESS01;Initial Catalog=QLQuanAn;Integrated Security=True");
            conn.Open();
            string sqlrl = "select *from MONAN";
            SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string mma = txtMma.Text;
            string tm = txtTenmon.Text;
            string gia = txtGia.Text;

            if (tm.Length == 0 || gia.Length == 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KEST8LBE\SQLEXPRESS01;Initial Catalog=QLQuanAn;Integrated Security=True");
                conn.Open();
                string sql = "insert into MONAN(TenMonAn,Gia) values ( N'" + tm + "','" + gia + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công");
                string sqlrl = "select *from MONAN";
                SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
                conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string mma = txtMma.Text;
            if (mma.Length == 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
                conn.Open();
                string sql = "delete from MonAn where Mamonan = '" + mma + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("đã xóa thanh công");
                string sqlrl = "select *from MonAn";
                SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
                conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            string mma = txtMma.Text;
            string tm = txtTenmon.Text;
            string gia = txtGia.Text;
            int Gia = int.Parse(gia);
            if (mma.Length == 0)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
                conn.Open();
                string sql = "update  MonAn set Tenmonan ='" + tm + "', Gia= '" + Gia + "' where Mamonan='" + mma + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("đã cập nhật thanh công");
                string sqlrl = "select *from MonAn";
                SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
                conn.Close();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txttukhoa.Text;
            string sqlQuery = "SELECT * FROM MonAn WHERE Tenmonan LIKE @TuKhoa";
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
                    conn.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
