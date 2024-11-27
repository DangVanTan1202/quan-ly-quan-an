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
    public partial class FrmGoiMon : Form
    {
        public FrmGoiMon()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tukhoa = txtThongTinTK.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            string sql = "select * from MONAN where TenMonAn like C ";
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from MONAN where TenMonAn like N'%" + tukhoa + "%' ", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            LSVKetQua.Items.Clear();
            while (rdr.Read())
            {
                ListViewItem item = new ListViewItem(rdr.GetInt32(0) + "");
                item.SubItems.Add(rdr.GetString(1));
                item.SubItems.Add(rdr.GetInt32(2) + "");

                LSVKetQua.Items.Add(item);
            }
            rdr.Close();
        }

        private void LSVKetQua_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SoLuong = Convert.ToInt32(numUDSoLuong.Value);
            if (LSVKetQua.SelectedItems.Count > 0 && SoLuong != 0 )
            {
                string tt = txtTongTien.Text;
                
                if(tt.Length != 0)
                {
                    int tong = Convert.ToInt32(tt);

                    ListViewItem item = LSVKetQua.SelectedItems[0];
                    int MaMonAn = Int32.Parse(item.SubItems[0].Text);
                    string TenMonAn = item.SubItems[1].Text;
                    int Gia = Int32.Parse(item.SubItems[2].Text);

                    int ThanhTien = SoLuong * Gia;
                    tong = tong + ThanhTien;

                    txtTongTien.Text = tong.ToString();
                    AddRowToDataGridView(MaMonAn, TenMonAn, Gia, SoLuong, ThanhTien);
                    //dgvDSMon.Rows.Add(MaMonAn, TenMonAn, Gia, SoLuong, ThanhTien);
                }
                else
                {
                    int tong = 0;

                    ListViewItem item = LSVKetQua.SelectedItems[0];
                    int MaMonAn = Int32.Parse(item.SubItems[0].Text);
                    string TenMonAn = item.SubItems[1].Text;
                    int Gia = Int32.Parse(item.SubItems[2].Text);

                    int ThanhTien = SoLuong * Gia;
                    tong = tong + ThanhTien;

                    txtTongTien.Text = tong.ToString();
                    AddRowToDataGridView(MaMonAn, TenMonAn, Gia, SoLuong, ThanhTien);
                    //dgvDSMon.Rows.Add(MaMonAn, TenMonAn, Gia, SoLuong, ThanhTien);
                }
            }
            else
            {
                MessageBox.Show("Chọn số lượng món");
            }
        }

        private void AddRowToDataGridView(int col1Value, string col2Value, int col3Value, int col4Value, int col5Value)
        {
            // Tạo một DataTable nếu DataGridView chưa có dữ liệu
            if (dgvDSMon.DataSource == null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Column1");
                dt.Columns.Add("Column2");
                dgvDSMon.DataSource = dt;
            }

            // Lấy DataTable từ DataGridView
            DataTable dataTable = (DataTable)dgvDSMon.DataSource;

            // Thêm dữ liệu từ ListView vào DataTable
            DataRow newRow = dataTable.NewRow();
            newRow["MaMonAn"] = col1Value;
            newRow["TenMonAn"] = col2Value;
            newRow["Gia"] = col3Value;
            newRow["SoLuong"] = col4Value;
            newRow["ThanhTien"] = col5Value;
            dataTable.Rows.Add(newRow);

            // Cập nhật DataGridView
            dgvDSMon.DataSource = dataTable;
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            string SoBan = cbbSoBan.Text;
            
            if (SoBan.Length == 0)
            {
                MessageBox.Show("Chọn bàn");
            }
            else
            {
                int SB = int.Parse(SoBan);
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
                conn.Open();
                string delete = "delete from GOIMON where SoBan = '" + SoBan + "'";
                SqlCommand command = new SqlCommand(delete, conn);
                command.ExecuteNonQuery();
                for(int i = 0; i < dgvDSMon.Rows.Count - 1; i++)
                {
                    var MaMonAn = int.Parse(dgvDSMon.Rows[i].Cells[0].Value.ToString());
                    string TenMonAn = dgvDSMon.Rows[i].Cells[1].Value.ToString();
                    int Gia = int.Parse(dgvDSMon.Rows[i].Cells[2].Value.ToString());
                    int SoLuong = int.Parse(dgvDSMon.Rows[i].Cells[3].Value.ToString());
                    int ThanhTien = int.Parse(dgvDSMon.Rows[i].Cells[4].Value.ToString());

                    string sql = "insert into GOIMON values('" + SB + "', '" + MaMonAn + "', N'" + TenMonAn + "', '" + Gia + "', '" + SoLuong + "', '" + ThanhTien + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã đặt món thành công");
            }
        }

        private void cbbSoBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
            string SoBan = cbbSoBan.Text;
            MessageBox.Show("Chọn bàn '" + SoBan + "'");

            conn.Open();
            string sql = "select MaMonAn, TenMonAn, Gia, SoLuong, ThanhTien from GOIMON where SoBan = '" + SoBan + "'";
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
            txtTongTien.Text = tongTien.ToString();


        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            string SoBan = cbbSoBan.Text;
            if (SoBan.Length == 0)
            {
                MessageBox.Show("Chọn bàn");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-EEQLAOM2\\SQLEXPRESS01;Initial Catalog=quanliquanan;Integrated Security=True;Trust Server Certificate=True");
                conn.Open();
                string delete = "delete from GOIMON where SoBan = '" + SoBan + "'";
                SqlCommand command = new SqlCommand(delete, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Đã xóa bàn");
                string sql = "select MaMonAn, TenMonAn, Gia, SoLuong, ThanhTien from GOIMON where SoBan = '" + SoBan + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dgvDSMon.DataSource = dt;
                txtTongTien.Text = "0";
            }
        }

        private void btnInTamTinh_Click(object sender, EventArgs e)
        {
            FrmInTamTinh frmInTamTinh = new FrmInTamTinh();
            this.Hide();
            frmInTamTinh.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            FrmThanhToan frmThanh = new FrmThanhToan();
            this.Hide();
            frmThanh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKiemMon frmKiemMon = new FrmKiemMon();
            this.Hide();
            frmKiemMon.Show();
        }
    }
}
