using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCarTraders
{
    public partial class AdminF : Form
    {
        public Int32 AdminID { get; set; }
        public String AdminName { get; set; }

        public AdminF()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            welcome_a_lbl.Text = "Welcome: " + AdminName + " | Id Number: " + AdminID.ToString();
        }

        private void main_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCustomer mCustomer = new ManageCustomer();
            mCustomer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageCars mCars = new ManageCars();
            mCars.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageCarParts mCarParts = new ManageCarParts();
            mCarParts.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            r.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageOrders mOrders = new ManageOrders();
            mOrders.Show();
            this.Hide();
        }

        private void admin_hp_b_Click(object sender, EventArgs e)
        {
            Form1 ul = new Form1();
            ul.Show();
            this.Hide();
        }
    }
}
