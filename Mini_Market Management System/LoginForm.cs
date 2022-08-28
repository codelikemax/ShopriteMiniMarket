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

namespace Mini_Market_Management_System
{
    public partial class LoginForm : Form
    {

        DBconnect dBCon = new DBconnect();
        public static string SellerName;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Red;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Goldenrod;
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Goldenrod;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if(TextBox_username.Text == "" || TextBox_password.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (comboBox_role.SelectedIndex > -1)

            {
                if (comboBox_role.SelectedItem.ToString() == "ADMIN")
                {
                    if (TextBox_username.Text == "Admin" && TextBox_password.Text == "Admin123")
                    {
                        ProductForm product = new ProductForm();
                        product.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("If you are Admin, Please Enter the Correct ID and Password", "Miss ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    string selectQuery = "SELECT * FROM Seller WHERE SellerName = '" + TextBox_username.Text + "' AND SellerPassword='" + TextBox_password.Text + "'";
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.GetCon());
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        SellerName = TextBox_username.Text;
                        SellingForm selling = new SellingForm();
                        selling.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                    {
                        MessageBox.Show("Please Select Role", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
    }
}

