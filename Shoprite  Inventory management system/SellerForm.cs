using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shoprite__Inventory_management_system
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cedric Danvide\Documents\Shoperite Management System.mdf"";Integrated Security=True;Connect Timeout=30");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into SellerTbl values(" + SId.Text + ",'" + SName.Text + "','" + SDob.Text + "','" + SNumber.Text + "','" + SPassword.Text + "') ";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Successfully Added");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
