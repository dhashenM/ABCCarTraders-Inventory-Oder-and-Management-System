
namespace ABCCarTraders
{
    partial class ManageCars
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
            this.car_stock_tb = new System.Windows.Forms.TextBox();
            this.car_price_tb = new System.Windows.Forms.TextBox();
            this.car_stock = new System.Windows.Forms.Label();
            this.car_price = new System.Windows.Forms.Label();
            this.car_dgv = new System.Windows.Forms.DataGridView();
            this.clear_b = new System.Windows.Forms.Button();
            this.add_b = new System.Windows.Forms.Button();
            this.model_tb = new System.Windows.Forms.TextBox();
            this.make_tb = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.Label();
            this.make = new System.Windows.Forms.Label();
            this.main_label = new System.Windows.Forms.Label();
            this.admin_hp_b = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.car_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_b
            // 
            this.delete_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_b.Location = new System.Drawing.Point(262, 420);
            this.delete_b.Name = "delete_b";
            this.delete_b.Size = new System.Drawing.Size(115, 37);
            this.delete_b.TabIndex = 74;
            this.delete_b.Text = "Delete";
            this.delete_b.UseVisualStyleBackColor = true;
            this.delete_b.Click += new System.EventHandler(this.delete_b_Click);
            // 
            // update_b
            // 
            this.update_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_b.Location = new System.Drawing.Point(107, 420);
            this.update_b.Name = "update_b";
            this.update_b.Size = new System.Drawing.Size(115, 37);
            this.update_b.TabIndex = 73;
            this.update_b.Text = "Update";
            this.update_b.UseVisualStyleBackColor = true;
            this.update_b.Click += new System.EventHandler(this.update_b_Click);
            // 
            // view_b
            // 
            this.view_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_b.Location = new System.Drawing.Point(195, 369);
            this.view_b.Name = "view_b";
            this.view_b.Size = new System.Drawing.Size(98, 37);
            this.view_b.TabIndex = 72;
            this.view_b.Text = "View";
            this.view_b.UseVisualStyleBackColor = true;
            this.view_b.Click += new System.EventHandler(this.view_b_Click);
            // 
            // car_stock_tb
            // 
            this.car_stock_tb.Location = new System.Drawing.Point(195, 299);
            this.car_stock_tb.Multiline = true;
            this.car_stock_tb.Name = "car_stock_tb";
            this.car_stock_tb.Size = new System.Drawing.Size(255, 34);
            this.car_stock_tb.TabIndex = 69;
            this.car_stock_tb.TextChanged += new System.EventHandler(this.car_stock_tb_TextChanged);
            this.car_stock_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.car_stock_tb_KeyPress);
            // 
            // car_price_tb
            // 
            this.car_price_tb.Location = new System.Drawing.Point(195, 240);
            this.car_price_tb.Multiline = true;
            this.car_price_tb.Name = "car_price_tb";
            this.car_price_tb.Size = new System.Drawing.Size(255, 34);
            this.car_price_tb.TabIndex = 68;
            this.car_price_tb.TextChanged += new System.EventHandler(this.car_price_tb_TextChanged);
            this.car_price_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.car_price_tb_KeyPress);
            // 
            // car_stock
            // 
            this.car_stock.AutoSize = true;
            this.car_stock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_stock.Location = new System.Drawing.Point(34, 301);
            this.car_stock.Name = "car_stock";
            this.car_stock.Size = new System.Drawing.Size(94, 32);
            this.car_stock.TabIndex = 67;
            this.car_stock.Text = "Stock";
            // 
            // car_price
            // 
            this.car_price.AutoSize = true;
            this.car_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_price.Location = new System.Drawing.Point(34, 242);
            this.car_price.Name = "car_price";
            this.car_price.Size = new System.Drawing.Size(88, 32);
            this.car_price.TabIndex = 66;
            this.car_price.Text = "Price";
            // 
            // car_dgv
            // 
            this.car_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.car_dgv.Location = new System.Drawing.Point(498, 121);
            this.car_dgv.Name = "car_dgv";
            this.car_dgv.RowHeadersWidth = 51;
            this.car_dgv.RowTemplate.Height = 24;
            this.car_dgv.Size = new System.Drawing.Size(651, 337);
            this.car_dgv.TabIndex = 65;
            this.car_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.car_dgv_CellContentClick);
            this.car_dgv.Click += new System.EventHandler(this.car_dgv_Click);
            // 
            // clear_b
            // 
            this.clear_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_b.Location = new System.Drawing.Point(59, 369);
            this.clear_b.Name = "clear_b";
            this.clear_b.Size = new System.Drawing.Size(98, 37);
            this.clear_b.TabIndex = 64;
            this.clear_b.Text = "Clear";
            this.clear_b.UseVisualStyleBackColor = true;
            this.clear_b.Click += new System.EventHandler(this.clear_b_Click);
            // 
            // add_b
            // 
            this.add_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_b.Location = new System.Drawing.Point(331, 369);
            this.add_b.Name = "add_b";
            this.add_b.Size = new System.Drawing.Size(98, 37);
            this.add_b.TabIndex = 63;
            this.add_b.Text = "Add";
            this.add_b.UseVisualStyleBackColor = true;
            this.add_b.Click += new System.EventHandler(this.add_b_Click);
            // 
            // model_tb
            // 
            this.model_tb.Location = new System.Drawing.Point(195, 181);
            this.model_tb.Multiline = true;
            this.model_tb.Name = "model_tb";
            this.model_tb.Size = new System.Drawing.Size(255, 34);
            this.model_tb.TabIndex = 62;
            // 
            // make_tb
            // 
            this.make_tb.Location = new System.Drawing.Point(195, 121);
            this.make_tb.Multiline = true;
            this.make_tb.Name = "make_tb";
            this.make_tb.Size = new System.Drawing.Size(255, 34);
            this.make_tb.TabIndex = 61;
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model.Location = new System.Drawing.Point(34, 183);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(98, 32);
            this.model.TabIndex = 60;
            this.model.Text = "Model";
            // 
            // make
            // 
            this.make.AutoSize = true;
            this.make.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.make.Location = new System.Drawing.Point(34, 123);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(88, 32);
            this.make.TabIndex = 59;
            this.make.Text = "Make";
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.Location = new System.Drawing.Point(476, 23);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(238, 46);
            this.main_label.TabIndex = 58;
            this.main_label.Text = "Car Details";
            this.main_label.Click += new System.EventHandler(this.main_label_Click);
            // 
            // admin_hp_b
            // 
            this.admin_hp_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_hp_b.Location = new System.Drawing.Point(40, 32);
            this.admin_hp_b.Name = "admin_hp_b";
            this.admin_hp_b.Size = new System.Drawing.Size(293, 37);
            this.admin_hp_b.TabIndex = 91;
            this.admin_hp_b.Text = "Go back to the Admin Home Page";
            this.admin_hp_b.UseVisualStyleBackColor = true;
            this.admin_hp_b.Click += new System.EventHandler(this.admin_hp_b_Click);
            // 
            // ManageCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 523);
            this.Controls.Add(this.admin_hp_b);
            this.Controls.Add(this.delete_b);
            this.Controls.Add(this.update_b);
            this.Controls.Add(this.view_b);
            this.Controls.Add(this.car_stock_tb);
            this.Controls.Add(this.car_price_tb);
            this.Controls.Add(this.car_stock);
            this.Controls.Add(this.car_price);
            this.Controls.Add(this.car_dgv);
            this.Controls.Add(this.clear_b);
            this.Controls.Add(this.add_b);
            this.Controls.Add(this.model_tb);
            this.Controls.Add(this.make_tb);
            this.Controls.Add(this.model);
            this.Controls.Add(this.make);
            this.Controls.Add(this.main_label);
            this.Name = "ManageCars";
            this.Text = "ManageCars";
            ((System.ComponentModel.ISupportInitialize)(this.car_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_b;
        private System.Windows.Forms.Button update_b;
        private System.Windows.Forms.Button view_b;
        private System.Windows.Forms.TextBox car_stock_tb;
        private System.Windows.Forms.TextBox car_price_tb;
        private System.Windows.Forms.Label car_stock;
        private System.Windows.Forms.Label car_price;
        private System.Windows.Forms.DataGridView car_dgv;
        private System.Windows.Forms.Button clear_b;
        private System.Windows.Forms.Button add_b;
        private System.Windows.Forms.TextBox model_tb;
        private System.Windows.Forms.TextBox make_tb;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label make;
        private System.Windows.Forms.Label main_label;
        private System.Windows.Forms.Button admin_hp_b;
    }
}