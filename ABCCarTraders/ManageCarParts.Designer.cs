
namespace ABCCarTraders
{
    partial class ManageCarParts
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
            this.delete_b = new System.Windows.Forms.Button();
            this.update_b = new System.Windows.Forms.Button();
            this.view_b = new System.Windows.Forms.Button();
            this.car_part_stock_tb = new System.Windows.Forms.TextBox();
            this.car_part_price_tb = new System.Windows.Forms.TextBox();
            this.car_part_stock = new System.Windows.Forms.Label();
            this.car_part_price = new System.Windows.Forms.Label();
            this.car_part_dgv = new System.Windows.Forms.DataGridView();
            this.clear_b = new System.Windows.Forms.Button();
            this.add_b = new System.Windows.Forms.Button();
            this.cp_name_tb = new System.Windows.Forms.TextBox();
            this.cp_name = new System.Windows.Forms.Label();
            this.main_label = new System.Windows.Forms.Label();
            this.admin_hp_b = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.car_part_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_b
            // 
            this.delete_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_b.Location = new System.Drawing.Point(260, 414);
            this.delete_b.Name = "delete_b";
            this.delete_b.Size = new System.Drawing.Size(115, 37);
            this.delete_b.TabIndex = 89;
            this.delete_b.Text = "Delete";
            this.delete_b.UseVisualStyleBackColor = true;
            this.delete_b.Click += new System.EventHandler(this.delete_b_Click);
            // 
            // update_b
            // 
            this.update_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_b.Location = new System.Drawing.Point(105, 414);
            this.update_b.Name = "update_b";
            this.update_b.Size = new System.Drawing.Size(115, 37);
            this.update_b.TabIndex = 88;
            this.update_b.Text = "Update";
            this.update_b.UseVisualStyleBackColor = true;
            this.update_b.Click += new System.EventHandler(this.update_b_Click);
            // 
            // view_b
            // 
            this.view_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_b.Location = new System.Drawing.Point(193, 363);
            this.view_b.Name = "view_b";
            this.view_b.Size = new System.Drawing.Size(98, 37);
            this.view_b.TabIndex = 87;
            this.view_b.Text = "View";
            this.view_b.UseVisualStyleBackColor = true;
            this.view_b.Click += new System.EventHandler(this.view_b_Click);
            // 
            // car_part_stock_tb
            // 
            this.car_part_stock_tb.Location = new System.Drawing.Point(193, 293);
            this.car_part_stock_tb.Multiline = true;
            this.car_part_stock_tb.Name = "car_part_stock_tb";
            this.car_part_stock_tb.Size = new System.Drawing.Size(255, 34);
            this.car_part_stock_tb.TabIndex = 86;
            this.car_part_stock_tb.TextChanged += new System.EventHandler(this.car_part_stock_tb_TextChanged);
            this.car_part_stock_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.car_part_stock_tb_KeyPress);
            // 
            // car_part_price_tb
            // 
            this.car_part_price_tb.Location = new System.Drawing.Point(193, 234);
            this.car_part_price_tb.Multiline = true;
            this.car_part_price_tb.Name = "car_part_price_tb";
            this.car_part_price_tb.Size = new System.Drawing.Size(255, 34);
            this.car_part_price_tb.TabIndex = 85;
            this.car_part_price_tb.TextChanged += new System.EventHandler(this.car_part_price_tb_TextChanged);
            this.car_part_price_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.car_part_price_tb_KeyPress);
            // 
            // car_part_stock
            // 
            this.car_part_stock.AutoSize = true;
            this.car_part_stock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_part_stock.Location = new System.Drawing.Point(32, 295);
            this.car_part_stock.Name = "car_part_stock";
            this.car_part_stock.Size = new System.Drawing.Size(94, 32);
            this.car_part_stock.TabIndex = 84;
            this.car_part_stock.Text = "Stock";
            // 
            // car_part_price
            // 
            this.car_part_price.AutoSize = true;
            this.car_part_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_part_price.Location = new System.Drawing.Point(32, 236);
            this.car_part_price.Name = "car_part_price";
            this.car_part_price.Size = new System.Drawing.Size(88, 32);
            this.car_part_price.TabIndex = 83;
            this.car_part_price.Text = "Price";
            this.car_part_price.Click += new System.EventHandler(this.car_part_price_Click);
            // 
            // car_part_dgv
            // 
            this.car_part_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.car_part_dgv.Location = new System.Drawing.Point(496, 140);
            this.car_part_dgv.Name = "car_part_dgv";
            this.car_part_dgv.RowHeadersWidth = 51;
            this.car_part_dgv.RowTemplate.Height = 24;
            this.car_part_dgv.Size = new System.Drawing.Size(651, 337);
            this.car_part_dgv.TabIndex = 82;
            this.car_part_dgv.Click += new System.EventHandler(this.car_part_dgv_Click);
            // 
            // clear_b
            // 
            this.clear_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_b.Location = new System.Drawing.Point(56, 363);
            this.clear_b.Name = "clear_b";
            this.clear_b.Size = new System.Drawing.Size(98, 37);
            this.clear_b.TabIndex = 81;
            this.clear_b.Text = "Clear";
            this.clear_b.UseVisualStyleBackColor = true;
            this.clear_b.Click += new System.EventHandler(this.clear_b_Click);
            // 
            // add_b
            // 
            this.add_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_b.Location = new System.Drawing.Point(328, 363);
            this.add_b.Name = "add_b";
            this.add_b.Size = new System.Drawing.Size(98, 37);
            this.add_b.TabIndex = 80;
            this.add_b.Text = "Add";
            this.add_b.UseVisualStyleBackColor = true;
            this.add_b.Click += new System.EventHandler(this.add_b_Click);
            // 
            // cp_name_tb
            // 
            this.cp_name_tb.Location = new System.Drawing.Point(193, 170);
            this.cp_name_tb.Multiline = true;
            this.cp_name_tb.Name = "cp_name_tb";
            this.cp_name_tb.Size = new System.Drawing.Size(255, 34);
            this.cp_name_tb.TabIndex = 78;
            // 
            // cp_name
            // 
            this.cp_name.AutoSize = true;
            this.cp_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp_name.Location = new System.Drawing.Point(32, 172);
            this.cp_name.Name = "cp_name";
            this.cp_name.Size = new System.Drawing.Size(95, 32);
            this.cp_name.TabIndex = 76;
            this.cp_name.Text = "Name";
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.Location = new System.Drawing.Point(411, 26);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(331, 46);
            this.main_label.TabIndex = 75;
            this.main_label.Text = "Car Part Details";
            this.main_label.Click += new System.EventHandler(this.main_label_Click);
            // 
            // admin_hp_b
            // 
            this.admin_hp_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_hp_b.Location = new System.Drawing.Point(38, 35);
            this.admin_hp_b.Name = "admin_hp_b";
            this.admin_hp_b.Size = new System.Drawing.Size(293, 37);
            this.admin_hp_b.TabIndex = 90;
            this.admin_hp_b.Text = "Go back to the Admin Home Page";
            this.admin_hp_b.UseVisualStyleBackColor = true;
            this.admin_hp_b.Click += new System.EventHandler(this.admin_hp_b_Click);
            // 
            // ManageCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 530);
            this.Controls.Add(this.admin_hp_b);
            this.Controls.Add(this.delete_b);
            this.Controls.Add(this.update_b);
            this.Controls.Add(this.view_b);
            this.Controls.Add(this.car_part_stock_tb);
            this.Controls.Add(this.car_part_price_tb);
            this.Controls.Add(this.car_part_stock);
            this.Controls.Add(this.car_part_price);
            this.Controls.Add(this.car_part_dgv);
            this.Controls.Add(this.clear_b);
            this.Controls.Add(this.add_b);
            this.Controls.Add(this.cp_name_tb);
            this.Controls.Add(this.cp_name);
            this.Controls.Add(this.main_label);
            this.Name = "ManageCarParts";
            this.Text = "ManageCarParts";
            ((System.ComponentModel.ISupportInitialize)(this.car_part_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_b;
        private System.Windows.Forms.Button update_b;
        private System.Windows.Forms.Button view_b;
        private System.Windows.Forms.TextBox car_part_stock_tb;
        private System.Windows.Forms.TextBox car_part_price_tb;
        private System.Windows.Forms.Label car_part_stock;
        private System.Windows.Forms.Label car_part_price;
        private System.Windows.Forms.DataGridView car_part_dgv;
        private System.Windows.Forms.Button clear_b;
        private System.Windows.Forms.Button add_b;
        private System.Windows.Forms.TextBox cp_name_tb;
        private System.Windows.Forms.Label cp_name;
        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.Button admin_hp_b;
    }
}