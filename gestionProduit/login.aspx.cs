using System;
using gestionProduit.Models;
using System.Data;
using System.Data.SqlClient;

namespace gestionProduit
{
    public partial class login : System.Web.UI.Page
    {
        ADO ado = new ADO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user"] = null;
            TextBox1.Focus();
        }

        protected void login_click(object sender, EventArgs e)
        {
            try
            {
                ado.connection.Open();
                ado.command.CommandText = "select * from accounts";
                ado.command.Connection = ado.connection;
                ado.reader = ado.command.ExecuteReader();
                while (ado.reader.Read())
                {
                    if (ado.reader[1].ToString() == TextBox1.Text && ado.reader[2].ToString() == TextBox2.Text)
                    {   
                        Session["user"] = "ID : " + ado.reader[0].ToString() + " - " + "Username : " + ado.reader[1].ToString();
                        Session["userID"] = ado.reader[0].ToString();
                        Session["username"] = ado.reader[1].ToString();
                        Session["password"] = ado.reader[2].ToString();
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        notfound.Text = "we don't find your account ! you can sign up <a href=\"signup.aspx\">Here</a>";
                        notfound.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                ado.connection.Close();
            }
            
        }
    }
}