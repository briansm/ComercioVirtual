using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
/// <summary>
/// Descripción breve de Conexion
/// </summary>
public class Conexion
{
    SqlCommand comd;
    SqlConnection conex;
    SqlDataReader dread;
    SqlDataAdapter dadapter;
 
	public Conexion()
	{
        try {
            conex = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
            conex.Open();
        
        }catch(Exception ex){

            MessageBox.Show("Error en conexion" + ex.ToString());
        }
        

	}


    public string registrarU(String nombre,String apellido,string direc,int telefono,int ncuenta,string usuario,string contra) {

        string ans = "Registro exitoso";
        try {
            comd = new SqlCommand("Insert into Usuario(Nombre,Apellido,Direccion,Telefono,Ncuenta,usuario,contraseña)values('"+nombre+"','"+apellido+"','"+direc+"',"+telefono+","+ncuenta+",'"+usuario+"','"+contra+"')",conex);
            comd.ExecuteNonQuery();

        
        
        
        }catch(Exception ex){
            ans = "No se pudo insertar" + ex.ToString();
        
        }

        return ans;
    }

    public string registrarestudiante(string nombre, string carnet, string edad) {

        string resp = "Registro exitoso";
        try {
            comd = new SqlCommand("Insert into Estudiante(Nombre,Carnet,Edad)values ('"+nombre+"',"+carnet+","+edad+")",conex);
            comd.ExecuteNonQuery();
        }catch(Exception ex){
            resp = "NO se pudo insertar" + ex.ToString();
        
        }
        
        return resp;
    
    }

    public string registrarcategoria(int ncateg,string nombrec) {
        string resp = "Registro exitoso";
    try {
            comd = new SqlCommand("Insert into Categoria(Ncategoria,nombrecategoria)values ("+ncateg+",'"+nombrec+"')",conex);
            comd.ExecuteNonQuery();
        }catch(Exception ex){
            resp = "NO se pudo insertar" + ex.ToString();
        
        }
        
        return resp;
    
    
    }

    public string registrarproductos(int idp, string npro, string tipopro, string desc,string ofert,string multi,double precio,int exist, int ncate)
    {
        string resp = "Registro exitoso";
        try
        {
            comd = new SqlCommand("Insert into Productos(Idproducto,nombre,tipoproducto,descripcion,ofertado,multimedia,precio,existencia,CategoriaProducto)values (" + idp + ",'" + npro + "','" + tipopro + "','" + desc + "','" + ofert + "','" + multi + "'," + precio + "," + exist + "," + ncate + ")", conex);
            comd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            resp = "NO se pudo insertar" + ex.ToString();

        }

        return resp;


    }

    public string registrarzonas(int nzona, string nombrez,int zonasup)
    {
        string resp = "Registro exitoso";
        try
        {
            comd = new SqlCommand("Insert into zona(Nzona,nombre,zonasuperior)values (" + nzona + ",'" + nombrez + "'," + zonasup + ")", conex);
            comd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            resp = "NO se pudo insertar" + ex.ToString();

        }

        return resp;


    }

    public string registrarzonasv(int nzona, int nzonav)
    {
        string resp = "Registro exitoso";
        try
        {
            comd = new SqlCommand("Insert into zonaV(Nzona,nombre,zonasuperior)values (" + nzona + "," + nzonav + ")", conex);
            comd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            resp = "NO se pudo insertar" + ex.ToString();

        }

        return resp;


    }

    public string registrarsolicitud(int idlinea, int npedido, int cantidad,int idpro)
    {
        string resp = "Registro exitoso";
        try
        {
            comd = new SqlCommand("Insert into solicitudes(idlinea,nopedido,cantidad,idproducto)values (" + idlinea + "," + npedido + "," + cantidad + "," + idpro  + ")", conex);
            comd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            resp = "NO se pudo insertar" + ex.ToString();

        }

        return resp;


    }

    public string registrardespacho(int idlinea, int npedido, int cantidad, int idpro,string estado)
    {
        string resp = "Registro exitoso";
        try
        {
            comd = new SqlCommand("Insert into despachos(idlinea,nopedido,cantidad,idproducto,estadoproducto)values (" + idlinea + "," + npedido + "," + cantidad + "," + idpro + ",'" + estado + "')", conex);
            comd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            resp = "NO se pudo insertar" + ex.ToString();

        }

        return resp;


    }

    public string registrarcarrito(int idusuario, int idproducto, int cantidad,int total)
    {
        string resp = "Registro exitoso";
        try
        {
            comd = new SqlCommand("Insert into carrito(idusuario,Idproducto,cantidad,total)values (" + idusuario + "," + idproducto + "," + cantidad + "," + total + ")", conex);
            comd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            resp = "NO se pudo insertar" + ex.ToString();

        }

        return resp;


    }

}