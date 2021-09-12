using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Framework.D_2015.Funciones
{
    public class Fechas
    {

        /// <summary>
        /// Fecha de hoy
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>

        public static string Hoy()
        {
            return Conversions.ToString(DateTime.Today);
        }

        /// <summary>
        /// Devuelve fecha y hora del momento
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>

        public static string Ahora()
        {
            return Conversions.ToString(DateTime.Now);
        }

        public static DateTime UltimoDiaDelMesEnFecha(int Mes, int Anio)
        {
            return new DateTime(Anio, Mes, 1).AddMonths(1).AddDays(-1);
        }
    }
}