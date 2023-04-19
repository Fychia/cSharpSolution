using System;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PharmacyManagement
{
    public partial class Medicine : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WorkSpace\CSharp\YouTubeProjects\PharmacyManagement\ManagementPharmacy_db.mdf;Integrated Security=True;Connect Timeout=30");
        public Medicine()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlCommand addCmd = new SqlCommand("insert into Medicine_tbl values('" + tb_MedicineName.Text + "', '" + tb_BuyingPrice.Text + "', '" + tb_SellingPrice.Text + "', '" + tb_Quantity.Text + "', '" + ExpireDate.Text + "', '"+ cb_Company.SelectedItem.ToString()+ "')", Con);
            addCmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Added");

            Con.Close();
        }
    }
}
