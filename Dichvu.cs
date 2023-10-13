using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien_qlpks
{
    public partial class Dichvu : Form
    {
        public Dichvu()
        {
            InitializeComponent();
            loaddichvulist();
        }
        void loaddichvulist()
        {
            try
            {
                string connectionSTR = @"Data Source=LAPTOP-JKMABAVK\TESTSQL;Initial Catalog=QUANLYPHONGKHACHSAN;Integrated Security=True;TrustServerCertificate=true;";
                SqlConnection connection = new SqlConnection(connectionSTR);
                string query = "SELECT * FROM [dbo].[Table_SANPHAM]";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
                dtgvdichvu.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void Dichvu_Load(object sender, EventArgs e)
        {

        }

        private void btcapnhap_Click(object sender, EventArgs e)
        {

        }

        private void xoa_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtgvdichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
