using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class GestorDetallesAlumnoMateria
    {
        public List<Alumno_MateriaCC> TraerMateriasAprobadas(Alumno unAlumno)
        {
            List<Alumno_MateriaCC> ListaAprobadas = new List<Alumno_MateriaCC>();
            DetalleAlumnoMateriaDAO unDetalleAlumnoMateriaDAO = new DetalleAlumnoMateriaDAO();
            ListaAprobadas = unDetalleAlumnoMateriaDAO.TraerTodo(unAlumno);

            //comentando
            return ListaAprobadas;
        }
    }
}
