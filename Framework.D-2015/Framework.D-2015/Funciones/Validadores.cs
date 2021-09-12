using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Framework.D_2015.Funciones
{
    public class Validadores
    {

        /// <summary>
        /// Esta función permite conocer si la fecha provista es mayor al día contemporáneo
        /// </summary>
        /// <param name="fecha">La fecha a analizar</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool FechaEsMayorAHoy(DateTime fecha)
        {
            if (DateTime.Now > fecha)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Esta función permite conocer si la fecha provista es mayor al día contemporáneo
        /// </summary>
        /// <param name="fecha">La fecha a analizar</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool FechaEsMayorAHoy(string fecha)
        {
            DateTime fechaCasteada;
            fechaCasteada = Conversions.ToDate(fecha);
            if (DateTime.Now > fechaCasteada)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Permite conocer si la cadena no tiene valores.
        /// </summary>
        /// <param name="cadena">Cadena de texto</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool CadenaEstaVacia(string cadena)
        {
            if ((cadena ?? "") == (string.Empty ?? ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Da verdadero si la fecha podrá ser de tipo Date.
        /// </summary>
        /// <param name="texto">Cadena de texto</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool EsFechaValida(string texto)
        {
            if (Information.IsDate(texto) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Da verdadero si el texto se puede evaluar como un número.
        /// </summary>
        /// <param name="texto">Cadena de texto</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static bool EsNumeroValido(string texto)
        {
            if (Information.IsNumeric(texto) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}