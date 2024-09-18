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
    public partial class CustomerF : Form
    {
        public CustomerF()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (name_tb.Text == "" || username_tb.Text == "" || password_tb.Text == ""|| address_tb.Text == "" || number_tb.Text == "")
                {
                    MessageBox.Show("Please input all the relevant registration details!", "Incomplete Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(password_tb.Text != re_password_tb.Text)
                {
                    MessageBox.Show("The passwords do not match!", "Incorrect passwords", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = "INSERT INTO [user]([u_name],[u_username],[u_password],[u_address],[u_number],[u_type]) VALUES('" + name_tb.Text + "', '" + username_tb.Text + "', '" + password_tb.Text + "', '" + address_tb.Text + "', '" + number_tb.Text + "', '" + "Customer" + "')";
                    User.createCon();
                    Customer.registration(query);
                    User.closeCon();

                    Form1 ul = new Form1();
                    ul.Show();
                    this.Hide();
                }
                
                /*
                string query = "INSERT INTO [user]([u_name],[u_username],[u_password],[u_address],[u_number],[u_type]) VALUES('" + name_tb.Text + "', '" + username_tb.Text + "', '" + password_tb.Text + "', '" + address_tb.Text + "', '" + number_tb.Text + "', '" + "Customer" + "')";
                Admin.createCon();
                User.insertData(query);
                DBConn.closeCon();
                */
                /*
                Customer customeradd = new Customer();
                customeradd.addData(name_tb.Text, username_tb.Text, password_tb.Text, address_tb.Text, int.Parse(number_tb.Text));
                MessageBox.Show("Record added");
                */
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                clearTextboxes();
            }

        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void view_b_Click(object sender, EventArgs e)
        {
            /*
            string query = "select * from [user]";
            DBConn.createCon();
            DataTable dt = Admin.viewData(query);
            DBConn.closeCon();
            */

            //customer_dgv.DataSource = dt;

            /*
            Customer customerview = new Customer();

            List<Customer> cv = customerview.get_all_customers();
            customer_dgv.DataSource = cv;
            */

        }

        private void clear_b_Click(object sender, EventArgs e)
        {
            clearTextboxes();
        }

        private void exit_b_Click(object sender, EventArgs e)
        {
            Form1 ul = new Form1();
            ul.Show();
            this.Hide();

            /*
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
            */
        }

        private void customer_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customer_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void number_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearTextboxes()
        {
            name_tb.Clear();
            username_tb.Clear();
            password_tb.Clear();
            address_tb.Clear();
            number_tb.Clear();
        }
    }
}
