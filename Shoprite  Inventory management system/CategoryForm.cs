using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shoprite__Inventory_management_system
{
    public partial class CATEGORYFORM :Form
    {
        public CATEGORYFORM()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Cedric Danvide\Documents\Shoprite database.mdf"";Integrated Security=True;Connect Timeout=30");
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CategoryTbl values(" + CatIdTb.Text + ",'" + CatNameTb.Text + "','" + CatDescTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category has been Added Successsfully");
                Con.Close();
                populate();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void CATEGORYFORM_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void catDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           CatIdTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
           CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
           CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatIdTb.Text == "")
                {
                    MessageBox.Show("Select the Category to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTbl where CatId=" + CatIdTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category has been Deleted Successuflly");
                    Con.Close();
                    populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update CategoryTbl set CatName='" + CatNameTb.Text + "',CatDesc = '" + CatDescTb.Text + "'  where CatId =" + CatIdTb.Text + " ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated ");
                    Con.Close();
                    populate();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
