using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaTuLibro;

namespace TuLibroWeb
{
    public partial class CarritoDeCompras : System.Web.UI.Page
    {
        private List<Libro> _libros;
        private List<Usuario> _usuarios;
        private Stock _stock;
        private CarritoCompra _carrito;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["agregar"] != null)
            {
                var seleccionado = new Libro();
                foreach (var current in ((List<Libro>)Session["arregloLibros"]).Where(current => current.Isbn.ToString().Equals(Request.QueryString["agregar"])))
                {
                    seleccionado = current;
                }
                ((CarritoCompra)Session["objUsuario"]).Productos.Add(seleccionado);
                Response.Redirect("CarritoDeCompras.aspx");
            }
            else if (Request.QueryString["eliminar"] != null)
            {
                foreach (var current in ((CarritoCompra)Session["objUsuario"]).Productos.Where(current => current.Isbn.ToString().Equals(Request.QueryString["eliminar"])))
                {
                    ((CarritoCompra)Session["objUsuario"]).Productos.Remove(current);
                    Response.Redirect("CarroCompra.aspx");
                }
            }
            else
            {
                if (((CarritoCompra)Session["objUsuario"]).Productos.Count == 0)
                {   
                    var subtotal = ((CarritoCompra)Session["objUsuario"]).Productos.Sum(objeto => objeto.Valor);
                }
                listaCarro.DataSource = ((CarritoCompra)Session["objUsuario"]).Productos;
                listaCarro.DataBind();
            }
        }
    }
}