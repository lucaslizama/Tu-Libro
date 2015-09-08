using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TuLibroWeb
{
    

    public partial class InicioDeSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }
        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string userIngresada = txtUser.Text;
            string passIngresada = txtPass.Text;

            
        }

        
    }
}