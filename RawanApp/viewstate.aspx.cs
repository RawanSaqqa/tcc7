using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RawanApp
{
    public partial class viewstate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           ViewState["name"]=TextBox1.Text;
            TextBox1.Text = " ";
            ViewState["lname"] = TextBox2.Text;
            TextBox2.Text = " ";
            


            //  ViewState["age"] = DropDownList1.Text;
            //  DropDownList1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["name"].ToString();
            TextBox2.Text = ViewState["lname"].ToString();
            //  DropDownList1.Text = ViewState["age"].ToString();
        }
    }
}