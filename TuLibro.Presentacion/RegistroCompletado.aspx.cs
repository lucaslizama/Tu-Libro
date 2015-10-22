using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaTuLibro;

namespace TuLibroWeb
{
    public partial class RegistroCompletado : System.Web.UI.Page
    {
        private List<Libro> _libros;
        private List<Usuario> _usuarios;
        private Stock _stock;
        private CarritoCompra _carrito;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["nombre"] != null)
            {
                string nombre = Request.Params["nombre"];
                string apellido = Request.Params["apellido"];
                string user = Request.Params["user"];
                
                string completado = "Estimado(a) " +nombre+ " " + apellido + " su usuario " + user + " ha ingresado con exito";
                lblRegistroCompletado.Text = completado;
            }
        }
    }
}