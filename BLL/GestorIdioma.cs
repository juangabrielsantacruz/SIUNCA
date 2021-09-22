using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;
using Framework.D_2015.Multiidioma;
using Interfaces;


namespace BLL
{
    public class GestorIdioma 
    {
        public static IIdioma ObtenerIdiomaDefault()
        {
            return ObtenerIdiomas().Where(i => i.Default).FirstOrDefault();
        }
        public static IList<Idioma> ObtenerIdiomas()
        {
            
                var listaIdioma = new List<Idioma>();
                var unIdiomaDAO = new IdiomaDAO();
                listaIdioma = unIdiomaDAO.ListarIdiomas();

                return listaIdioma;
            

        }

        public static Idioma TraerIdiomaPorId(int id)
        {
            var idioma = new Idioma();
            idioma = IdiomaDAO.ObtenerIdiomaPorId(id);
            return idioma;
        }

        public static Traduccion BuscarTraduccionPalabraIdioma(int palabra, Idioma idioma)
        {
            throw new NotImplementedException();
        }

        public static IDictionary<string, ITraduccion> ObtenerTraducciones(IIdioma idioma)
        {
            //var listaTraduccion = new List<Traduccion>();
            var listaTraduccion = IdiomaDAO.ObtenerTraducciones(idioma);
            return listaTraduccion;
        }

        public static List<ITraduccion> ObtenerTraducciones1(IIdioma idioma)
        {
            var listaTraduccion = new List<ITraduccion>();
            listaTraduccion = IdiomaDAO.ObtenerTraducciones1(idioma);
            return listaTraduccion;
        }
    }
}
