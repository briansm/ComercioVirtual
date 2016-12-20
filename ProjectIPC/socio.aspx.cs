using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
public partial class socio : System.Web.UI.Page
{
    Conexion con = new Conexion();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conex = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
        conex.Open();

        SqlDataAdapter datap = new SqlDataAdapter("SELECT nombre,precio FROM Productos where Idproducto=2", conex);
        DataTable t = new DataTable();
        datap.Fill(t);
        this.GridView1.DataSource = t;
        this.GridView1.DataBind();

        SqlDataAdapter datap2 = new SqlDataAdapter("SELECT nombre,precio FROM Productos where Idproducto=3", conex);
        DataTable t2 = new DataTable();
        datap2.Fill(t2);
        this.GridView2.DataSource = t2;
        this.GridView2.DataBind();

        SqlDataAdapter datap3 = new SqlDataAdapter("SELECT nombre,precio FROM Productos where Idproducto=4", conex);
        DataTable t3 = new DataTable();
        datap3.Fill(t3);
        this.GridView3.DataSource = t3;
        this.GridView3.DataBind();


        SqlDataAdapter datap4 = new SqlDataAdapter("SELECT nombre,precio FROM Productos where Idproducto=5", conex);
        DataTable t4 = new DataTable();
        datap4.Fill(t4);
        this.GridView4.DataSource = t4;
        this.GridView4.DataBind();
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        MessageBox.Show(con.registrarcarrito(1, 2, Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox1.Text)*25));
        TextBox1.Text = "";
        

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pago.aspx");
    }
}