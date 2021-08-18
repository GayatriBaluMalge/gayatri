using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task18
{
    public partial class program6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           if(ListBox1.SelectedValue=="Soap")
            {
                ImageButton1.ImageUrl=("Soap.jpg");
                Literal1.Text = "40";

            }
           else if(ListBox1.SelectedValue == "Lipstick")
            {
                ImageButton1.ImageUrl = ("lipstick.jpg");
                Literal1.Text = "100";
            }
            else if (ListBox1.SelectedValue == "Shampoo")
            {
                ImageButton1.ImageUrl = ("shampoo.jpg");
                Literal1.Text = "80";
            }
            else
            {
                ImageButton1.ImageUrl = ("facewash.jpg");
                Literal1.Text = "50";
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int cost = Convert.ToInt32(Literal1.Text);
            int qtn = Convert.ToInt32(txt_qtn.Text);
            int total = cost * qtn;
            txt_quantity.Text = "total cost is" + total.ToString();
        }
    }
}