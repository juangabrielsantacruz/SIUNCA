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
        public List<Familia> TraerTodo()
        {
            return unaFamiliaDAO.TraerTodo();
        }

        public void GuardarPermisos(Familia unaFamilia)
        {
            unaFamiliaDAO.GuardarPermisos(unaFamilia);
        }

        public void Insertar(Familia unaFamilia)
        {
            unaFamiliaDAO.Insertar(unaFamilia);
        }
        public void Quitar(Familia unaFamilia)
        {
            unaFamiliaDAO.Quitar(unaFamilia);
        }

        public void Modificar(Familia unaFamilia)
        {
            unaFamiliaDAO.Modificar(unaFamilia);
        }

    }
}
