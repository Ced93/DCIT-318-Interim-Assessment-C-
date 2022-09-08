namespace Shoprite__Inventory_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernameTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter The userName And Password");
            }
            else
            {
                if (RoleCb.SelectedIndex > -1)
                {
                    if (RoleCb.SelectedItem.ToString() == "ADMIN")
                    {
                        if (UsernameTb.Text == "Admin" && PassTb.Text == "Admin")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are The Admin Enter the Correct Username And Password ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You are in The Seller Section");
                    }

                }
                else
                {
                    MessageBox.Show("Select A Role");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }
    }
}