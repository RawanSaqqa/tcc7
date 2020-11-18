using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RawanApp
{
    public partial class cook : System.Web.UI.Page
    {
        private HttpCookie cookie;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("test", TextBox1.Text);
            Response.Cookies.Add(cookie);
            Response.Redirect("cook2.aspx");
        }
    }
}