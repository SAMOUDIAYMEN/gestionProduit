using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using gestionProduit.Models;

namespace gestionProduit
{
    public partial class Basket : System.Web.UI.Page
    {
        //ADO ado = new ADO();

        //void insertIntoBasket()
        //{
        //    try
        //    {
        //        ado.connection.Open();
        //        ado.command.CommandText = 
        //            $"insert into basket " +
        //            $"values ({(int)Session["id"]} , {Request.QueryString["id"]} , 1)";
        //            //quantity khassni nbdlha f design ba3da
        //        ado.command.Connection = ado.connection;
        //        //execut
        //        ado.command.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //    }
        //    finally
        //    {
        //        ado.connection.Close();
        //    }
        //}
        //void selectData()
        //{
        //    try
        //    {
        //        ado.connection.Open();
        //        ado.command.CommandText =
        //            $"select productName, price, quantity";//bug
        //        ado.command.Connection = ado.connection;

        //        ado.adapter.SelectCommand = ado.command;
        //        ado.adapter.Fill(ado.set,"");


        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //    }
        //    finally
        //    {
        //        ado.connection.Close();
        //    }
        //}

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (Session["user"] != null)
        //    {
        //        Label1.Text = "welcom " + Session["username"].ToString() + " kolchi diyalk";

        //        insertIntoBasket();
        //        selectData();
        //    }
        //    else
        //    {
        //        Response.Redirect("login.aspx");
        //    }
        //}


    }
}