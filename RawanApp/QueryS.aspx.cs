using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RawanApp
{
    public partial class QueryS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string n = Request.QueryString.Get("name");
            Response.Write("hello "+n);
        }
    }
}