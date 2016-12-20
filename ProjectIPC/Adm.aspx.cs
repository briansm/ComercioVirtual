using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
public partial class Adm : System.Web.UI.Page
{
    Conexion con = new Conexion();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void bvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("home.aspx");
    }

   




   
    protected void cargarA_Click(object sender, EventArgs e)
    {
        LeerXML lxml = new LeerXML();
        


    }
 

        
        
        
    
    protected void Button1_Click2(object sender, EventArgs e)
    {

        
            
           
            

        }
    protected void Button2_Click(object sender, EventArgs e)
    {
        LeerXML lcat = new LeerXML();

        if (FileUpload1.HasFile)
        {
            try
            {

                string fileName = FileUpload1.PostedFile.FileName;
                lcat.leercategorias(fileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show("NO se pudo" + ex.ToString());
            }


        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        LeerXML lpro = new LeerXML();
        if (FileUpload1.HasFile)
        {
            try
            {

                string fileName = FileUpload1.PostedFile.FileName;
                lpro.leerproductos(fileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show("NO se pudo" + ex.ToString());
            }


        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        LeerXML lzona = new LeerXML();
        if (FileUpload1.HasFile)
        {
            try
            {

                string fileName = FileUpload1.PostedFile.FileName;
                lzona.leerzonas(fileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show("NO se pudo" + ex.ToString());
            }


        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        LeerXML lsol = new LeerXML();
        
        if (FileUpload1.HasFile)
        {
            try
            {

                string fileName = FileUpload1.PostedFile.FileName;
                lsol.leersolicitudes(fileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show("NO se pudo" + ex.ToString());
            }


        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        LeerXML ldesp = new LeerXML();
        if (FileUpload1.HasFile)
        {
            try
            {

                string fileName = FileUpload1.PostedFile.FileName;
                ldesp.leerdespachos(fileName);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO se pudo" + ex.ToString());
            }


        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button7_Click(object sender, EventArgs e)
    {

        SqlConnection conex = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
        conex.Open();
        SqlDataAdapter datap = new SqlDataAdapter("SELECT * FROM despachos", conex);
        DataTable t = new DataTable();
        datap.Fill(t);
        this.GridView1.DataSource = t;
        this.GridView1.DataBind();
        
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("Reportes.aspx");
    }
}
