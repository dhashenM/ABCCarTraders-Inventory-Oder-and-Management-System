using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace ABCCarTraders
{
    class User
    {
        public static SqlConnection conn;

        //public DataTable dt = new DataTable();

        /*
        public int u_id { get; set; }

        public string u_name { get; set; }

        public string u_username { get; set; }

        public string u_password { get; set; }

        public string u_address { get; set; }

        public int u_number { get; set; }

        public string u_type { get; set; }
        */

        public static void createCon()
        {
            string constring = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
            conn = new SqlConnection(constring);
            conn.Open();
        }

        public static void closeCon()
        {
            conn.Close();
        }

        public static DataTable viewData(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);

            return dt;
        }

        /*
        public static void obtainID(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            cmd.CommandText = query;
            Int32 CustomerID = (Int32)cmd.ExecuteScalar();
        }
        */
    }
}
