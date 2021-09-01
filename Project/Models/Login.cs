using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Transportproject.Models
{
    public class Login
    {
        SqlConnection con;
        public Login()
        {
            con = new SqlConnection("Data source= LAPTOP-D3N6B5KQ\\SQLEXPRESS; database=TransportDB; integrated security=true");
        }
        public DataTable GetLogins()
        {
            string selqry = "select UserName,Password from tbl_login";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
