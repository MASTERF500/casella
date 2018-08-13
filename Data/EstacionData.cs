using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregados
using System.Data.SqlClient;
using System.Data;
using Caborca.Entity;
using Caborca.Provider;

namespace Caborca.Data
{
    public class EstacionData:EstacionProvider
    {
        public override List<EstacionEntity> GetEstacionTri(int idEstacion, string fecha)
        {
            string fch1="", fch2="";
            DateTime fch = Convert.ToDateTime(fecha);
            if (fch.Month == 1 || fch.Month == 2 || fch.Month == 3) {
                fch1 = "01/01/" + fch.Year;
                fch2 = "01/04/" + fch.Year;
            }
            if (fch.Month == 4 || fch.Month == 5 || fch.Month == 6)
            {
                fch1 = "01/04/" + fch.Year;
                fch2 = "01/07/" + fch.Year;
            }
            if (fch.Month == 7 || fch.Month == 8 || fch.Month == 9)
            {
                fch1 = "01/07/" + fch.Year;
                fch2 = "01/10/" + fch.Year;
            }
            if (fch.Month == 10 || fch.Month == 11 || fch.Month == 12)
            {
                fch1 = "01/10/" + fch.Year;
                fch2 = "01/01/" + fch.Year+1;
            }
            EstacionEntity entityEstacion = null;
            List<EstacionEntity> List = new List<EstacionEntity>();

            SqlConnection connection = new SqlConnection(DataAccess.SqlGlobalConectionString);
            SqlCommand command = new SqlCommand("select count(datepart(hour, fecha)) as FLAG, avg(datepart(year, fecha)) as Y,avg(datepart(month, fecha)) as M,avg(datepart(day, fecha)) as D, avg(PM1_1H) as PM1_1H, avg(PM2P5_1H) as PM2P5_1H,avg(PM10_1H) as PM10_1H from caborca_estacion_" + idEstacion + " where fecha between '" + fch1 + "' and '" + fch2 + "' and datepart(minute,fecha)='00' and PM1_1H!=0 and PM2P5_1H!=0 and PM10_1H!=0 and PM1_1H<1000 and PM2P5_1H<1000 and PM10_1H<1000 group by datepart(year, fecha), datepart(month, fecha), datepart(day, fecha) having count(datepart(hour, fecha)) > = 18  order by Y, M, D", connection);
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    entityEstacion = new EstacionEntity();
                    entityEstacion = GetEstacionesFromReader1(reader);
                    List.Add(entityEstacion);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar Estaciones TRI..." + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                reader.Close();
                connection.Dispose();
            }
            return List;
        }
        public override List<EstacionEntity> GetEstacion(int idEstacion, string fecha)
        {
            DateTime fch = Convert.ToDateTime(fecha);
 	        EstacionEntity entityEstacion = null;
                    List<EstacionEntity> List = new List<EstacionEntity>();

                    SqlConnection connection = new SqlConnection(DataAccess.SqlGlobalConectionString);
                    SqlCommand command = new SqlCommand("select fecha,PM1_1M, PM1_5M, PM1_15M, PM1_1H, PM2P5_1M, PM2P5_5M,PM2P5_15M,PM2P5_1H,PM10_1M,PM10_5M,PM10_15M,PM10_1H from caborca_estacion_" + idEstacion + " where DATEPART(YEAR,fecha)=" + fch.Year + " and datepart(MONTH,fecha)=" + fch.Month + " and DATEPART(DAY,fecha)=" + fch.Day + " and datepart(minute,fecha)='00' and PM1_1H!=0 and PM2P5_1H!=0 and PM10_1H!=0 and PM1_1H<1000 and PM2P5_1H<1000 and PM10_1H<1000 ", connection);

                    command.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = null;

                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            entityEstacion = new EstacionEntity();
                            entityEstacion = GetEstacionesFromReader(reader);
                            List.Add(entityEstacion);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al consultar Estaciones..." + ex.Message, ex);
                    }
                    finally
                    {
                        connection.Close();
                        reader.Close();
                        connection.Dispose();
                    }
                    return List;
        }
        public override List<EstacionEntity> GetEstacionAnual(int idEstacion, string fecha)
        {
            DateTime fch = Convert.ToDateTime(fecha);
            EstacionEntity entityEstacion = null;
            List<EstacionEntity> List = new List<EstacionEntity>();

            SqlConnection connection = new SqlConnection(DataAccess.SqlGlobalConectionString);

            SqlCommand command = new SqlCommand("select count(datepart(hour, fecha)) as FLAG, avg(datepart(year, fecha)) as Y,avg(datepart(month, fecha)) as M,count(datepart(day,fecha)) as D,avg(PM1_1H) as PM1_1H, avg(PM2P5_1H) as PM2P5_1H,avg(PM10_1H) as PM10_1H from caborca_estacion_" + idEstacion + " where fecha >='01/01/" + fch.Year + "' and fecha <'01/01/" + (fch.Year + 1) + "' and datepart(minute,fecha)='00' and PM1_1H!=0 and PM2P5_1H!=0 and PM10_1H!=0 and PM1_1H<1000 and PM2P5_1H<1000 and PM10_1H<1000 group by datepart(year, fecha), datepart(month, fecha) having count(datepart(hour, fecha)) > = 18 order by Y, M ", connection);

            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    entityEstacion = new EstacionEntity();
                    entityEstacion = GetEstacionesFromReader2(reader);
                    List.Add(entityEstacion);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar Estaciones..." + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                reader.Close();
                connection.Dispose();
            }
            return List;
        }

        public override List<EstacionEntity> GetAll(int idEstacion)
        {
            EstacionEntity entityEstacion = null;
            List<EstacionEntity> List = new List<EstacionEntity>();

            SqlConnection connection = new SqlConnection(DataAccess.SqlGlobalConectionString);

            SqlCommand command = new SqlCommand("select fecha,PM1_1M,PM1_15M, PM1_1H, PM2P5_1M, PM2P5_15M, PM2P5_1H, PM10_1M, PM10_15M, PM10_1H, temp, supply from caborca_estacion_" + idEstacion, connection);

            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    entityEstacion = new EstacionEntity();
                    entityEstacion = GetEstacionesFromReader3(reader);
                    List.Add(entityEstacion);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar Estaciones..." + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                reader.Close();
                connection.Dispose();
            }
            return List;
        }

        //Aun no es necesario utilizar...
        public override List<EstacionEntity> GetAllByFecha(int idEstacion, string fecha)
        {
            DateTime fch = Convert.ToDateTime(fecha);
            EstacionEntity entityEstacion = null;
            List<EstacionEntity> List = new List<EstacionEntity>();

            SqlConnection connection = new SqlConnection(DataAccess.SqlGlobalConectionString);

            SqlCommand command = new SqlCommand(" select fecha,PM1_1M,PM1_15M, PM1_1H, PM2P5_1M, PM2P5_15M, PM2P5_1H, PM10_1M, PM10_15M, PM10_1H, temp, supply from caborca_estacion_" + idEstacion, connection);

            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    entityEstacion = new EstacionEntity();
                    entityEstacion = GetEstacionesFromReader2(reader);
                    List.Add(entityEstacion);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar Estaciones..." + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                reader.Close();
                connection.Dispose();
            }
            return List;
        }
    }
}
