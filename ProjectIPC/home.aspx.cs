using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("registro.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (droprol.SelectedItem.Text == "Administrador")
        {

            Response.Redirect("Adm.aspx");

        }
        else if (droprol.SelectedItem.Text == "Socio")
        {

            Response.Redirect("socio.aspx");

        }else if(droprol.SelectedItem.Text=="Proveedor"){
            Response.Redirect("Proveedor.aspx");
        
        }
        else {

            Response.Redirect("home.aspx");
        
        
        }

      


    }
}