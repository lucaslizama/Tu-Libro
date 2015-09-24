using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
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
            InicializarCarrito();
            InicializarStock();
            InicializarUsuarios();
            InicializarDatosCarrito();

            if (Request.Params["compraExistosa"] != null)
            {
                errorLabel.InnerHtml = "Compra realizada con exito";
            }
        }

        private void InicializarDatosCarrito()
        {
            if (_carrito.Productos.Count == 0)
            {
                listaProductos.Visible = false;
                contenedorInfoCarro.InnerHtml = "<h3>Carro de compras vacío</h3>";
            }
            else
            {
                listaProductos.InnerHtml = _carrito.MostrarDatos();
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

        protected void btnVaciar_Click(object sender, EventArgs e)
        {
            _carrito.Productos.Clear();
            Session["carrito"] = _carrito;
            Response.Redirect("CarritoDeCompras.aspx");
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            if (_carrito.puedeComprar())
            {
                foreach (Libro l in _carrito.Productos)
                {
                    _stock.Libros.Remove(l);
                }
                _carrito.Productos.Clear();
                Session["stock"] = _stock;
                Session["carrito"] = _carrito;
                Response.Redirect("CarritoDeCompras.aspx?compraExistosa=true");
            }
            else
            {
                errorLabel.InnerHtml = "No hay stock de alguno de los productos, imposible realizar compra";
            }
            
        }
    }
}