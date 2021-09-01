using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Transportproject.Models;
using System.Data.SqlClient;
using System.Data;


namespace Transportproject.Models
{
    public class Employee
    {

        SqlConnection con;
        public Employee()
        {
            con = new SqlConnection("Data source= LAPTOP-D3N6B5KQ\\SQLEXPRESS; database=TransportDB; integrated security=true");
        }
        public DataTable Employees()
        {
            string selqry = "select EmployeeID,EmployeeName,Age,Location,Phone,VehicleID from tbl_Employee";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
           
        }
            public int InsertEmployee(int EmployeeID, string EmployeeName,int Age, string Location, string Phone, string VehicleID) 
       {

            string insqry = "insert tbl_Employee(EmployeeID,EmployeeName,Age,Location,Phone,VehicleID) values(@EmployeeID,@EmployeeName,@Age,@Location,@Phone,@VehicleID)";
            SqlCommand cmd = new SqlCommand(insqry, con);
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            cmd.Parameters.AddWithValue("@EmployeeName", EmployeeName);
            cmd.Parameters.AddWithValue("@Age", Age);
            cmd.Parameters.AddWithValue("@Location", Location);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
            con.Open();
            return cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable EmployeeByNo(int EmployeeID)
        {
            string byNoQry = "select EmployeeID,EmployeeName,Age,Location,Phone,VehicleID from tbl_Employee where EmployeeID=" + EmployeeID;
            SqlDataAdapter da = new SqlDataAdapter(byNoQry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int UpdateEmployees(int EmployeeID, string EmployeeName, int Age, string Location, string Phone, string VehicleID)
        {
            string updqry = "update tbl_Employee set EmployeeID=@EmployeeID,EmployeeName=@EmployeeName,Age=@Age,Location=@Location,Phone=@Phone,VehicleID=@VehicleID where EmployeeID=@EmployeeID";
            SqlCommand cmd = new SqlCommand(updqry, con);
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            cmd.Parameters.AddWithValue("@EmployeeName", EmployeeName);
            cmd.Parameters.AddWithValue("@Age", Age);
            cmd.Parameters.AddWithValue("@Location", Location);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }
        public DataTable DeleteByNo(int EmployeeID)
        {
            string byNoQry = "select EmployeeID,EmployeeName,Age,Location,Phone,VehicleID from tbl_Employee where EmployeeID=" + EmployeeID;
            SqlDataAdapter da = new SqlDataAdapter(byNoQry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int DeleteEmployee(int EmployeeID)
        {
            string up = "delete tbl_Employee where EmployeeID=" + EmployeeID;
            SqlCommand cmd = new SqlCommand(up, con);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

       
    }
}