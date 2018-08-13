using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caborca.Entity
{
    public class DatosEntity
    {
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        private decimal _Latitud;
        public decimal Latitud
        {
            get { return _Latitud; }
            set { _Latitud = value; }
        }
        private decimal _Longitud;
        public decimal Longitud
        {
            get { return _Longitud; }
            set { _Longitud = value; }
        }
        private int _IdUsuario;
        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }
        private string _Usuario;
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        private string _NombreUsuario;
        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }
        private string _Apellido;
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public DatosEntity() { }
        public DatosEntity(int Id, string Nombre, decimal Latitud, decimal Longitud,
            int IdUsuario, string Usuario, string Password, string NombreUsuario, string Apellido) {
                this._Id = Id;
                this._Nombre = Nombre;
                this._Latitud = Latitud;
                this._Longitud = Longitud;
                this._IdUsuario = IdUsuario;
                this._Usuario = Usuario;
                this._Password = Password;
                this._NombreUsuario = NombreUsuario;
                this._Apellido = Apellido;
        }

    }
}
