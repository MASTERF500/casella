using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caborca.Entity;
using Caborca.Provider;
using Caborca.Data;
namespace Caborca.Business
{
    public class Estacion
    {
        private DateTime _Fecha;
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        private string _FechaParseo;
        public string FechaParseo
        {
            get { return _FechaParseo; }
            set { _FechaParseo = value; }
        }

        private decimal _PM1_1M;
        public decimal PM1_1M
        {
            get { return _PM1_1M; }
            set { _PM1_1M = value; }
        }

        private decimal _PM1_5M;
        public decimal PM1_5M
        {
            get { return _PM1_5M; }
            set { _PM1_5M = value; }
        }

        private decimal _PM1_15M;
        public decimal PM1_15M
        {
            get { return _PM1_15M; }
            set { _PM1_15M = value; }
        }

        private decimal _PM1_1H;
        public decimal PM1_1H
        {
            get { return _PM1_1H; }
            set { _PM1_1H = value; }
        }

        private decimal _PM2P5_1M;
        public decimal PM2P5_1M
        {
            get { return _PM2P5_1M; }
            set { _PM2P5_1M = value; }
        }

        private decimal _PM2P5_5M;
        public decimal PM2P5_5M
        {
            get { return _PM2P5_5M; }
            set { _PM2P5_5M = value; }
        }

        private decimal _PM2P5_15M;
        public decimal PM2P5_15M
        {
            get { return _PM2P5_15M; }
            set { _PM2P5_15M = value; }
        }

        private decimal _PM2P5_1H;
        public decimal PM2P5_1H
        {
            get { return _PM2P5_1H; }
            set { _PM2P5_1H = value; }
        }

        private decimal _PM10_15M;
        public decimal PM10_15M
        {
            get { return _PM10_15M; }
            set { _PM10_15M = value; }
        }

        private decimal _PM10_5M;
        public decimal PM10_5M
        {
            get { return _PM10_5M; }
            set { _PM10_5M = value; }
        }

        private decimal _PM10_1M;
        public decimal PM10_1M
        {
            get { return _PM10_1M; }
            set { _PM10_1M = value; }
        }

        private decimal _PM10_1H;
        public decimal PM10_1H
        {
            get { return _PM10_1H; }
            set { _PM10_1H = value; }
        }

        private decimal _Temp;
        public decimal Temp
        {
            get { return _Temp; }
            set { _Temp = value; }
        }

        private decimal _Supply;
        public decimal Supply
        {
            get { return _Supply; }
            set { _Supply = value; }
        }

        public Estacion(){}
        public Estacion(DateTime Fecha, string FechaParseo, decimal PM1_1M, decimal PM1_5M, decimal PM1_15M, decimal PM1_1H,
            decimal PM2P5_1M, decimal PM2P5_5M, decimal PM2P5_15M, decimal PM2P5_1H, decimal PM10_15M, decimal PM10_5M, decimal PM10_1M, decimal PM10_1H, decimal Temp, decimal Supply)
        {
                this._Fecha = Fecha;
                this._FechaParseo = FechaParseo;
                this._PM1_1M = PM1_1M;
                this._PM1_5M=PM1_5M;
                this._PM1_15M=PM1_15M;
                this._PM1_1H=PM1_1H;
                this._PM2P5_1M=PM2P5_1M;
                this._PM2P5_5M=PM2P5_5M;
                this._PM2P5_15M=PM2P5_15M;
                this._PM2P5_1H=PM2P5_1H;
                this._PM10_1M = PM10_1M;
                this._PM10_5M = PM10_5M;    
                this._PM10_15M=PM10_15M;
                this._PM10_1H = PM10_1H;
                this._Temp = Temp;
                this._Supply = Supply;
        }
        public static List<Estacion> GetEstacionesDay(int idedo, string fecha)
        {
            List<Estacion> ListaEstn = new List<Estacion>();
            List<EstacionEntity> Estaciones = new List<EstacionEntity>();
            Estaciones = Provider.Provider.Estacion.GetEstacion(idedo, fecha);
            foreach (EstacionEntity get in Estaciones)
            {
                    Estacion esTrucEstacion = new Estacion(get.Fecha, get.FechaParseo, get.PM1_1M, get.PM1_5M, get.PM1_15M, Math.Round(get.PM1_1H, MidpointRounding.AwayFromZero), get.PM2P5_1M, get.PM2P5_5M, get.PM2P5_15M, Math.Round(get.PM2P5_1H, MidpointRounding.AwayFromZero), get.PM10_1M, get.PM10_5M, get.PM10_15M, Math.Round(get.PM10_1H, MidpointRounding.AwayFromZero),get.Temp,get.Supply);
                    ListaEstn.Add(esTrucEstacion);
            }
            return ListaEstn;
        }
        public static List<Estacion> GetEstacionesTRI(int idedo, string fchx)
        {
            List<Estacion> ListaEstn = new List<Estacion>();
            List<EstacionEntity> Estaciones = new List<EstacionEntity>();
            List<Estacion> ListClean = new List<Estacion>();
            Estaciones = Provider.Provider.Estacion.GetEstacionTri(idedo,fchx);
            
            foreach(EstacionEntity get in Estaciones){
                Math.Round(get.PM1_1H, 1, MidpointRounding.AwayFromZero); Math.Round(get.PM2P5_1H, 1, MidpointRounding.AwayFromZero); Math.Round(get.PM10_1H, 1, MidpointRounding.AwayFromZero);
                Estacion esTrucEstacion = new Estacion(get.Fecha, get.FechaParseo, get.PM1_1M, get.PM1_5M, get.PM1_15M, get.PM1_1H, get.PM2P5_1M, get.PM2P5_5M, get.PM2P5_15M, get.PM2P5_1H, get.PM10_1M, get.PM10_5M, get.PM10_15M, get.PM10_1H, get.Supply, get.Temp);
                ListaEstn.Add(esTrucEstacion);
            }
            int x=1;
            ListClean = Caborca.Business.fecha.fechas(fchx, ListaEstn);
            return ListClean;
        }
        public static void GetEstacionesAnual(int idedo, string fchx, out List<Estacion> ListaEstn1, out List<Estacion> ListaEstn2, out List<Estacion> ListaEstn3, out List<Estacion> ListaEstn4)
        {
            ListaEstn1 = new List<Estacion>();
            ListaEstn2 = new List<Estacion>();
            ListaEstn3 = new List<Estacion>();
            ListaEstn4 = new List<Estacion>();
            List<EstacionEntity> Estaciones = new List<EstacionEntity>();
            Estaciones = Provider.Provider.Estacion.GetEstacionAnual(idedo, fchx);
                foreach (EstacionEntity get in Estaciones)
                {
                        Estacion esTrucEstacion = new Estacion(get.Fecha, get.FechaParseo, get.PM1_1M, get.PM1_5M, get.PM1_15M, get.PM1_1H, get.PM2P5_1M, get.PM2P5_5M, get.PM2P5_15M, get.PM2P5_1H, get.PM10_1M, get.PM10_5M, get.PM10_15M, get.PM10_1H,get.Temp,get.Supply);
                        switch (get.Fecha.Month)
                        {
                            case 1: 
                            case 2:
                            case 3:
                                ListaEstn1.Add(esTrucEstacion);
                                break;
                            case 4:
                            case 5:
                            case 6:
                                ListaEstn2.Add(esTrucEstacion);
                                break;
                            case 7:
                            case 8:
                            case 9:
                                ListaEstn3.Add(esTrucEstacion);
                                break;
                            case 10:
                            case 11:
                            case 12:
                                ListaEstn4.Add(esTrucEstacion);
                                break;
                         }
                }
        }

        public static List<Estacion> GetAllInfo(int idedo)
        {

            List<Estacion> ListaEstn = new List<Estacion>();
            List<EstacionEntity> Estaciones = new List<EstacionEntity>();
            Estaciones = Provider.Provider.Estacion.GetAll(idedo);
            foreach (EstacionEntity get in Estaciones)
            {
                    Estacion esTrucEstacion = new Estacion(get.Fecha, get.FechaParseo, get.PM1_1M, get.PM1_5M, get.PM1_15M,get.PM1_1H, get.PM2P5_1M, get.PM2P5_5M, get.PM2P5_15M,get.PM2P5_1H, get.PM10_1M, get.PM10_5M, get.PM10_15M,get.PM10_1H, get.Temp, get.Supply);
                    ListaEstn.Add(esTrucEstacion);
            }
            return ListaEstn;
        }

    }
}
