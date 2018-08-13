using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//namespace add
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.DataVisualization.Charting;
using System.Text;

namespace SisMonAmbiental.Paginas
{
    public partial class Info : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            FillChart();    
            SqlConnection conn = new SqlConnection("Server=10.20.55.34;database=Caborca;User=intranet;Password=Newl@b0ratorio;");
            try
            {
                #region infoEstacion
                conn.Open();
                SqlCommand command;
                SqlDataReader reader;
                string noEst = Request.QueryString["estacion"];
                command = new SqlCommand("select nombre,latitud,longitud from caborca_estaciones where id="+noEst+" ", conn);
                using (reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Label1.Text = "Estación: "+reader[0];
                        Label2.Text = "Latitud: " + reader[1];
                        Label3.Text = "Longitud: " + reader[2];
                    }
                    else
                    {
                        Label1.Text = "Null";
                        Label2.Text = "Null";
                        Label3.Text = "Null";
                    }
                }
                #endregion
                #region Metodos
                llenarGraficaFecha();
               
                #endregion

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
        protected void FillGrids() {
            
            SqlConnection conn = new SqlConnection("Server=10.20.55.34;database=Caborca;User=intranet;Password=Newl@b0ratorio;");
            string noEst = Request.QueryString["estacion"];
            if (TextBox1.Text == "" || TextBox1.Text == null)
            {
                TextBox1.Text = DateTime.Today.ToShortDateString();
            }
            if (TextBox2.Text == "" || TextBox2.Text == null)
            {
                TextBox2.Text = DateTime.Today.ToShortDateString();
            }
            TextBox2.Enabled = true;
            DateTime date1 = Convert.ToDateTime(TextBox1.Text), date2=Convert.ToDateTime(TextBox2.Text);
            string fch1 =date1.ToShortDateString(), fch2 = date2.ToShortDateString();
            string c = "select sum(pm1_1m)/count(pm1_1m) as pm1_1m,sum(pm1_5m)/count(pm1_5m) as pm1_5m,sum(pm1_15m)/count(pm1_15m) as pm1_15m,sum(pm1_1h)/count(pm1_1h) as pm1_1h from caborca_estacion_" + noEst + " where fecha >='" + fch1 + "' and fecha <='" + fch2 + "' ";
            string c1 = "select sum(pm2p5_1m)/count(pm2p5_1m) as pm2p5_1m,sum(pm2p5_5m)/count(pm2p5_5m) as pm2p5_5m,sum(pm2p5_15m)/count(pm2p5_15m) as pm2p5_15m,sum(pm2p5_1h)/count(pm2p5_1h) as pm2p5_1h from caborca_estacion_" + noEst + " where fecha >='" + fch1 + "' and fecha <='" + fch2 + "' ";
            string c2 = "select sum(pm10_1m)/count(pm10_1m) as pm10_1m,sum(pm10_5m)/count(pm10_5m) as pm10_5m,sum(pm10_15m)/count(pm10_15m) as pm10_15m,sum(pm10_1h)/count(pm10_1h) as pm10_1h from caborca_estacion_" + noEst + " where fecha >='" + fch1 + "' and fecha <='" + fch2 + "' ";
            string c3 = "select sum(temp)/count(temp) as temp from caborca_estacion_" + noEst + " where fecha >='" + fch1 + "' and fecha <='" + fch2 + "'";
            #region grid1
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(c, conn);
                SqlDataAdapter sDa = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sDa.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            #endregion
            #region grid2
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(c1, conn);
                    SqlDataAdapter sDa = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sDa.Fill(dt);
                    GridView2.DataSource = dt;
                    GridView2.DataBind();

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }
            #endregion
            #region grid3
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(c2, conn);
                    SqlDataAdapter sDa = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sDa.Fill(dt);
                    GridView3.DataSource = dt;
                    GridView3.DataBind();

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }
            #endregion
            #region temp
            try{conn.Open();
           SqlCommand command= new SqlCommand(c3, conn);
                SqlDataReader reader;
                using (reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        decimal temp=Convert.ToDecimal(reader["temp"]);
                        templbl.Text = "" + decimal.Round(temp,0);
                    }
                    else
                    {
                        templbl.Text = "Null";

                    }
                }
            }
            catch { }
            finally { conn.Close(); }
            #endregion
        }
        protected void llenarGraficaFecha()
        {
            //string fch1 = "" + Calendar1.SelectedDate.Year + "/" + Calendar1.SelectedDate.Day + "/" + Calendar1.SelectedDate.Month, fch2 = "" + Calendar2.SelectedDate.Year + "/" + Calendar2.SelectedDate.Day + "/" + Calendar2.SelectedDate.Month;
            DateTime date1 = Convert.ToDateTime(TextBox1.Text), date2 = Convert.ToDateTime(TextBox2.Text);
            string fch1 = date1.ToShortDateString(), fch2 = date2.ToShortDateString();
            #region graficas
            #endregion
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            FillGrids();
            llenarGraficaFecha();
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            FillGrids();
            llenarGraficaFecha();
        }
        private static DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            string constr = "Server=10.20.55.34;database=Caborca;User=intranet;Password=Newl@b0ratorio";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(dt);
                    }
                }
                return dt;
            }
        }
        protected void FillChart()
        {
            string noEst = Request.QueryString["estacion"];
            if (TextBox1.Text == "" || TextBox1.Text == null)
            {
                TextBox1.Text = DateTime.Today.ToShortDateString();
            }
            if (TextBox2.Text == "" || TextBox2.Text == null)
            {
                TextBox2.Text = DateTime.Today.ToShortDateString();
            }
            DateTime date1 = Convert.ToDateTime(TextBox1.Text), date2 = Convert.ToDateTime(TextBox2.Text);
            string fch1 = date1.ToShortDateString(), fch2 = date2.ToShortDateString();
            string query = string.Format("select fecha, PM1_1H,PM2P5_1H,PM10_1H from caborca_estacion_"+noEst+" where fecha >='"+fch1+"' and fecha <='"+fch2+"' order by fecha desc");
            try { 
            DataTable dt = GetData(query);
            string[] x = new string[dt.Rows.Count];
            decimal[] y1 = new decimal[dt.Rows.Count];
            decimal[] y2 = new decimal[dt.Rows.Count];
            decimal[] y3 = new decimal[dt.Rows.Count];       
            decimal[] dml1= new decimal[dt.Rows.Count];
            decimal[] dml2 = new decimal[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                x[i] = dt.Rows[i][0].ToString();
                y1[i] = Convert.ToInt32(dt.Rows[i][1]);
                y2[i] = Convert.ToInt32(dt.Rows[i][2]);
                y3[i] = Convert.ToInt32(dt.Rows[i][3]);
                dml1[i] = 40;
                dml2[i] = 70;
            }
            LineChart1.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM1_1H ", Data = y1 });
            LineChart1.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM2P5_1H ", Data = y2 });
            LineChart1.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM10_1H ", Data = y3 });
            LineChart1.CategoriesAxis = string.Join(",", x);
            LineChart1.ChartTitle = string.Format("Ejemplo");

            if (x.Length > 3)
            {
                LineChart1.ChartWidth = (x.Length * 75).ToString();
                LineChart1.BaseLineColor = "#00b0f0";
                LineChart1.ChartHeight = "500";
            }


            FillGrids();
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