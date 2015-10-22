using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaTuLibro
{
    public abstract class Producto
    {
        #region Campos de Objeto

        protected string _nombre;
        protected double _valor;
        protected string _descripcion;

        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece el Nombre del Producto.
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
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
        /// <param name="nombre">Establece el nombre del Producto</param>
        /// <param name="valor">Establece el valor del Producto</param>
        /// <param name="descripcion">Establece la descripcion del Producto</param>
        public Producto(string nombre, double valor, string descripcion)
        {
            this._nombre = nombre;
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
            _nombre = string.Empty;
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
            sb.AppendLine(string.Format("Nombre del Producto: {0}", _nombre));
            sb.AppendLine(string.Format("Valor : {0}", _valor));
            sb.AppendLine(string.Format("Descripcion : {0}", _descripcion));

            return sb.ToString();
        }
        #endregion
    }
}