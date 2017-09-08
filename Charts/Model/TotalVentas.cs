using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;

namespace Charts.Model
{
    public abstract class TotalVentas
    {
        private SalesOrderBLL soBl;

        public long MaximoVentas { get; set; }
        public long MinimoVentas { get; set; }

        public string MaximoMes { get; set; }
        public string MinimoMes { get; set; }

        public SalesOrder GetSalesOrderByYear(SalesOrder sOrder, int year)
        {
            soBl = new SalesOrderBLL();

            sOrder = soBl.GetSalesOrderByYear(sOrder, year);

            if (sOrder.totalVentas != null)
            {
                if (sOrder.totalVentas.Count > 0)
                {
                    MaximoVentas = sOrder.totalVentas.Max();
                    MinimoVentas = sOrder.totalVentas.Min();
                }

                if (sOrder.meses.Count > 0)
                {
                    MaximoMes = sOrder.meses[sOrder.totalVentas.IndexOf(sOrder.MaximoVentas)];
                    MinimoMes = sOrder.meses[sOrder.totalVentas.IndexOf(sOrder.MinimoVentas)];
                }
            }

            return sOrder;
        }
    }
}