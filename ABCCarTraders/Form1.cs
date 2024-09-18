using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABCCarTraders
{
    public partial class Form1 : Form
    {
        //public static Form1 instance;

        //public Int32 CustomerID { get; set; }

        public Form1()
        {
            InitializeComponent();
            //instance = this;
        }

        ULogin userlogin = new ULogin();
        DataTable TBL = new DataTable();
        

        //SqlConnection conn = new SqlConnection(@"Data Source =.; Initial Catalog = ABCCarTraders; Integrated Security = True");

        private void label1_Click(object sender, EventArgs e)
        {   

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (username_textbox.Text == "" || password_textbox.Text == "")
                {
                    MessageBox.Show("Please input all login details", "Incomplete Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (userType_cb.Text == "Admin")
                {
                    TBL = userlogin.GetTable("SELECT * FROM [user] WHERE u_username = '" + username_textbox.Text + "' AND u_password = '" + password_textbox.Text + "' AND u_type = '" + userType_cb.Text + "' ");

                    if (TBL.Rows.Count > 0)
                    {
                        //Query to create a connection to the SQL Server
                        SqlConnection SQLConnection = new SqlConnection();
                        SQLConnection.ConnectionString = @"Data Source = MUFASA; Initial Catalog = ABCCarTraders; Integrated Security = True";

                        //Query to obtain the User ID with the entererd username and password
                        string idQuery = "SELECT TOP 1 u_id FROM [user] WHERE u_username = '" + username_textbox.Text + "' AND u_password = '" + password_textbox.Text + "' AND u_type = '" + userType_cb.Text + "' ";

                        //Query to store the User Id from the database into a variable in C#
                        SqlCommand CmdId = SQLConnection.CreateCommand();
                        CmdId.CommandText = idQuery;
                        SQLConnection.Open();
                        Int32 selectedAdminID = (Int32)CmdId.ExecuteScalar();
                        SQLConnection.Close();

                        //Query to obtain the User Name with the entererd username and password
                        string nameQuery = "SELECT TOP 1 u_name FROM [user] WHERE u_username = '" + username_textbox.Text + "' AND u_password = '" + password_textbox.Text + "' AND u_type = '" + userType_cb.Text + "' ";

                        //Query to store the User Name from the database into a variable in C#
                        SqlCommand CmdName = SQLConnection.CreateCommand();
                        CmdName.CommandText = nameQuery;
                        SQLConnection.Open();
                        string selectedAdminName = (string)CmdName.ExecuteScalar();
                        SQLConnection.Close();

                        //Creating an instance of an Admin Home Page 
                        AdminF ah = new AdminF();

                        //Sending the admin ID and name data to the Admin Home page
                        ah.AdminID = selectedAdminID;
                        ah.AdminName = selectedAdminName;

                        //Opening the Customer Home Page and closing the current page
                        ah.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Login Failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (userType_cb.Text == "Customer")
                {
                    TBL = userlogin.GetTable("SELECT * FROM [user] WHERE u_username = '" + username_textbox.Text + "' AND u_password = '" + password_textbox.Text + "' AND u_type = '" + userType_cb.Text + "' ");

                    if (TBL.Rows.Count > 0)
                    {
                        //Query to create a connection to the SQL Server
                        SqlConnection SQLConnection = new SqlConnection();
                        SQLConnection.ConnectionString = @"Data Source = MUFASA; Initial Catalog = ABCCarTraders; Integrated Security = True";

                        //Query to obtain the User ID with the entererd username and password
                        string idQuery = "SELECT TOP 1 u_id FROM [user] WHERE u_username = '" + username_textbox.Text + "' AND u_password = '" + password_textbox.Text + "' AND u_type = '" + userType_cb.Text + "' ";

                        //Query to store the User Id from the database into a variable in C#
                        SqlCommand CmdId = SQLConnection.CreateCommand();
                        CmdId.CommandText = idQuery;
                        SQLConnection.Open();
                        Int32 selectedCustomerID = (Int32)CmdId.ExecuteScalar();
                        SQLConnection.Close();

                        //Query to obtain the User Name with the entererd username and password
                        string nameQuery = "SELECT TOP 1 u_name FROM [user] WHERE u_username = '" + username_textbox.Text + "' AND u_password = '" + password_textbox.Text + "' AND u_type = '" + userType_cb.Text + "' ";

                        //Query to store the User Name from the database into a variable in C#
                        SqlCommand CmdName = SQLConnection.CreateCommand();
                        CmdName.CommandText = nameQuery;
                        SQLConnection.Open();
                        string selectedCustomerName = (string)CmdName.ExecuteScalar();
                        SQLConnection.Close();

                        //Creating an instance of a Customer Home Page 
                        CustomerHome ch = new CustomerHome();

                        //Sending the customer ID and Name data to the Customer Home page
                        ch.CustomerID = selectedCustomerID;
                        ch.CustomerName = selectedCustomerName;

                        //Opening the Customer Home Page and closing the current page
                        ch.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                username_textbox.Clear();
                password_textbox.Clear();
                userType_cb.SelectedIndex = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            username_textbox.Clear();
            password_textbox.Clear();
            userType_cb.SelectedIndex = -1;

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            
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
            
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerF cr = new CustomerF();
            cr.Show();
            this.Hide();
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
