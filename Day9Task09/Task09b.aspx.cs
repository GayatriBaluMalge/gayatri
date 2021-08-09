using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Task09b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = ListBox1.SelectedValue.ToString();
            {
                if (name == "Gold")
                {
                  Response.Write (" Gold price is :1 gm=4000");
                    
                }
                else if (name == "Silver")
                {
                    Response.Write(" silver price  is :1 gm=2000");
                }
            }

        }
    }
}


        
    
