using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Xml;
using System.Windows.Forms;

/// <summary>
/// Descripción breve de LeerXML
/// </summary>
public class LeerXML
{
    Conexion con = new Conexion();
    public LeerXML(){
        
        
        
	
        }
    


    public void leercategorias(string ruta){
        

        XmlDocument xdoc = new XmlDocument();

        xdoc.Load("C:\\SAC\\CatalogoProductos\\" + ruta);

        XmlNodeList nodos = xdoc.GetElementsByTagName("CATEGORIAS_PRODUCTO");

        XmlNodeList lista = ((XmlElement)nodos[0]).GetElementsByTagName("CATEGORIA");

        foreach (XmlElement nodo in lista)
        {

            int i = 0;

            XmlNodeList ncategoria = nodo.GetElementsByTagName("no_categoria");

            XmlNodeList nombrec = nodo.GetElementsByTagName("nombre_categoria");



            MessageBox.Show(con.registrarcategoria(Convert.ToInt32(ncategoria[i].InnerText),nombrec[i].InnerText));

            i++;
        }



        
           }


    public void leerproductos(string ruta)
    {
        

        XmlDocument xdoc = new XmlDocument();

        xdoc.Load("C:\\SAC\\CatalogoProductos\\" + ruta);

        XmlNodeList nodos = xdoc.GetElementsByTagName("PRODUCTOS");

        XmlNodeList lista = ((XmlElement)nodos[0]).GetElementsByTagName("PRODUCTO");

        foreach (XmlElement nodo in lista)
        {

            int i = 0;

            XmlNodeList idpro = nodo.GetElementsByTagName("id_producto");
            XmlNodeList npro = nodo.GetElementsByTagName("nombre_producto");
            XmlNodeList tipopro = nodo.GetElementsByTagName("tipo_producto");
            XmlNodeList descr = nodo.GetElementsByTagName("descripcion");
            XmlNodeList ofertado = nodo.GetElementsByTagName("ofertado");
            XmlNodeList multi = nodo.GetElementsByTagName("multimedia");
            XmlNodeList precio = nodo.GetElementsByTagName("precio");
            XmlNodeList existencia = nodo.GetElementsByTagName("existencia");
            XmlNodeList ncatego = nodo.GetElementsByTagName("CATEGORIA_PRODUCTO_no_categoria");


            MessageBox.Show(con.registrarproductos(Convert.ToInt32(idpro[i].InnerText), npro[i].InnerText, tipopro[i].InnerText, descr[i].InnerText, ofertado[i].InnerText, multi[i].InnerText, Convert.ToDouble(precio[i].InnerText), Convert.ToInt32(existencia[i].InnerText), Convert.ToInt32(ncatego[i].InnerText)));

            i++;
        }



       
    }



    public void leerzonas(string ruta)
    {
        

        XmlDocument xdoc = new XmlDocument();

        xdoc.Load("C:\\SAC\\"+ruta);

        XmlNodeList nodos = xdoc.GetElementsByTagName("ZONAS");

        XmlNodeList lista = ((XmlElement)nodos[0]).GetElementsByTagName("ZONA");

        foreach (XmlElement nodo in lista)
        {

            int i = 0;

            XmlNodeList nzona = nodo.GetElementsByTagName("no_zona");
            XmlNodeList nombrez = nodo.GetElementsByTagName("nombre_zona");
            XmlNodeList nzonasup = nodo.GetElementsByTagName("ZONA_no_zona_superior");



            MessageBox.Show(con.registrarzonas(Convert.ToInt32(nzona[i].InnerText), nombrez[i].InnerText,Convert.ToInt32(nzonasup[i].InnerText)));

            i++;
        }


               XmlNodeList lista2 = ((XmlElement)nodos[0]).GetElementsByTagName("ZONA_VECINA");

        foreach (XmlElement nodo in lista2)
        {

            int i = 0;

            XmlNodeList nzona = nodo.GetElementsByTagName("ZONA_no_zona");
            XmlNodeList zonav = nodo.GetElementsByTagName("ZONA_zonavecina");




            MessageBox.Show(con.registrarzonasv(Convert.ToInt32(nzona[i].InnerText), Convert.ToInt32(zonav[i].InnerText)));

            i++;
        }



        
    }

    public void leerdespachos(string path)
    {
        

        XmlDocument xdoc = new XmlDocument();

        xdoc.Load("C:\\SAC\\Despachos\\"+path);

        XmlNodeList nodos = xdoc.GetElementsByTagName("DETALLE_SOLICITUDES");

        XmlNodeList lista = ((XmlElement)nodos[0]).GetElementsByTagName("DETALLE_SOLICITUD");

        foreach (XmlElement nodo in lista)
        {

            int i = 0;

            XmlNodeList idlinea = nodo.GetElementsByTagName("id_linea_producto");
            XmlNodeList nopedido = nodo.GetElementsByTagName("PEDIDO_no_pedido");
            XmlNodeList cantidad = nodo.GetElementsByTagName("cantidad");
            XmlNodeList idproduco = nodo.GetElementsByTagName("PRODUCTO_id_producto");
            XmlNodeList estad = nodo.GetElementsByTagName("SOLICITUD_estado_producto");


            MessageBox.Show(con.registrardespacho(Convert.ToInt32(idlinea[i].InnerText), Convert.ToInt32(nopedido[i].InnerText), Convert.ToInt32(cantidad[i].InnerText), Convert.ToInt32(idproduco[i].InnerText), estad[i].InnerText));

            i++;
        }



        
    }


    public void leersolicitudes(string ruta)
    {
        

        XmlDocument xdoc = new XmlDocument();

        xdoc.Load("C:\\SAC\\Solicitudes\\"+ruta);

        XmlNodeList nodos = xdoc.GetElementsByTagName("DETALLE_SOLICITUDES");

        XmlNodeList lista = ((XmlElement)nodos[0]).GetElementsByTagName("DETALLE_SOLICITUD");

        foreach (XmlElement nodo in lista)
        {

            int i = 0;

            XmlNodeList idlinea = nodo.GetElementsByTagName("id_linea_producto");
            XmlNodeList nopedido = nodo.GetElementsByTagName("PEDIDO_no_pedido");
            XmlNodeList cantidad = nodo.GetElementsByTagName("cantidad");
            XmlNodeList idproduco = nodo.GetElementsByTagName("PRODUCTO_id_producto");
            


            MessageBox.Show(con.registrarsolicitud(Convert.ToInt32(idlinea[i].InnerText), Convert.ToInt32(nopedido[i].InnerText), Convert.ToInt32(cantidad[i].InnerText), Convert.ToInt32(idproduco[i].InnerText)));

            i++;
        }



        
    }



}