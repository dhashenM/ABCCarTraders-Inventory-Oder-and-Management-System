
namespace ABCCarTraders
{
    partial class CustomerF
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
            this.exit_b = new System.Windows.Forms.Button();
            this.clear_b = new System.Windows.Forms.Button();
            this.add_b = new System.Windows.Forms.Button();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.c_username = new System.Windows.Forms.Label();
            this.c_name = new System.Windows.Forms.Label();
            this.main_label = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.c_address = new System.Windows.Forms.Label();
            this.c_password = new System.Windows.Forms.Label();
            this.number_tb = new System.Windows.Forms.TextBox();
            this.c_number = new System.Windows.Forms.Label();
            this.re_password_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_b
            // 
            this.exit_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_b.Location = new System.Drawing.Point(53, 438);
            this.exit_b.Name = "exit_b";
            this.exit_b.Size = new System.Drawing.Size(280, 37);
            this.exit_b.TabIndex = 15;
            this.exit_b.Text = "Go back to User Login";
            this.exit_b.UseVisualStyleBackColor = true;
            this.exit_b.Click += new System.EventHandler(this.exit_b_Click);
            // 
            // clear_b
            // 
            this.clear_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_b.Location = new System.Drawing.Point(349, 438);
            this.clear_b.Name = "clear_b";
            this.clear_b.Size = new System.Drawing.Size(95, 37);
            this.clear_b.TabIndex = 14;
            this.clear_b.Text = "Clear";
            this.clear_b.UseVisualStyleBackColor = true;
            this.clear_b.Click += new System.EventHandler(this.clear_b_Click);
            // 
            // add_b
            // 
            this.add_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_b.Location = new System.Drawing.Point(459, 438);
            this.add_b.Name = "add_b";
            this.add_b.Size = new System.Drawing.Size(125, 37);
            this.add_b.TabIndex = 13;
            this.add_b.Text = "Register";
            this.add_b.UseVisualStyleBackColor = true;
            this.add_b.Click += new System.EventHandler(this.login_button_Click);
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(218, 161);
            this.username_tb.Multiline = true;
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(245, 34);
            this.username_tb.TabIndex = 12;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(157, 111);
            this.name_tb.Multiline = true;
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(245, 34);
            this.name_tb.TabIndex = 11;
            this.name_tb.TextChanged += new System.EventHandler(this.username_textbox_TextChanged);
            // 
            // c_username
            // 
            this.c_username.AutoSize = true;
            this.c_username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_username.Location = new System.Drawing.Point(47, 163);
            this.c_username.Name = "c_username";
            this.c_username.Size = new System.Drawing.Size(165, 32);
            this.c_username.TabIndex = 10;
            this.c_username.Text = "Username:";
            // 
            // c_name
            // 
            this.c_name.AutoSize = true;
            this.c_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_name.Location = new System.Drawing.Point(47, 113);
            this.c_name.Name = "c_name";
            this.c_name.Size = new System.Drawing.Size(104, 32);
            this.c_name.TabIndex = 9;
            this.c_name.Text = "Name:";
            this.c_name.Click += new System.EventHandler(this.username_label_Click);
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.Location = new System.Drawing.Point(84, 34);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(461, 46);
            this.main_label.TabIndex = 8;
            this.main_label.Text = "Customer Registration";
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(192, 316);
            this.address_tb.Multiline = true;
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(245, 34);
            this.address_tb.TabIndex = 20;
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.Location = new System.Drawing.Point(213, 212);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(245, 34);
            this.password_tb.TabIndex = 19;
            this.password_tb.UseSystemPasswordChar = true;
            // 
            // c_address
            // 
            this.c_address.AutoSize = true;
            this.c_address.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_address.Location = new System.Drawing.Point(47, 318);
            this.c_address.Name = "c_address";
            this.c_address.Size = new System.Drawing.Size(139, 32);
            this.c_address.TabIndex = 18;
            this.c_address.Text = "Address:";
            // 
            // c_password
            // 
            this.c_password.AutoSize = true;
            this.c_password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_password.Location = new System.Drawing.Point(47, 214);
            this.c_password.Name = "c_password";
            this.c_password.Size = new System.Drawing.Size(160, 32);
            this.c_password.TabIndex = 17;
            this.c_password.Text = "Password:";
            // 
            // number_tb
            // 
            this.number_tb.Location = new System.Drawing.Point(187, 369);
            this.number_tb.Multiline = true;
            this.number_tb.Name = "number_tb";
            this.number_tb.Size = new System.Drawing.Size(245, 34);
            this.number_tb.TabIndex = 22;
            this.number_tb.TextChanged += new System.EventHandler(this.number_tb_TextChanged);
            // 
            // c_number
            // 
            this.c_number.AutoSize = true;
            this.c_number.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_number.Location = new System.Drawing.Point(47, 371);
            this.c_number.Name = "c_number";
            this.c_number.Size = new System.Drawing.Size(134, 32);
            this.c_number.TabIndex = 21;
            this.c_number.Text = "Number:";
            // 
            // re_password_tb
            // 
            this.re_password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re_password_tb.Location = new System.Drawing.Point(339, 263);
            this.re_password_tb.Name = "re_password_tb";
            this.re_password_tb.Size = new System.Drawing.Size(245, 34);
            this.re_password_tb.TabIndex = 25;
            this.re_password_tb.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Re-enter Password:";
            // 
            // CustomerF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 516);
            this.Controls.Add(this.re_password_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number_tb);
            this.Controls.Add(this.c_number);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.c_address);
            this.Controls.Add(this.c_password);
            this.Controls.Add(this.exit_b);
            this.Controls.Add(this.clear_b);
            this.Controls.Add(this.add_b);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.c_username);
            this.Controls.Add(this.c_name);
            this.Controls.Add(this.main_label);
            this.Name = "CustomerF";
            this.Text = "Customer Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_b;
        private System.Windows.Forms.Button clear_b;
        private System.Windows.Forms.Button add_b;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label c_username;
        private System.Windows.Forms.Label c_name;
        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label c_address;
        private System.Windows.Forms.Label c_password;
        private System.Windows.Forms.TextBox number_tb;
        private System.Windows.Forms.Label c_number;
        private System.Windows.Forms.TextBox re_password_tb;
        private System.Windows.Forms.Label label1;
    }
}