using Framework.D_2015.Multiidioma;
using Framework.D_2015.Persistencia;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DAL
{
    public class IdiomaDAO
    {
        public List<Idioma> ListarIdiomas()
        {
            List<Idioma> resultado;
            Conexion unaConexion = new Conexion("config.xml");
            unaConexion.ConexionIniciar();
            try
            {
                resultado = unaConexion.EjecutarTupla<Idioma>("SELECT Id, Nombre FROM Idioma", new List<Parametro>());
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            // Dim log As New EventViewer("error", "SQL", "Error al traer los Clientes de la base de datos", ".", EventViewer.TipoEvento._Error)
            finally
            {
                unaConexion.ConexionFinalizar();
            }
        }


        public static void CargarDiccionario(Idioma pIdioma)
        {
            //"select Palabra_Texto, Traduccion_Palabra from Palabra inner join Traduccion on IdPalabra = IdPalabra_Traduccion where IdIdioma = " + pIdioma.IdIdioma;

        }

        public static IDictionary<string, ITraduccion> ObtenerTraducciones(IIdioma idioma)
        {
            throw new NotImplementedException();
        }

        public static List<ITraduccion> ObtenerTraducciones1(IIdioma idioma)
        {
            throw new NotImplementedException();
        }

        public List<Palabra> TraerPalabrasBase()
        {
            throw new NotImplementedException();
        }

        public string BuscarTraduccionPalabraIdioma(int idPalabra, int idIdioma)
        {
            throw new NotImplementedException();
        }



        public void AgregarIdioma(Idioma idioma)
        {
            throw new NotImplementedException();
        }

        public void AgregarTraduccion(int idPalabra, int idIdioma, string traduccion)
        {
            throw new NotImplementedException();
        }

        public bool ComprobarExistenciaTraduccion(int idPalabra, int idIdioma)
        {
            throw new NotImplementedException();
        }

        public void CambiarIdiomaUsuario(string nombreUsuario, int idIdioma)
        {
            throw new NotImplementedException();
        }

        public static Idioma ObtenerIdiomaPorId(int id)
        {
            throw new NotImplementedException();
        }

    }
}
