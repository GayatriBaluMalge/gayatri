using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Task09 : System.Web.UI.Page
    {
        public object ListBox1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Breakfast")
            {
                Response.Redirect("Breakfast.aspx");
            }
           else if (DropDownList1.SelectedValue == "Lunch")
            {
                Response.Redirect("Lunch.aspx");
            }
            else if (DropDownList1.SelectedValue == "Snacks")
            {
                Response.Redirect("Snacks.aspx");
            }


        }
    }
}