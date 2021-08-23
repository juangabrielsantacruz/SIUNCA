using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;


namespace BLL
{
    public class GestorMateria
    {
        public List<Materias> TraerListaMaterias()
        {
            List<Materias> ListaMaterias = new List<Materias>();
            MateriaDAO unaMateriaDAO = new MateriaDAO();
            ListaMaterias = unaMateriaDAO.TraerTodo();
            return ListaMaterias;
        }

    }
}
