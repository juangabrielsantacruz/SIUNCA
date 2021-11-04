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
        public List<Materia> TraerListaMaterias()
        {
            List<Materia> ListaMaterias = new List<Materia>();
            MateriaDAO unaMateriaDAO = new MateriaDAO();
            ListaMaterias = unaMateriaDAO.TraerTodo();
            return ListaMaterias;
        }

    }
}
