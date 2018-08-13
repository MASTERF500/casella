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
    public class DatosData:DatosProvider
    {

        public override List<DatosEntity> GetDatosEstacion(int id)
        {
            DatosEntity entityEstacion = null;
            List<DatosEntity> List = new List<DatosEntity>();

            SqlConnection connection = new SqlConnection(DataAccess.SqlGlobalConectionString);
            SqlCommand command = new SqlCommand("select id,nombre,latitud,longitud from caborca_estaciones where id="+id, connection);

            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    entityEstacion = new DatosEntity();
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

        public override List<DatosEntity> GetDatosUsuario(string user, string passwrd)
        {
            DatosEntity entityEstacion = null;
            List<DatosEntity> List = new List<DatosEntity>();

            SqlConnection connection = new SqlConnection(DataAccess.SqlGlobalConectionString);
            SqlCommand command = new SqlCommand("select id_usuarios,usr,pwd,nombre,apellidoM from caborca_usuarios where usr='"+user+"' and pwd='" + passwrd+"' ", connection);

            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = null;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    entityEstacion = new DatosEntity();
                    entityEstacion = GetEstacionesFromReader1(reader);
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
