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
    public partial class ManageCustomer : Form
    {
        int u_id;
        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void view_b_Click(object sender, EventArgs e)
        {
            string query = "SELECT [u_id],[u_name],[u_username],[u_password],[u_address],[u_number] FROM [user]";
            User.createCon();
            DataTable dt = Admin.viewData(query);
            User.closeCon();
            customer_dgv.DataSource = dt;
        }

        private void add_b_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO [user]([u_name],[u_username],[u_password],[u_address],[u_number],[u_type]) VALUES('" + name_tb.Text + "', '" + username_tb.Text + "', '" + password_tb.Text + "', '" + address_tb.Text + "', '" + number_tb.Text + "', '" + "Customer" + "')";
                User.createCon();
                Admin.insertData(query);
                User.closeCon();
                view_b_Click(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter relevant data into the fields!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                clearTextboxes();
            }
        }
        private void clearTextboxes()
        {
            name_tb.Clear();
            username_tb.Clear();
            password_tb.Clear();
            address_tb.Clear();
            number_tb.Clear();
        }

        private void customer_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clear_b_Click(object sender, EventArgs e)
        {
            clearTextboxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE [user] SET [u_name] = '" + name_tb.Text + "', [u_username] = '" + username_tb.Text + "', [u_password] = '" + password_tb.Text + "', [u_address] = '" + address_tb.Text + "',  [u_number] = '" + number_tb.Text + "' WHERE u_id = '" + u_id + "' ";
                User.createCon();
                Admin.updateData(query);
                User.closeCon();
                view_b_Click(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter relevant data into the fields!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                clearTextboxes();
            }  
        }

        private void customer_dgv_DoubleClick(object sender, EventArgs e)
        {
            //The following code allows for the rows to be selected and entered into the respective textboxes displayed in the Forms
            int selectedrowindex = customer_dgv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = customer_dgv.Rows[selectedrowindex];
            u_id = Convert.ToInt32(selectedRow.Cells["u_id"].Value);
            name_tb.Text = Convert.ToString(selectedRow.Cells["u_name"].Value);
            username_tb.Text = Convert.ToString(selectedRow.Cells["u_username"].Value);
            password_tb.Text = Convert.ToString(selectedRow.Cells["u_password"].Value);
            address_tb.Text = Convert.ToString(selectedRow.Cells["u_address"].Value);
            number_tb.Text = Convert.ToString(selectedRow.Cells["u_number"].Value);
        }

        private void delete_b_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM [user] WHERE u_id = '" + u_id + "' ";
            User.createCon();
            Admin.deleteData(query);
            User.closeCon();
            view_b_Click(sender, e);
            clearTextboxes();
        }

        private void number_tb_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(number_tb.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only!");
                number_tb.Text = number_tb.Text.Remove(number_tb.Text.Length - 1);
            }
        }

        private void customer_dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admin_hp_b_Click(object sender, EventArgs e)
        {
            AdminF ah = new AdminF();
            ah.Show();
            this.Hide();
        }

        private void gcr_b_Click(object sender, EventArgs e)
        {

        }
    }
}
