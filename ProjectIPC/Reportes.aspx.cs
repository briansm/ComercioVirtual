using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Reportes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conex = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
        conex.Open();
        SqlDataAdapter datap = new SqlDataAdapter("SELECT * FROM despachos", conex);
        DataTable t = new DataTable();
        datap.Fill(t);
        this.GridView1.DataSource = t;
        this.GridView1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conex = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
        conex.Open();
        SqlDataAdapter datap = new SqlDataAdapter("SELECT * FROM solicitudes", conex);
        DataTable t = new DataTable();
        datap.Fill(t);
        this.GridView1.DataSource = t;
        this.GridView1.DataBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection conex = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
        conex.Open();
        SqlDataAdapter datap = new SqlDataAdapter("SELECT * FROM Productos", conex);
        DataTable t = new DataTable();
        datap.Fill(t);
        this.GridView1.DataSource = t;
        this.GridView1.DataBind();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlConnection conex = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
        conex.Open();
        SqlDataAdapter datap = new SqlDataAdapter("SELECT * FROM Categoria", conex);
        DataTable t = new DataTable();
        datap.Fill(t);
        this.GridView1.DataSource = t;
        this.GridView1.DataBind();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        SqlConnection conex = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
        conex.Open();
        SqlDataAdapter datap = new SqlDataAdapter("SELECT * FROM zona", conex);
        DataTable t = new DataTable();
        datap.Fill(t);
        this.GridView1.DataSource = t;
        this.GridView1.DataBind();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        SqlConnection conex = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
        conex.Open();
        SqlDataAdapter datap = new SqlDataAdapter("SELECT * FROM Usuario", conex);
        DataTable t = new DataTable();
        datap.Fill(t);
        this.GridView1.DataSource = t;
        this.GridView1.DataBind();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("Adm.aspx");
    }
}