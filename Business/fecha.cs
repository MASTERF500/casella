using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Caborca.Entity;
namespace Caborca.Business
{
    public class fecha
    {
        private DateTime _Fecha;
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        private int _Mes;
        public fecha() { }
        public fecha(DateTime Fecha) {
            this._Fecha = Fecha;
        }
        public static List<Estacion> fechas(string fch, List<Estacion> lstEst) {
            List<fecha> lst = new List<fecha>(); 
            DateTime fchs = Convert.ToDateTime(fch);
            #region lstfechas
            switch (fchs.Month)
            {
                case 1:
                case 2:
                case 3:
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-01") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-02") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-03") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-04") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-05") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-06") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-07") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-08") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-09") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-10") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-11") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-12") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-13") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-14") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-15") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-16") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-17") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-18") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-19") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-20") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-21") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-22") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-23") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-24") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-25") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-26") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-27") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-28") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-29") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-30") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-01-31") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-01") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-02") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-03") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-04") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-05") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-06") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-07") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-08") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-09") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-10") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-11") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-12") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-13") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-14") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-15") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-16") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-17") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-18") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-19") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-20") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-21") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-22") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-23") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-24") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-25") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-26") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-27") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-02-28") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-01") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-02") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-03") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-04") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-05") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-06") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-07") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-08") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-09") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-10") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-11") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-12") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-13") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-14") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-15") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-16") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-17") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-18") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-19") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-20") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-21") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-22") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-23") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-24") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-25") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-26") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-27") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-28") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-29") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-30") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-03-31") });
                    break;
                case 4:
                case 5:
                case 6:
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-01") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-02") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-03") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-04") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-05") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-06") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-07") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-08") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-09") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-10") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-11") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-12") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-13") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-14") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-15") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-16") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-17") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-18") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-19") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-20") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-21") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-22") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-23") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-24") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-25") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-26") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-27") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-28") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-29") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-04-30") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-01") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-02") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-03") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-04") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-05") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-06") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-07") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-08") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-09") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-10") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-11") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-12") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-13") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-14") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-15") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-16") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-17") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-18") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-19") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-20") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-21") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-22") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-23") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-24") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-25") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-26") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-27") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-28") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-29") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-30") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-05-31") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-01") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-02") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-03") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-04") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-05") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-06") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-07") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-08") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-09") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-10") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-11") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-12") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-13") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-14") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-15") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-16") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-17") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-18") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-19") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-20") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-21") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-22") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-23") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-24") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-25") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-26") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-27") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-28") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-29") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-06-30") });
                    break;
                case 7:
                case 8:
                case 9:
                    lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-01") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-02") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-03") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-04") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-05") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-06") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-07") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-08") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-09") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-10") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-11") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-12") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-13") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-14") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-15") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-16") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-17") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-18") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-19") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-20") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-21") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-22") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-23") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-24") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-25") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-26") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-27") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-28") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-29") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-30") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-07-31") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-01") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-02") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-03") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-04") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-05") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-06") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-07") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-08") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-09") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-10") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-11") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-12") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-13") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-14") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-15") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-16") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-17") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-18") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-19") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-20") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-21") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-22") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-23") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-24") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-25") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-26") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-27") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-28") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-29") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-30") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-08-31") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-01") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-02") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-03") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-04") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-05") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-06") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-07") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-08") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-09") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-10") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-11") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-12") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-13") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-14") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-15") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-16") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-17") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-18") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-19") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-20") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-21") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-22") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-23") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-24") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-25") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-26") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-27") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-28") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-29") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-09-30") });
                    break;
                case 10:
                case 11:
                case 12:
                     lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-01") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-02") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-03") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-04") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-05") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-06") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-07") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-08") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-09") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-10") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-11") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-12") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-13") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-14") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-15") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-16") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-17") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-18") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-19") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-20") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-21") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-22") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-23") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-24") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-25") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-26") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-27") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-28") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-29") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-30") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-10-31") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-01") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-02") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-03") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-04") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-05") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-06") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-07") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-08") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-09") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-10") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-11") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-12") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-13") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-14") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-15") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-16") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-17") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-18") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-19") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-20") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-21") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-22") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-23") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-24") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-25") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-26") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-27") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-28") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-29") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-11-30") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-01") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-02") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-03") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-04") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-05") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-06") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-07") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-08") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-09") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-10") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-11") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-12") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-13") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-14") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-15") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-16") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-17") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-18") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-19") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-20") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-21") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-22") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-23") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-24") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-25") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-26") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-27") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-28") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-29") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-30") });
            lst.Add(new fecha() { Fecha = Convert.ToDateTime("2018-12-31") });
                    break;
                default:

                    break;
            }
            #endregion
            //int count=0;
            //foreach (Estacion row in lstEst) {
            //    for (int i = 0; i < lst.Count(); i++)
            //    {
            //        bool exist = lst.Any(d => d.Fecha.Year == row.Fecha.Year && d.Fecha.Month == row.Fecha.Month && d.Fecha.Day == row.Fecha.Day);
            //        if (exist==true) {}else{
            //            Estacion esTrucEstacion = new Estacion(lst[i].Fecha, lst[i].Fecha.ToShortDateString(), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            //            lstEst.Add(esTrucEstacion);
            //        }
            //    }
            //}
            foreach (fecha row in lst) {
                bool exist = lstEst.Any(d => d.Fecha.Year == row.Fecha.Year && d.Fecha.Month == row.Fecha.Month && d.Fecha.Day == row.Fecha.Day);
                if (exist) { }
                else
                {
                    Estacion esTrucEstacion = new Estacion(row.Fecha, row.Fecha.ToShortDateString(), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    lstEst.Add(esTrucEstacion);
                }
            }

            return lstEst;
            }


    }
}
