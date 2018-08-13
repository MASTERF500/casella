using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Agregados
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Configuration;

namespace SisMonAmbiental.Paginas
{
    public partial class Pruebas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillChart();
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

        protected void FillChart() {
            string query = string.Format("select top(10) fecha, PM1_1M, PM1_5M, PM1_15M, PM1_1H, PM2P5_1M, PM2P5_5M,PM2P5_15M,PM2P5_1H, PM10_15M, PM10_5M,PM10_1M,PM10_1H from caborca_estacion_2 order by fecha desc");
            DataTable dt = GetData(query);
            string[] x = new string[dt.Rows.Count];
            decimal[] y1 = new decimal[dt.Rows.Count];
            decimal[] y2 = new decimal[dt.Rows.Count];
            decimal[] y3 = new decimal[dt.Rows.Count];
            decimal[] y4 = new decimal[dt.Rows.Count];
            decimal[] y5 = new decimal[dt.Rows.Count];
            decimal[] y6 = new decimal[dt.Rows.Count];
            decimal[] y7 = new decimal[dt.Rows.Count];
            decimal[] y8 = new decimal[dt.Rows.Count];
            decimal[] y9 = new decimal[dt.Rows.Count];
            decimal[] y10 = new decimal[dt.Rows.Count];
            decimal[] y11 = new decimal[dt.Rows.Count];
            decimal[] y12 = new decimal[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                x[i] = dt.Rows[i][0].ToString();
                y1[i] = Convert.ToInt32(dt.Rows[i][1]);
                y2[i] = Convert.ToInt32(dt.Rows[i][2]);
                y3[i] = Convert.ToInt32(dt.Rows[i][3]);
                y4[i] = Convert.ToInt32(dt.Rows[i][4]);
                y5[i] = Convert.ToInt32(dt.Rows[i][5]);
                y6[i] = Convert.ToInt32(dt.Rows[i][6]);
                y7[i] = Convert.ToInt32(dt.Rows[i][7]);
                y8[i] = Convert.ToInt32(dt.Rows[i][8]);
                y9[i] = Convert.ToInt32(dt.Rows[i][9]);
                y10[i] = Convert.ToInt32(dt.Rows[i][10]);
                y11[i] = Convert.ToInt32(dt.Rows[i][11]);
                y12[i] = Convert.ToInt32(dt.Rows[i][12]);
            }
            LineChart1.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM1_1M ", Data = y1 });
            LineChart1.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM1_5M ", Data = y2 });
            LineChart1.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM1_15M ", Data = y3 });
            LineChart1.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM1_1H ", Data = y4 });
            LineChart1.CategoriesAxis = string.Join(",", x);
            LineChart1.ChartTitle = string.Format("Ejemplo");

            LineChart2.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM2P5_1M ", Data = y5 });
            LineChart2.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM2P5_5M ", Data = y6 });
            LineChart2.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM2P5_15M ", Data = y7 });
            LineChart2.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM2P5_1H ", Data = y8 });
            LineChart2.CategoriesAxis = string.Join(",", x);
            LineChart2.ChartTitle = string.Format("Ejemplo2");

            LineChart3.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM10_1M ", Data = y5 });
            LineChart3.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM10_5M ", Data = y6 });
            LineChart3.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM10_15M ", Data = y7 });
            LineChart3.Series.Add(new AjaxControlToolkit.LineChartSeries { Name = " PM10_1H ", Data = y8 });
            LineChart3.CategoriesAxis = string.Join(",", x);
            LineChart3.ChartTitle = string.Format("Ejemplo3");

            //AreaChart1.Series.Add(new AjaxControlToolkit.AreaChartSeries { Name = " PM10_1M ", Data = y5 });
            //AreaChart1.Series.Add(new AjaxControlToolkit.AreaChartSeries { Name = " PM10_5M ", Data = y6 });
            //AreaChart1.Series.Add(new AjaxControlToolkit.AreaChartSeries { Name = " PM10_15M ", Data = y7 });
            //AreaChart1.Series.Add(new AjaxControlToolkit.AreaChartSeries { Name = " PM10_1H ", Data = y8 });
            //AreaChart1.CategoriesAxis = string.Join(",", x);
            //AreaChart1.ChartTitle = string.Format("Ejemplo4");

            //PM10_15M, PM10_5M,PM10_1M,PM10_1H
            if (x.Length > 3)
            {
                LineChart1.ChartWidth = (x.Length * 75).ToString();
                LineChart1.BaseLineColor = "#00b0f0";
                LineChart1.ChartHeight = "500";
                LineChart2.ChartWidth = (x.Length * 75).ToString();
                LineChart2.ChartHeight = "500";
                LineChart3.ChartWidth = (x.Length * 75).ToString();
                LineChart3.ChartHeight = "500";
                //AreaChart1.ChartWidth = (x.Length * 75).ToString();
                //AreaChart1.ChartHeight = "500";
            }
            LineChart1.Visible = true;
        }
    }
}