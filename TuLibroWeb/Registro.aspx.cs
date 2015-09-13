using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaTuLibro;

namespace TuLibroWeb
{
    public partial class Registro2 : System.Web.UI.Page
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
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string user = txtUser.Text;
            int edad = int.Parse(txtEdad.Text);
            string correo = txtCorreoUsuario.Text;
            string pass = txtPassword.Text;

            Usuario usuario = new Usuario(nombre, apellido, DateTime.Now, correo, user, pass);

            string url = string.Format("RegistroCompletado.aspx?nombre={0}&apellido={1}&user={2}", nombre, apellido, user);

            Session["UsuarioLoggeado"] = usuario;
            Server.Transfer(url);
        }
        
    }
}