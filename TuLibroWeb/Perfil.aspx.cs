using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaTuLibro;

namespace TuLibroWeb
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["objUsuario"] != null)
            {
                Usuario usu = (Usuario)Session["objUsuario"];
                txtInfo.Text = usu.MostrarDatos();
            }
        }

        protected void btnModificarPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarPerfil.aspx");
        }
    }
}