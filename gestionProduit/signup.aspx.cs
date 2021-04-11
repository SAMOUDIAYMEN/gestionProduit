using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using gestionProduit.Models;
using System.Web.UI.WebControls;

namespace gestionProduit
{
    public partial class signup : System.Web.UI.Page
    {
        ADO ado = new ADO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user"] = null;
            TextBox1.Focus();
        }

        protected bool finduser()
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
                        return true;
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
            return false;
        }

        protected void login_click(object sender, EventArgs e)
        {
            if (finduser() == false)
            {
                try
                {
                    ado.connection.Open();
                    ado.command.CommandText = $"insert into accounts values('{TextBox1.Text}','{TextBox2.Text}')";
                    ado.command.Connection = ado.connection;
                    ado.command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
                finally
                {
                    ado.connection.Close();
                    Response.Redirect("login.aspx");
                }
            }
            else
            {
                notfound.Text = "account alredy exist!";
                notfound.Visible = true;
            }
        }
    }
}