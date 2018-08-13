using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//clases agregadas:
using System.Threading.Tasks;
using System.Runtime.Remoting; 
using System.Configuration;
using Caborca.Entity;
using System.Data;
using System.Data.SqlClient;
namespace Caborca.Provider
{
    public abstract class EstacionProvider:DataAccess
    {
        private static ObjectHandle obj;
        private static EstacionProvider _Instance = null;
        public static EstacionProvider Instance
        {
            get {
                if (_Instance == null){
                    obj = Activator.CreateInstance(
                        ConfigurationManager.AppSettings["EstacionDll"],
                        ConfigurationManager.AppSettings["EstacionClass"]);
                    _Instance = (EstacionProvider)obj.Unwrap();
                }  
                return _Instance; }
        }
        public EstacionProvider() { }
        public abstract List<EstacionEntity> GetEstacion(int idEstacion, string fecha);
        public abstract List<EstacionEntity> GetEstacionTri(int idEstacion, string fecha);
        public abstract List<EstacionEntity> GetEstacionAnual(int idEstacion, string fecha);
        public abstract List<EstacionEntity> GetAll(int idEstacion);
        public abstract List<EstacionEntity> GetAllByFecha(int idEstacion, string fecha);
        public virtual EstacionEntity GetEstacionesFromReader(IDataReader reader) {
            EstacionEntity entity = null;
            try
            {
                entity = new EstacionEntity();
                entity.Fecha = reader["fecha"] == System.DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["fecha"]);
                DateTime fecha = reader["fecha"] == System.DBNull.Value ? DateTime.MinValue : (DateTime)reader["fecha"];
                entity.FechaParseo = fecha.Day + "/" + fecha.Month + "/" + fecha.Year;
                entity.PM1_1M=reader["PM1_1M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM1_1M"]);
                entity.PM1_5M=reader["PM1_5M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM1_5M"]);
                entity.PM1_15M=reader["PM1_15M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM1_15M"]);
                entity.PM1_1H=reader["PM1_1H"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM1_1H"]);
                entity.PM2P5_1M = reader["PM2P5_1M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM2P5_1M"]);
                entity.PM2P5_5M = reader["PM2P5_5M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM2P5_5M"]);
                entity.PM2P5_15M = reader["PM2P5_15M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM2P5_15M"]);
                entity.PM2P5_1H = reader["PM2P5_1H"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM2P5_1H"]);
                entity.PM10_1M=reader["PM10_1M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM10_1M"]);
                entity.PM10_5M=reader["PM10_5M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM10_5M"]);
                entity.PM10_15M=reader["PM10_15M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM10_15M"]);
                entity.PM10_1H=reader["PM10_1H"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM10_1H"]);
                entity.FLAG = 0;
  
            }
            catch(Exception ex) {
                throw new Exception("Error converting data...", ex);
            }
            return entity;
        }
        public virtual EstacionEntity GetEstacionesFromReader1(IDataReader reader) {
            EstacionEntity entity = null;
            try
            {
                entity = new EstacionEntity();
                string Y = reader["Y"] == System.DBNull.Value ? "00" : Convert.ToString(reader["Y"]);
                string M = reader["M"] == System.DBNull.Value ? "00" : Convert.ToString(reader["M"]);
                string D = reader["D"] == System.DBNull.Value ? "00" : Convert.ToString(reader["D"]);
                entity.Fecha = Convert.ToDateTime(D + "/" + M + "/" + Y);
                entity.FechaParseo = D + "/" + M + "/" + Y;
                entity.PM1_1M = 0;
                entity.PM1_5M = 0;
                entity.PM1_15M = 0;
                entity.PM1_1H = reader["PM1_1H"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM1_1H"]);
                entity.PM2P5_1M = 0;
                entity.PM2P5_5M = 0;
                entity.PM2P5_15M = 0;
                entity.PM2P5_1H = reader["PM2P5_1H"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM2P5_1H"]);
                entity.PM10_1M = 0;
                entity.PM10_5M = 0;
                entity.PM10_15M = 0;
                entity.PM10_1H = reader["PM10_1H"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM10_1H"]);
                entity.FLAG = reader["FLAG"] == System.DBNull.Value ? 0 : (int)reader["FLAG"];

            }
            catch (Exception ex)
            {
                throw new Exception("Error converting data...", ex);
            }
            return entity;
        }
        public virtual EstacionEntity GetEstacionesFromReader2(IDataReader reader)
        {
            EstacionEntity entity = null;
            try
            {
                entity = new EstacionEntity();
                string Y = reader["Y"] == System.DBNull.Value ? "01" : Convert.ToString(reader["Y"]);
                string M = reader["M"] == System.DBNull.Value ? "01" : Convert.ToString(reader["M"]);
                string D = "01";
                entity.Fecha = Convert.ToDateTime(D + "/" + M + "/" + Y);
                entity.FechaParseo = D + "/" + M + "/" + Y;
                entity.PM1_1M = 0;
                entity.PM1_5M = 0;
                entity.PM1_15M = 0;
                entity.PM1_1H = reader["PM1_1H"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM1_1H"]);
                entity.PM2P5_1M = 0;
                entity.PM2P5_5M = 0;
                entity.PM2P5_15M = 0;
                entity.PM2P5_1H = reader["PM2P5_1H"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM2P5_1H"]);
                entity.PM10_1M = 0;
                entity.PM10_5M = 0;
                entity.PM10_15M = 0;
                entity.PM10_1H = reader["PM10_1H"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM10_1H"]);
                entity.FLAG = reader["FLAG"] == System.DBNull.Value ? 0 : (int)reader["FLAG"];

            }
            catch (Exception ex)
            {
                throw new Exception("Error converting data...", ex);
            }
            return entity;
        }
        public virtual EstacionEntity GetEstacionesFromReader3(IDataReader reader)
        {
            EstacionEntity entity = null;
            try
            {
                entity = new EstacionEntity();
                entity.Fecha = reader["fecha"] == System.DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["fecha"]);
                DateTime fecha = reader["fecha"] == System.DBNull.Value ? DateTime.MinValue : (DateTime)reader["fecha"];
                entity.FechaParseo = fecha.Day + "/" + fecha.Month + "/" + fecha.Year;
                entity.PM1_1M = reader["PM1_1M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM1_1M"]);
                entity.PM1_5M = reader["PM1_5M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM1_5M"]);
                entity.PM1_15M = reader["PM1_15M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM1_15M"]);
                entity.PM1_1H = reader["PM1_1H"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM1_1H"]);
                entity.PM2P5_1M = reader["PM2P5_1M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM2P5_1M"]);
                entity.PM2P5_5M = reader["PM2P5_5M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM2P5_5M"]);
                entity.PM2P5_15M = reader["PM2P5_15M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM2P5_15M"]);
                entity.PM2P5_1H = reader["PM2P5_1H"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM2P5_1H"]);
                entity.PM10_1M = reader["PM10_1M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM10_1M"]);
                entity.PM10_5M = reader["PM10_5M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM10_5M"]);
                entity.PM10_15M = reader["PM10_15M"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM10_15M"]);
                entity.PM10_1H = reader["PM10_1H"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM10_1H"]);
                entity.Temp = reader["temp"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["temp"]);
                entity.Supply = reader["supply"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["supply"]);
                entity.FLAG = 0;

            }
            catch (Exception ex)
            {
                throw new Exception("Error converting data...", ex);
            }
            return entity;
        }
        public virtual EstacionEntity GetEstacionesFromReaderPm1(IDataReader reader)
        {
            EstacionEntity entity = null;
            try
            {
                entity = new EstacionEntity();
                entity.Fecha = reader["fecha"] == System.DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["fecha"]);
                DateTime fecha = reader["fecha"] == System.DBNull.Value ? DateTime.MinValue : (DateTime)reader["fecha"];
                entity.FechaParseo = fecha.Day + "/" + fecha.Month + "/" + fecha.Year;
                entity.PM1_1H = reader["PM1_1H"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["PM1_1H"]);
                entity.Temp = reader["temp"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["temp"]);
                entity.Supply = reader["supply"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["supply"]);
                entity.FLAG = 0;

            }
            catch (Exception ex)
            {
                throw new Exception("Error converting data...", ex);
            }
            return entity;
        }

    }

}
