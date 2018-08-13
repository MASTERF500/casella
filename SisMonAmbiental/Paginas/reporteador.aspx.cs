using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//add
using Caborca.Business;
using System.Data;
using System.Text;
using System.Drawing;
namespace SisMonAmbiental.Paginas
{
    public partial class reporteador : System.Web.UI.Page
    {
        protected string calenda;
        protected string nameEst;
        protected void Page_Load(object sender, EventArgs e)
        {
            nameEst= nameLabel.Text = Convert.ToString(Request.QueryString["nom"]);
            LatLabel.Text = Convert.ToString(Request.QueryString["lat"]);
            LongLabel.Text = Convert.ToString(Request.QueryString["lon"]);
            SqlDataSource1.SelectCommand = "SELECT [fecha], [PM1_1H], [PM2P5_1H], [PM10_1H], [temp], [supply] FROM caborca_estacion_" + Convert.ToDecimal(Request.QueryString["estacion"]) + " ORDER BY [fecha]";
        }
        public static string reporte(int id, string fch1, string fhc2, int tipo)
        {
            List<Estacion> lst = new List<Estacion>();
            lst = Estacion.GetAllInfo(id); 
            string acumulador = "";
            foreach (Estacion row in lst)
            {
                DateTime date = Convert.ToDateTime(row.FechaParseo);
                acumulador += "[new Date(,,),],";
            }
            return acumulador;
        }
        protected void ImageButtonPdf_Click(object sender, ImageClickEventArgs e)
        {
            ExportGridToCSV();
        }
        private void ExportGridToCSV()
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename="+nameEst+"_report.csv");
            Response.Charset = "";
            Response.ContentType = "application/text";
            GridView1.AllowPaging = false;
            GridView1.DataBind();

            StringBuilder columnbind = new StringBuilder();
            for (int k = 0; k < GridView1.Columns.Count; k++)
            {

                columnbind.Append(GridView1.Columns[k].HeaderText + ',');
            }

            columnbind.Append("\r\n");
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                for (int k = 0; k < GridView1.Columns.Count; k++)
                {

                    columnbind.Append(GridView1.Rows[i].Cells[k].Text + ',');
                }

                columnbind.Append("\r\n");
            }
            Response.Output.Write(columnbind.ToString());
            Response.Flush();
            Response.End();

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {


            if (e.Row.RowIndex >= 0)
            {

                    if (Convert.ToDecimal(e.Row.Cells[1].Text) == 0 || Convert.ToDecimal(e.Row.Cells[1].Text) > 1000) //Here is the condition!
                    {
                        e.Row.BackColor = System.Drawing.Color.Yellow;
                        e.Row.BorderColor = System.Drawing.Color.Red;
                    }
                    if (Convert.ToDecimal(e.Row.Cells[2].Text) == 0 || Convert.ToDecimal(e.Row.Cells[2].Text) > 1000) //Here is the condition!
                    {
                        e.Row.BackColor = System.Drawing.Color.Yellow;
                        e.Row.BorderColor = System.Drawing.Color.Red;
                    }
                    if (Convert.ToDecimal(e.Row.Cells[3].Text) == 0 || Convert.ToDecimal(e.Row.Cells[3].Text) > 1000) //Here is the condition!
                    {
                        e.Row.BackColor = System.Drawing.Color.Yellow;
                        e.Row.BorderColor = System.Drawing.Color.Red;
                    }
                    if (Convert.ToDecimal(e.Row.Cells[4].Text) == 0 || Convert.ToDecimal(e.Row.Cells[4].Text) > 1000) //Here is the condition!
                    {
                        e.Row.BackColor = System.Drawing.Color.Yellow;
                        e.Row.BorderColor = System.Drawing.Color.Red;
                    }
            }

        }

    }
}