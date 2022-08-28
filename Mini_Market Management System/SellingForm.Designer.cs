
namespace Mini_Market_Management_System
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_addOrder = new System.Windows.Forms.Button();
            this.label_price = new System.Windows.Forms.Label();
            this.label_logout = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label_close = new System.Windows.Forms.Label();
            this.TextBox_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridView_order = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_selling = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label_billid = new System.Windows.Forms.Label();
            this.label_Amount = new System.Windows.Forms.Label();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_ghc = new System.Windows.Forms.Label();
            this.label_sales = new System.Windows.Forms.Label();
            this.DataGridView_sellList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_qty = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_sellername = new System.Windows.Forms.Label();
            this.DataGridView_product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_name = new System.Windows.Forms.Label();
            this.label_qty = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_order)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_sellList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_product)).BeginInit();
            this.SuspendLayout();
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
            this.TextBox_name.Location = new System.Drawing.Point(135, 90);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.PlaceholderText = "";
            this.TextBox_name.ReadOnly = true;
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.Size = new System.Drawing.Size(174, 27);
            this.TextBox_name.TabIndex = 13;
            this.TextBox_name.TextChanged += new System.EventHandler(this.TextBox_name_TextChanged);
            // 
            // button_addOrder
            // 
            this.button_addOrder.FlatAppearance.BorderSize = 0;
            this.button_addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addOrder.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addOrder.ForeColor = System.Drawing.Color.White;
            this.button_addOrder.Location = new System.Drawing.Point(208, 228);
            this.button_addOrder.Name = "button_addOrder";
            this.button_addOrder.Size = new System.Drawing.Size(111, 33);
            this.button_addOrder.TabIndex = 20;
            this.button_addOrder.Text = "Add Order";
            this.button_addOrder.UseVisualStyleBackColor = true;
            this.button_addOrder.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.BackColor = System.Drawing.Color.Goldenrod;
            this.label_price.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.ForeColor = System.Drawing.Color.White;
            this.label_price.Location = new System.Drawing.Point(17, 134);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(55, 29);
            this.label_price.TabIndex = 14;
            this.label_price.Text = "Price";
            this.label_price.Click += new System.EventHandler(this.label_price_Click);
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_logout.Location = new System.Drawing.Point(21, 608);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(111, 32);
            this.label_logout.TabIndex = 49;
            this.label_logout.Text = "LOGOUT";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            this.label_logout.MouseEnter += new System.EventHandler(this.label_logout_MouseEnter);
            this.label_logout.MouseLeave += new System.EventHandler(this.label_logout_MouseLeave);
            // 
            // button_add
            // 
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(461, 219);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(76, 41);
            this.button_add.TabIndex = 22;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click_1);
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_close.Location = new System.Drawing.Point(1066, 2);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(31, 32);
            this.label_close.TabIndex = 45;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
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
            this.TextBox_price.Location = new System.Drawing.Point(135, 136);
            this.TextBox_price.Name = "TextBox_price";
            this.TextBox_price.PasswordChar = '\0';
            this.TextBox_price.PlaceholderText = "";
            this.TextBox_price.ReadOnly = true;
            this.TextBox_price.SelectedText = "";
            this.TextBox_price.Size = new System.Drawing.Size(174, 27);
            this.TextBox_price.TabIndex = 15;
            this.TextBox_price.TextChanged += new System.EventHandler(this.TextBox_age_TextChanged);
            // 
            // DataGridView_order
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.DataGridView_order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridView_order.ColumnHeadersHeight = 29;
            this.DataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.Total});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_order.DefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridView_order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_order.Location = new System.Drawing.Point(0, 3);
            this.DataGridView_order.Name = "DataGridView_order";
            this.DataGridView_order.RowHeadersVisible = false;
            this.DataGridView_order.RowHeadersWidth = 51;
            this.DataGridView_order.RowTemplate.Height = 24;
            this.DataGridView_order.Size = new System.Drawing.Size(539, 159);
            this.DataGridView_order.TabIndex = 0;
            this.DataGridView_order.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_order.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_order.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_order.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_order.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_order.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_order.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_order.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_order.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_order.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_order.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_order.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_order.ThemeStyle.HeaderStyle.Height = 29;
            this.DataGridView_order.ThemeStyle.ReadOnly = false;
            this.DataGridView_order.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_order.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_order.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_order.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView_order.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView_order.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_order.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_seller_CellContentClick);
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.MinimumWidth = 6;
            this.ProdId.Name = "ProdId";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.MinimumWidth = 6;
            this.ProdPrice.Name = "ProdPrice";
            // 
            // ProdQty
            // 
            this.ProdQty.HeaderText = "ProdQty";
            this.ProdQty.MinimumWidth = 6;
            this.ProdQty.Name = "ProdQty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // label_selling
            // 
            this.label_selling.AutoSize = true;
            this.label_selling.BackColor = System.Drawing.Color.Goldenrod;
            this.label_selling.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selling.ForeColor = System.Drawing.Color.White;
            this.label_selling.Location = new System.Drawing.Point(392, 0);
            this.label_selling.Name = "label_selling";
            this.label_selling.Size = new System.Drawing.Size(135, 43);
            this.label_selling.TabIndex = 25;
            this.label_selling.Text = "SELLING";
            this.label_selling.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.button_delete);
            this.guna2Panel1.Controls.Add(this.label_billid);
            this.guna2Panel1.Controls.Add(this.label_Amount);
            this.guna2Panel1.Controls.Add(this.TextBox_id);
            this.guna2Panel1.Controls.Add(this.label_ghc);
            this.guna2Panel1.Controls.Add(this.label_sales);
            this.guna2Panel1.Controls.Add(this.DataGridView_sellList);
            this.guna2Panel1.Controls.Add(this.button1);
            this.guna2Panel1.Controls.Add(this.DataGridView_order);
            this.guna2Panel1.Controls.Add(this.button_print);
            this.guna2Panel1.Controls.Add(this.button_add);
            this.guna2Panel1.Location = new System.Drawing.Point(325, 86);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(540, 517);
            this.guna2Panel1.TabIndex = 23;
            // 
            // label_billid
            // 
            this.label_billid.AutoSize = true;
            this.label_billid.BackColor = System.Drawing.Color.Goldenrod;
            this.label_billid.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_billid.ForeColor = System.Drawing.Color.White;
            this.label_billid.Location = new System.Drawing.Point(286, 225);
            this.label_billid.Name = "label_billid";
            this.label_billid.Size = new System.Drawing.Size(68, 29);
            this.label_billid.TabIndex = 31;
            this.label_billid.Text = "Bill ID";
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.BackColor = System.Drawing.Color.Goldenrod;
            this.label_Amount.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Amount.ForeColor = System.Drawing.Color.White;
            this.label_Amount.Location = new System.Drawing.Point(102, 165);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(81, 29);
            this.label_Amount.TabIndex = 30;
            this.label_Amount.Text = "Amount";
            this.label_Amount.Click += new System.EventHandler(this.label_amount_Click);
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
            this.TextBox_id.Location = new System.Drawing.Point(369, 226);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.Size = new System.Drawing.Size(90, 27);
            this.TextBox_id.TabIndex = 32;
            // 
            // label_ghc
            // 
            this.label_ghc.AutoSize = true;
            this.label_ghc.BackColor = System.Drawing.Color.Goldenrod;
            this.label_ghc.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ghc.ForeColor = System.Drawing.Color.White;
            this.label_ghc.Location = new System.Drawing.Point(320, 165);
            this.label_ghc.Name = "label_ghc";
            this.label_ghc.Size = new System.Drawing.Size(51, 29);
            this.label_ghc.TabIndex = 31;
            this.label_ghc.Text = "GHC";
            this.label_ghc.Click += new System.EventHandler(this.label_ks_Click);
            // 
            // label_sales
            // 
            this.label_sales.AutoSize = true;
            this.label_sales.BackColor = System.Drawing.Color.Goldenrod;
            this.label_sales.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sales.ForeColor = System.Drawing.Color.White;
            this.label_sales.Location = new System.Drawing.Point(3, 225);
            this.label_sales.Name = "label_sales";
            this.label_sales.Size = new System.Drawing.Size(86, 29);
            this.label_sales.TabIndex = 30;
            this.label_sales.Text = "Sale List";
            this.label_sales.Click += new System.EventHandler(this.label_sales_Click);
            // 
            // DataGridView_sellList
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.DataGridView_sellList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_sellList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DataGridView_sellList.ColumnHeadersHeight = 29;
            this.DataGridView_sellList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_sellList.DefaultCellStyle = dataGridViewCellStyle15;
            this.DataGridView_sellList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_sellList.Location = new System.Drawing.Point(0, 264);
            this.DataGridView_sellList.Name = "DataGridView_sellList";
            this.DataGridView_sellList.RowHeadersVisible = false;
            this.DataGridView_sellList.RowHeadersWidth = 51;
            this.DataGridView_sellList.RowTemplate.Height = 24;
            this.DataGridView_sellList.Size = new System.Drawing.Size(539, 203);
            this.DataGridView_sellList.TabIndex = 30;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_sellList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_sellList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.Height = 29;
            this.DataGridView_sellList.ThemeStyle.ReadOnly = false;
            this.DataGridView_sellList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_sellList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_sellList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_sellList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView_sellList.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView_sellList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_sellList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-81, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 29;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_print
            // 
            this.button_print.FlatAppearance.BorderSize = 0;
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.Color.White;
            this.button_print.Location = new System.Drawing.Point(221, 473);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(97, 41);
            this.button_print.TabIndex = 21;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.TextBox_qty);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.comboBox_category);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label_sellername);
            this.panel1.Controls.Add(this.DataGridView_product);
            this.panel1.Controls.Add(this.label_selling);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.button_addOrder);
            this.panel1.Controls.Add(this.TextBox_price);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label_price);
            this.panel1.Controls.Add(this.label_qty);
            this.panel1.Location = new System.Drawing.Point(211, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 609);
            this.panel1.TabIndex = 44;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.TextBox_qty.Location = new System.Drawing.Point(135, 179);
            this.TextBox_qty.Name = "TextBox_qty";
            this.TextBox_qty.PasswordChar = '\0';
            this.TextBox_qty.PlaceholderText = "";
            this.TextBox_qty.SelectedText = "";
            this.TextBox_qty.Size = new System.Drawing.Size(174, 27);
            this.TextBox_qty.TabIndex = 30;
            this.TextBox_qty.TextChanged += new System.EventHandler(this.TextBox_qty_TextChanged);
            // 
            // button_refresh
            // 
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(223, 307);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(96, 32);
            this.button_refresh.TabIndex = 29;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // comboBox_category
            // 
            this.comboBox_category.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(22, 307);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(195, 32);
            this.comboBox_category.TabIndex = 28;
            this.comboBox_category.Text = "Select Category";
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            this.comboBox_category.SelectionChangeCommitted += new System.EventHandler(this.comboBox_category_SelectionChangeCommitted);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.Color.Goldenrod;
            this.label_date.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(656, 54);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(58, 29);
            this.label_date.TabIndex = 27;
            this.label_date.Text = "Date:";
            // 
            // label_sellername
            // 
            this.label_sellername.AutoSize = true;
            this.label_sellername.BackColor = System.Drawing.Color.Goldenrod;
            this.label_sellername.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sellername.ForeColor = System.Drawing.Color.White;
            this.label_sellername.Location = new System.Drawing.Point(16, 25);
            this.label_sellername.Name = "label_sellername";
            this.label_sellername.Size = new System.Drawing.Size(112, 29);
            this.label_sellername.TabIndex = 26;
            this.label_sellername.Text = "SellerName";
            this.label_sellername.Click += new System.EventHandler(this.label_sellername_Click);
            // 
            // DataGridView_product
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.DataGridView_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DataGridView_product.ColumnHeadersHeight = 29;
            this.DataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_product.DefaultCellStyle = dataGridViewCellStyle18;
            this.DataGridView_product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_product.Location = new System.Drawing.Point(21, 350);
            this.DataGridView_product.Name = "DataGridView_product";
            this.DataGridView_product.RowHeadersVisible = false;
            this.DataGridView_product.RowHeadersWidth = 51;
            this.DataGridView_product.RowTemplate.Height = 24;
            this.DataGridView_product.Size = new System.Drawing.Size(288, 217);
            this.DataGridView_product.TabIndex = 1;
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
            this.DataGridView_product.Click += new System.EventHandler(this.DataGridView_product_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Goldenrod;
            this.label_name.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(17, 88);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(63, 29);
            this.label_name.TabIndex = 12;
            this.label_name.Text = "Name";
            this.label_name.Click += new System.EventHandler(this.label_name_Click);
            // 
            // label_qty
            // 
            this.label_qty.AutoSize = true;
            this.label_qty.BackColor = System.Drawing.Color.Goldenrod;
            this.label_qty.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qty.ForeColor = System.Drawing.Color.White;
            this.label_qty.Location = new System.Drawing.Point(17, 177);
            this.label_qty.Name = "label_qty";
            this.label_qty.Size = new System.Drawing.Size(88, 29);
            this.label_qty.TabIndex = 16;
            this.label_qty.Text = "Quantity";
            this.label_qty.Click += new System.EventHandler(this.label_phoneno_Click);
            // 
            // button_delete
            // 
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(382, 473);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(77, 41);
            this.button_delete.TabIndex = 33;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 652);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_order)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_sellList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private System.Windows.Forms.Button button_addOrder;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_close;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_price;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_order;
        private System.Windows.Forms.Label label_selling;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_print;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_product;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_sellername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.Label label_ghc;
        private System.Windows.Forms.Label label_sales;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_sellList;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_qty;
        private System.Windows.Forms.Label label_billid;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Button button_delete;
    }
}