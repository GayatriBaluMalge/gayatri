using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class program1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue=="Maharashtra")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("amravati");
                ListBox1.Items.Add("akola");
                ListBox1.Items.Add("nagpur");

            }
           else if (DropDownList1.SelectedValue == "UP")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("lucknow");
                ListBox1.Items.Add("agra");
                ListBox1.Items.Add("noida");

            }
           else if (DropDownList1.SelectedValue == "tamil nadu")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("chennai");
                ListBox1.Items.Add("ambattur");
                ListBox1.Items.Add("avadi");

            }
           else if (DropDownList1.SelectedValue == "punjab")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("amritsar");
                ListBox1.Items.Add("jalandhar");
                ListBox1.Items.Add("ludhiana");

            }
           else if (DropDownList1.SelectedValue == "MP")
            {
                ListBox1.Items.Clear();
                ListBox1.Items.Add("bhopal");
                ListBox1.Items.Add("indore");
                ListBox1.Items.Add("nagpur");

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {


        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}