﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using BibliotecaTuLibro;

namespace TuLibroWeb
{
    public partial class VistaLibro : System.Web.UI.Page
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
            InicializarPagina();
        }

        private void InicializarPagina()
        {
            if (Request.Params["isbn"] != null)
            {
                Libro auxiliar = Stock.BuscarPorIsbn(Request.Params["isbn"], _libros);
                thumbnailVistaLibro.Src = "recursos/imagenes/book-thumbnails/" + auxiliar.NombreImagen;
                infoVistaLibro.InnerHtml = auxiliar.MostrarDatos();
                descVistaLibro.InnerText = auxiliar.Descripcion;
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

        protected void btnAgregarLibro_Click(object sender, ImageClickEventArgs e)
        {
            if (Request.Params["isbn"] != null)
            {
                Libro libro = Stock.BuscarPorIsbn(Request.Params["isbn"], _libros);
                _carrito.Productos.Add(libro);
                Session["carrito"] = _carrito;
                Response.Redirect("CarritoDeCompras.aspx");
            }
        }
    }
}