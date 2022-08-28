
using System;
using System.Windows.Forms;

namespace Mini_Market_Management_System
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboBox_category = new System.Windows.Forms.ComboBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox_search = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.TextBox_qty = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.TextBox_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_close = new System.Windows.Forms.Label();
            this.button_seller = new System.Windows.Forms.Button();
            this.button_category = new System.Windows.Forms.Button();
            this.button_selling = new System.Windows.Forms.Button();
            this.DataGridView_product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_logout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.ComboBox_category);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ComboBox_search);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.TextBox_qty);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.label_quantity);
            this.panel1.Controls.Add(this.label_Price);
            this.panel1.Controls.Add(this.label_category);
            this.panel1.Controls.Add(this.TextBox_price);
            this.panel1.Location = new System.Drawing.Point(218, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 609);
            this.panel1.TabIndex = 0;
            // 
            // ComboBox_category
            // 
            this.ComboBox_category.FormattingEnabled = true;
            this.ComboBox_category.Location = new System.Drawing.Point(111, 286);
            this.ComboBox_category.Name = "ComboBox_category";
            this.ComboBox_category.Size = new System.Drawing.Size(174, 29);
            this.ComboBox_category.TabIndex = 27;
            this.ComboBox_category.Text = "Select Category";
            // 
            // button_refresh
            // 
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.Location = new System.Drawing.Point(685, 41);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(113, 47);
            this.button_refresh.TabIndex = 24;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 43);
            this.label1.TabIndex = 25;
            this.label1.Text = "MANAGE PRODUCTS";
            // 
            // ComboBox_search
            // 
            this.ComboBox_search.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_search.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_search.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_search.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_search.ItemHeight = 30;
            this.ComboBox_search.Location = new System.Drawing.Point(505, 46);
            this.ComboBox_search.Name = "ComboBox_search";
            this.ComboBox_search.Size = new System.Drawing.Size(174, 36);
            this.ComboBox_search.TabIndex = 23;
            this.ComboBox_search.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_search_SelectionChangeCommitted);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.DataGridView_product);
            this.guna2Panel1.Location = new System.Drawing.Point(325, 94);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(540, 509);
            this.guna2Panel1.TabIndex = 23;
            // 
            // TextBox_qty
            // 
            this.TextBox_qty.BorderRadius = 10;
            this.TextBox_qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_qty.DefaultText = "";
            this.TextBox_qty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_qty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_qty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_qty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_qty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_qty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_qty.ForeColor = System.Drawing.Color.Black;
            this.TextBox_qty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_qty.Location = new System.Drawing.Point(111, 184);
            this.TextBox_qty.Name = "TextBox_qty";
            this.TextBox_qty.PasswordChar = '\0';
            this.TextBox_qty.PlaceholderText = "";
            this.TextBox_qty.SelectedText = "";
            this.TextBox_qty.Size = new System.Drawing.Size(174, 27);
            this.TextBox_qty.TabIndex = 15;
            this.TextBox_qty.TextChanged += new System.EventHandler(this.TextBox_quantity_TextChanged);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.Color.Goldenrod;
            this.label_id.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(16, 94);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(33, 29);
            this.label_id.TabIndex = 10;
            this.label_id.Text = "ID";
            // 
            // TextBox_id
            // 
            this.TextBox_id.BorderRadius = 10;
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.DefaultText = "";
            this.TextBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_id.ForeColor = System.Drawing.Color.Black;
            this.TextBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Location = new System.Drawing.Point(111, 94);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.Size = new System.Drawing.Size(174, 27);
            this.TextBox_id.TabIndex = 11;
            // 
            // button_update
            // 
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(116, 348);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(113, 47);
            this.button_update.TabIndex = 22;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Goldenrod;
            this.label_name.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(17, 138);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(63, 29);
            this.label_name.TabIndex = 12;
            this.label_name.Text = "Name";
            // 
            // button_delete
            // 
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(235, 348);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(86, 47);
            this.button_delete.TabIndex = 21;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextBox_name
            // 
            this.TextBox_name.BorderRadius = 10;
            this.TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_name.DefaultText = "";
            this.TextBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_name.ForeColor = System.Drawing.Color.Black;
            this.TextBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Location = new System.Drawing.Point(111, 138);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.PlaceholderText = "";
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.Size = new System.Drawing.Size(174, 27);
            this.TextBox_name.TabIndex = 13;
            // 
            // button_add
            // 
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(6, 348);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(113, 47);
            this.button_add.TabIndex = 20;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.BackColor = System.Drawing.Color.Goldenrod;
            this.label_quantity.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.Location = new System.Drawing.Point(17, 184);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(88, 29);
            this.label_quantity.TabIndex = 14;
            this.label_quantity.Text = "Quantity";
            this.label_quantity.Click += new System.EventHandler(this.label_quantity_Click);
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.BackColor = System.Drawing.Color.Goldenrod;
            this.label_Price.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(17, 227);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(55, 29);
            this.label_Price.TabIndex = 16;
            this.label_Price.Text = "Price";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.BackColor = System.Drawing.Color.Goldenrod;
            this.label_category.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.Location = new System.Drawing.Point(16, 286);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(88, 29);
            this.label_category.TabIndex = 18;
            this.label_category.Text = "Category";
            this.label_category.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBox_price
            // 
            this.TextBox_price.BorderRadius = 10;
            this.TextBox_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_price.DefaultText = "";
            this.TextBox_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_price.ForeColor = System.Drawing.Color.Black;
            this.TextBox_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_price.Location = new System.Drawing.Point(111, 227);
            this.TextBox_price.Name = "TextBox_price";
            this.TextBox_price.PasswordChar = '\0';
            this.TextBox_price.PlaceholderText = "";
            this.TextBox_price.SelectedText = "";
            this.TextBox_price.Size = new System.Drawing.Size(174, 27);
            this.TextBox_price.TabIndex = 17;
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_close.Location = new System.Drawing.Point(1067, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(31, 32);
            this.label_close.TabIndex = 9;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // button_seller
            // 
            this.button_seller.FlatAppearance.BorderSize = 0;
            this.button_seller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_seller.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seller.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_seller.Location = new System.Drawing.Point(27, 38);
            this.button_seller.Name = "button_seller";
            this.button_seller.Size = new System.Drawing.Size(113, 47);
            this.button_seller.TabIndex = 26;
            this.button_seller.Text = "Seller";
            this.button_seller.UseVisualStyleBackColor = true;
            this.button_seller.Click += new System.EventHandler(this.button_seller_Click);
            // 
            // button_category
            // 
            this.button_category.FlatAppearance.BorderSize = 0;
            this.button_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_category.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_category.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_category.Location = new System.Drawing.Point(27, 110);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(113, 47);
            this.button_category.TabIndex = 27;
            this.button_category.Text = "Category";
            this.button_category.UseVisualStyleBackColor = true;
            this.button_category.Click += new System.EventHandler(this.button_category_Click);
            // 
            // button_selling
            // 
            this.button_selling.FlatAppearance.BorderSize = 0;
            this.button_selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selling.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selling.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_selling.Location = new System.Drawing.Point(27, 199);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(113, 47);
            this.button_selling.TabIndex = 28;
            this.button_selling.Text = "Selling";
            this.button_selling.UseVisualStyleBackColor = true;
            this.button_selling.Click += new System.EventHandler(this.button_selling_Click);
            // 
            // DataGridView_product
            // 
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.White;
            this.DataGridView_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle43;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.DataGridView_product.ColumnHeadersHeight = 29;
            this.DataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_product.DefaultCellStyle = dataGridViewCellStyle45;
            this.DataGridView_product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_product.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_product.Name = "DataGridView_product";
            this.DataGridView_product.RowHeadersVisible = false;
            this.DataGridView_product.RowHeadersWidth = 51;
            this.DataGridView_product.RowTemplate.Height = 24;
            this.DataGridView_product.Size = new System.Drawing.Size(539, 508);
            this.DataGridView_product.TabIndex = 0;
            this.DataGridView_product.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_product.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_product.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_product.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_product.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_product.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_product.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_product.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_product.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_product.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_product.ThemeStyle.HeaderStyle.Height = 29;
            this.DataGridView_product.ThemeStyle.ReadOnly = false;
            this.DataGridView_product.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_product.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_product.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_product.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView_product.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView_product.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_product.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_product.Click += new System.EventHandler(this.DataGridView_product_Click_1);
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_logout.Location = new System.Drawing.Point(28, 606);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(111, 32);
            this.label_logout.TabIndex = 37;
            this.label_logout.Text = "LOGOUT";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            this.label_logout.MouseEnter += new System.EventHandler(this.label_logout_MouseEnter);
            this.label_logout.MouseLeave += new System.EventHandler(this.label_logout_MouseLeave);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 652);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.button_seller);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_id;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private System.Windows.Forms.Label label_name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_qty;
        private System.Windows.Forms.Label label_quantity;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_price;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_search;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button button_seller;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.Button button_selling;
        private System.Windows.Forms.ComboBox ComboBox_category;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_product;
        private Label label_logout;
    }
}