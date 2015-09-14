using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaTuLibro;

namespace TuLibroWeb
{
    public partial class MiPerfil : System.Web.UI.Page
    {
        private List<Libro> _libros;
        private List<Usuario> _usuarios;
        private Stock _stock;
        private CarritoCompra _carrito;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioLoggeado"] != null)
            {
                Usuario usuario = Session["UsuarioLoggeado"] as Usuario;

                lblNombre.Text = lblNombre.Text + usuario.Nombre;
                lblApellido.Text = lblApellido.Text + usuario.Apellido;
                lblCorreo.Text = lblCorreo.Text + usuario.Correo;
                lblUser.Text = lblUser.Text + usuario.User;
                txtNombre.Visible = false;
                txtApellido.Visible = false;
                txtCorreo.Visible = false;
                txtUsuario.Visible = false;
                txtFecha.Visible = false;
                txtPass.Visible = false;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            txtNombre.Visible = true;
            txtApellido.Visible = true;
            txtCorreo.Visible = true;
            txtUsuario.Visible = true;
            txtFecha.Visible = true;
            txtPass.Visible = true;

            DateTime fecha = DateTime.Parse(txtFecha.Text);

            Session["objUsuario"] = new Usuario(txtNombre.Text,txtApellido.Text,fecha,txtCorreo.Text,txtUsuario.Text,txtPass.Text);
            
            
        }
    }
}
//string nombre, string apellido, DateTime fechaNacimiento, string correo, string user, string password