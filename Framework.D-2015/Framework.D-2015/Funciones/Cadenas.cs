using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Framework.D_2015
{
    public class Cadenas
    {



        /// <summary>
    /// Decora una lista por izquierda y derecha
    /// </summary>
    /// <param name="unaLista">La lista a decorar</param>
    /// <param name="DecoradoDerecho">El decorado derecho</param>
    /// <param name="DecoradoIzquierdo">El decorado izquierdo</param>
    /// <returns>Devuelve la lista decorada</returns>
    /// <remarks></remarks>
        public static List<string> DecorarLista(List<string> unaLista, string DecoradoDerecho, string DecoradoIzquierdo)
        {
            var Resultado = new List<string>();
            foreach (var item in unaLista)
                Resultado.Add(DecoradoIzquierdo + item + DecoradoDerecho);
            return Resultado;
        }

        /// <summary>
    /// Separar cadena en lista
    /// </summary>
    /// <param name="UnaCadena">Cadena a convertir</param>
    /// <param name="UnSeparador">Separador</param>
    /// <returns>cadena en lista</returns>
    /// <remarks></remarks>

        public static List<string> Parsear(string UnaCadena, char UnSeparador)
        {
            var Resultado = new List<string>();
            Resultado = Strings.Split(UnaCadena, Conversions.ToString(UnSeparador)).ToList();
            return Resultado;
        }


        /// <summary>
    /// Borrar basura a la derecha de un texto
    /// </summary>
    /// <param name="UnaCadena">Cadena con basura</param>
    /// <param name="unSeparador">Separador</param>
    /// <returns>Cadena sin basura</returns>
    /// <remarks></remarks>

        public static string TextoSinBasuraDerecha(string UnaCadena, char unSeparador)
        {
            List<string> Resultado;
            Resultado = Parsear(UnaCadena, unSeparador);
            return Resultado[0];
        }


        /// <summary>
    /// Borrar basura a la izquierda de un texto
    /// </summary>
    /// <param name="UnaCadena">Cadena con basura</param>
    /// <param name="unSeparador">Separador</param>
    /// <returns>Cadena sin basura</returns>
    /// <remarks></remarks>

        public static string TextoSinBasuraIzquierda(string UnaCadena, char unSeparador)
        {
            List<string> Resultado;
            Resultado = Parsear(UnaCadena, unSeparador);
            return Resultado[1];
        }



        /// <summary>
    /// Convertir una lista en cadena
    /// </summary>
    /// <param name="UnaLista">lista a unir</param>
    /// <param name="unSeparador">separador</param>
    /// <returns>Lista convertida en cadena</returns>
    /// <remarks></remarks>
        public static string UnirLista(List<string> UnaLista, string unSeparador)
        {
            string Resultado;
            Resultado = string.Join(unSeparador, UnaLista);
            return Resultado;
        }

        public static string StreamACadena(Stream stream)
        {
            var bytes = new byte[(int)(stream.Length + 1)];
            stream.Position = 0L;
            stream.Read(bytes, 0, (int)stream.Length);
            return BytesACadena(bytes);
        }

        public static byte[] CadenaABytes(string cadena)
        {
            return Encoding.ASCII.GetBytes(cadena);
        }

        public static string BytesACadena(byte[] bytes)
        {
            return Encoding.ASCII.GetString(bytes);
        }
    }
}