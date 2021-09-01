using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transportproject.Models;

namespace Transportproject.Controllers
{
    public class TransportController : Controller
    {
        // GET: Transport
        public ActionResult Index()
        {
            Employee eobj = new Employee();
            DataTable dt = eobj.Employees();
            return View("Home", dt);

           
        }

        public ActionResult Insert()
        {
            return View("InsertEmployee");
        }
        public ActionResult InsertEmployee(FormCollection frm, string action)
        {
            Employee eobj = new Employee();
            if (action == "Submit")
            {
                int EmployeeID = Convert.ToInt32(frm["txtEmployeeID"]);
                String EmployeeName = frm["txtEmployeeName"];
                int Age = Convert.ToInt32(frm["txtAge"]);
                String Location = frm["txtLocation"];
                String Phone = frm["txtPhone"];
                String VehicleID = frm["txtVehicleID"];
                int instatus = eobj.InsertEmployee(EmployeeID, EmployeeName, Age, Location, Phone, VehicleID);
                DataTable dt = eobj.Employees();

                return View("Home", dt);

            }
            else
            {
                DataTable dt = eobj.Employees();
                return RedirectToAction("Vehicle", dt);
            }
        }
        public ActionResult Delete(int EmployeeID)
        {
            Employee eobj = new Employee();
            DataTable dt = eobj.DeleteByNo(EmployeeID);
                return View("Delete", dt);
        }
       public ActionResult DeleteEmployee(FormCollection frm,string action)
        {
            Employee eobj = new Employee();
            if(action=="Delete")
            {
                int EmployeeID = Convert.ToInt32(frm["txtEmployeeID"]);
                int res = eobj.DeleteEmployee(EmployeeID);
                return RedirectToAction("Home");

            }
            return RedirectToAction("Vehicle");
        }
            public ActionResult UpdateEmployee(int EmployeeID)
            {
                Employee eobj = new Employee();
                DataTable dt = eobj.EmployeeByNo(EmployeeID);
                return View("UpdateEmployee", dt);
            }
            public ActionResult UpdateEmployees(FormCollection frm, string action)
            {
                Employee dmodel = new Employee();
                if (action == "Submit")
                {
                    int EmployeeID = Convert.ToInt32(frm["txtEmployeeID"]);
                    string EmployeeName = frm["txtEmployeeName"];
                    int Age = Convert.ToInt32(frm["txtAge"]);
                    string Location = frm["txtLocation"];
                    string Phone = frm["txtPhone"];
                    string VehicleID = frm["txtVehicle"];
                    int res = dmodel.UpdateEmployees(EmployeeID,EmployeeName,Age,Location,Phone,VehicleID);
                    return RedirectToAction("Home");
                }
                return RedirectToAction("Vehicle");
            }

       

        public ActionResult Employee()
        {
           
            return View();
        }

        public ActionResult Index1()
        {
            Vehicle vobj = new Vehicle();
            DataTable dt = vobj.Vehicles();
            return View("Vehicle1", dt);
        }
        public ActionResult Insert1()
        {
            return View("InsertVehicle");
        }
        public ActionResult Vehicle()
        {
            return View();
        }
        public ActionResult VehicleInsert(FormCollection frm, string action)
        {
            Vehicle vobj = new Vehicle();
            if (action == "Submit")
            {
                string VehicleID = frm["txtVehicleID"];
                string  VehicleNumber =frm["txtVehicleNumber"];
                int Capacity = Convert.ToInt32(frm["txtCapacity"]);
                int TotalCapacity = Convert.ToInt32(frm["txtTotalCapacity"]);

                int AvailableSeats = Convert.ToInt32(frm["txtAvailableSeats"]);
                String Operable = frm["txtOperable"];


                int instatus = vobj.InsertVehicle(VehicleID,VehicleNumber, Capacity, TotalCapacity, AvailableSeats, Operable);
                DataTable dt = vobj.Vehicles();

                return View("Vehicle1", dt);

            }
            else
            {
                DataTable dt = vobj.Vehicles();
                return RedirectToAction("ChangeVehicle", dt);
            }
        }
            public ActionResult UpdateVehicle(string VehicleID)
            {
                Vehicle eobj = new Vehicle();
                DataTable dt = eobj.VehicleByNo(VehicleID);
                return View("UpdateVehicle", dt);
            }
            public ActionResult UpdateVehicles(FormCollection frm, string action)
            {
              Vehicle dmodel = new Vehicle();
                if (action == "Submit")
                {
                    string VehicleID = frm["txtVehicleID"];
                    int VehicleNumber = Convert.ToInt32(frm["txtVehicleNumber"]);
                    int TotalCapacity = Convert.ToInt32(frm["txtTotalCapacity"]);
                    int Capacity = Convert.ToInt32(frm["txtCapacity"]);
                    int AvailableSeats = Convert.ToInt32(frm["txtAvailableSeats"]);
                    string Operable = frm["txtOperable"];
                    
                    int res = dmodel.UpdateVehicles(VehicleID,VehicleNumber, TotalCapacity, Capacity, AvailableSeats, Operable);
                    return RedirectToAction("Vehicle1");
                }
                return RedirectToAction("");
            }


        
        public ActionResult InsertVehicle()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View("Login");
        }
        public ActionResult Validate(FormCollection frm, string action)
        {
            Login obj = new Login();
            DataTable dt = obj.GetLogins();
            string UserName = frm["txtUserName"];
            string Password = frm["txtPassword"];
            if (action == "Submit")
            {
                for (int i = 0; i <= dt.Rows.Count; i++)
                {
                    if (UserName == dt.Rows[i]["UserName"].ToString() && Password == dt.Rows[i]["Password"].ToString())
                        return View("HomePage");
                }
            }
            else { return View("Login"); }
            return View("Login");

        }

        public ActionResult Logout()
        {

            return View("Login");
        }
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult Route()
        {
            return View();
        }

        public ActionResult routeinsert(FormCollection frm, string action)
        {
            Route robj = new Route();
            if (action == "Submit")
            {
                int RootNumber = Convert.ToInt32(frm["txtRootNumber"]);
                string VehicleNumber = frm["txtVehicleNumber"];
                String Stop1 = frm["txtStop1"];
                String Stop2 = frm["txtStop2"];
                String Stop3 = frm["txtStop3"];
                int instatus = robj.routeinsert(RootNumber, VehicleNumber, Stop1, Stop2, Stop3);
                DataTable dt = robj.Routes();

                return View("Route1", dt);

            }
            else
            {
                DataTable dt = robj.Routes();
                return RedirectToAction("AllocateVehicle", dt);
            }

        }
       public ActionResult Details()
        {
            AllocateVehicle aobj = new AllocateVehicle();
            DataTable dt = aobj.AllDetails();
            return View("Details", dt);
        }
        
        public ActionResult AllocateVehicle()
        {
            return View();
        }
        public ActionResult allocateinsertvehicle(FormCollection frm, string action)
        {
            AllocateVehicle aobj = new AllocateVehicle();
            if (action == "Submit")
            {
                string VehicleID = frm["txtVehicleID"];
                string VehicleNumber = frm["txtVehicleNumber"];
                string VehicleName = frm["txtVehicleName"];

                int instatus = aobj.allocateinsertvehicle(VehicleID,VehicleNumber, VehicleName);
                DataTable dt = aobj.AllocateVehicles();

                return View("AllocateVehicle1", dt);

            }
            else
            {
                DataTable dt = aobj.AllocateVehicles();
                return RedirectToAction("", dt);
            }


        }
        public ActionResult ChangeVehicle()
        {
            
            return View();

        }
        [HttpPost]
        public ActionResult vehiclestatus(FormCollection frm, string action)
        {
            Vehicle cobj = new Vehicle();
            DataTable dt = cobj.status();
            //string Status = frm["txtStatus"];
            if (action == "Submit")
            {
                string dropdown = frm["txtdropdown"];

                if (dropdown == "Active")

                    return RedirectToAction("Route");
                
             
            }
           
            return View("Vehicle");


         



        }
       
        public ActionResult Home()
        {
            Employee obj = new Employee();
            DataTable dt = obj.Employees();
            return View("Home",dt);
        }
        public ActionResult Vehicle1()
        {
            Vehicle obj = new Vehicle();
            DataTable dt = obj.Vehicles();
            return View("Vehicle1", dt);
        }
       

    }
}

   

