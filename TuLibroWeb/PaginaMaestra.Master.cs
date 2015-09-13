using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaTuLibro;

namespace TuLibroWeb
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioLoggeado"] != null)
            {
                btnCerrarSesion.Visible = true;
                btnInicioSesion.Visible = false;
                lblBienvenida.Visible = true;
            }
            else
            {
                btnCerrarSesion.Visible = false;
                btnInicioSesion.Visible = true;
                lblBienvenida.Visible = false;
            }
        }
    }
}