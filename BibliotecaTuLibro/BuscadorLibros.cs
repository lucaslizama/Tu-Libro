using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaTuLibro
{
    public class BuscadorLibros
    {
        public static List<Libro> BuscarPorIsbn(string isbn, List<Libro> libros) 
        {
            List<Libro> librosEncontrados = new List<Libro>();

            var resultados = from n in libros
                             where n.Isbn.Equals(isbn)
                             select n;

            foreach (Libro l in resultados)
            {
                librosEncontrados.Add(l);
            }

            return librosEncontrados;
        }

        public static List<Libro> BuscarPorTitulo(string titulo, List<Libro> libros)
        {
            List<Libro> librosEncontrados = new List<Libro>();

            var resultados = from n in libros
                             where n.Nombre.Equals(titulo)
                             select n;

            foreach (Libro l in resultados)
            {
                librosEncontrados.Add(l);
            }

            return librosEncontrados;
        }

        public static List<Libro> BuscarPorAutor(string autor, List<Libro> libros)
        {
            List<Libro> librosEncontrados = new List<Libro>();

            var resultados = from n in libros
                             where n.Autor.Equals(autor)
                             select n;

            foreach (Libro l in resultados)
            {
                librosEncontrados.Add(l);
            }

            return librosEncontrados;
        }

        public static List<Libro> BuscarPorEditorial(string editorial, List<Libro> libros)
        {
            List<Libro> librosEncontrados = new List<Libro>();

            var resultados = from n in libros
                             where n.Editorial.Equals(editorial)
                             select n;

            foreach (Libro l in resultados)
            {
                librosEncontrados.Add(l);
            }

            return librosEncontrados;
        }

        public static List<Libro> BuscarPorPalabraClave(string palabraClave, List<Libro> libros)
        {
            List<Libro> librosEncontrados = new List<Libro>();

            var resultados = from n in libros
                             where existePalabraClave(n,palabraClave)
                             select n;

            foreach (Libro l in resultados)
            {
                librosEncontrados.Add(l);
            }

            return librosEncontrados;
        }

        private static bool existePalabraClave(Libro libro,string palabraClave)
        {
            if (libro.Nombre.ToLower().IndexOf(palabraClave.ToLower()) != -1)
                return true;
            if (libro.Descripcion.ToLower().IndexOf(palabraClave.ToLower()) != -1)
                return true;
            if (libro.Editorial.ToLower().IndexOf(palabraClave.ToLower()) != -1)
                return true;
            if (libro.Genero.ToLower().IndexOf(palabraClave.ToLower()) != -1)
                return true;
            if (libro.Isbn.ToLower().IndexOf(palabraClave.ToLower()) != -1)
                return true;
            if (libro.Autor.ToLower().IndexOf(palabraClave.ToLower()) != -1)
                return true;
            if (libro.Nombre.ToLower().IndexOf(palabraClave.ToLower()) != -1)
                return true;
            if (libro.Edicion.ToLower().IndexOf(palabraClave.ToLower()) != -1)
                return true;
            if (libro.FechaPublicacion.ToString().ToLower().IndexOf(palabraClave.ToLower()) != -1)
                return true;
            return false;
        }

        public static string GenerarVista(List<Libro> libros)
        {
            string vista = string.Empty;

            if(libros.Count == 0)
                return "<h2>No se encontraron libros</h2>";
            else
            {
                foreach (Libro l in libros)
                {
		            vista += CrearTemplateLibro(l) + "<br>";
                }
            }

            return vista;
        }

        private static string CrearTemplateLibro(Libro libro)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<div class='contenedorLibroEncontrado'>");
            sb.Append(string.Format("<a href='VistaLibro.aspx?isbn={0}'><img class='thumbnailLibroEncontrado' src='recursos/imagenes/book-thumbnails/{1}' alt='libro' /></a>",libro.Isbn,libro.NombreImagen));
            sb.Append(string.Format("<p class='infoLibroEncontrado'>{0}</p>",libro.MostrarDatos()));
            sb.Append(string.Format("<p class='descLibroEncontrado'>{0}</p>",libro.Descripcion.Substring(0,270)));
            sb.Append("</div>");
            return sb.ToString();
        }
    }
}