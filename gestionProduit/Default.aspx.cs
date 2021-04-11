using System;
using System.Web.UI;
using gestionProduit.Models;

namespace gestionProduit
{
    public partial class _Default : Page
    {
        ADO ado = new ADO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
                Label1.Text = "welcom " + Session["username"].ToString() + " kolchi diyalk";
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }

    }
}