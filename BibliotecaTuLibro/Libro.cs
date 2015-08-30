using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaTuLibro
{
    public class Libro : Producto
    {
        #region Campos de Objeto

        private string _edicionLibro;
        private string _generoLibro;       

        #endregion

        #region Propiedades        

        /// <summary>
        /// Obtiene o establece la Edicion del Libro.
        /// </summary>
        public string EdicionLibro
        {
            get { return _edicionLibro; }
            set { _edicionLibro = value; }
        }
        /// <summary>
        /// Obtiene o estableceel Genero del Libro.
        /// </summary>
        public string GeneroLibro
        {
            get { return _generoLibro; }
            set { _generoLibro = value; }
        }

        #endregion
        
        #region Constructores
        /// <summary>
        /// Constructor vacio que inicilaiza los valores de Libro con valores 
        /// Preestablecidos.
        /// </summary>
        public Libro()
            :base()
        {
            Init();
        }
        /// <summary>
        /// Constructor con parametros que establece los valores de Libro
        /// de acuerdo a los parametros recibidos.
        /// </summary>
        /// <param name="nombreProducto">Obtiene o establece el nombre del Libro.</param>
        /// <param name="fechaPublicacion">Obtiene o establece la Fecha de publicacion del Libro.</param>
        /// <param name="isbn">Obtiene o establece el ISBN del Libro.</param>
        /// <param name="nombreAutor">Obtiene o establece el nombre del Autor del Libro.</param>
        /// <param name="editorial">Obtiene o establece la editorial del Libro.</param>
        /// <param name="valor">Obtiene o establece el valor del Libro.</param>
        /// <param name="descripcion">Obtiene o establece el descripcion del Libro.</param>
        /// <param name="edicionLibro">Obtiene o establece la edicion del Libro.</param>
        /// <param name="generoLibro">Obtiene o establece el genero del Libro.</param>
        public Libro(string nombreProducto,string fechaPublicacion,string isbn,
            string nombreAutor,string editorial,double valor,string descripcion,string edicionLibro, string generoLibro)
            : base(nombreProducto,fechaPublicacion,isbn,nombreAutor,editorial,valor,descripcion)

        {
            this._edicionLibro = edicionLibro;
            this._generoLibro = generoLibro;            
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo Privado que Inicializa los valores por defecto.
        /// </summary>
        private void Init()
        {
            _edicionLibro = string.Empty;
            _generoLibro = string.Empty;
        }
        /// <summary>
        /// Metodo que muestra la informacion del Libro.
        /// </summary>
        /// <returns>cadena de caracteres con los datos del Libro.</returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Nombre del Libro : {0}", _nombreProducto));
            sb.AppendLine(string.Format("Fecha de Publicacion : {0}", _fechaPublicacion));
            sb.AppendLine(string.Format("ISBN : {0}", _isbn));
            sb.AppendLine(string.Format("Nombre del Autor : {0}", _nombreAutor));
            sb.AppendLine(string.Format("Editorial : {0}", _editorial));
            sb.AppendLine(string.Format("Valor : {0}", _valor));
            sb.AppendLine(string.Format("Descripcion : {0}",_descripcion));
            sb.AppendLine(string.Format("Edicion del Libro :{0}", _edicionLibro));
            sb.AppendLine(string.Format("Genero del Libro :{0}", _generoLibro));

            return sb.ToString();
        }
        #endregion
    }
}

        