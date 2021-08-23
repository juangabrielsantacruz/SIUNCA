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
        public List<Patente> TraerTodo()
        {
            return unaPatenteDAO.TraerTodo();
        }

        public void Insertar(Patente unaPatente)
        {
            unaPatenteDAO.Insertar(unaPatente);
        }

        public void Modificar(Patente unaPatente)
        {
            unaPatenteDAO.Modificar(unaPatente);
        }
        public void Quitar(Patente unaPatente)
        {
            unaPatenteDAO.Quitar(unaPatente);
        }


    }
}
