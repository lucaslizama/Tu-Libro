using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaTuLibro;

namespace BibliotecaTuLibro
{
    public class CarritoCompra
    {
        private List<Libro> _productos;

        public List<Libro> Productos
        {
            get { return _productos; }
            set { _productos = value; }
        }

        public CarritoCompra()
        {
            _productos = new List<Libro>();
        }

        public CarritoCompra(List<Libro> productos)
        {
            _productos = productos;
        }

        /// <summary>
        /// Metodo que devuelve una cadena fromateada con la 
        /// informacion del carrito de compras
        /// </summary>
        /// <returns>Cadena con la informacion del carro de compras</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            List<Libro> filtrados = FiltrarLibros();
            int i = 1;

            foreach (Libro l in filtrados)
            {
                sb.AppendLine(string.Format("{0}.- Nombre: {1}  Cantidad: {2}  Precio: ${3} <br />",
                              i, l.Nombre, Cantidad(l), l.Valor));
                i++;
            }

            return sb.ToString();

        }

        /// <summary>
        /// Metodo que devuelve la cantidad existente de un libro
        /// en el carro de compras
        /// </summary>
        /// <param name="libro">El libro</param>
        /// <returns>La cantidad del dicho libro en el carro de compras</returns>
        private int Cantidad(Libro libro)
        {
            int contador = 0;
            foreach (Libro l in _productos)
            {
                if (l.Nombre == libro.Nombre)
                    contador++;
            }
            return contador;
        }

        /// <summary>
        /// Metodo ayudador que devuelve una lsita de libros
        /// con solo 1 ocurrencia por libro.
        /// </summary>
        /// <returns>La lsita filtrada</returns>
        private List<Libro> FiltrarLibros()
        {
            List<Libro> libros = new List<Libro>();
            foreach (Libro l in _productos)
            {
                if (!Buscar(l, libros))
                    libros.Add(l);
            }
            return libros;
        }

        /// <summary>
        /// Metodo que confirma la existencia de un libro en una
        /// lista de libros
        /// </summary>
        /// <param name="libro">El libro a buscar</param>
        /// <param name="libros">La lista de libros donde buscar</param>
        /// <returns>Verdadero si el libro existe en la lista, falso en caso contrario</returns>
        private bool Buscar(Libro libro, List<Libro> libros)
        {
            foreach (Libro l in libros)
            {
                if (l.Nombre == libro.Nombre)
                    return true;
            }
            return false;
        }

    }
}
