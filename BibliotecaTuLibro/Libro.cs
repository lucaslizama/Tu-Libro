using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace BibliotecaTuLibro
{
    public class Libro : Producto
    {
        #region Campos de Objeto

        private string _edicion;
        private string _genero;
        private string _isbn;
        private string _autor;
        private string _editorial;
        private DateTime _fechaPublicacion;
        private int _paginas;
        private string _nombreImagen;

        

        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece el nombre del archivo
        /// que contiene la imagen de este libro.
        /// </summary>
        public string NombreImagen
        {
            get { return _nombreImagen; }
            set { _nombreImagen = value; }
        }

        /// <summary>
        /// Obtiene o establece el numero de paginas del libro.
        /// </summary>
        public int Paginas
        {
            get { return _paginas; }
            set { _paginas = value; }
        }

        /// <summary>
        /// Obtiene o establece la Edicion del Libro.
        /// </summary>
        public string Edicion
        {
            get { return _edicion; }
            set { _edicion = value; }
        }
        /// <summary>
        /// Obtiene o establece el Genero del Libro.
        /// </summary>
        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }
        /// <summary>
        /// Obtiene o establece la Isbn del Libro.
        /// </summary>
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        /// <summary>
        /// Obtiene o establece el Autor del Libro.
        /// </summary>
        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }
        /// <summary>
        /// Obtiene o establece la Editorial del Libro.
        /// </summary>
        public string Editorial
        {
            get { return _editorial; }
            set { _editorial = value; }
        }
        /// <summary>
        /// Obtiene o establece la Fecha de Publicacion del Libro.
        /// </summary>
        public DateTime FechaPublicacion
        {
            get { return _fechaPublicacion; }
            set { _fechaPublicacion = value; }
        }

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor vacio que inicilaiza los valores de Libro con valores 
        /// Preestablecidos.
        /// </summary>
        public Libro()
            : base()
        {
            Init();
        }
        /// <summary>
        /// Constructor con parametros que establece los valores del Libro
        /// de acuerdo a los parametros recibidos.
        /// </summary>
        /// <param name="nombre">Establece el nombre del Libro</param>
        /// <param name="valor">Establece el valor del Libro</param>
        /// <param name="descripcion">Establece la descripcion del Libro</param>
        /// <param name="edicion">Establece la edicion del Libro</param>
        /// <param name="genero">Establece el genero del Libro</param>
        /// <param name="isbn">Establece el isbn del Libro</param>
        /// <param name="autor">Establece el autor del Libro</param>
        /// <param name="editorial">Establece la editorial del Libro</param>
        /// <param name="fechaPublicacion">Establece la fecha de publicacion del Libro</param>
        public Libro(string nombre, double valor, string descripcion, string edicion, string genero, string isbn,
            string autor, string editorial, DateTime fechaPublicacion, int paginas, string nombreImagen)
            : base(nombre, valor, descripcion)
        {
            this._edicion = edicion;
            this._genero = genero;
            this._isbn = isbn;
            this._autor = autor;
            this._editorial = editorial;
            this._fechaPublicacion = fechaPublicacion;
            this._paginas = paginas;
            this._nombreImagen = nombreImagen;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo Privado que Inicializa los valores por defecto.
        /// </summary>
        private void Init()
        {
            _edicion = string.Empty;
            _genero = string.Empty;
            _autor = string.Empty;
            _editorial = string.Empty;
            _fechaPublicacion = new DateTime(1900, 1, 1);
            _isbn = string.Empty;
            _paginas = 1;
            _nombreImagen = string.Empty;
        }
        /// <summary>
        /// Metodo que muestra la informacion del Libro.
        /// </summary>
        /// <returns>cadena de caracteres con los datos del Libro.</returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("{0}<br />", _nombre));
            sb.AppendLine(string.Format("Publicado : {0}<br />", _fechaPublicacion.ToString("dd/MM/yyyy")));
            sb.AppendLine(string.Format("ISBN : {0}<br />", _isbn));
            sb.AppendLine(string.Format("Autor : {0}<br />", _autor));
            sb.AppendLine(string.Format("Editorial : {0}<br />", _edicion));
            sb.AppendLine(string.Format("Valor : {0} pesos<br />", _valor.ToString("C",CultureInfo.CreateSpecificCulture("es-CL"))));
            sb.AppendLine(string.Format("Genero : {0}", _genero));

            return sb.ToString();
        }
        #endregion
    }
}

