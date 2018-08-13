using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//clases agregadas:
using System.Runtime.Remoting;
using System.Configuration;
using Caborca.Entity;
using System.Data;
using System.Data.SqlClient;

namespace Caborca.Provider
{
    public abstract class DatosProvider:DataAccess
    {
        private static ObjectHandle obj;
        private static DatosProvider _Instance = null;
        public static DatosProvider Instance
        {
            get {
                if (_Instance == null){
                    obj = Activator.CreateInstance(
                        ConfigurationManager.AppSettings["DatosDll"],
                        ConfigurationManager.AppSettings["DatosClass"]);
                    _Instance = (DatosProvider)obj.Unwrap();
                } 
                return _Instance;
            }
        }
        public DatosProvider() { }
        public abstract List<DatosEntity> GetDatosEstacion(int id);
        public abstract List<DatosEntity> GetDatosUsuario(string user, string passwrd);
        public virtual DatosEntity GetEstacionesFromReader(IDataReader reader) {
            DatosEntity entity = null;
            try
            {
                entity = new DatosEntity();
                entity.Id = reader["id"] == System.DBNull.Value ? 0 : (int)reader["id"];
                entity.Nombre= reader["nombre"] == System.DBNull.Value ? "Null":(string)reader["nombre"];
                entity.Latitud = reader["latitud"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["latitud"]);
                entity.Longitud = reader["longitud"] == System.DBNull.Value ? 0 : Convert.ToDecimal(reader["longitud"]);
                entity.IdUsuario = 0;
                entity.Usuario = "Null";
                entity.Password = "Null";
                entity.NombreUsuario = "Null";
                entity.Apellido = "Null";
            }catch(Exception ex){
                throw new Exception("Error al consultar datos...", ex);
            }
            return entity;
        }
        public virtual DatosEntity GetEstacionesFromReader1(IDataReader reader) {
            DatosEntity entity = null;
            try
            {
                entity = new DatosEntity();
                entity.Id = 0;
                entity.Nombre = "Null";
                entity.Latitud = 0;
                entity.Longitud = 0;
                entity.IdUsuario = reader["id_usuarios"] == System.DBNull.Value ? 0 : (int)reader["id_usuarios"]; ;
                entity.Usuario = reader["usr"] == System.DBNull.Value ? "Null" : (string)reader["usr"];
                entity.Password = reader["pwd"] == System.DBNull.Value ? "Null" : (string)reader["pwd"];
                entity.NombreUsuario = reader["nombre"] == System.DBNull.Value ? "Null" : (string)reader["nombre"];
                entity.Apellido = reader["apellidoM"] == System.DBNull.Value ? "Null" : (string)reader["apellidoM"];
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar datos...", ex);
            }
            return entity;
        
        }
    }
}
