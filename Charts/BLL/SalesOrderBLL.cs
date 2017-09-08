using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesAdapter = DAL.AdventureworksTableAdapters.SalesOrderChartTableAdapter;
using Charts;
using Charts.Model;

namespace BLL
{
    public class SalesOrderBLL
    {
        public SalesOrder GetSalesOrderByYear(SalesOrder salesOrder, int year)
        {
            SalesAdapter salesAdapter = new SalesAdapter();

            var dt = salesAdapter.GetSalesByYear(year);

            if (dt.Rows.Count > 0)
            {
                salesOrder.totalVentas = new List<long>();
                salesOrder.meses = new List<string>();

                foreach (var venta in dt)
                {
                    long total = venta.TotalVentas;
                    salesOrder.totalVentas.Add(total);

                    string strMes = GlobalHelper.hMes[venta.Mes];
                    salesOrder.meses.Add(strMes);
                }

                salesOrder.TotalVenta = salesOrder.totalVentas.Max();
                salesOrder.Mes = salesOrder.meses[salesOrder.totalVentas.IndexOf(salesOrder.TotalVenta)];
            }

            return salesOrder;
        }
    }
}
