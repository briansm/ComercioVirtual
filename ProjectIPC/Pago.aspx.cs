using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
public partial class Pago : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conex = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
        conex.Open();
        SqlDataAdapter datap = new SqlDataAdapter("SELECT Idproducto,cantidad,total FROM carrito", conex);
        DataTable t = new DataTable();
        datap.Fill(t);
        this.GridView1.DataSource = t;
        this.GridView1.DataBind();
    }
}