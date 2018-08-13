using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisMonAmbiental.Paginas
{
    public partial class MasterP : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["usr"] == null && (bool)Session["login"] == false)
                {
                    Response.Redirect("~/Inicio/Login.aspx");
                }
            }
            catch (Exception es) { }
        }
    }
}