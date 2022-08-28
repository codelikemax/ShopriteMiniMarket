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
    public partial class SellerForm : Form
    {
        DBconnect dBCon = new DBconnect();
        public SellerForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Seller";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_seller.DataSource = table;

        }


        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_age.Clear();
            TextBox_password.Clear();

        }
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {

                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_age.Text == "" || TextBox_phoneno.Text == "" || TextBox_password.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string insertQuery = "INSERT INTO Seller VALUES(" + TextBox_id.Text + ",'" + TextBox_name.Text + "','" + TextBox_age.Text + "','" + TextBox_phoneno.Text + "','" + TextBox_password.Text + "')";
                    SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "" || TextBox_name.Text == "" || TextBox_age.Text == "" || TextBox_phoneno.Text == "" ||TextBox_password.Text =="")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string updateQuery = "UPDATE Seller SET SellerName='" + TextBox_name.Text + "',SellerAge='" + TextBox_age.Text + "', SellerPhoneno='" + TextBox_phoneno.Text + "', SellerPassword='" + TextBox_password.Text + "'WHERE SellerId=" + TextBox_id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DataGridView_seller_Click(object sender, EventArgs e)
        {
            TextBox_id.Text = DataGridView_seller.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = DataGridView_seller.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_age.Text = DataGridView_seller.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_phoneno.Text = DataGridView_seller.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_password.Text = DataGridView_seller.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string deleteQuery = "DELETE FROM Seller WHERE SellerId=" + TextBox_id.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Seller Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dBCon.CloseCon();
                        getTable();
                        clear();

                    }   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_selling_Click(object sender, EventArgs e)
        {

        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Red;
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Goldenrod;
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Red;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Goldenrod;
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide(); 
        }
    }
    }

