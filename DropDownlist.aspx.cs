using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_DropDown
{
    public partial class DropDownlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                string[] str = new string[] { "Select", "IQOOZ3", "AppleIPhone", "OnePlus5", "OppoA74" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/images/" + str + ".jpg";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "IQOOZ3")
            {
                TextBox1.Text = "17990";
            }
            else if (DropDownList1.SelectedValue == "AppleIPhone")
            {
                TextBox1.Text = "30000";
            }
            else if (DropDownList1.SelectedValue == "OnePlus5")
            {
                TextBox1.Text = "10,990";
            }
            else if (DropDownList1.SelectedValue == "OppoA74")
            {
                TextBox1.Text = "18000";
            }
        }
    }
}