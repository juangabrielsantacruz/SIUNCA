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
        //public static IIdioma ObtenerIdiomaDefault()
        //{
        //    return ObtenerIdiomas().Where(i => i.Default).FirstOrDefault();
        //}
        public static List<Idioma> ObtenerIdiomas()
        {
                List<Idioma> listaIdioma = new List<Idioma>();
                IdiomaDAO unIdiomaDAO = new IdiomaDAO();
                listaIdioma = unIdiomaDAO.ListarIdiomas();

                return listaIdioma;           

        }

        public static Idioma TraerIdiomaPorId(int id)
        {
            Idioma listaIdioma = new Idioma();
            listaIdioma = IdiomaDAO.ObtenerIdiomaPorId(id);
            return listaIdioma;
        }

        public static Traduccion BuscarTraduccionPalabraIdioma(int palabra, Idioma idioma)
        {
            throw new NotImplementedException();
        }

        public static List<Traduccion> ObtenerTraducciones(IIdioma idioma)
        {
            var listaTraduccion = new List<Traduccion>();
            listaTraduccion = IdiomaDAO.ObtenerTraducciones(idioma);
            return listaTraduccion;
        }

        public static List<ITraduccion> ObtenerTraducciones1(IIdioma idioma)
        {
            var listaTraduccion = new List<ITraduccion>();
            listaTraduccion = IdiomaDAO.ObtenerTraducciones1(idioma);
            return listaTraduccion;
        }
        public static List<ITraduccion> ObtenerTraducciones2(IIdioma idioma)
        {
            var listaTraduccion = new List<ITraduccion>();
            listaTraduccion = IdiomaDAO.ObtenerTraducciones2(idioma);
            return listaTraduccion;
        }
    }
}
