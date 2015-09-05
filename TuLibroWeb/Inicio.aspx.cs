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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["stock"] == null)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Server.MapPath("~/libros.xml"));
                _stock = new Stock();
                _stock.CargarStock(doc);
                Session["stock"] = _stock;
            }
            else
            {
                _stock = Session["stock"] as Stock;
            }

            if (Session["nombreUsuario"] != null)
            {
                
            }
            else
            {
                
            }
            desclibrorec1.InnerHtml = _stock.Libros.Count.ToString();
        }
    }
}