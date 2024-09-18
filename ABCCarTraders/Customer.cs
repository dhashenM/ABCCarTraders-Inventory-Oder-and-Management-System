using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ABCCarTraders
{

    class Customer : User
    {
        public static void updateQuantityData(string customerQuery)
        {
            SqlCommand cmd = new SqlCommand(customerQuery, conn);
            int a = cmd.ExecuteNonQuery();    
        }

        public static void insertTempData(string customerQuery)
        {
            SqlCommand cmd = new SqlCommand(customerQuery, conn);
            int a = cmd.ExecuteNonQuery();
        }
        public static void deleteCartData(string customerQuery)
        {
            SqlCommand cmd = new SqlCommand(customerQuery, conn);
            int a = cmd.ExecuteNonQuery();
        }
        public static void updateCancelledQuantityData(string customerQuery)
        {
            SqlCommand cmd = new SqlCommand(customerQuery, conn);
            int a = cmd.ExecuteNonQuery();
        }
        public static void registration(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("You have successfully registered!");
            }
        }
        public static void placeOrder(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
        }

        //static SqlConnection conn = new SqlConnection(@"Data Source =.; Initial Catalog = ABCCarTraders; Integrated Security = True");

        /*
        public void addData(string name, string username, string password, string address, int number)
        {

            String sql = "INSERT INTO [user](u_name, u_username, u_password, u_address, u_number, u_type) values('" + name + "', '" + username + "', '" + password + "', '" + address + "', '" + number + "', '" + "Customer" + "')";
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        */


        /*
        public List<Customer> get_all_customers()
        {
            List<Customer> li = new List<Customer>();

            string sql = "SELECT * FROM [user]";
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Customer c = new Customer();

                c.u_id = (int)dr["u_id"];
                c.u_name = dr["u_name"].ToString();
                c.u_username = dr["u_username"].ToString();
                c.u_password = dr["u_password"].ToString();
                c.u_address = dr["u_address"].ToString();
                c.u_number = (int)dr["u_number"];
                c.u_type = dr["u_type"].ToString();

                li.Add(c);

            }
            return li;
        }
        */

        /*
        public void login()
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            DataTable GetTable(string query)
            {
                if (conn.State == ConnectionState.Closed)
                {
                    cmd.Connection = conn;
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    conn.Close();

                }
                return dt;
            }
        }
        */
    }
}