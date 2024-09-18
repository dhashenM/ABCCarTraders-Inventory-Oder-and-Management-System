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
    public partial class ManageCarParts : Form
    {
        int cp_id;
        public ManageCarParts()
        {
            InitializeComponent();
        }

        private void main_label_Click(object sender, EventArgs e)
        {

        }

        private void car_part_price_Click(object sender, EventArgs e)
        {

        }

        private void clear_b_Click(object sender, EventArgs e)
        {
            clearTextboxes();
        }
        private void clearTextboxes()
        {
            cp_name_tb.Clear();
            car_part_price_tb.Clear();
            car_part_stock_tb.Clear();
        }

        private void view_b_Click(object sender, EventArgs e)
        {
            string query = "select * from [car_parts]";
            User.createCon();
            DataTable dt = Admin.viewData(query);
            User.closeCon();
            car_part_dgv.DataSource = dt;
        }

        private void add_b_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO [car_parts]([car_part_name],[car_part_price],[car_part_stock]) VALUES('" + cp_name_tb.Text + "', '" + decimal.Parse(car_part_price_tb.Text) + "', '" + int.Parse(car_part_stock_tb.Text) + "')";
                User.createCon();
                Admin.insertData(query);
                User.closeCon();
                view_b_Click(sender, e);
            }
            catch (FormatException f)
            {
                MessageBox.Show("Please enter relevant data into the fields!");
            }
            catch (Exception f)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                clearTextboxes();
            }
        }

        private void update_b_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE [car_parts] SET [car_part_name] = '" + cp_name_tb.Text + "', [car_part_price] = '" + decimal.Parse(car_part_price_tb.Text) + "', [car_part_stock] = '" + int.Parse(car_part_stock_tb.Text) + "' WHERE car_part_id = '" + cp_id + "' ";
                User.createCon();
                Admin.updateData(query);
                User.closeCon();
                view_b_Click(sender, e);
            }
            catch (FormatException f)
            {
                MessageBox.Show("Please enter relevant data into the fields!");
            }
            catch (Exception f)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                clearTextboxes();
            }
        }

        private void delete_b_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM [car_parts] WHERE car_part_id = '" + cp_id + "' ";
            User.createCon();
            Admin.deleteData(query);
            User.closeCon();
            view_b_Click(sender, e);
            clearTextboxes();
        }

        private void car_part_dgv_Click(object sender, EventArgs e)
        {
            //The following code allows for the rows to be selected and entered into the respective textboxes displayed in the Forms
            int selectedrowindex = car_part_dgv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = car_part_dgv.Rows[selectedrowindex];
            cp_id = Convert.ToInt32(selectedRow.Cells["car_part_id"].Value);
            cp_name_tb.Text = Convert.ToString(selectedRow.Cells["car_part_name"].Value);
            car_part_price_tb.Text = Convert.ToString(selectedRow.Cells["car_part_price"].Value);
            car_part_stock_tb.Text = Convert.ToString(selectedRow.Cells["car_part_stock"].Value);
        }

        private void car_part_price_tb_TextChanged(object sender, EventArgs e)
        {
            /*
            if (System.Text.RegularExpressions.Regex.IsMatch(car_part_price_tb.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only!");
                car_part_price_tb.Text = car_part_price_tb.Text.Remove(car_part_price_tb.Text.Length - 1);
            }
            */
        }

        private void car_part_stock_tb_TextChanged(object sender, EventArgs e)
        {
            /*
            if (System.Text.RegularExpressions.Regex.IsMatch(car_part_stock_tb.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only!");
                car_part_stock_tb.Text = car_part_stock_tb.Text.Remove(car_part_stock_tb.Text.Length - 1);
            }
            */
        }

        private void car_part_price_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void car_part_stock_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void admin_hp_b_Click(object sender, EventArgs e)
        {
            AdminF ah = new AdminF();
            ah.Show();
            this.Hide();
        }
    }
}
