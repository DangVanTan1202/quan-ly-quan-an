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
    public partial class FrmQLChiTieu : Form
    {
        public FrmQLChiTieu()
        {
            InitializeComponent();
        }

        private void FrmQLChiTieu_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            conn.Open();
            string sqlrl = "select *from CHITIEU";
            SqlCommand cmd = new SqlCommand(sqlrl, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridViewChitieu.DataSource = dt;
            conn.Close();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            conn.Open();
            string tmh = textBoxTennguyenlieu.Text;
            DateTime dtnm = dtpNgaymua.Value;
            string nm = dtnm.ToString("MM/dd/yyyy");
            if (tmh.Length == 0)
            {
                MessageBox.Show("Nhập tên mặt hàng");
            }
            else
            {
                string sql = "delete from CHITIEU where TenMatHAng = N'" + tmh + "' and NgayMua = '" + nm + "'  ";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                string sqlrl = "select *from CHITIEU";
                SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewChitieu.DataSource = dt;
                conn.Close();
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            conn.Open();
            string tmh = textBoxTennguyenlieu.Text;
            string gt = textBoxGiatien.Text;
            DateTime dtnm = dtpNgaymua.Value;
            string nm = dtnm.ToString("MM/dd/yyyy");
            if (tmh.Length == 0)
            {
                MessageBox.Show("Nhập tên mặt hàng");
            }
            else
            {
                string sql = "update CHITIEU set GiaTien = '" + gt + "' , NgayMua = '" + nm + "' where TenMatHAng = N'" + tmh + "' ";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                string sqlrl = "select *from CHITIEU";
                SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewChitieu.DataSource = dt;
                conn.Close();
            }
        }

        private void buttonTimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = textBoxTennguyenlieu.Text;
            string sqlQuery = "SELECT * FROM CHITIEU WHERE TenMatHang LIKE @TuKhoa";
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewChitieu.DataSource = dt;
                    conn.Close();
                }
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string tmh = textBoxTennguyenlieu.Text;
            string tien = textBoxGiatien.Text;
            DateTime dtnm = dtpNgaymua.Value;
            string nm = dtnm.ToString("MM/dd/yyyy");
            if (tmh.Length == 0 || tien.Length == 0 || nm.Length == 0)
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
                conn.Open();
                string sql = "insert into CHITIEU values(N'" + tmh + "', '" + tien + "', '" + nm + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công");
                string sqlrl = "select *from CHITIEU";
                SqlCommand sqlCommand = new SqlCommand(sqlrl, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewChitieu.DataSource = dt;
                conn.Close();
            }
        }

        private void labelNgay_Click(object sender, EventArgs e)
        {

        }
    }
 }


