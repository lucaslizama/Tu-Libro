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
        private List<Libro> libros; 

        protected void Page_Load(object sender, EventArgs e)
        {
            initLibros();

            if (Session["nombreUsuario"] != null)
            {
                
            }
            else
            {
                
            }
        }

        private void initLibros()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("~/libros.xml"));

            string text = string.Empty;

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                if (node.Name.Equals("libro"))
                {
                    String nombre = node.ChildNodes[0].InnerText;
                    String autor = node.ChildNodes[1].InnerText;
                    String isbn = node.ChildNodes[2].InnerText;
                    String genero = node.ChildNodes[3].InnerText;
                    String editorial = node.ChildNodes[4].InnerText;
                    String edicion = node.ChildNodes[6].InnerText;
                    int valor = int.Parse(node.ChildNodes[7].InnerText);
                    String descripcion = node.ChildNodes[8].InnerText;
                    String fecha = node.ChildNodes[5].InnerText;
                    DateTime fechaPublicacion = new DateTime(int.Parse(fecha.Substring(6,10)),
                                                int.Parse(fecha.Substring(3,5)),
                                                int.Parse(fecha.Substring(0,2)));
                    Libro libro = new Libro(nombre, valor, descripcion, edicion, genero, 
                                            isbn, autor, editorial, fechaPublicacion);
                    libros.Add(libro);
                }   
            }
        }
    }
}