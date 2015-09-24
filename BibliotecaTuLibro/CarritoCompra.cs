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

            foreach (Libro l in filtrados)
            {
                sb.Append(string.Format("<li><label>Nombre: {0}</label>  <label class='infoCarrito'>Cantidad: {1}</label>  <label class='infoCarrito'>Precio: ${2}</label></li>",
                              l.Nombre, Stock.Cantidad(l,_productos), l.Valor));
            }
            sb.Append(string.Format("<label class='totalCarrito'>Total: ${0}</label>",totalCarrito()));

            return sb.ToString();

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

        private double totalCarrito()
        {
            double total = 0;
            foreach (Libro l in _productos)
            {
                total += l.Valor;
            }
            return total;
        }

        public bool puedeComprar()
        {
            foreach (Libro l in Stock.ListarLibros(_productos))
            {
                if(!Stock.hayStock(l,Stock.Cantidad(l,_productos)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
