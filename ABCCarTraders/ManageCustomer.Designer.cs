
namespace ABCCarTraders
{
    partial class ManageCustomer
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
            this.view_b = new System.Windows.Forms.Button();
            this.number_tb = new System.Windows.Forms.TextBox();
            this.c_number = new System.Windows.Forms.Label();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.c_address = new System.Windows.Forms.Label();
            this.c_password = new System.Windows.Forms.Label();
            this.customer_dgv = new System.Windows.Forms.DataGridView();
            this.clear_b = new System.Windows.Forms.Button();
            this.add_b = new System.Windows.Forms.Button();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.c_username = new System.Windows.Forms.Label();
            this.c_name = new System.Windows.Forms.Label();
            this.main_label = new System.Windows.Forms.Label();
            this.update_b = new System.Windows.Forms.Button();
            this.delete_b = new System.Windows.Forms.Button();
            this.admin_hp_b = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customer_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // view_b
            // 
            this.view_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_b.Location = new System.Drawing.Point(207, 409);
            this.view_b.Name = "view_b";
            this.view_b.Size = new System.Drawing.Size(98, 37);
            this.view_b.TabIndex = 55;
            this.view_b.Text = "View";
            this.view_b.UseVisualStyleBackColor = true;
            this.view_b.Click += new System.EventHandler(this.view_b_Click);
            // 
            // number_tb
            // 
            this.number_tb.Location = new System.Drawing.Point(207, 347);
            this.number_tb.Multiline = true;
            this.number_tb.Name = "number_tb";
            this.number_tb.Size = new System.Drawing.Size(255, 34);
            this.number_tb.TabIndex = 54;
            this.number_tb.TextChanged += new System.EventHandler(this.number_tb_TextChanged);
            // 
            // c_number
            // 
            this.c_number.AutoSize = true;
            this.c_number.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_number.Location = new System.Drawing.Point(46, 349);
            this.c_number.Name = "c_number";
            this.c_number.Size = new System.Drawing.Size(125, 32);
            this.c_number.TabIndex = 53;
            this.c_number.Text = "Number";
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(207, 287);
            this.address_tb.Multiline = true;
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(255, 34);
            this.address_tb.TabIndex = 52;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(207, 228);
            this.password_tb.Multiline = true;
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(255, 34);
            this.password_tb.TabIndex = 51;
            // 
            // c_address
            // 
            this.c_address.AutoSize = true;
            this.c_address.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_address.Location = new System.Drawing.Point(46, 289);
            this.c_address.Name = "c_address";
            this.c_address.Size = new System.Drawing.Size(130, 32);
            this.c_address.TabIndex = 50;
            this.c_address.Text = "Address";
            // 
            // c_password
            // 
            this.c_password.AutoSize = true;
            this.c_password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_password.Location = new System.Drawing.Point(46, 230);
            this.c_password.Name = "c_password";
            this.c_password.Size = new System.Drawing.Size(151, 32);
            this.c_password.TabIndex = 49;
            this.c_password.Text = "Password";
            // 
            // customer_dgv
            // 
            this.customer_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_dgv.Location = new System.Drawing.Point(510, 109);
            this.customer_dgv.Name = "customer_dgv";
            this.customer_dgv.RowHeadersWidth = 51;
            this.customer_dgv.RowTemplate.Height = 24;
            this.customer_dgv.Size = new System.Drawing.Size(651, 337);
            this.customer_dgv.TabIndex = 48;
            this.customer_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_dgv_CellContentClick_1);
            this.customer_dgv.Click += new System.EventHandler(this.customer_dgv_DoubleClick);
            this.customer_dgv.DoubleClick += new System.EventHandler(this.customer_dgv_DoubleClick);
            // 
            // clear_b
            // 
            this.clear_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_b.Location = new System.Drawing.Point(70, 409);
            this.clear_b.Name = "clear_b";
            this.clear_b.Size = new System.Drawing.Size(98, 37);
            this.clear_b.TabIndex = 46;
            this.clear_b.Text = "Clear";
            this.clear_b.UseVisualStyleBackColor = true;
            this.clear_b.Click += new System.EventHandler(this.clear_b_Click);
            // 
            // add_b
            // 
            this.add_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_b.Location = new System.Drawing.Point(341, 409);
            this.add_b.Name = "add_b";
            this.add_b.Size = new System.Drawing.Size(98, 37);
            this.add_b.TabIndex = 45;
            this.add_b.Text = "Add";
            this.add_b.UseVisualStyleBackColor = true;
            this.add_b.Click += new System.EventHandler(this.add_b_Click);
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(207, 169);
            this.username_tb.Multiline = true;
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(255, 34);
            this.username_tb.TabIndex = 44;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(207, 109);
            this.name_tb.Multiline = true;
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(255, 34);
            this.name_tb.TabIndex = 43;
            // 
            // c_username
            // 
            this.c_username.AutoSize = true;
            this.c_username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_username.Location = new System.Drawing.Point(46, 171);
            this.c_username.Name = "c_username";
            this.c_username.Size = new System.Drawing.Size(156, 32);
            this.c_username.TabIndex = 42;
            this.c_username.Text = "Username";
            // 
            // c_name
            // 
            this.c_name.AutoSize = true;
            this.c_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_name.Location = new System.Drawing.Point(46, 111);
            this.c_name.Name = "c_name";
            this.c_name.Size = new System.Drawing.Size(95, 32);
            this.c_name.TabIndex = 41;
            this.c_name.Text = "Name";
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.Location = new System.Drawing.Point(436, 29);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(357, 46);
            this.main_label.TabIndex = 40;
            this.main_label.Text = "Customer Details";
            // 
            // update_b
            // 
            this.update_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_b.Location = new System.Drawing.Point(119, 460);
            this.update_b.Name = "update_b";
            this.update_b.Size = new System.Drawing.Size(115, 37);
            this.update_b.TabIndex = 56;
            this.update_b.Text = "Update";
            this.update_b.UseVisualStyleBackColor = true;
            this.update_b.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete_b
            // 
            this.delete_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_b.Location = new System.Drawing.Point(274, 460);
            this.delete_b.Name = "delete_b";
            this.delete_b.Size = new System.Drawing.Size(115, 37);
            this.delete_b.TabIndex = 57;
            this.delete_b.Text = "Delete";
            this.delete_b.UseVisualStyleBackColor = true;
            this.delete_b.Click += new System.EventHandler(this.delete_b_Click);
            // 
            // admin_hp_b
            // 
            this.admin_hp_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_hp_b.Location = new System.Drawing.Point(52, 38);
            this.admin_hp_b.Name = "admin_hp_b";
            this.admin_hp_b.Size = new System.Drawing.Size(293, 37);
            this.admin_hp_b.TabIndex = 58;
            this.admin_hp_b.Text = "Go back to the Admin Home Page";
            this.admin_hp_b.UseVisualStyleBackColor = true;
            this.admin_hp_b.Click += new System.EventHandler(this.admin_hp_b_Click);
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 516);
            this.Controls.Add(this.admin_hp_b);
            this.Controls.Add(this.delete_b);
            this.Controls.Add(this.update_b);
            this.Controls.Add(this.view_b);
            this.Controls.Add(this.number_tb);
            this.Controls.Add(this.c_number);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.c_address);
            this.Controls.Add(this.c_password);
            this.Controls.Add(this.customer_dgv);
            this.Controls.Add(this.clear_b);
            this.Controls.Add(this.add_b);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.c_username);
            this.Controls.Add(this.c_name);
            this.Controls.Add(this.main_label);
            this.Name = "ManageCustomer";
            this.Text = "ManageCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.customer_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button view_b;
        private System.Windows.Forms.TextBox number_tb;
        private System.Windows.Forms.Label c_number;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label c_address;
        private System.Windows.Forms.Label c_password;
        private System.Windows.Forms.DataGridView customer_dgv;
        private System.Windows.Forms.Button clear_b;
        private System.Windows.Forms.Button add_b;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label c_username;
        private System.Windows.Forms.Label c_name;
        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.Button update_b;
        private System.Windows.Forms.Button delete_b;
        private System.Windows.Forms.Button admin_hp_b;
    }
}