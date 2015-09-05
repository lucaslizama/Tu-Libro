﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaTuLibro;
using System.Xml;

namespace BibliotecaTuLibro
{
    public class Stock
    {
        #region Campos
        private List<Libro> _libros;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece el stock de libros
        /// </summary>
        public List<Libro> Libros
        {
            get { return _libros; }
            set { _libros = value; }
        }
        #endregion

        #region Constructores
        public Stock() { Init(); }
        public Stock(List<Libro> libros)
        {
            _libros = libros;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que ayudador que inicializa el stock de libros
        /// </summary>
        private void Init()
        {
            _libros = new List<Libro>();
        }

        /// <summary>
        /// Metodo que pobla el stock de libros
        /// leyendo los datos de un documento Xml
        /// </summary>
        /// <param name="doc">El documento Xml que contiene los datos de los libros</param>
        public void CargarStock(XmlDocument doc)
        {
            if (doc == null || doc.ChildNodes.Count == 0)
                return;
            else
            {
                foreach (XmlNode node in doc.ChildNodes)
                {
                    if (node.Name == "libro")
                    {
                        Libro libro = CrearLibro(node);
                        int stock = int.Parse(node.Attributes["stock"].Value);

                        for (int i = 0; i < stock; i++)
                        {
                            _libros.Add(libro);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Metodo que crea un libro en base a un
        /// nodo Xml pasado pro parametro.
        /// </summary>
        /// <param name="node">"El nodo Xml usado para obtener los datos" </param>
        /// <returns></returns>
        private Libro CrearLibro(XmlNode node)
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
            DateTime fechaPublicacion = new DateTime(int.Parse(fecha.Substring(6, 2)),
                                        int.Parse(fecha.Substring(3, 2)),
                                        int.Parse(fecha.Substring(0, 2)));
            Libro libro = new Libro(nombre, valor, descripcion, edicion, genero,
                                    isbn, autor, editorial, fechaPublicacion);
            return libro;
        }

        /// <summary>
        /// Metodo que devuelve una lista con una sola
        /// instancia de cada libro en el stock
        /// </summary>
        /// <returns>Lista con una instancia de cada libro en el stock</returns>
        public List<Libro> ListarLibros()
        {
            List<Libro> filtrado = new List<Libro>();
            foreach (Libro l in _libros)
            {
                if (!Buscar(l, filtrado))
                    filtrado.Add(l);
            }
            return filtrado;
        }

        /// <summary>
        /// Metodo que busca si un libro existe en una 
        /// lista de libros o no.
        /// </summary>
        /// <param name="libro">El libro</param>
        /// <param name="libros">La lista</param>
        /// <returns></returns>
        private bool Buscar(Libro libro, List<Libro> libros)
        {
            foreach (Libro l in libros)
            {
                if (l.Nombre == libro.Nombre)
                    return true;
            }
            return false;
        }
        #endregion
    }
}
