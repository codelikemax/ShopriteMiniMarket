
namespace Mini_Market_Management_System
{
    partial class LoginForm
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
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.TextBox_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_login = new Guna.UI2.WinForms.Guna2Button();
            this.label_clear = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Gold;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(-213, -2);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(427, 402);
            this.guna2CircleButton1.TabIndex = 0;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_username.Location = new System.Drawing.Point(220, 107);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(146, 32);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "USERNAME";
            this.label_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_password.Location = new System.Drawing.Point(220, 155);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(148, 32);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "PASSWORD";
            this.label_password.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_login.Location = new System.Drawing.Point(429, 22);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(138, 51);
            this.label_login.TabIndex = 3;
            this.label_login.Text = "LOGIN";
            // 
            // TextBox_username
            // 
            this.TextBox_username.BorderRadius = 10;
            this.TextBox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_username.DefaultText = "";
            this.TextBox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_username.Location = new System.Drawing.Point(438, 110);
            this.TextBox_username.Name = "TextBox_username";
            this.TextBox_username.PasswordChar = '\0';
            this.TextBox_username.PlaceholderText = "";
            this.TextBox_username.SelectedText = "";
            this.TextBox_username.Size = new System.Drawing.Size(200, 29);
            this.TextBox_username.TabIndex = 4;
            this.TextBox_username.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
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
            this.TextBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.Location = new System.Drawing.Point(438, 155);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.PasswordChar = '●';
            this.TextBox_password.PlaceholderText = "";
            this.TextBox_password.SelectedText = "";
            this.TextBox_password.Size = new System.Drawing.Size(200, 27);
            this.TextBox_password.TabIndex = 5;
            this.TextBox_password.UseSystemPasswordChar = true;
            // 
            // Button_login
            // 
            this.Button_login.BorderRadius = 18;
            this.Button_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_login.FillColor = System.Drawing.Color.Goldenrod;
            this.Button_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_login.ForeColor = System.Drawing.Color.Black;
            this.Button_login.Location = new System.Drawing.Point(340, 212);
            this.Button_login.Name = "Button_login";
            this.Button_login.Size = new System.Drawing.Size(145, 42);
            this.Button_login.TabIndex = 6;
            this.Button_login.Text = "LOGIN";
            this.Button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // label_clear
            // 
            this.label_clear.AutoSize = true;
            this.label_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clear.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_clear.Location = new System.Drawing.Point(386, 276);
            this.label_clear.Name = "label_clear";
            this.label_clear.Size = new System.Drawing.Size(46, 20);
            this.label_clear.TabIndex = 7;
            this.label_clear.Text = "Clear";
            this.label_clear.Click += new System.EventHandler(this.label_clear_Click);
            this.label_clear.MouseEnter += new System.EventHandler(this.label_clear_MouseEnter);
            this.label_clear.MouseLeave += new System.EventHandler(this.label_clear_MouseLeave);
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_close.Location = new System.Drawing.Point(623, -2);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(31, 32);
            this.label_close.TabIndex = 8;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.BackColor = System.Drawing.Color.Gold;
            this.label_welcome.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.Color.Black;
            this.label_welcome.Location = new System.Drawing.Point(27, 101);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(146, 40);
            this.label_welcome.TabIndex = 9;
            this.label_welcome.Text = "WELCOME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "GHANA";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "SHOPRITE";
            // 
            // comboBox_role
            // 
            this.comboBox_role.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_role.ForeColor = System.Drawing.Color.Goldenrod;
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBox_role.Location = new System.Drawing.Point(438, 76);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(200, 28);
            this.comboBox_role.TabIndex = 12;
            this.comboBox_role.Text = "SELECT ROLE";
            this.comboBox_role.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(72, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "TO";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_welcome);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label_clear);
            this.Controls.Add(this.Button_login);
            this.Controls.Add(this.TextBox_password);
            this.Controls.Add(this.TextBox_username);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.guna2CircleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_username;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private Guna.UI2.WinForms.Guna2Button Button_login;
        private System.Windows.Forms.Label label_clear;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label label3;
    }
}

