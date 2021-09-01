using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Transportproject.Models
{
    public class Route
    {
        SqlConnection con;
        public Route()
        {
            con = new SqlConnection("Data source= LAPTOP-D3N6B5KQ\\SQLEXPRESS; database=TransportDB; integrated security=true");
        }
        public DataTable Routes()
        {
            string selqry = "select RootNumber,VehicleNumber,Stop1,Stop2,Stop3 from Route";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public int routeinsert(int RootNumber, string VehicleNumber,string Stop1,string Stop2,string Stop3)
        {

            string insqry = "insert Route(RootNumber,VehicleNumber,Stop1,Stop2,Stop3) values(@RootNumber,@VehicleNumber,@Stop1,@Stop2,@Stop3)";
            SqlCommand cmd = new SqlCommand(insqry, con);
            cmd.Parameters.AddWithValue("@RootNumber", RootNumber);
            cmd.Parameters.AddWithValue("@VehicleNumber", VehicleNumber);
            cmd.Parameters.AddWithValue("@Stop1", Stop1);
            cmd.Parameters.AddWithValue("@Stop2", Stop2);
            cmd.Parameters.AddWithValue("@Stop3", Stop3);
            
            con.Open();
            return cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
