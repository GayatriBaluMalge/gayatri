using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registrationwithmvc.Models;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Registrationwithmvc.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            Registration dmobj = new Registration();
            DataTable dt = dmobj.GetRecords();
            return View("Home",dt);
        }
        public ActionResult Insert()
        {
            return View("InsertRecord");
        }
        public ActionResult InsertRecords(FormCollection frm,string action)
        {

            Registration dmobj = new Registration();
            if (action == "Submit")
            {
                int rollno = Convert.ToInt32(frm["txtrollno"]);
                string fname = frm["txtfname"];
                string lname = frm["txtlname"];
                string city = frm["txtcity"];
                string email = frm["txtemail"];
                string password = frm["txtpassword"];
                string gender = frm["txtgender"];

                int instatus = dmobj.InsertRecords(rollno,fname,lname,city,email,password,gender);
                DataTable dt = dmobj.GetRecords();
                return View("Home", dt);
            }
            else
            {
                DataTable dp = dmobj.GetRecords();
                return RedirectToAction("Home", dp);
            }
        }

        public ActionResult Edit(int RollNo)
        {
            Registration dmobj = new Registration();
            DataTable dt = dmobj.RecordsByNo(RollNo);
            return View("Edit", dt);
        }
        public ActionResult UpdateRecords(FormCollection frm, string action)
        {
            Registration dmodel = new Registration();
            if (action == "Submit")
            {
                int rollno = Convert.ToInt32(frm["txtrollno"]);
                string fname = frm["txtfname"];
                string lname = frm["txtlname"];
              
                string city = frm["txtcity"];
                string email = frm["txtemail"];
                string password = frm["txtpassword"];
                string gender = frm["txtgender"];
                int res = dmodel.UpdateRecords(rollno,fname,lname,city,email,password,gender);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
    }
