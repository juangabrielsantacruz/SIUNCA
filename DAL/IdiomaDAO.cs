using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.D_2015.Multiidioma;
using Framework.D_2015.Persistencia;
using Interfaces;

namespace DAL
{
    public class IdiomaDAO
    {
        public List<Idioma> ListarIdiomas()
        {
            List<Idioma> resultado = new List<Idioma>();
            var con = new Conexion("config.xml");
            con.ConexionIniciar();

            List<Parametro> listaParametrosCD = new List<Parametro>();

            try
            {
                resultado = con.EjecutarTupla<Idioma>(@"SELECT IdIdioma, Nombre_Idioma FROM Idioma", listaParametrosCD);
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al traer idiomas" + ex);
                return null;
            }
            finally
            {
                con.ConexionFinalizar();
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
