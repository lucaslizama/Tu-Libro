using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaTuLibro
{
    public class Producto
    {
        #region Campos de Objeto

        protected string _nombreProducto;
        protected string _fechaPublicacion;
        protected string _isbn;
        protected string _nombreAutor;
        protected string _editorial;
        protected double _valor;
        protected string _descripcion;

        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece el Nombre del Producto.
        /// </summary>
        public string NombreProducto
        {
            get {return _nombreProducto ;}
            set { _nombreProducto = value; }
        }
        /// <summary>
        /// Obtiene o establece la Fecha de Elaboracion del Producto.
        /// </summary>
        public string FechaPublicacion
        {
            get { return _fechaPublicacion; }
            set { _fechaPublicacion = value; }
        }
        /// <summary>
        /// Obtiene o establece el ISBN del Producto.
        /// </summary>
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        /// <summary>
        /// Obtiene o establece el Nombre del Autor del Producto.
        /// </summary>
        public string NombreAutor
        {
            get { return _nombreAutor; }
            set { _nombreAutor = value; }
        }
        /// <summary>
        /// Obtiene o establece la Editorial del Autor del Producto.
        /// </summary>
        public string Editorial
        {
            get { return _editorial; }
            set { _editorial = value; }
        }
        /// <summary>
        /// Obtiene o establece el Valor o Precio del Producto.
        /// </summary>
        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        /// <summary>
        /// Obtiene o establece la Descripcion del Producto.
        /// </summary>
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor que Inicializa los valores de Producto
        /// con valores por defecto.
        /// </summary>
        public Producto()
        {
            Init();
        }
        /// <summary>
        /// Constructor con parametros que establece los valores de Producto
        /// de acuerdo a los parametros recibidos.
        /// </summary>
        /// <param name="nombreProducto"></param>
        /// <param name="fechaPublicacion"></param>
        /// <param name="isbn"></param>
        /// <param name="nombreAutor"></param>
        /// <param name="editorial"></param>
        /// <param name="valor"></param>
        /// <param name="descripcion"></param>
        public Producto(string nombreProducto,string fechaPublicacion,string isbn,
            string nombreAutor,string editorial,double valor,string descripcion)
        {
            this._nombreProducto = nombreProducto;
            this._fechaPublicacion = fechaPublicacion;
            this._isbn = isbn;
            this._nombreAutor = nombreAutor;
            this._editorial = editorial;
            this._valor = valor;
            this._descripcion = descripcion;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Metodo Privado que Inicializa los valores por defecto
        /// </summary>
        private void Init()
        {
            _nombreProducto = string.Empty;
            _fechaPublicacion = string.Empty;
            _isbn = string.Empty;
            _nombreAutor = string.Empty;
            _editorial = string.Empty;
            _descripcion = string.Empty;
            _valor = 0;
        }
        /// <summary>
        /// Metodo que muestra la informacion de Producto
        /// </summary>
        /// <returns>cadena de caracteres con los datos de Producto</returns>
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Nombre del Producto: {0}", _nombreProducto));
            sb.AppendLine(string.Format("Fecha de Publicacion: {0}", _fechaPublicacion));
            sb.AppendLine(string.Format("ISBN: {0}", _isbn));
            sb.AppendLine(string.Format("Nombre del Autor: {0}", _nombreAutor));
            sb.AppendLine(string.Format("Editorial : {0}", _editorial));
            sb.AppendLine(string.Format("Valor : {0}", _valor));
            sb.AppendLine(string.Format("Descripcion : {0}",_descripcion));

            return sb.ToString();
        }
        #endregion
    }
}
