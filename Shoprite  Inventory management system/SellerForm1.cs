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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using System.Net;
//using System.Web.Security;

namespace Shoprite__Inventory_management_system
{
    public partial class SellerForm1 : Form
    {
        public SellerForm1()
        {
            InitializeComponent();
        }
        SqlConnection  Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cedric Danvide\Documents\Shoprite database.mdf"";Integrated Security=True;Connect Timeout=30");
        private void button5_Click(object sender, EventArgs e)
        {
             try
            {
                Con.Open();
                string query = "insert into SellerTbl values(" +SId.Text+ ",'" +SName.Text+ "','" +SDob.Text+ "','" +SNumber.Text+ "','" +SPassword.Text+ "')";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller has been Added Successfuly");
                Con.Close();
                populate();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from SellerTbl", Con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            cmd.ExecuteNonQuery();
            Con.Close();
        }
        private void SellerForm1_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
