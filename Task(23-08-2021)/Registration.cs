using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Registrationwithmvc.Models
{
    public class Registration
    {
        SqlConnection con;
        public Registration()
        {
            con = new SqlConnection("Data source= LAPTOP-D3N6B5KQ\\SQLEXPRESS; database=RegistrationDB; integrated security=true");
        }
        public DataTable GetRecords()
        {
            string selqry = "select RollNo,FName,LName,City,Email,Password,Gender from Student";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public int InsertRecords(int rollno, string fname, string lname, string city,string email,string password,string gender)
        {
            string insqry = "insert Student(rollno,FName,LName,City,Email,Password,Gender )values (@rollno,@FName,@LName,@City,@Email,@Password,@Gender)";
            SqlCommand cmd = new SqlCommand(insqry, con);
            cmd.Parameters.AddWithValue("@rollno",rollno );
            cmd.Parameters.AddWithValue("@fName", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@gender", gender);

            con.Open();
            return cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable RecordsByNo(int RollNo)
        {
            string byNoQry = "select RollNo,FName,LName,City,Email,Password,Gender from Student where RollNo=" + RollNo;
            SqlDataAdapter da = new SqlDataAdapter(byNoQry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int UpdateRecords(int rollno, string fname, string lname, string city, string email, string password,string gender)
        {
            string updqry = "update Student set FName=@fname,LName=@lname,City=@city,Email=@email,Password=@password,Gender=@gender where RollNo=@RollNo";
            SqlCommand cmd = new SqlCommand(updqry, con);
            cmd.Parameters.AddWithValue("@rollno", rollno);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@gender", gender);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }
    }
}