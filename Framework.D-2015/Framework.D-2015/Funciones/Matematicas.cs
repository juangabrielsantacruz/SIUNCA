using System;

namespace Framework.D_2015.Funciones
{
    public class Matematicas
    {

        /// <summary>
        /// Ingreso un numero y lo redondea la cantidad de decimales deseada.
        /// </summary>
        /// <param name="unNumero">Ingrese cualquier numero.</param>
        /// <param name="cantidadDecimales">Ingrese la cantidad de decimales.</param>
        /// <returns></returns>
        /// <remarks></remarks>

        public static decimal Redondear(decimal unNumero, int cantidadDecimales)
        {

            // wrapper
            return Math.Round(unNumero, cantidadDecimales);
        }

        /// <summary>
        /// Devuelve un numero entro los valores indicados.
        /// </summary>
        /// <param name="desde"></param>
        /// <param name="hasta"></param>
        /// <returns></returns>
        /// <remarks></remarks>

        public static int ObtenerNumeroAleatorio(int desde, int hasta)
        {
            var rnd = new Random();
            int resultado = rnd.Next(desde, hasta + 1);
            return resultado;
        }


        /// <summary>
        /// Obtener un Interes del 21%
        /// </summary>
        /// <param name="Valor"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static double ObetenerInteresIVA(double Valor)
        {
            double valorFinal = Valor * 0.21d + Valor;
            return valorFinal;
        }
        /// <summary>
        /// Suma de 2 numeros
        /// </summary>
        /// <param name="Numero1"></param>
        /// <param name="Numero2"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static double Suma(double Numero1, double Numero2)
        {
            double sumafinal = Numero1 + Numero2;
            return sumafinal;
        }





        /// <summary>
        /// Descuento
        /// </summary>
        /// <param name="ImporteNeto">Ingrese Importe</param>
        /// <param name="PorcentajeDescontar">Ingrese % de descuento</param>
        /// <returns>Devuelve importe con descuento</returns>
        /// <remarks></remarks>

        public static double AplicarDescuento(double ImporteNeto, double PorcentajeDescontar)
        {
            double Resultado;
            Resultado = ImporteNeto - ImporteNeto * PorcentajeDescontar / 100d;
            return Resultado;
        }


        /// <summary>
        /// Recargo
        /// </summary>
        /// <param name="ImporteNeto">Ingrese Importe</param>
        /// <param name="PorcentajeRecargo">Ingrese % recargo</param>
        /// <returns>Devuelve importe con recargo</returns>
        /// <remarks></remarks>
        public static double AplicarRecargo(double ImporteNeto, double PorcentajeRecargo)
        {
            double Resultado;
            Resultado = ImporteNeto + ImporteNeto * PorcentajeRecargo / 100d;
            return Resultado;
        }
    }





    // 1) Metodo AplicarDescuento(ImporteNeto, PorcentajeDescontar) devuelve el importe aplicando el descuento del porcentaje ingresado. (ejemplo: AplicarDescuento(100, 10) = 90)
    // 2) Metodo AplicarRecargo(ImporteNeto, PorcentajeRecargo) devuelve el importe aplicando el recargo ingresado. (Ejemplo: AplicarRecargo(100, 10) = 110
    // 3) Metodo redondear. Ingreso un numero y deve tener hasta 2 decimales.







}