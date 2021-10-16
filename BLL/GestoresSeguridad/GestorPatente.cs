using BIZ.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAOSeguridad;

namespace BLL.GestoresSeguridad
{
    public class GestorPatente
    {
        PatenteDAO unaPatenteDAO = new PatenteDAO();
        public List<Patente2> TraerTodo()
        {
            return unaPatenteDAO.TraerTodo();
        }

        public void Insertar(Patente2 unaPatente)
        {
            unaPatenteDAO.Insertar(unaPatente);
        }

        public void Modificar(Patente2 unaPatente)
        {
            unaPatenteDAO.Modificar(unaPatente);
        }
        public void Quitar(Patente2 unaPatente)
        {
            unaPatenteDAO.Quitar(unaPatente);
        }


    }
}
