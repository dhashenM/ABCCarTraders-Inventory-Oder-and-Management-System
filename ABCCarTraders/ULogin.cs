using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ABCCarTraders
{
    public class ULogin
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ABCCarTraders;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        public DataTable GetTable(string query)
        {
            if (con.State == ConnectionState.Closed)
            {
                cmd.Connection = con;
                cmd.CommandTimeout = 0;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
                con.Close();
            }

            return dt;
        }
    }
}
