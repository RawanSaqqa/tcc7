using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RawanApp
{
    public partial class sessio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string x = (string)Session["jo"].ToString();
            Response.Write(x);
        }
    }
}