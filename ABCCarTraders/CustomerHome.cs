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
    public partial class CustomerHome : Form
    {
        decimal totalCarCost = 0;
        decimal totalCarPartCost = 0;
        decimal totalCost = 0;
        public DataTable dt = new DataTable();
        public int customer_id;

        public Int32 CustomerID { get; set; }
        public String CustomerName { get; set; }

        public CustomerHome()
        {
            InitializeComponent();

        }

        private void CustomerHome_Load(object sender, EventArgs e)
        {
            welcome_c_lbl.Text = "Welcome: " + CustomerName + " | Id Number: " + CustomerID.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "select * from [car]";
            User.createCon();
            dt = Customer.viewData(query);
            User.closeCon();
            car_dgv.DataSource = dt;
        }

        private void car_dgv_Click(object sender, EventArgs e)
        {
            //The following code allows for the rows to be selected and entered into the respective textboxes displayed in the Forms
            int selectedrowindex = car_dgv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = car_dgv.Rows[selectedrowindex];
            car_id_tb.Text = Convert.ToString(selectedRow.Cells["car_id"].Value);
            make_tb.Text = Convert.ToString(selectedRow.Cells["car_make"].Value);
            model_tb.Text = Convert.ToString(selectedRow.Cells["car_model"].Value);
            car_price_tb.Text = Convert.ToString(selectedRow.Cells["car_price"].Value);
            car_stock_tb.Text = Convert.ToString(selectedRow.Cells["car_stock"].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tcoc_lbl.Text = "Total Cost of Cars: ";
            tcocp_lbl.Text = "Total cost of Car Parts:";
            lblTotalCost.Text = "Total cost of all Products: ";

            if (Cars_Ordered.Items.Count == 0 && Car_Parts_Ordered.Items.Count == 0)
            {
                MessageBox.Show("There are no items in your cart!", "Non-existent order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //updating the quantity of cars after deletion
                try
                {
                    string updateQuery = "UPDATE A SET A.car_stock = B.quantity + A.car_stock FROM car A INNER JOIN car_cart B ON A.car_id = B.car_id";
                    User.createCon();
                    Customer.updateCancelledQuantityData(updateQuery);
                    User.closeCon();
                }
                catch (Exception)
                {
                    MessageBox.Show("Updation Error!");
                }
                finally
                {

                }

                //updating the quantity of car parts after deletion
                try
                {
                    string updateQuery = "UPDATE A SET A.car_part_stock = B.quantity + A.car_part_stock FROM car_parts A INNER JOIN car_part_cart B ON A.car_part_id = B.car_part_id";
                    User.createCon();
                    Customer.updateCancelledQuantityData(updateQuery);
                    User.closeCon();
                }
                catch (Exception)
                {
                    MessageBox.Show("Updation Error!");
                }
                finally
                {

                }

                string carCartQuery = "DELETE FROM [car_cart]";
                User.createCon();
                Customer.deleteCartData(carCartQuery);
                User.closeCon();

                string carPartCartQuery = "DELETE FROM [car_part_cart]";
                User.createCon();
                Customer.deleteCartData(carPartCartQuery);
                User.closeCon();

                Cars_Ordered.Items.Clear();
                Car_Parts_Ordered.Items.Clear();
                button3_Click(sender, e);
                view_cp_b_Click(sender, e);

                MessageBox.Show("Your order has been cancelled!", "Order Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(make_tb.Text == "" )
            {
                MessageBox.Show("No items have been selected to add to cart!", "Invalid order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (quantity_cb.Text == "")
            {
                MessageBox.Show("Select how many items you would like to add to cart!", "Invalid order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Checking the availability of items and updating the number of items in the database after the user has added to cart
            else if (int.Parse(car_stock_tb.Text) == 0)
            {
                MessageBox.Show("This item is out of stock!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (int.Parse(quantity_cb.Text) > int.Parse(car_stock_tb.Text))
            {
                MessageBox.Show("There are not enough of these items in stock!", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Converting the car price into decimal value and saving it in a variable
                decimal readableCP = decimal.Parse(car_price_tb.Text);

                //Adding the items into a list that will be displayed to the customer
                Cars_Ordered.Items.Add((quantity_cb.Text).ToString() + " X " + make_tb.Text + " | " + model_tb.Text + " - Rs. " + readableCP.ToString("#,##0"));

                //Calculating the total of the cars added to cart and displaying it to the customer
                totalCarCost += decimal.Parse(car_price_tb.Text) * int.Parse(quantity_cb.Text);
                tcoc_lbl.Text = "Total Cost of Cars: Rs. " + totalCarCost.ToString("#,##0");

                //Calculating the total of the car parts added to cart and displaying it to the customer


                //Calculating the total of all the items in the cart and displaying it to the customer
                totalCost = totalCarCost + totalCarPartCost;
                lblTotalCost.Text = "Total Cost: Rs. " + totalCost.ToString("#,##0");

                try
                {
                int stockRemaining = int.Parse(car_stock_tb.Text) - int.Parse(quantity_cb.Text);
                string customerQuery = "UPDATE [car] SET [car_stock] = '" + stockRemaining + "' WHERE car_id = '" + car_id_tb.Text + "' ";
                User.createCon();
                Customer.updateQuantityData(customerQuery);
                User.closeCon();
                }
                catch (Exception)
                {
                    MessageBox.Show("Updation Error!");
                }
                finally
                {

                }

                //Adding the items into a temporary database table that will act as the order cart, before finally adding it into the order database table
                try
                {
                    string customerQuery = "INSERT INTO [car_cart]([car_id],[car_make],[car_model],[car_price],[quantity]) VALUES('" + int.Parse(car_id_tb.Text) + "', '" + make_tb.Text + "', '" + model_tb.Text + "', '" + decimal.Parse(car_price_tb.Text) + "', '" + int.Parse(quantity_cb.Text) + "')";
                    User.createCon();
                    Customer.insertTempData(customerQuery);
                    User.closeCon();
                    button3_Click(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Insertion Error!");
                }
                finally
                {
                        
                }
                MessageBox.Show("Successfully added items to cart!", "Valid order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTextboxes();
                   
            }
        }

        private void clearTextboxes()
        {
            car_id_tb.Clear();
            make_tb.Clear();
            model_tb.Clear();
            car_price_tb.Clear();
            car_stock_tb.Clear();
            quantity_cb.SelectedIndex = -1;
        }

        private void clearCarPartTextboxes()
        {
            cp_ID_tb.Clear();
            cp_name_tb.Clear();;
            cp_price_tb.Clear();
            cp_stock_tb.Clear();
            cp_quantity_cb.SelectedIndex = -1;
        }

        private void tabCustomerHome_sic(object sender, EventArgs e)
        {
           
        }


        private void status_lbl_Click(object sender, EventArgs e)
        {

        }

        private void car_price_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void place_order_b_Click(object sender, EventArgs e)
        {
            if (Cars_Ordered.Items.Count == 0 && Car_Parts_Ordered.Items.Count == 0)
            {
                MessageBox.Show("There are no items in your cart!", "Non-existent order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Updating the main order table with car cart details
                try
                {
                    string query = "INSERT INTO [order] (u_id, car_id, car_make, car_model, price, quantity, order_status) SELECT '" + CustomerID + "', car_id, car_make, car_model, car_price, quantity, '" + "Pending" + "' FROM car_cart";
                    User.createCon();
                    Customer.placeOrder(query);
                    User.closeCon();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Order Placement Error!");
                }
                finally
                {

                }

                //Updating the main order table with car part cart details
                try
                {
                    string query = "INSERT INTO [order] (u_id, car_part_id, car_part_name, price, quantity, order_status) SELECT '" + CustomerID + "', car_part_id, car_part_name, car_part_price, quantity, '" + "Pending" + "' FROM car_part_cart";
                    User.createCon();
                    Customer.placeOrder(query);
                    User.closeCon();

                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Order Placement Error!");
                }
                finally
                {

                }

                //Deleting the temporary data in the car cart
                try
                {
                    string carCartQuery = "DELETE FROM [car_cart]";
                    User.createCon();
                    Customer.deleteCartData(carCartQuery);
                    User.closeCon();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
                finally
                {

                }

                //Deleting the temporary data in the car part cart
                try
                {
                    string carPartCartQuery = "DELETE FROM [car_part_cart]";
                    User.createCon();
                    Customer.deleteCartData(carPartCartQuery);
                    User.closeCon();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
                finally
                {

                }

                //clearing the data in the listboxes
                Cars_Ordered.Items.Clear();
                Car_Parts_Ordered.Items.Clear();
                MessageBox.Show("Your order has been successfully placed!");
            } 
        }

        private void view_cp_b_Click(object sender, EventArgs e)
        {
            string query = "select * from [car_parts]";
            User.createCon();
            dt = Customer.viewData(query);
            User.closeCon();
            car_cp_dgv.DataSource = dt;
        }

        private void car_cp_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void car_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cp_add_b_Click(object sender, EventArgs e)
        {
            if (cp_name_tb.Text == "")
            {
                MessageBox.Show("No items have been selected to add to cart!", "Invalid order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cp_quantity_cb.Text == "")
            {
                MessageBox.Show("Select how many items you would like to add to cart!", "Invalid order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Checking the availability of items and updating the number of items in the database after the user has added to cart
            else if (int.Parse(cp_stock_tb.Text) == 0)
            {
                MessageBox.Show("This item is out of stock!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (int.Parse(cp_quantity_cb.Text) > int.Parse(cp_stock_tb.Text))
            {
                MessageBox.Show("There are not enough of these items in stock!", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Converting the car part price into a decimal value and saving it in a variable
                decimal readableCPP = decimal.Parse(cp_price_tb.Text);

                //Adding the items into a list that will be displayed to the customer
                Car_Parts_Ordered.Items.Add((cp_quantity_cb.Text).ToString() + " X " + cp_name_tb.Text + " - Rs. " + readableCPP.ToString("#,##0"));

                //Calculating the total of the car parts added to cart and displaying it to the customer
                totalCarPartCost += decimal.Parse(cp_price_tb.Text) * int.Parse(cp_quantity_cb.Text);
                tcocp_lbl.Text = "Total Cost of Car Parts: Rs. " + totalCarPartCost.ToString("#,##0");

                //Calculating the total of all the items in the cart and displaying it to the customer
                totalCost = totalCarPartCost + totalCarCost;
                lblTotalCost.Text = "Total Cost: Rs. " + totalCost.ToString("#,##0");

                try
                {
                    int stockRemaining = int.Parse(cp_stock_tb.Text) - int.Parse(cp_quantity_cb.Text);
                    string customerQuery = "UPDATE [car_parts] SET [car_part_stock] = '" + stockRemaining + "' WHERE car_part_id = '" + cp_ID_tb.Text + "' ";
                    User.createCon();
                    Customer.updateQuantityData(customerQuery);
                    User.closeCon();
                }
                catch (Exception)
                {
                    MessageBox.Show("Updation Error!");
                }
                finally
                {

                }

                //Adding the items into a temporary database table that will act as the order cart, before finally adding it into the order database table
                try
                {
                    string customerQuery = "INSERT INTO [car_part_cart]([car_part_id],[car_part_name],[car_part_price],[quantity]) VALUES('" + int.Parse(cp_ID_tb.Text) + "', '" + cp_name_tb.Text + "', '" + decimal.Parse(cp_price_tb.Text) + "', '" + int.Parse(cp_quantity_cb.Text) + "')";
                    User.createCon();
                    Customer.insertTempData(customerQuery);
                    User.closeCon();
                    view_cp_b_Click(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Insertion Error!");
                }
                finally
                {

                }
                MessageBox.Show("Successfully added items to cart!", "Valid order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearCarPartTextboxes();

            }
        }

        private void car_cp_dgv_Click(object sender, EventArgs e)
        {
            //The following code allows for the rows to be selected and entered into the respective textboxes displayed in the Forms
            int selectedrowindex = car_cp_dgv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = car_cp_dgv.Rows[selectedrowindex];
            cp_ID_tb.Text = Convert.ToString(selectedRow.Cells["car_part_id"].Value);
            cp_name_tb.Text = Convert.ToString(selectedRow.Cells["car_part_name"].Value);
            cp_price_tb.Text = Convert.ToString(selectedRow.Cells["car_part_price"].Value);
            cp_stock_tb.Text = Convert.ToString(selectedRow.Cells["car_part_stock"].Value);
        }

        //Method used to implement searching amongst the product lists
        public void SearchByColumnName(string columnName, TextBox txt)
        {
            DataView carItems = dt.DefaultView;
            carItems.RowFilter = columnName + " like '%" + txt.Text + "%'";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchByColumnName("car_model", model_search_tb);    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SearchByColumnName("car_make", make_search_tb);
        }

        

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            SearchByColumnName("car_part_name", name_search_tb);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 ul = new Form1();
            ul.Show();
            this.Hide();
        }

        private void CustomerHome_Shown(object sender, EventArgs e)
        {

        }

        private void welcome_c_lbl_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void view_orders_b_Click(object sender, EventArgs e)
        {

            //Viewing the ordered cars
            string viewOrderedCars = "SELECT [car_id], [car_make], [car_model], [price], [quantity], [order_status] FROM [order] WHERE [u_id] = '" + CustomerID + "' AND [car_id] IS NOT NULL";
            User.createCon();
            DataTable ocdt = Customer.viewData(viewOrderedCars);
            User.closeCon();
            car_orders_dgv.DataSource = ocdt;

            //Viewing the ordered car parts
            string viewOrderedCarParts = "SELECT [car_part_id], [car_part_name], [price], [quantity], [order_status] FROM [order] WHERE [u_id] = '" + CustomerID + "' AND [car_part_id] IS NOT NULL";
            User.createCon();
            DataTable ocpdt = Customer.viewData(viewOrderedCarParts);
            User.closeCon();
            car_part_orders_dgv.DataSource = ocpdt;

            if (car_orders_dgv.Rows.Count == 0 && car_part_orders_dgv.Rows.Count == 0)
            {
                MessageBox.Show("You have not placed any orders!", "No orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void make_search_tb_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void name_search_tb_Click(object sender, EventArgs e)
        {
            view_cp_b_Click(sender, e);
        }

        private void model_search_tb_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }
    }
}
