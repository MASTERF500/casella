using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisMonAmbiental.Inicio
{
    public partial class MasterI : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["usr"] = null;
            Session["nombre"] = null;
            Session["login"] = false;
        }
    }
}