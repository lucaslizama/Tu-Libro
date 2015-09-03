using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TuLibroWeb
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] != null)
            {
                btnCerrarSesion.Visible = true;
                btnInicioSesion.Visible = false;
            }
            else
            {
                btnCerrarSesion.Visible = false;
                btnInicioSesion.Visible = true;
            }
        }
    }
}