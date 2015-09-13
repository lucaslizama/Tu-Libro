using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaTuLibro;

namespace TuLibroWeb
{
    public partial class InicioDeSession : System.Web.UI.Page
    {
        private List<Libro> _libros;
        private List<Usuario> _usuarios;
        private Stock _stock;
        private CarritoCompra _carrito;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }
        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string userIngresada = txtUser.Text;
            string passIngresada = txtPass.Text;

            
        }

        
    }
}