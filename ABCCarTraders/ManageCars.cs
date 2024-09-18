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
    public partial class ManageCars : Form
    {
        int c_id;
        public ManageCars()
        {
            InitializeComponent();
        }

        private void main_label_Click(object sender, EventArgs e)
        {

        }

        private void clear_b_Click(object sender, EventArgs e)
        {
            clearTextboxes();
        }

        private void clearTextboxes()
        {
            make_tb.Clear();
            model_tb.Clear();
            car_price_tb.Clear();
            car_stock_tb.Clear();
        }

        private void view_b_Click(object sender, EventArgs e)
        {
            string query = "select * from [car]";
            User.createCon();
            DataTable dt = Admin.viewData(query);
            User.closeCon();
            car_dgv.DataSource = dt;
        }

        private void add_b_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO [car]([car_make],[car_model],[car_price],[car_stock]) VALUES('" + make_tb.Text + "', '" + model_tb.Text + "', '" + decimal.Parse(car_price_tb.Text) + "', '" + int.Parse(car_stock_tb.Text) + "')";
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
                string query = "UPDATE [car] SET [car_make] = '" + make_tb.Text + "', [car_model] = '" + model_tb.Text + "', [car_price] = '" + decimal.Parse(car_price_tb.Text) + "', [car_stock] = '" + int.Parse(car_stock_tb.Text) + "' WHERE car_id = '" + c_id + "' ";
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
            string query = "DELETE FROM [car] WHERE car_id = '" + c_id + "' ";
            User.createCon();
            Admin.deleteData(query);
            User.closeCon();
            view_b_Click(sender, e);
            clearTextboxes();
        }

        private void car_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void car_dgv_Click(object sender, EventArgs e)
        {
            //The following code allows for the rows to be selected and entered into the respective textboxes displayed in the Forms
            int selectedrowindex = car_dgv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = car_dgv.Rows[selectedrowindex];
            c_id = Convert.ToInt32(selectedRow.Cells["car_id"].Value);
            make_tb.Text = Convert.ToString(selectedRow.Cells["car_make"].Value);
            model_tb.Text = Convert.ToString(selectedRow.Cells["car_model"].Value);
            car_price_tb.Text = Convert.ToString(selectedRow.Cells["car_price"].Value);
            car_stock_tb.Text = Convert.ToString(selectedRow.Cells["car_stock"].Value);
        }

        private void car_price_tb_TextChanged(object sender, EventArgs e)
        {
            /*
            if (System.Text.RegularExpressions.Regex.IsMatch(car_price_tb.Text, "^[0-9]([.,][0-9]{1,4})?$"))
            {
                MessageBox.Show("Please enter numbers only!");
                car_price_tb.Text = car_price_tb.Text.Remove(car_price_tb.Text.Length - 1);
            }
            */
        }

        private void car_stock_tb_TextChanged(object sender, EventArgs e)
        {
            /*
            if (System.Text.RegularExpressions.Regex.IsMatch(car_stock_tb.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only!");
                car_stock_tb.Text = car_stock_tb.Text.Remove(car_stock_tb.Text.Length - 1);
            }
            */
        }

        private void car_price_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar!='.')
                e.Handled = true;
        }

        private void car_stock_tb_KeyPress(object sender, KeyPressEventArgs e)
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
