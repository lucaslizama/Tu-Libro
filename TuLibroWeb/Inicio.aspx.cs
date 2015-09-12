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
    public partial class Inicio : System.Web.UI.Page
    {
        private List<Libro> _libros;
        private Stock _stock;
        private CarritoCompra _carrito;

        protected void Page_Load(object sender, EventArgs e)
        {
            InicializarUsuario();
            InicializarStock();
            InicializarCarrito();
            InicializarLibrosRecomendados();
        }

        private void InicializarLibrosRecomendados()
        {
            Libro rec1 = Stock.BuscarPorIsbn("9788478887590", _libros);
            Libro rec2 = Stock.BuscarPorIsbn("8478884955", _libros);
            Libro rec3 = Stock.BuscarPorIsbn("8478889922", _libros);
            Libro rec4 = Stock.BuscarPorIsbn("9788498384499", _libros);

            imgLibroRec1.Attributes["src"] = "recursos/imagenes/book-thumbnails/" + rec1.NombreImagen;
            infoLibroRec1.InnerHtml = rec1.MostrarDatos();
            desclibrorec1.InnerHtml = rec1.Descripcion.Substring(0, 170) + "...";

            imgLibroRec2.Attributes["src"] = "recursos/imagenes/book-thumbnails/" + rec2.NombreImagen;
            infoLibroRec2.InnerHtml = rec2.MostrarDatos();
            desclibrorec2.InnerHtml = rec2.Descripcion.Substring(0, 170) + "...";

            imgLibroRec3.Attributes["src"] = "recursos/imagenes/book-thumbnails/" + rec3.NombreImagen;
            infoLibroRec3.InnerHtml = rec3.MostrarDatos();
            desclibrorec3.InnerHtml = rec3.Descripcion.Substring(0, 170) + "...";

            imgLibroRec4.Attributes["src"] = "recursos/imagenes/book-thumbnails/" + rec4.NombreImagen;
            infoLibroRec4.InnerHtml = rec4.MostrarDatos();
            desclibrorec4.InnerHtml = rec4.Descripcion.Substring(0, 170) + "...";
        }

        private void InicializarUsuario()
        {
            if (Session["nombreUsuario"] != null)
            {

            }
            else
            {

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

    }
}