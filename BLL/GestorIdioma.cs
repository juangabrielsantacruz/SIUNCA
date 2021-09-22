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

    }
}
