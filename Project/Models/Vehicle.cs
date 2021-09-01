using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Transportproject.Models
{
    public class Vehicle
    {
        SqlConnection con;
        public Vehicle()
        {
            con = new SqlConnection("Data source= LAPTOP-D3N6B5KQ\\SQLEXPRESS; database=TransportDB; integrated security=true");
        }
       
        public DataTable Vehicles()
        {
            string selqry = "select VehicleID,VehicleNumber,Capacity,TotalCapacity,AvailableSeats,Operable from Vehicle";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public int InsertVehicle(string VehicleID,string VehicleNumber, int Capacity,int TotalCapacity, int AvailableSeats, string Operable)
        {

            string insqry = "insert Vehicle(VehicleID,VehicleNumber,Capacity,TotalCapacity,AvailableSeats,Operable) values(@VehicleID,@VehicleNumber,@Capacity,@TotalCapacity,@AvailableSeats,@Operable)";
            SqlCommand cmd = new SqlCommand(insqry, con);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
            cmd.Parameters.AddWithValue("@VehicleNumber", VehicleNumber);
            cmd.Parameters.AddWithValue("@Capacity",Capacity);
            cmd.Parameters.AddWithValue("@TotalCapacity", TotalCapacity);
            cmd.Parameters.AddWithValue("@AvailableSeats", AvailableSeats);
            cmd.Parameters.AddWithValue("@Operable",Operable);
           
            con.Open();
            return cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable VehicleByNo(string VehicleID)
        {
            string byNoQry = "select VehicleID,VehicleNumber,TotalCapacity,Capacity,AvailableSeats,Operable from Vehicle where VehicleID=" + VehicleID;
            SqlDataAdapter da = new SqlDataAdapter(byNoQry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int UpdateVehicles(string VehicleID,int VehicleNumber, int Capacity, int TotalCapacity, int AvailableSeats, string Operable)
        {
            string updqry = "update Vehicle set VehicleID=@VehicleID, VehicleNumber=@VehicleNumber,TotalCapacity=@TotalCapacity,Capacity=@Capacity,AvailableSeats=@AvailableSeats,Operable=@Operable where VehicleID=@VehicleID";
            SqlCommand cmd = new SqlCommand(updqry, con);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
            cmd.Parameters.AddWithValue("@VehicleNumber",VehicleNumber);
            cmd.Parameters.AddWithValue("@TotalCapacity", TotalCapacity);
            cmd.Parameters.AddWithValue("@Capacity", Capacity);
            cmd.Parameters.AddWithValue("@AvailableSeats", AvailableSeats);
            cmd.Parameters.AddWithValue("@Operable", Operable);
           
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }
        public DataTable status()
        {
            string selqry = "select Status from ChangeVehicle";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

    }
}