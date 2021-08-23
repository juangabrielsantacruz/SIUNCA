using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;
using DAL;

namespace BLL
{
    public class GestorAlumno
    {
        public List<Alumno> TraerAlumno(Alumno UnAlumno)
        {
            List<Alumno> ListaAlumno = new List<Alumno>();
            AlumnoDAO UnAlumnoDAO = new AlumnoDAO();
            ListaAlumno = UnAlumnoDAO.TraerTodo(UnAlumno);
            return ListaAlumno;
        }



        public void AsignarAlumnoAMaterias(List<Alumno_MateriaCC> AlumnoMateriaDetalles)
        {
            AlumnoDAO unAlumnoDAO = new AlumnoDAO();

            unAlumnoDAO.GuardarAsignacionAlumnoAMaterias(AlumnoMateriaDetalles);
        }

        public void Crear(object unAlumno)
        {
        }
        public void Modificar(object unAlumno)
        {
        }
        public void Eliminar(object unAlumno)
        {
        }
    }
}
