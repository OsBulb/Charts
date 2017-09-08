using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Charts.Model
{
    public class SalesOrder : TotalVentas
    {
        private long _totalVentas;
        private string _mes;

        public long TotalVenta {
            get { return _totalVentas; }
            set { _totalVentas = value; }
        }

        public string Mes
        {
            get { return _mes; }
            set { _mes = value; }
        }

        public List<long> totalVentas;
        public List<string> meses;
    }
}