using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaTuLibro
{
    public class Usuario
    {
        #region Campos de Objeto

        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private string correo;
        private string user;
        private string password;

        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece el Nombre del Usuario.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        /// <summary>
        /// Obtiene o establece el Apellido del Usuario.
        /// </summary>
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        /// <summary>
        /// Obtiene o establece la Edad del Usuario.
        /// </summary>
        public DateTime Edad
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        /// <summary>
        /// Obtiene o establece el Correo del Usuario.
        /// </summary>
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        /// <summary>
        /// Obtiene o establece el Password del Usuario.
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// Obtiene o establece el Usuario del Usuario.
        /// </summary>
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor vacio que inicializa los valores de Usuario
        /// Con valores por defecto.
        /// </summary>
        public Usuario()
        {
            Init();
        }

        /// <summary>
        /// Constructor con parametros que establece los valores de Usuario
        /// de acuerdo a los parametros recibidos.
        /// </summary>
        /// <param name="nombre">Establece el nombre del usuario</param>
        /// <param name="apellido">Establece el apellido del usuario</param>
        /// <param name="fechaNacimiento">Establece la fechaNacimiento del usuario</param>
        /// <param name="correo">Establece el correo del usuario</param>
        /// <param name="user">Establece el user del usuario</param>
        /// <param name="password">Establece el password del usuario</param>
        public Usuario(string nombre, string apellido, DateTime fechaNacimiento, string correo, string user, string password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.correo = correo;
            this.user = user;
            this.password = password;

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
            return string.Format("Nombre {0}  Apellido {1}", nombre, apellido);
        }

        /// <summary>
        /// Metodo que muestra una cadena de caracteres con los datos de la persona
        /// </summary>
        /// <returns>Cadena de caracteres con nombre edad correo usuario
        /// y la password escondido de la persona. </returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Nombre : {0} <br> ", nombre));
            sb.AppendLine(string.Format("Apellido : {0} <br> ", apellido));
            sb.AppendLine(string.Format("Edad : {0} <br> ", CalcularEdad(fechaNacimiento)));
            sb.AppendLine(string.Format("Correo Electronico : {0} <br> ", correo));
            sb.AppendLine(string.Format("Usuario : {0} <br> ", user));

            string passMostrar = "";

            for (int i = 0; i < password.Length; i++)
            {
                passMostrar = passMostrar + "*";
            }
            sb.AppendLine(string.Format("Pass : {0}<br>", passMostrar));

            return sb.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        private void Init()
        {
            nombre = string.Empty;
            apellido = string.Empty;
            fechaNacimiento = new DateTime(1900, 1, 1);
            correo = string.Empty;
            password = string.Empty;
            user = string.Empty;
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            if (DateTime.Now.Month < fechaNacimiento.Month)
            {
                edad--;
                return edad;
            }
            else
            {
                if (DateTime.Now.Day < fechaNacimiento.Day)
                {
                    edad--;
                    return edad;
                }
            }
                
            return edad;
        }
        #endregion

    }
}
