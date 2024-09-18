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
    public partial class ManageOrders : Form
    {
        int o_id;
        public ManageOrders()
        {
            InitializeComponent();
        }

        private void model_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void admin_hp_b_Click(object sender, EventArgs e)
        {
            AdminF ah = new AdminF();
            ah.Show();
            this.Hide();
        }

        private void view_b_Click(object sender, EventArgs e)
        {
            //Viewing the ordered cars
            string viewOrderedCars = "SELECT [order_id], [u_id], [car_id], [car_make], [car_model], [price], [quantity], [order_status] FROM [order] WHERE [car_id] IS NOT NULL";
            User.createCon();
            DataTable ocdt = Admin.viewData(viewOrderedCars);
            User.closeCon();
            cars_ordered_dgv.DataSource = ocdt;

            //Viewing the ordered car parts
            string viewOrderedCarParts = "SELECT [order_id], [u_id], [car_part_id], [car_part_name], [price], [quantity], [order_status] FROM [order] WHERE [car_part_id] IS NOT NULL";
            User.createCon();
            DataTable ocpdt = Admin.viewData(viewOrderedCarParts);
            User.closeCon();
            car_parts_ordered_dgv.DataSource = ocpdt;
        }

        private void cars_ordered_dgv_Click(object sender, EventArgs e)
        {
            //The following code allows for the rows to be selected and entered into the respective textboxes displayed in the Forms
            int selectedrowindex = cars_ordered_dgv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = cars_ordered_dgv.Rows[selectedrowindex];
            o_id = Convert.ToInt32(selectedRow.Cells["order_id"].Value);
            co_userId_tb.Text = Convert.ToString(selectedRow.Cells["u_id"].Value);
            co_carId_tb.Text = Convert.ToString(selectedRow.Cells["car_id"].Value);
            co_carMake_tb.Text = Convert.ToString(selectedRow.Cells["car_make"].Value);
            co_carModel_tb.Text = Convert.ToString(selectedRow.Cells["car_model"].Value);
            co_price_tb.Text = Convert.ToString(selectedRow.Cells["price"].Value);
            co_quantity_tb.Text = Convert.ToString(selectedRow.Cells["quantity"].Value);
            co_orderStatus_cb.Text = Convert.ToString(selectedRow.Cells["order_status"].Value);
        }

        private void car_parts_ordered_dgv_Click(object sender, EventArgs e)
        {
            //The following code allows for the rows to be selected and entered into the respective textboxes displayed in the Forms
            int selectedrowindex = car_parts_ordered_dgv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = car_parts_ordered_dgv.Rows[selectedrowindex];
            o_id = Convert.ToInt32(selectedRow.Cells["order_id"].Value);
            cpo_userId_tb.Text = Convert.ToString(selectedRow.Cells["u_id"].Value);
            cpo_carPart_tb.Text = Convert.ToString(selectedRow.Cells["car_part_id"].Value);
            cpo_carpartName_tb.Text = Convert.ToString(selectedRow.Cells["car_part_name"].Value);
            cpo_price_tb.Text = Convert.ToString(selectedRow.Cells["price"].Value);
            cpo_quantity_tb.Text = Convert.ToString(selectedRow.Cells["quantity"].Value);
            cpo_orderStatus_cb.Text = Convert.ToString(selectedRow.Cells["order_status"].Value);
        }

        private void clearCarsOrderedTextboxes()
        {
            co_userId_tb.Clear();
            co_carId_tb.Clear();
            co_carMake_tb.Clear();
            co_carModel_tb.Clear();
            co_price_tb.Clear();
            co_quantity_tb.Clear();
            co_orderStatus_cb.SelectedIndex = -1;
        }

        private void clearCarPartsOrderedTextboxes()
        {
            cpo_userId_tb.Clear();
            cpo_carPart_tb.Clear();
            cpo_carpartName_tb.Clear();
            cpo_price_tb.Clear();
            cpo_quantity_tb.Clear();
            cpo_orderStatus_cb.SelectedIndex = -1;
        }

        private void clear_b_Click(object sender, EventArgs e)
        {
            clearCarsOrderedTextboxes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearCarPartsOrderedTextboxes();
        }

        private void add_b_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO [order]([u_id],[car_id],[car_make],[car_model],[price],[quantity],[order_status]) VALUES('" + co_userId_tb.Text + "', '" + co_carId_tb.Text + "', '" + co_carMake_tb.Text + "', '" + co_carModel_tb.Text + "',  '" + decimal.Parse(co_price_tb.Text) + "', '" + int.Parse(co_quantity_tb.Text) + "', '" + co_orderStatus_cb.Text + "')";
                User.createCon();
                Admin.insertData(query);
                User.closeCon();
                view_b_Click(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter relevant data into the fields (Make sure the relevant users, cars or car parts exist!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                clearCarsOrderedTextboxes();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO [order]([u_id],[car_part_id],[car_part_name],[price],[quantity],[order_status]) VALUES('" + cpo_userId_tb.Text + "', '" + cpo_carPart_tb.Text + "', '" + cpo_carpartName_tb.Text + "',  '" + decimal.Parse(cpo_price_tb.Text) + "', '" + int.Parse(cpo_quantity_tb.Text) + "', '" + cpo_orderStatus_cb.Text + "')";
                User.createCon();
                Admin.insertData(query);
                User.closeCon();
                view_b_Click(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter relevant data into the fields (Make sure the relevant users, cars or car parts exist!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                clearCarPartsOrderedTextboxes();
            }
        }

        private void update_b_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE [order] SET [u_id] = '" + co_userId_tb.Text + "', [car_id] = '" + co_carId_tb.Text + "', [car_make] = '" + co_carMake_tb.Text + "', [car_model] = '" + co_carModel_tb.Text + "', [price] = '" + decimal.Parse(co_price_tb.Text) + "', [quantity] = '" + int.Parse(co_quantity_tb.Text) + "', [order_status] = '" + co_orderStatus_cb.Text + "' WHERE order_id = '" + o_id + "' ";
                User.createCon();
                Admin.updateData(query);
                User.closeCon();
                view_b_Click(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter relevant data into the fields (Make sure the relevant users, cars or car parts exist)!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                clearCarsOrderedTextboxes();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE [order] SET [u_id] = '" + cpo_userId_tb.Text + "', [car_part_id] = '" + cpo_carPart_tb.Text + "', [car_part_name] = '" + cpo_carpartName_tb.Text + "', [price] = '" + decimal.Parse(cpo_price_tb.Text) + "', [quantity] = '" + int.Parse(cpo_quantity_tb.Text) + "', [order_status] = '" + cpo_orderStatus_cb.Text + "' WHERE order_id = '" + o_id + "' ";
                User.createCon();
                Admin.updateData(query);
                User.closeCon();
                view_b_Click(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter relevant data into the fields (Make sure the relevant users, cars or car parts exist)!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                clearCarPartsOrderedTextboxes();
            }
        }

        private void delete_b_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM [order] WHERE order_id = '" + o_id + "' ";
            User.createCon();
            Admin.deleteData(query);
            User.closeCon();
            view_b_Click(sender, e);
            clearCarsOrderedTextboxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM [order] WHERE order_id = '" + o_id + "' ";
            User.createCon();
            Admin.deleteData(query);
            User.closeCon();
            view_b_Click(sender, e);
            clearCarPartsOrderedTextboxes();
        }
    }
}
