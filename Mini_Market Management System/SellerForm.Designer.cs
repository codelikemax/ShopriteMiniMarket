
namespace Mini_Market_Management_System
{
    partial class SellerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_logout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.DataGridView_seller = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TextBox_age = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.button_selling = new System.Windows.Forms.Button();
            this.button_category = new System.Windows.Forms.Button();
            this.button_product = new System.Windows.Forms.Button();
            this.label_close = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label_age = new System.Windows.Forms.Label();
            this.TextBox_phoneno = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_phoneno = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_password = new System.Windows.Forms.Label();
            this.TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_seller)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_logout.Location = new System.Drawing.Point(28, 606);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(111, 32);
            this.label_logout.TabIndex = 43;
            this.label_logout.Text = "LOGOUT";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            this.label_logout.MouseEnter += new System.EventHandler(this.label_logout_MouseEnter);
            this.label_logout.MouseLeave += new System.EventHandler(this.label_logout_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(268, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 43);
            this.label1.TabIndex = 25;
            this.label1.Text = "MANAGE SELLER";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.DataGridView_seller);
            this.guna2Panel1.Location = new System.Drawing.Point(325, 94);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(540, 509);
            this.guna2Panel1.TabIndex = 23;
            // 
            // DataGridView_seller
            // 
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.White;
            this.DataGridView_seller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle46;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_seller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.DataGridView_seller.ColumnHeadersHeight = 29;
            this.DataGridView_seller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_seller.DefaultCellStyle = dataGridViewCellStyle48;
            this.DataGridView_seller.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_seller.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_seller.Name = "DataGridView_seller";
            this.DataGridView_seller.RowHeadersVisible = false;
            this.DataGridView_seller.RowHeadersWidth = 51;
            this.DataGridView_seller.RowTemplate.Height = 24;
            this.DataGridView_seller.Size = new System.Drawing.Size(539, 508);
            this.DataGridView_seller.TabIndex = 0;
            this.DataGridView_seller.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_seller.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_seller.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_seller.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_seller.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_seller.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_seller.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_seller.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_seller.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_seller.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_seller.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_seller.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_seller.ThemeStyle.HeaderStyle.Height = 29;
            this.DataGridView_seller.ThemeStyle.ReadOnly = false;
            this.DataGridView_seller.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_seller.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_seller.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_seller.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView_seller.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView_seller.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_seller.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_seller.Click += new System.EventHandler(this.DataGridView_seller_Click);
            // 
            // TextBox_age
            // 
            this.TextBox_age.BorderRadius = 10;
            this.TextBox_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_age.DefaultText = "";
            this.TextBox_age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_age.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_age.ForeColor = System.Drawing.Color.Black;
            this.TextBox_age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_age.Location = new System.Drawing.Point(135, 186);
            this.TextBox_age.Name = "TextBox_age";
            this.TextBox_age.PasswordChar = '\0';
            this.TextBox_age.PlaceholderText = "";
            this.TextBox_age.SelectedText = "";
            this.TextBox_age.Size = new System.Drawing.Size(174, 27);
            this.TextBox_age.TabIndex = 15;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.Color.Goldenrod;
            this.label_id.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.White;
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
            this.TextBox_id.Location = new System.Drawing.Point(135, 96);
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
            this.button_update.ForeColor = System.Drawing.Color.White;
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
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(17, 138);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(63, 29);
            this.label_name.TabIndex = 12;
            this.label_name.Text = "Name";
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
            this.button_selling.TabIndex = 42;
            this.button_selling.Text = "Selling";
            this.button_selling.UseVisualStyleBackColor = true;
            this.button_selling.Click += new System.EventHandler(this.button_selling_Click);
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
            this.button_category.TabIndex = 41;
            this.button_category.Text = "Category";
            this.button_category.UseVisualStyleBackColor = true;
            this.button_category.Click += new System.EventHandler(this.button_category_Click);
            // 
            // button_product
            // 
            this.button_product.FlatAppearance.BorderSize = 0;
            this.button_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_product.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_product.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_product.Location = new System.Drawing.Point(27, 38);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(113, 47);
            this.button_product.TabIndex = 40;
            this.button_product.Text = "Product";
            this.button_product.UseVisualStyleBackColor = true;
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_close.Location = new System.Drawing.Point(1055, 4);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(31, 32);
            this.label_close.TabIndex = 39;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // button_delete
            // 
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(235, 348);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(86, 47);
            this.button_delete.TabIndex = 21;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
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
            this.TextBox_name.Location = new System.Drawing.Point(135, 140);
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
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(6, 348);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(113, 47);
            this.button_add.TabIndex = 20;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.BackColor = System.Drawing.Color.Goldenrod;
            this.label_age.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.ForeColor = System.Drawing.Color.White;
            this.label_age.Location = new System.Drawing.Point(17, 184);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(44, 29);
            this.label_age.TabIndex = 14;
            this.label_age.Text = "Age";
            // 
            // TextBox_phoneno
            // 
            this.TextBox_phoneno.BorderRadius = 10;
            this.TextBox_phoneno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_phoneno.DefaultText = "";
            this.TextBox_phoneno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_phoneno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_phoneno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_phoneno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_phoneno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_phoneno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_phoneno.ForeColor = System.Drawing.Color.Black;
            this.TextBox_phoneno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_phoneno.Location = new System.Drawing.Point(135, 229);
            this.TextBox_phoneno.Name = "TextBox_phoneno";
            this.TextBox_phoneno.PasswordChar = '\0';
            this.TextBox_phoneno.PlaceholderText = "";
            this.TextBox_phoneno.SelectedText = "";
            this.TextBox_phoneno.Size = new System.Drawing.Size(174, 27);
            this.TextBox_phoneno.TabIndex = 17;
            // 
            // label_phoneno
            // 
            this.label_phoneno.AutoSize = true;
            this.label_phoneno.BackColor = System.Drawing.Color.Goldenrod;
            this.label_phoneno.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phoneno.ForeColor = System.Drawing.Color.White;
            this.label_phoneno.Location = new System.Drawing.Point(17, 227);
            this.label_phoneno.Name = "label_phoneno";
            this.label_phoneno.Size = new System.Drawing.Size(99, 29);
            this.label_phoneno.TabIndex = 16;
            this.label_phoneno.Text = "Phone No.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.label_password);
            this.panel1.Controls.Add(this.TextBox_password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.TextBox_age);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.label_age);
            this.panel1.Controls.Add(this.label_phoneno);
            this.panel1.Controls.Add(this.TextBox_phoneno);
            this.panel1.Location = new System.Drawing.Point(218, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 609);
            this.panel1.TabIndex = 38;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Goldenrod;
            this.label_password.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(17, 280);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(94, 29);
            this.label_password.TabIndex = 26;
            this.label_password.Text = "Password";
            // 
            // TextBox_password
            // 
            this.TextBox_password.BorderRadius = 10;
            this.TextBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_password.DefaultText = "";
            this.TextBox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_password.ForeColor = System.Drawing.Color.Black;
            this.TextBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.Location = new System.Drawing.Point(135, 282);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.PasswordChar = '●';
            this.TextBox_password.PlaceholderText = "";
            this.TextBox_password.SelectedText = "";
            this.TextBox_password.Size = new System.Drawing.Size(174, 27);
            this.TextBox_password.TabIndex = 27;
            this.TextBox_password.UseSystemPasswordChar = true;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 652);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.button_product);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_seller)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_seller;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_age;
        private System.Windows.Forms.Label label_id;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_selling;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.Button button_product;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Button button_delete;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_age;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_phoneno;
        private System.Windows.Forms.Label label_phoneno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_password;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
    }
}