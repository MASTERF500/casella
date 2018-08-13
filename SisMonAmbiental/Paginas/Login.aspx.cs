using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//namespace add
using System.Data.SqlClient;

namespace SisMonAmbiental.Paginas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=10.20.55.34;database=Caborca;User=intranet;Password=Newl@b0ratorio;");
            conn.Open();
            string usr, pwd;
            usr = TextBox1.Text;
            pwd = TextBox2.Text;
            try
            {
                SqlCommand command = new SqlCommand("if exists(select * from caborca_usuarios where usr='" + usr + "' and pwd='" + pwd + "')begin select usr,nombre from caborca_usuarios where usr='" + usr + "' and pwd='" + pwd + "' end", conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Session["usr"] = "" + reader[0];
                        Session["nombre"] = "" + reader[1];
                        Session["login"] = true;
                        Response.Redirect("~/Paginas/Inicio.aspx");
                    }
                    else { 
                            
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}