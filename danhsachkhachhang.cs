using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GiaoDien_qlpks
{
    public partial class danhsachkhachhang : Form
    {
        public danhsachkhachhang()
        {
            InitializeComponent();
            loadkhachhanglist();
        }
        void loadkhachhanglist()
        {
            try
            {
                string connectionSTR = @"Data Source=LAPTOP-JKMABAVK\TESTSQL;Initial Catalog=QUANLYPHONGKHACHSAN;Integrated Security=True;TrustServerCertificate=true;";
                SqlConnection connection = new SqlConnection(connectionSTR);
                string query = "SELECT * FROM [dbo].[Table.KHACHHANG]";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbmakhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo chỉ số hàng hợp lệ được chọn
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // Lấy dữ liệu từ dòng đã chọn
                tbmakhachhang.Text = row.Cells["MAKHACHHANG"].Value.ToString();
                tbtenkhach.Text = row.Cells["TENKHACHHANG"].Value.ToString();
                tbsđt.Text = row.Cells["SĐT"].Value.ToString();
                tbcccd.Text = row.Cells["CCCD"].Value.ToString();
                tbidphong.Text = row.Cells["IDPHONG"].Value.ToString();
                // "Tên_Cột" là tên của cột mà bạn muốn lấy dữ liệu từ đó
            }
        }

        private void tbtenkhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbtenkhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void chinhsua_Click(object sender, EventArgs e)
        {

        }
    }
}
