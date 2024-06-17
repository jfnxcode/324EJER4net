using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E42A
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre = Request.Params["nombre"].ToString();
            string edad = Request.Params["apellido"].ToString();
            Response.Write("<h3> Nombre:  " + nombre + "</h3>");
            Response.Write("<p> Edad:   " + edad + "</p> ");
        }
    }
}