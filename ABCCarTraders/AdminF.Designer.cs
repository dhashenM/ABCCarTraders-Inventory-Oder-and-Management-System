
namespace ABCCarTraders
{
    partial class AdminF
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.admin_hp_b = new System.Windows.Forms.Button();
            this.welcome_a_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(241, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage Customer Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(241, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(382, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Manage Car Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(241, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(382, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Manage Car Parts Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(241, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(382, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "Manage Order Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(241, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(382, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "Generate Reports";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // admin_hp_b
            // 
            this.admin_hp_b.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_hp_b.Location = new System.Drawing.Point(335, 413);
            this.admin_hp_b.Name = "admin_hp_b";
            this.admin_hp_b.Size = new System.Drawing.Size(203, 37);
            this.admin_hp_b.TabIndex = 92;
            this.admin_hp_b.Text = "Go back to User Login";
            this.admin_hp_b.UseVisualStyleBackColor = true;
            this.admin_hp_b.Click += new System.EventHandler(this.admin_hp_b_Click);
            // 
            // welcome_a_lbl
            // 
            this.welcome_a_lbl.AutoSize = true;
            this.welcome_a_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_a_lbl.Location = new System.Drawing.Point(236, 32);
            this.welcome_a_lbl.Name = "welcome_a_lbl";
            this.welcome_a_lbl.Size = new System.Drawing.Size(109, 25);
            this.welcome_a_lbl.TabIndex = 93;
            this.welcome_a_lbl.Text = "Welcome:";
            // 
            // AdminF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 523);
            this.Controls.Add(this.welcome_a_lbl);
            this.Controls.Add(this.admin_hp_b);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AdminF";
            this.Text = "Admin Home Page";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button admin_hp_b;
        private System.Windows.Forms.Label welcome_a_lbl;
    }
}