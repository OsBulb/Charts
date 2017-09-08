using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Charts
{
    public static class GlobalHelper
    {
        public static Dictionary<int, string> hMes = new Dictionary<int, string>() {
            { 1, "Enero"},
            { 2, "Febrero"},
            { 3, "Marzo"},
            { 4, "Abril"},
            { 5, "Mayo"},
            { 6, "Junio"},
            { 7, "Julio"},
            { 8, "Agosto"},
            { 9, "Septiembre"},
            { 10, "Octubre"},
            { 11, "Noviembre"},
            { 12, "Diciembre"}
        };

        public static string removeLastChar(string texto)
        {
            if(!texto.Trim().Length.Equals(0))
            texto = texto.Remove(texto.Length - 1);

            return texto;
        }
    }
}