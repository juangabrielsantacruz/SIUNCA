using System.Globalization;
using System.Threading;

namespace Framework.D_2015.Idiomas
{
    public class Idioma
    {

        /// <summary>
        /// Necesario para poder pasar un metodo como parametro en metodo cambiar idioma
        /// </summary>
        public delegate void ParametroEnMetodo();
        /// <summary>
        /// Propiedad para guardar el idioma de forma temporal
        /// </summary>
        public static string cacheIdioma = "Español";

        /// <summary>
        /// Metodo para cambiar el idioma del sistema
        /// </summary>
        /// <param name="idioma">Recibe "Ingles" o "Español"</param>
        /// <param name="metodo">parametro que recibe un metodo con retorno void y ningun parametro (Delegado)</param>
        public static void cambiarIdioma(string idioma, ParametroEnMetodo metodo)
        {
            if (idioma == "Ingles")
            {
                // Selecciona el archivo Res.en-US.resx
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                metodo();
            }

            if (idioma == "Español")
            {
                // Selecciona el archivo Res.resx
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
                metodo();
            }
        }
    }
}