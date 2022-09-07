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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            SDob.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            SNumber.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            SPassword.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if(SId.Text == "")
                {
                    MessageBox.Show("Select The Seller to Delete ");
                }
                else
                {
                    Con.Open();
                    string query = "delete from SellerTbl where SellerId= " + SId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    Con.Close();
                    populate();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (SId.Text == "" || SName.Text == "" || SDob.Text == "" || SNumber.Text == "" || SPassword.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update SellerTbl set SName='" + SName.Text + "',SDob='" + SDob.Text + "',SNumber='" + SNumber.Text + "',SPassword='" + SPassword.Text + "' where SId= " + SId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Successfully Updated ");
                    Con.Close();
                    populate();
                }
            }catch(System.Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
