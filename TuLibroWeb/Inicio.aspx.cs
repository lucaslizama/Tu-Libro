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
        private List<Usuario> _usuarios;
        private Stock _stock;
        private CarritoCompra _carrito;


        protected void Page_Load(object sender, EventArgs e)
        {
            InicializarUsuarios();
            InicializarStock();
            InicializarCarrito();
            InicializarLibrosRecomendados();
        }

        private void InicializarLibrosRecomendados()
        {
            List<Libro> librosRecomendados = new List<Libro>();
            Libro auxLibro = new Libro();

            for (int i = 0; i < 4; i++)
            {
                do{
                    auxLibro = Stock.libroAleatorio(_libros);
                }while(Stock.ExisteLibro(auxLibro,librosRecomendados));
                librosRecomendados.Add(auxLibro);
            }

            Libro rec1 = librosRecomendados[0]; Libro rec2 = librosRecomendados[1];
            Libro rec3 = librosRecomendados[2]; Libro rec4 = librosRecomendados[3];

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

    }
}