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
    public partial class InicioDeSession : System.Web.UI.Page
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
            Session["usuarios"] = _usuarios;
            Session["stock"] = _stock;
            Session["libros"] = _libros;
            Session["carrito"] = _carrito;
            Response.Redirect("Registro.aspx");
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUser.Text;
            string contraseña = txtPass.Text;

            if (PuedeLoggearse(nombreUsuario, contraseña))
            {
                Session["UsuarioLoggeado"] = Buscar(nombreUsuario);
                Session["usuarios"] = _usuarios;
                Session["stock"] = _stock;
                Session["libros"] = _libros;
                Session["carrito"] = _carrito;
                Response.Redirect("Inicio.aspx");
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

        private bool PuedeLoggearse(string user, string pass)
        {
            foreach (Usuario usuario in _usuarios)
            {
                if (usuario.User == user && usuario.Password == pass)
                    return true;
            }
            return false;
        }

        private Usuario Buscar(string username)
        {
            foreach (Usuario user in _usuarios)
            {
                if (user.User == username)
                    return user;
            }
            return null;
        }
    }
}