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
using DGVPrinterHelper;

namespace Mini_Market_Management_System
{
    public partial class SellingForm : Form
    {

        DBconnect dBCon = new DBconnect();
        DGVPrinter printer = new DGVPrinter();
        public SellingForm()
        {
            InitializeComponent();
        }
        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "CatName";
            
        }

        private void getTable()
        {
            string selectQuerry = "SELECT ProdName,  ProdPrice FROM Product";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;

        }

        private void getSellerTable() 
        {
            string selectQuerry = "SELECT * FROM Bill";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_sellList.DataSource = table;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int grandTotal = 0, n = 0;
        private void button_add_Click(object sender, EventArgs e)
        {
            if (TextBox_name.Text == "" || TextBox_qty.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                int Total = Convert.ToInt32(TextBox_qty.Text) * Convert.ToInt32(TextBox_price.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(DataGridView_order);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = TextBox_name.Text;
                addRow.Cells[2].Value = TextBox_price.Text;
                addRow.Cells[3].Value = TextBox_qty.Text;
                addRow.Cells[4].Value = Total;
                DataGridView_order.Rows.Add(addRow);
                grandTotal += Total;
                label_ghc.Text = grandTotal + "GHC";

            }
        }

        private void DataGridView_seller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_price_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_phoneno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_phoneno_Click(object sender, EventArgs e)
        {

        }

        private void label_sellername_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_amount_Click(object sender, EventArgs e)
        {

        }

        private void label_ks_Click(object sender, EventArgs e)
        {

        }
        


        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_sellername.Text = LoginForm.SellerName;
            label_date.Text = DateTime.Today.ToShortDateString();
            getTable();
            getSellerTable();
            getCategory();
        }

        private void TextBox_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_sales_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Bill VALUES(" + TextBox_id.Text + ",'" + label_sellername.Text + "','" + label_date.Text + "','" + grandTotal.ToString()+ "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getSellerTable();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "MiniMarket Sales";
            printer.SubTitle = string.Format("Date:{0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "fox.learn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_sellList);

        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Red;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Goldenrod;
        }

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Red;
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Goldenrod;
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT ProdName, ProdPrice FROM Product WHERE ProdCat='" + comboBox_category.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_product.DataSource = table;
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView_sellList.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string deleteQuery = "DELETE FROM Bill WHERE BillId=" + DataGridView_sellList.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Bill Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dBCon.CloseCon();
                        getTable();
                        

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView_product_Click(object sender, EventArgs e)
        {
            TextBox_name.Text = DataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_price.Text = DataGridView_product.SelectedRows[0].Cells[1].Value.ToString();

        }
    }
}
