using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Agregadas
using Caborca.Business;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SisMonAmbiental.Paginas
{
    public partial class Graficas : System.Web.UI.Page
    {
        protected int estacion;
        protected void Page_Load(object sender, EventArgs e)
        {
            estacion=Convert.ToInt16(Request.QueryString["estacion"]);
            if (Convert.ToInt16(Request.QueryString["estacion"]) != 0 && FechaTextBox.Text == "")
            {
                FechaTextBox.Text = DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
                renderCharts(Convert.ToInt16(Request.QueryString["estacion"]), FechaTextBox.Text);
                estacionDatos(Convert.ToInt16(Request.QueryString["estacion"]));
            }
        }
        protected void estacionDatos(int est)
        {
            try
            {
                List<Datosx> dt = Datosx.GetDatosEstacion(est);
                foreach (Datosx row in dt) { nameLabel.Text = row.Nombre; LatLabel.Text = "Latitud: " + row.Latitud; LongLabel.Text = "Longitud: " + row.Longitud; }
            }
            catch (Exception ex) { }
        }
        protected void renderCharts(int est, string fecha)
        {
            DateTime fch = Convert.ToDateTime(fecha);
            string pm1D, pm2p5D, pm10D, pm1T, pm2p5T, pm10T, pm1Y, pm2p5Y, pm10Y, m1, m2, m3; int mk1, mk2, mk3, cond1 = 0; decimal maxC1;
            int flagYear;
            trimestre(fecha, out m1, out m2, out m3, out mk1, out mk2, out mk3);
            chartDay(est, fecha, out pm1D, out pm2p5D, out pm10D, out maxC1);
            chartAnual(est, fecha, out pm1Y, out pm2p5Y, out pm10Y, out flagYear);
            #region chart1
            if (Convert.ToInt16(maxC1) >= 20) { cond1 = 20; }
            if (Convert.ToInt16(maxC1) >= 50) { cond1 = 30; }
            if (Convert.ToInt16(maxC1) >= 100) { cond1 = 40; }
            if (Convert.ToInt16(maxC1) >= 200) { cond1 = 50; }
            string chart1 = @"<script type='text/javascript' src='canvas/canvasjs.js'></script>
            <script type='text/javascript'>
            var chart1 = new CanvasJS.Chart('chart1',
            {
                animationEnabled: true,
                title: {text: 'DÍA: " + fecha + " ' " +
                @"},
                axisY: {   
                    interval: " + cond1 + ", maximum: " + (maxC1 + 80) + ", " +
                    @"title: 'Pm (µg/m3)', gridThickness: 0,
                    stripLines: [{value: 75,label: 'PM10: 75µg/m3',labelFontColor:'black', color:'red'}, {value: 45,label: 'PM2.5: 45µg/m3',labelFontColor:'black',color: 'red'}]
                       },
                axisX: {
                    interval: 1, maximun:24,
                    labelAngle: -50,
                    stripLines: [{value: new Date(" + fch.Year + "," + fch.Month + "," + fch.Day + ",06), lineDashType: 'dot',label: '▲ 6 a.m.',color:'red',labelFontColor:'black'},{value: new Date(" + fch.Year + "," + fch.Month + "," + fch.Day + ",12), lineDashType: 'dot',label: '▲ 12 p.m.',color:'red',labelFontColor:'black'},{value: new Date(" + fch.Year + "," + fch.Month + "," + fch.Day + ",18), lineDashType: 'dot',label: '▲ 6 P.M.',color:'red',labelFontColor:'black'}]}," +
                @"data: [
                {yValueFormatString: '## µg/m3',xValueFormatString:'hh:mm tt',showInLegend: true, name: 'PM1',type: 'line', dataPoints: [" + pm1D + "]},{yValueFormatString: '## µg/m3',xValueFormatString: 'hh:mm TT',showInLegend: true, name: 'PM2.5',type: 'line', dataPoints: [" + pm2p5D + "]},{yValueFormatString: '## µg/m3',xValueFormatString: 'hh:mm TT',showInLegend: true, name: 'PM10',type: 'line', dataPoints: [" + pm10D + "]},]},); chart1.render(); </script>";
            ClientScript.RegisterStartupScript(this.GetType(), "script1", chart1);
            #endregion
            #region chart2
            chartTRI(est, fecha, out pm1T, out pm2p5T, out pm10T, out maxC1);
            if (Convert.ToInt16(maxC1) >= 50) { cond1 = 20; }
            if (Convert.ToInt16(maxC1) >= 100) { cond1 = 60; }
            if (Convert.ToInt16(maxC1) >= 200) { cond1 = 100; }
            if (Convert.ToInt16(maxC1) >= 400) { cond1 = 120; }
            string chart2 = "<script src='canvas/canvasjs.js'></script><script type='text/javascript'>" +
            @"var chart2 = new CanvasJS.Chart('chart2',
            {
                animationEnabled: true,
                title: {
                    text: 'TRIMESTRE " + m1 + "-" + m2 + "-" + m3 + "' " +
                @"},
                axisY: { " +
                           " interval: " + cond1 + ", maximun:" + (maxC1 + 80) + "," +
                            @"title: 'Pm (µg/m3)', gridThickness: 0,
                            stripLines: [{value: 40,label: 'PM10: 40µg/m3',labelFontColor:'black', color:'red'}, {value: 12,label: 'PM2.5: 12µg/m3',labelFontColor:'black',color: 'red'}]
                        },
                axisX: { 
                    interval: 1, maximun:1000, " +
                    @"labelAngle: -50,
                    stripLines:[{value:new Date(" + fch.Year + "," + mk1 + "), lineDashType: 'dot',label: '▲ " + m1 + " ',color:'red',labelFontColor:'black' },{value:new Date(" + fch.Year + "," + mk2 + "), lineDashType: 'dot',label: '▲ " + m2 + " ',color:'red',labelFontColor:'black' },{value:new Date(" + fch.Year + "," + mk3 + "), lineDashType: 'dot',label: '▲ " + m3 + " ',color:'red',labelFontColor:'black'}]}," +
                @"data: [
                {yValueFormatString: '##.# µg/m3',xValueFormatString:'DD MMM',showInLegend: true, name: 'PM1',type: 'line', dataPoints: [" + pm1T + "]},{yValueFormatString: '##.# µg/m3',xValueFormatString: 'DD MMM',showInLegend: true, name: 'PM2.5',type: 'line', dataPoints: [" + pm2p5T + "]},{yValueFormatString: '##.# µg/m3',xValueFormatString: 'DD MMM',showInLegend: true, name: 'PM10',type: 'line', dataPoints: [" + pm10T + "]}, ]}); chart2.render(); </script>";
            ClientScript.RegisterStartupScript(this.GetType(), "script2", chart2);
            #endregion
            #region chart3
            string chart3 = "<script src='canvas/canvasjs.min.js'></script> <script type='text/javascript'>  " +
           @"var chart3 = new CanvasJS.Chart('chart3',
            {
                animationEnabled: true,
                title: {
                    text: 'AÑ0 " + fch.Year + " ' " +
               @"},
                axisY: {    
                            interval: 10, maximun:200, " +
                        @"title: 'Pm (µg/m3)', gridThickness: 0, 
                            stripLines: [{value: 40,label: 'PM10: 40µg/m3',labelFontColor:'black', color:'red'}, {value: 12,label: 'PM2.5: 12µg/m3',labelFontColor:'black',color: 'red'}]
                        },
                axisX: {
                    interval: 1,
                    intervalType: 'month',
                    stripLines:[{value:new Date(" + fch.Year + ",03,01), lineDashType: 'dot',label: '▲ 1er Trimestre:Ene-Feb-Mar',color:'red',labelFontColor:'black' },{value:new Date(" + fch.Year + ",06,01), lineDashType: 'dot',label: '▲ 2do Trimestre:Abr-May-Jun ',color:'red',labelFontColor:'black' },{value:new Date(" + fch.Year + ",09,01), lineDashType: 'dot',label: '▲ 3er Trimestre ',color:'red',labelFontColor:'black' },{value:new Date(" + (fch.Year + 1) + ",01,01), lineDashType: 'dot',label: '▲ 4to Trimestre ',color:'red',labelFontColor:'black' } ] " +
                   @" },
                data: [
                {yValueFormatString: '##.# µg/m3',xValueFormatString: 'MMM',showInLegend: true, name: 'PM1',type: 'line',connectNullData: true, dataPoints: [" + pm1Y + "]},{yValueFormatString: '##.# µg/m3',xValueFormatString: 'MMM',showInLegend: true, name: 'PM2.5',type: 'line', connectNullData: true, dataPoints: [" + pm2p5Y + "]},{yValueFormatString: '##.# µg/m3',xValueFormatString: 'MMM',showInLegend: true, name: 'PM10',type: 'line', connectNullData: true, dataPoints: [" + pm10Y + "]}, ]});  chart3.render(); </script>";
            ClientScript.RegisterStartupScript(this.GetType(), "script3", chart3);
            #endregion
        }
        protected void chartTRI(int idEstacion, string fecha, out string pm1T, out string pm2p5T, out string pm10T, out decimal max)
        {
            pm10T = pm2p5T = pm1T = ""; max = 0;
            try
            {
                List<Estacion> lstDatosEstacion = new List<Estacion>();
                //error al retornar datos
                lstDatosEstacion = Estacion.GetEstacionesTRI(idEstacion, fecha);
                lstDatosEstacion = lstDatosEstacion.OrderBy(o => o.Fecha).ToList();
                    foreach (Estacion row in lstDatosEstacion)
                    {
                        var pm1 = ""; var pm2p5 = ""; var pm10 = "";
                        if (row.PM1_1H != 0) { pm1 = ""+row.PM1_1H; } else { pm1 = "null"; }
                        if (row.PM2P5_1H != 0) { pm2p5 = "" + row.PM2P5_1H; } else { pm2p5 = "null"; }
                        if (row.PM10_1H != 0) { pm10 = "" + row.PM10_1H; } else { pm10 = "null"; }
                        pm1T += "{x: new Date(" + row.Fecha.Year + "," + (row.Fecha.Month - 1) + "," + row.Fecha.Day + "), y: " + pm1 + "},";
                        pm2p5T += "{x: new Date(" + row.Fecha.Year + "," + (row.Fecha.Month - 1) + "," + row.Fecha.Day + "), y: " + pm2p5+ "},";
                        pm10T += "{x: new Date(" + row.Fecha.Year + "," + (row.Fecha.Month - 1) + "," + row.Fecha.Day + "), y: " + pm10 + "},";
                    }
            }
            catch (Exception ex) { }

        }
        protected void chartDay(int idEstacion, string fecha, out string pm1D, out string pm2p5D, out string pm10D, out decimal max)
        {

            pm1D = pm2p5D = pm10D = ""; max = 0;
            try
            {
                List<Estacion> lstDatosEstacion = new List<Estacion>();
                lstDatosEstacion = Estacion.GetEstacionesDay(idEstacion, fecha);
                    foreach (Estacion row in lstDatosEstacion)
                    {
                        if (max < row.PM1_1H) max = row.PM1_1H;
                        if (max < row.PM2P5_1H) max = row.PM2P5_1H;
                        if (max < row.PM10_1H) max = row.PM10_1H;
                        pm1D += "{x: new Date(" + row.Fecha.Year + "," + row.Fecha.Month + "," + row.Fecha.Day + "," + row.Fecha.Hour + "," + row.Fecha.Minute + "), y: " + row.PM1_1H + "},";
                        pm2p5D += "{x: new Date(" + row.Fecha.Year + "," + row.Fecha.Month + "," + row.Fecha.Day + "," + row.Fecha.Hour + "," + row.Fecha.Minute + "), y: " + row.PM2P5_1H + "},";
                        pm10D += "{x: new Date(" + row.Fecha.Year + "," + row.Fecha.Month + "," + row.Fecha.Day + "," + row.Fecha.Hour + "," + row.Fecha.Minute + "), y: " + row.PM10_1H + "},";
                    }
            }
            catch (Exception ex) { }
        }
        protected void chartAnual(int idEstacion, string fecha, out string pm1Y, out string pm2p5Y, out string pm10Y, out int flag)
        {
            List<Estacion> lstDatosEstacion1 = new List<Estacion>();
            List<Estacion> lstDatosEstacion2 = new List<Estacion>();
            List<Estacion> lstDatosEstacion3 = new List<Estacion>();
            List<Estacion> lstDatosEstacion4 = new List<Estacion>();
            pm1Y = pm2p5Y = pm10Y = ""; flag = 0;
            decimal acum1 = 0, acum2 = 0, acum3 = 0;
            try
            {
                Estacion.GetEstacionesAnual(idEstacion, fecha, out lstDatosEstacion1, out lstDatosEstacion2, out lstDatosEstacion3, out lstDatosEstacion4);
                if (lstDatosEstacion1.Count >= 68) flag++;
                if (lstDatosEstacion2.Count >= 68) flag++;
                if (lstDatosEstacion3.Count >= 68) flag++;
                if (lstDatosEstacion4.Count >= 68) flag++;
                if (flag >= 3)
                {
                    foreach (Estacion row in lstDatosEstacion1)
                    {
                        acum1 += row.PM1_1H;
                        acum2 += row.PM2P5_1H;
                        acum3 += row.PM10_1H;
                    }
                    pm1Y += "{x:new Date(" + Convert.ToDateTime(fecha).Year + ",03,01),y: " + (acum1 / lstDatosEstacion1.Count) + "},";
                    pm2p5Y += "{x:new Date(" + Convert.ToDateTime(fecha).Year + ",03,01),y: " + (acum2 / lstDatosEstacion2.Count) + "},";
                    pm10Y += "{x:new Date(" + Convert.ToDateTime(fecha).Year + ",03,01),y: " + (acum3 / lstDatosEstacion1.Count) + "},";
                    acum1 = acum2 = acum3 = 0;
                    foreach (Estacion row in lstDatosEstacion2)
                    {
                        acum1 += row.PM1_1H;
                        acum2 += row.PM2P5_1H;
                        acum3 += row.PM10_1H;
                    }
                    pm1Y += "{x:new Date(" + Convert.ToDateTime(fecha).Year + ",06,01),y: " + (acum1 / lstDatosEstacion2.Count) + "},";
                    pm2p5Y += "{x:new Date(" + Convert.ToDateTime(fecha).Year + ",06,01),y: " + (acum2 / lstDatosEstacion2.Count) + "},";
                    pm10Y += "{x:new Date(" + Convert.ToDateTime(fecha).Year + ",06,01),y: " + (acum3 / lstDatosEstacion2.Count) + "},";
                    acum1 = acum2 = acum3 = 0;
                    foreach (Estacion row in lstDatosEstacion3)
                    {
                        acum1 += row.PM1_1H;
                        acum2 += row.PM2P5_1H;
                        acum3 += row.PM10_1H;
                    }
                    pm1Y += "{x:new Date(" + Convert.ToDateTime(fecha).Year + ",09,01),y: " + (acum1 / lstDatosEstacion3.Count) + ",label: 'Jul-Ago-Sep'},";
                    pm2p5Y += "{x:new Date(" + Convert.ToDateTime(fecha).Year + ",09,01),y: " + (acum2 / lstDatosEstacion3.Count) + ",label: 'Jul-Ago-Sep'},";
                    pm10Y += "{x:new Date(" + Convert.ToDateTime(fecha).Year + ",09,01),y: " + (acum3 / lstDatosEstacion3.Count) + ",label: 'Jul-Ago-Sep'},";
                    acum1 = acum2 = acum3 = 0;
                    foreach (Estacion row in lstDatosEstacion4)
                    {
                        acum1 += row.PM1_1H;
                        acum2 += row.PM2P5_1H;
                        acum3 += row.PM10_1H;
                    }
                    pm1Y += "{x:new Date(" + Convert.ToDateTime(fecha).Year + ",12,01),y: " + (acum1 / lstDatosEstacion4.Count) + ",label: 'Jul-Ago-Sep'},";
                    pm2p5Y += "{x:new Date(" + Convert.ToDateTime(fecha).Year + ",12,01),y: " + (acum2 / lstDatosEstacion4.Count) + ",label: 'Jul-Ago-Sep'},";
                    pm10Y += "{x:new Date(" + Convert.ToDateTime(fecha).Year + ",12,01),y: " + (acum3 / lstDatosEstacion4.Count) + ",label: 'Jul-Ago-Sep'},";
                    acum1 = acum2 = acum3 = 0;
                }
            }
            catch (Exception ex) { }
        }
        protected void trimestre(string fecha, out string m1, out string m2, out string m3, out int mk1, out int mk2, out int mk3)
        {
            DateTime fch = Convert.ToDateTime(fecha);
            switch (fch.Month)
            {
                case 1:
                case 2:
                case 3:
                    m1 = "ENERO"; m2 = "FEBRERO"; m3 = "MARZO";
                    mk1 = 1; mk2 = 2; mk3 = 3;
                    break;
                case 4:
                case 5:
                case 6:
                    m1 = "ABRIL"; m2 = "MAYO"; m3 = "JUNIO";
                    mk1 = 3; mk2 = 4; mk3 = 5;
                    break;
                case 7:
                case 8:
                case 9:
                    m1 = "JULIO"; m2 = "AGOSTO"; m3 = "SEPTIEMBRE";
                    mk1 = 6; mk2 = 7; mk3 = 8;
                    break;
                case 10:
                case 11:
                case 12:
                    m1 = "OCTUBRE"; m2 = "NOVIEMBRE"; m3 = "DICIEMBRE";
                    mk1 = 9; mk2 = 10; mk3 = 11;
                    break;
                default:
                    m1 = m2 = m3 = "";
                    mk1 = mk2 = mk3 = 0;
                    break;
            }

        }
        protected void FechaTextBox_TextChanged(object sender, EventArgs e)
        {
            DateTime fch = Convert.ToDateTime(FechaTextBox.Text);
            renderCharts(Convert.ToInt16(Request.QueryString["estacion"]), fch.Day + "/" + fch.Month + "/" + fch.Year);

        }

        protected void LinkButtonReporteador_Click(object sender, EventArgs e)
        {
            Response.Redirect("reporteador.aspx?estacion="+estacion+"&nom="+nameLabel.Text+"&lat="+LatLabel.Text+"&lon="+LongLabel.Text);
        }

        protected List<Estacion> cleanfch(List<Estacion> lstEst) {
            List<Estacion> lst = new List<Estacion>();
            List<fecha> lstf = new List<fecha>();
            
            //lstf= fecha.fechas().Where(fecha ) ;
            //.Where(person => person.Age > 30);

            return lst;
        }

    }
}