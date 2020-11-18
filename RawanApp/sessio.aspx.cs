using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RawanApp
{
    public partial class sessio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["jo"] = TextBox1.Text;
            Response.Redirect("sessio2.aspx");
            Label1.Text="the age is : "+Session["jo"];
        }
    }
}