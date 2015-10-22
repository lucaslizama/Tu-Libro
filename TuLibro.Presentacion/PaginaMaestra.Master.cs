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
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        private List<Libro> _libros;
        private List<Usuario> _usuarios;
        private Stock _stock;
        private CarritoCompra _carrito;

        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioLoggeado();
            InicializarStock();
            InicializarCarrito();
            InicializarUsuarios();
        }

        protected void btnCarrito_Click(object sender, EventArgs e)
        {
            Session["usuarios"] = _usuarios;
            Session["stock"] = _stock;
            Session["libros"] = _libros;
            Session["carrito"] = _carrito;
            Response.Redirect("CarritoDeCompras.aspx");
        }

        protected void btnInicioSesion_Click(object sender, EventArgs e)
        {
            Session["usuarios"] = _usuarios;
            Session["stock"] = _stock;
            Session["libros"] = _libros;
            Session["carrito"] = _carrito;
            Response.Redirect("InicioDeSession.aspx");
        }

        private void UsuarioLoggeado()
        {
            if (Session["UsuarioLoggeado"] != null)
            {
                Usuario auxiliar = Session["UsuarioLoggeado"] as Usuario;
                btnCerrarSesion.Visible = true;
                btnInicioSesion.Visible = false;
                lblBienvenida.Visible = true;
                lblBienvenida.Text = "Bienvenido " + auxiliar.User;
            }
            else
            {
                btnCerrarSesion.Visible = false;
                btnInicioSesion.Visible = true;
                lblBienvenida.Visible = false;
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

        protected void btnSuCuenta_Click(object sender, EventArgs e)
        {
            if (Session["UsuarioLoggeado"] == null)
            {
                Session["usuarios"] = _usuarios;
                Session["stock"] = _stock;
                Session["libros"] = _libros;
                Session["carrito"] = _carrito;
                Response.Redirect("InicioDeSession.aspx");
            }
            else
            {
                Session["usuarios"] = _usuarios;
                Session["stock"] = _stock;
                Session["libros"] = _libros;
                Session["carrito"] = _carrito;
                Response.Redirect("Perfil.aspx");
            }
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["UsuarioLoggeado"] = null;
            Response.Redirect("Inicio.aspx");
        }
    }
}