using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
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
            InicializarUsuarios();
            InicializarStock();
            InicializarCarrito();
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

            if(!existeUsuario(usuario))
            {
                _usuarios.Add(usuario);
                string url = string.Format("RegistroCompletado.aspx?nombre={0}&apellido={1}&user={2}", nombre, apellido, user);
                Session["UsuarioLoggeado"] = usuario;
                Session["usuarios"] = _usuarios;
                Session["stock"] = _stock;
                Session["libros"] = _libros;
                Session["carrito"] = _carrito;
                Server.Transfer(url);
            }
        }

        private void InicializarUsuarios()
        {
            if (Session["usuarios"] == null)
            {
                _usuarios = new List<Usuario>();
                Session["usuarios"] = _usuarios;
            }
            else
            {
                _usuarios = Session["usuarios"] as List<Usuario>;
            }
        }

        private void InicializarStock()
        {
            if (Session["stock"] == null)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Server.MapPath("~/libros.xml"));
                _stock = new Stock();
                _stock.CargarStock(doc);
                _libros = Stock.ListarLibros(_stock.Libros);
                Session["stock"] = _stock;
                Session["libros"] = _libros;
            }
            else
            {
                _stock = Session["stock"] as Stock;
                _libros = Session["libros"] as List<Libro>;
            }
        }

        private void InicializarCarrito()
        {
            if (Session["carrito"] == null)
            {
                _carrito = new CarritoCompra();
                Session["carrito"] = _carrito;
            }
            else
            {
                _carrito = Session["carrito"] as CarritoCompra;
            }
        }

        protected bool existeUsuario(Usuario usuario)
        {
            foreach (Usuario user in _usuarios)
            {
                if (usuario.User == user.User)
                    return true;
            }
            return false;
        }
    }
}