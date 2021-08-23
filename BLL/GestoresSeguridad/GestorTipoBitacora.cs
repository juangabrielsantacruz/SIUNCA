using BIZ.Seguridad;
using DAL.DAOSeguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.GestoresSeguridad
{
   public class GestorTipoBitacora
    {
        public List<TipoBitacora> TraerTodos()
        {
            TipoBitacoraDAO unTipoBitacoraDAO = new TipoBitacoraDAO();

            return unTipoBitacoraDAO.TraerTodo();
        }
    }
}
