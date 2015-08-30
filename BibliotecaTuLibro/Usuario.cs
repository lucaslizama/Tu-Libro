using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaTuLibro
{
    public class Usuario
    {
        #region Campos de Objeto
        private string nombreUsuario;
        private string apellidoUsuario;
        private int edadUsuario;
        private string correoUsuario;
        private string correoUsuarioDos;
        private string userUsuario;
        private string passwordUsuario;
        private string passUsuarioDos;
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece el Nombre del Usuario.
        /// </summary>
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        /// <summary>
        /// Obtiene o establece el Apellido del Usuario.
        /// </summary>
        public string ApellidoUsuario
        {
            get { return apellidoUsuario; }
            set { apellidoUsuario = value; }
        }
        /// <summary>
        /// Obtiene o establece la Edad del Usuario.
        /// </summary>
        public int EdadUsuario
        {
            get { return edadUsuario; }
            set { edadUsuario = value; }
        }

        /// <summary>
        /// Obtiene o establece el Correo del Usuario.
        /// </summary>
        public string CorreoUsuario
        {
            get { return correoUsuario; }
            set { correoUsuario = value; }
        }

        /// <summary>
        /// Obtiene o establece el Correo del Usuario.
        /// </summary>
        public string CorreoUsuarioDos
        {
            get { return correoUsuarioDos; }
            set { correoUsuarioDos = value; }
        }

        /// <summary>
        /// Obtiene o establece el Password del Usuario.
        /// </summary>
        public string PasswordUsuario
        {
            get { return passwordUsuario; }
            set { passwordUsuario = value; }
        }

        /// <summary>
        /// Obtiene o establece el Password del Usuario.
        /// </summary>
        public string PassUsuarioDos
        {
            get { return passUsuarioDos; }
            set { passUsuarioDos = value; }
        }

        /// <summary>
        /// Obtiene o establece el Usuario del Usuario.
        /// </summary>
        public string UserUsuario
        {
            get { return userUsuario; }
            set { userUsuario = value; }
        }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor vacio que inicializa los valores de Usuario
        /// Con valores por defecto.
        /// </summary>
        public Usuario()
        {
            nombreUsuario = string.Empty;
            apellidoUsuario = string.Empty;
            edadUsuario = 0;
            correoUsuario = string.Empty;
            correoUsuarioDos = string.Empty;
            passwordUsuario = string.Empty;
            passUsuarioDos = string.Empty;
            userUsuario = string.Empty;
        }

        /// <summary>
        /// Constructor con parametros que establece los valores de Usuario
        /// de acuerdo a los parametros recibidos.
        /// </summary>
        /// <param name="nombreUsuario">Establece el Nombre del Usuario.</param>
        /// <param name="apellidoUsuario">Establece el Apellido del Usuario.</param>
        /// <param name="edadUsuario">Establece la Edad del Usuario.</param>
        /// <param name="correoUsuario">Establece el Correo del Usuario.</param>
        /// <param name="correoUsuarioDos">Establece el Correo dos del Usuario.</param>
        /// <param name="userUsuario">Establece el User del Usuario.</param>
        /// <param name="passwordUsuario">Establece la Password del Usuario.</param>
        /// <param name="passUsuarioDos">Establece la Password 2 del Usuario.</param>
        public Usuario(string nombreUsuario,string apellidoUsuario,int edadUsuario,string correoUsuario,string correoUsuarioDos,
            string userUsuario,string passwordUsuario,string passUsuarioDos)
        {
            this.nombreUsuario = nombreUsuario;
            this.apellidoUsuario = apellidoUsuario;
            this.edadUsuario = edadUsuario;
            this.correoUsuario = correoUsuario;
            this.correoUsuarioDos = correoUsuarioDos;
            this.userUsuario = userUsuario;
            this.passUsuarioDos = passUsuarioDos;
            this.passwordUsuario = passwordUsuario;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que retorna Nombre y Apellido del Usuario.
        /// Para ser Desplegado en la pagina principal despues de Iniciar Session.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Nombre {0}  Apellido {1}" ,nombreUsuario,apellidoUsuario);
        }

        /// <summary>
        /// Metodo que muestra una cadena de caracteres con los datos de la persona
        /// </summary>
        /// <returns>Cadena de caracteres con nombre edad correo usuario
        /// y la password escondido de la persona. </returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Nombre : {0}", nombreUsuario));
            sb.AppendLine(string.Format("Apellido : {0}", apellidoUsuario));
            sb.AppendLine(string.Format("Edad : {0}", edadUsuario));
            sb.AppendLine(string.Format("Correo Electronico : {0}", correoUsuario));
            sb.AppendLine(string.Format("Usuario : {0}", userUsuario));

            string passMostrar = "";

            for (int i = 0; i < passwordUsuario.Length; i++)
            {
                passMostrar = passMostrar + "*";
            }
            sb.AppendLine(string.Format("Pass : {0}", passMostrar));

            return sb.ToString();
        }
        #endregion

    }
}
