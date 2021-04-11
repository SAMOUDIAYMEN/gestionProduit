using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gestionProduit
{
    public partial class products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Label1.Text = "All Product in this category ...";
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}