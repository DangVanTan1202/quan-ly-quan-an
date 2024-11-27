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
    public partial class FrmThanhToan : Form
    {
        public FrmThanhToan()
        {
            InitializeComponent();
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

        private void txtTienthua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTienkhachdua_TextChanged(object sender, EventArgs e)
        {
            int tongt = int.Parse(txtTongtien.Text);
            int tkhachdua = int.Parse(txtTienkhachdua.Text);
            if (txtchietkhau.Text.Length != 0)
            {
                int ptChietkhau = int.Parse(txtchietkhau.Text);
                float tienthua = tkhachdua - tongt + tongt * ptChietkhau / 100;
                float TienTT = tongt - tongt * ptChietkhau / 100;
                txtTienTT.Text = TienTT.ToString();
                txtTienthua.Text = tienthua.ToString();
            }
            else
            {
                int ptChietkhau = 0;
                float tienthua = tkhachdua - tongt + tongt * ptChietkhau / 100;
                float TienTT = tongt - tongt * ptChietkhau / 100;
                txtTienTT.Text = TienTT.ToString();
                txtTienthua.Text = tienthua.ToString();
            }
        }

        private void txtchietkhau_TextChanged(object sender, EventArgs e)
        {
            int tongt = int.Parse(txtTongtien.Text);
            int tkhachdua = int.Parse(txtTienkhachdua.Text);
            if (txtchietkhau.Text.Length != 0)
            {
                int ptChietkhau = int.Parse(txtchietkhau.Text);
                float tienthua = tkhachdua - tongt + tongt * ptChietkhau / 100;
                float TienTT = tongt - tongt * ptChietkhau / 100;
                txtTienTT.Text = TienTT.ToString();
                txtTienthua.Text = tienthua.ToString();
            }
            else
            {
                int ptChietkhau = 0;
                float tienthua = tkhachdua - tongt + tongt * ptChietkhau / 100;
                float TienTT = tongt - tongt * ptChietkhau / 100;
                txtTienTT.Text = TienTT.ToString();
                txtTienthua.Text = tienthua.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGoiMon frmGoiMon = new FrmGoiMon();
            this.Hide();
            frmGoiMon.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string SoBan = cbbSoBan.Text;
            int SB = int.Parse(SoBan);
            if (SoBan.Length == 0)
            {
                MessageBox.Show("Chọn bàn");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
                conn.Open();
                DateTime dateTime = DateTime.Now;
                string dt = dateTime.ToString("MM-dd-yyyy");
                string dtMahoadon = dateTime.ToString("HH:mm-dd/MM/yyyy");
                string MaHoaDon = "B" + SoBan + "_" + dtMahoadon;
                int tienTT = int.Parse(txtTienTT.Text);
                string insert = "insert into HOADON values(N'" + MaHoaDon + "','" + tienTT + "', '" + dt + "')";
                SqlCommand sqlCommand = new SqlCommand(insert, conn);
                sqlCommand.ExecuteNonQuery();
                for (int i = 0; i < dgvDSMon.Rows.Count - 1; i++)
                {
                    //var MaMonAn = int.Parse(dgvDSMon.Rows[i].Cells[0].Value.ToString());
                    string TenMonAn = dgvDSMon.Rows[i].Cells[0].Value.ToString();
                    int Gia = int.Parse(dgvDSMon.Rows[i].Cells[1].Value.ToString());
                    int SoLuong = int.Parse(dgvDSMon.Rows[i].Cells[2].Value.ToString());
                    int ThanhTien = int.Parse(dgvDSMon.Rows[i].Cells[3].Value.ToString());

                    string sql = "insert into CHITIETHOADON values( N'"+MaHoaDon+"' , N'" + TenMonAn + "', '" + SoLuong + "', '" + Gia + "', '" + ThanhTien + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                
                string delete = "delete from GOIMON where SoBan = '" + SoBan + "'";
                SqlCommand command = new SqlCommand(delete, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Đã thanh toán thành công");

            }
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            labelNgayhientai.Text = dateTime.ToString("dd/MM/yyyy");
        }

        private void labelNgayhientai_Click(object sender, EventArgs e)
        {

        }

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}


