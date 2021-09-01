using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Transportproject.Models
{
    public class AllocateVehicle
    {

        SqlConnection con;
        public AllocateVehicle()
        {
            con = new SqlConnection("Data source= LAPTOP-D3N6B5KQ\\SQLEXPRESS; database=TransportDB; integrated security=true");
        }
        public DataTable AllocateVehicles()
        {
            string selqry = "select VehicleID, VehicleNumber,VehicleName from AllocateVehicle";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int allocateinsertvehicle(string VehicleID,string VehicleNumber,string VehicleName)
        {

            string insqry = "insert AllocateVehicle(VehicleID,VehicleNumber,VehicleName) values(@VehicleID,@VehicleNumber,@VehicleName)";
            SqlCommand cmd = new SqlCommand(insqry, con);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
            cmd.Parameters.AddWithValue("@VehicleNumber",VehicleNumber);
            cmd.Parameters.AddWithValue("@VehicleName", VehicleName);
           

            con.Open();
            return cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable AllDetails()
        {
            string selqry = "select EmployeeID,EmployeeName,Age,Location,Phone,veh.VehicleID,rou.VehicleNumber from tbl_Employee emp join Vehicle veh on veh.VehicleID=emp.VehicleID join Route rou on rou.VehicleNumber=veh.VehicleNumber ";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}