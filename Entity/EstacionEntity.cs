using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caborca.Entity
{
    public class EstacionEntity
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

        private int _FLAG;
        public int FLAG
        {
            get { return _FLAG; }
            set { _FLAG = value; }
        }

        public EstacionEntity(){}
        public EstacionEntity(DateTime Fecha, string FechaParseo, decimal PM1_1M, decimal PM1_5M, decimal PM1_15M, decimal PM1_1H,
            decimal PM2P5_1M, decimal PM2P5_5M, decimal PM2P5_15M, decimal PM2P5_1H, decimal PM10_15M, decimal PM10_5M, decimal PM10_1M, decimal PM10_1H, decimal Temp, decimal Supply,int FLAG) {
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
                this._FLAG = FLAG;
        }
    }
}
