using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//namespace add
using Caborca.Business;
using Caborca.Entity;
namespace SisMonAmbiental.Inicio
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["usr"] = null;
            Session["login"] = false;
            Session["nombre"] = null;
            Label1.Visible = false;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Datosx> datos= new List<Datosx>();
                List<DatosEntity> leer = new List<DatosEntity>();
                datos = Datosx.GetDatosUsuario(TextBox1.Text,TextBox2.Text);
                if (datos.Count() > 0)
                {
                    foreach (Datosx x in datos) { Session["usr"] = x.NombreUsuario; Session["login"] = true; Session["nombre"] = x.Nombre; }
                    Response.Redirect("~/Paginas/Inicio.aspx");
                }
                else { Label1.Visible = true; Label1.Text = "Usuario y/o Contraseña incorrectos..."; }
                
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                
            }
        }
        
    }
}