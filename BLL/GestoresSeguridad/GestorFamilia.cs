using BIZ.Seguridad;
using DAL.DAOSeguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.GestoresSeguridad
{
    public class GestorFamilia
    {
        FamiliaDAO unaFamiliaDAO = new FamiliaDAO();
        public List<Familia2> TraerTodo()
        {
            return unaFamiliaDAO.TraerTodo();
        }

        public void GuardarPermisos(Familia2 unaFamilia)
        {
            unaFamiliaDAO.GuardarPermisos(unaFamilia);
        }

        public void Insertar(Familia2 unaFamilia)
        {
            unaFamiliaDAO.Insertar(unaFamilia);
        }
        public void Quitar(Familia2 unaFamilia)
        {
            unaFamiliaDAO.Quitar(unaFamilia);
        }

        public void Modificar(Familia2 unaFamilia)
        {
            unaFamiliaDAO.Modificar(unaFamilia);
        }

    }
}
